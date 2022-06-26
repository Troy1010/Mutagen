/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Fallout4.Internals;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Fallout4.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Fallout4.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Fallout4
{
    #region Class
    /// <summary>
    /// Implemented by: [NpcLevel, PcLevelMult]
    /// </summary>
    public abstract partial class ANpcLevel :
        IANpcLevel,
        IEquatable<IANpcLevelGetter>,
        ILoquiObjectSetter<ANpcLevel>
    {
        #region Ctor
        public ANpcLevel()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public virtual void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ANpcLevelMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IANpcLevelGetter rhs) return false;
            return ((ANpcLevelCommon)((IANpcLevelGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IANpcLevelGetter? obj)
        {
            return ((ANpcLevelCommon)((IANpcLevelGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ANpcLevelCommon)((IANpcLevelGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
            }


            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public virtual bool All(Func<TItem, bool> eval)
            {
                return true;
            }
            #endregion

            #region Any
            public virtual bool Any(Func<TItem, bool> eval)
            {
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ANpcLevel.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(ANpcLevel.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, ANpcLevel.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(ANpcLevel.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            #endregion

            #region IErrorMask
            public virtual object? GetNthMask(int index)
            {
                ANpcLevel_FieldIndex enu = (ANpcLevel_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                ANpcLevel_FieldIndex enu = (ANpcLevel_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                ANpcLevel_FieldIndex enu = (ANpcLevel_FieldIndex)index;
                switch (enu)
                {
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual bool IsInError()
            {
                if (Overall != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public virtual void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected virtual void PrintFillInternal(StructuredStringBuilder sb)
            {
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected virtual void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ANpcLevelBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ANpcLevelBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((ANpcLevelSetterCommon)((IANpcLevelGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static ANpcLevel GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [NpcLevel, PcLevelMult]
    /// </summary>
    public partial interface IANpcLevel :
        IANpcLevelGetter,
        ILoquiObjectSetter<IANpcLevel>
    {
    }

    /// <summary>
    /// Implemented by: [NpcLevel, PcLevelMult]
    /// </summary>
    public partial interface IANpcLevelGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<IANpcLevelGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => ANpcLevel_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class ANpcLevelMixIn
    {
        public static void Clear(this IANpcLevel item)
        {
            ((ANpcLevelSetterCommon)((IANpcLevelGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ANpcLevel.Mask<bool> GetEqualsMask(
            this IANpcLevelGetter item,
            IANpcLevelGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IANpcLevelGetter item,
            string? name = null,
            ANpcLevel.Mask<bool>? printMask = null)
        {
            return ((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IANpcLevelGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ANpcLevel.Mask<bool>? printMask = null)
        {
            ((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IANpcLevelGetter item,
            IANpcLevelGetter rhs,
            ANpcLevel.TranslationMask? equalsMask = null)
        {
            return ((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IANpcLevel lhs,
            IANpcLevelGetter rhs)
        {
            ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IANpcLevel lhs,
            IANpcLevelGetter rhs,
            ANpcLevel.TranslationMask? copyMask = null)
        {
            ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IANpcLevel lhs,
            IANpcLevelGetter rhs,
            out ANpcLevel.ErrorMask errorMask,
            ANpcLevel.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ANpcLevel.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IANpcLevel lhs,
            IANpcLevelGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ANpcLevel DeepCopy(
            this IANpcLevelGetter item,
            ANpcLevel.TranslationMask? copyMask = null)
        {
            return ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ANpcLevel DeepCopy(
            this IANpcLevelGetter item,
            out ANpcLevel.ErrorMask errorMask,
            ANpcLevel.TranslationMask? copyMask = null)
        {
            return ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ANpcLevel DeepCopy(
            this IANpcLevelGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IANpcLevel item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((ANpcLevelSetterCommon)((IANpcLevelGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    #region Field Index
    internal enum ANpcLevel_FieldIndex
    {
    }
    #endregion

    #region Registration
    internal partial class ANpcLevel_Registration : ILoquiRegistration
    {
        public static readonly ANpcLevel_Registration Instance = new ANpcLevel_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 339,
            version: 0);

        public const string GUID = "45f0ebc2-ec5c-4469-b475-68f3fe1a5cff";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(ANpcLevel.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ANpcLevel.ErrorMask);

        public static readonly Type ClassType = typeof(ANpcLevel);

        public static readonly Type GetterType = typeof(IANpcLevelGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IANpcLevel);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.ANpcLevel";

        public const string Name = "ANpcLevel";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ANpcLevelBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    internal partial class ANpcLevelSetterCommon
    {
        public static readonly ANpcLevelSetterCommon Instance = new ANpcLevelSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IANpcLevel item)
        {
            ClearPartial();
        }
        
        #region Mutagen
        public void RemapLinks(IANpcLevel obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IANpcLevel item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
        }
        
        #endregion
        
    }
    internal partial class ANpcLevelCommon
    {
        public static readonly ANpcLevelCommon Instance = new ANpcLevelCommon();

        public ANpcLevel.Mask<bool> GetEqualsMask(
            IANpcLevelGetter item,
            IANpcLevelGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ANpcLevel.Mask<bool>(false);
            ((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IANpcLevelGetter item,
            IANpcLevelGetter rhs,
            ANpcLevel.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
        }
        
        public string Print(
            IANpcLevelGetter item,
            string? name = null,
            ANpcLevel.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IANpcLevelGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ANpcLevel.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"ANpcLevel =>");
            }
            else
            {
                sb.AppendLine($"{name} (ANpcLevel) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IANpcLevelGetter item,
            StructuredStringBuilder sb,
            ANpcLevel.Mask<bool>? printMask = null)
        {
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IANpcLevelGetter? lhs,
            IANpcLevelGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            return true;
        }
        
        public virtual int GetHashCode(IANpcLevelGetter item)
        {
            var hash = new HashCode();
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return ANpcLevel.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IANpcLevelGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class ANpcLevelSetterTranslationCommon
    {
        public static readonly ANpcLevelSetterTranslationCommon Instance = new ANpcLevelSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IANpcLevel item,
            IANpcLevelGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
        }
        
        #endregion
        
        public ANpcLevel DeepCopy(
            IANpcLevelGetter item,
            ANpcLevel.TranslationMask? copyMask = null)
        {
            ANpcLevel ret = (ANpcLevel)((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).GetNew();
            ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ANpcLevel DeepCopy(
            IANpcLevelGetter item,
            out ANpcLevel.ErrorMask errorMask,
            ANpcLevel.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ANpcLevel ret = (ANpcLevel)((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).GetNew();
            ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ANpcLevel.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ANpcLevel DeepCopy(
            IANpcLevelGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ANpcLevel ret = (ANpcLevel)((ANpcLevelCommon)((IANpcLevelGetter)item).CommonInstance()!).GetNew();
            ((ANpcLevelSetterTranslationCommon)((IANpcLevelGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Fallout4
{
    public partial class ANpcLevel
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ANpcLevel_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => ANpcLevel_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ANpcLevelCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return ANpcLevelSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ANpcLevelSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IANpcLevelGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IANpcLevelGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IANpcLevelGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class ANpcLevelBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public static readonly ANpcLevelBinaryWriteTranslation Instance = new ANpcLevelBinaryWriteTranslation();

        public virtual void Write(
            MutagenWriter writer,
            IANpcLevelGetter item,
            TypedWriteParams translationParams)
        {
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IANpcLevelGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class ANpcLevelBinaryCreateTranslation
    {
        public static readonly ANpcLevelBinaryCreateTranslation Instance = new ANpcLevelBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class ANpcLevelBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IANpcLevelGetter item,
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ANpcLevelBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal abstract partial class ANpcLevelBinaryOverlay :
        PluginBinaryOverlay,
        IANpcLevelGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ANpcLevel_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => ANpcLevel_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => ANpcLevelCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => ANpcLevelSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IANpcLevelGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IANpcLevelGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IANpcLevelGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => ANpcLevelBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ANpcLevelBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ANpcLevelBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public virtual void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ANpcLevelMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IANpcLevelGetter rhs) return false;
            return ((ANpcLevelCommon)((IANpcLevelGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IANpcLevelGetter? obj)
        {
            return ((ANpcLevelCommon)((IANpcLevelGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ANpcLevelCommon)((IANpcLevelGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

