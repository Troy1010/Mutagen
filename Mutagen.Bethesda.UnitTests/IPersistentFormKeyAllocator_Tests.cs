using Mutagen.Bethesda.Core.Persistance;
using Mutagen.Bethesda.Oblivion;
using Mutagen.Bethesda.Sqlite;
using Noggog.Utility;
using System;
using System.Collections.Concurrent;
using System.Data;
using System.Linq;
using Xunit;

namespace Mutagen.Bethesda.UnitTests
{

    public class SQLiteFormKeyAllocator_Tests : ISharedFormKeyAllocator_Tests<SQLiteFormKeyAllocator>
    {
        protected override SQLiteFormKeyAllocator CreateFormKeyAllocator(IMod mod) => new(mod, tempFile.Value.File.Path);

        protected override SQLiteFormKeyAllocator CreateFormKeyAllocator(IMod mod, string patcherName) => new(mod, tempFile.Value.File.Path, patcherName);
    }

    public abstract class IPersistentFormKeyAllocator_Tests<TFormKeyAllocator> : IFormKeyAllocator_Tests<TFormKeyAllocator>, IDisposable
        where TFormKeyAllocator : BasePersistentFormKeyAllocator
    {
        protected Lazy<TempFolder> tempFolder;

        protected Lazy<TempFile> tempFile;

        private bool disposedValue;

        protected IPersistentFormKeyAllocator_Tests()
        {
            tempFolder = new(() => TempFolder.Factory());
            tempFile = new(() => new TempFile(extraDirectoryPaths: Utility.TempFolderPath));
        }

        [Fact]
        public void CanSave()
        {
            var mod = new OblivionMod(Utility.PluginModKey);

            using var allocator = CreateFormKeyAllocator(mod);

            allocator.Save();
        }

        [Fact]
        public void AllocatesSameFormKeyAfterLoad()
        {
            uint nextFormID = 123;

            FormKey expectedFormKey;
            {
                var mod = new OblivionMod(Utility.PluginModKey);
                ((IMod)mod).NextFormID = nextFormID;

                using var allocator = CreateFormKeyAllocator(mod);

                expectedFormKey = allocator.GetNextFormKey();

                allocator.Save();
            }

            {
                var mod = new OblivionMod(Utility.PluginModKey);
                ((IMod)mod).NextFormID = nextFormID;

                using var allocator = CreateFormKeyAllocator(mod);

                var formKey = allocator.GetNextFormKey();

                Assert.Equal(expectedFormKey, formKey);
            }
        }

        [Fact]
        public void AllocatesSameFormKeyForNullEditorIDAfterLoad()
        {
            uint nextFormID = 123;

            FormKey expectedFormKey;
            {
                var mod = new OblivionMod(Utility.PluginModKey);
                ((IMod)mod).NextFormID = nextFormID;

                using var allocator = CreateFormKeyAllocator(mod);

                expectedFormKey = allocator.GetNextFormKey(null);

                allocator.Save();
            }

            {
                var mod = new OblivionMod(Utility.PluginModKey);
                ((IMod)mod).NextFormID = nextFormID;

                using var allocator = CreateFormKeyAllocator(mod);

                var formKey = allocator.GetNextFormKey(null);

                Assert.Equal(expectedFormKey, formKey);
            }
        }

        [Fact]
        public void AllocatesSameFormKeyForEditorIDAfterLoad()
        {
            FormKey expectedFormKey;
            {
                var mod = new OblivionMod(Utility.PluginModKey);
                using var allocator = CreateFormKeyAllocator(mod);

                expectedFormKey = allocator.GetNextFormKey(Utility.Edid1);

                allocator.Save();
            }

            {
                var mod = new OblivionMod(Utility.PluginModKey);
                using var allocator = CreateFormKeyAllocator(mod);

                var formKey = allocator.GetNextFormKey(Utility.Edid1);

                Assert.Equal(expectedFormKey, formKey);
            }
        }


        [Fact]
        public void OutOfOrderAllocationReturnsSameIdentifiers()
        {
            uint formID1, formID2;
            {
                var mod = new OblivionMod(Utility.PluginModKey);
                using var allocator = CreateFormKeyAllocator(mod);
                var formKey1 = allocator.GetNextFormKey(Utility.Edid1);
                formID1 = formKey1.ID;

                allocator.GetNextFormKey();

                var formKey2 = allocator.GetNextFormKey(Utility.Edid2);
                formID2 = formKey2.ID;

                allocator.Save();
            }

            {
                var mod = new OblivionMod(Utility.PluginModKey);
                using var allocator = CreateFormKeyAllocator(mod);

                var formKey2 = allocator.GetNextFormKey(Utility.Edid2);
                Assert.Equal(formID2, formKey2.ID);

                allocator.GetNextFormKey();

                var formKey1 = allocator.GetNextFormKey(Utility.Edid1);
                Assert.Equal(formID1, formKey1.ID);
            }
        }

        [Fact]
        public void ParallelAllocation()
        {
            var input = Enumerable.Range(1, 100).Select(i => (i, i.ToString())).ToList();
            var output1 = new ConcurrentDictionary<int, uint>();

            var mod = new OblivionMod(Utility.PluginModKey);
            {
                using var allocator = CreateFormKeyAllocator(mod);

                void apply((int i, string s) x)
                {
                    // "Randomly" allocate some non-unique FormIDs.
                    if (x.i % 3 == 0)
                        allocator.GetNextFormKey();
                    else
                    {
                        var key = allocator.GetNextFormKey(x.s);
                        output1.TryAdd(x.i, key.ID);
                    }
                }

                input.AsParallel().ForAll(apply);

                allocator.Save();
            }

            {
                using var allocator = CreateFormKeyAllocator(mod);

                void check((int i, string s) x)
                {
                    if (x.i % 3 != 0)
                    {
                        var key = allocator.GetNextFormKey(x.s);
                        if (!output1.TryGetValue(x.i, out var expectedID))
                            throw new Exception("?");
                        Assert.Equal(expectedID, key.ID);
                    }
                }

                input.AsParallel().ForAll(check);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if (tempFile.IsValueCreated)
                        tempFile.Value.Dispose();
                    if (tempFolder.IsValueCreated)
                        tempFile.Value.Dispose();
                }
                disposedValue = true;
            }
        }

        ~IPersistentFormKeyAllocator_Tests()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

