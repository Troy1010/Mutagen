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
using Mutagen.Bethesda.Fallout4;
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
    public partial class BookTeachesNothing :
        BookTeachTarget,
        IBookTeachesNothing,
        IEquatable<IBookTeachesNothingGetter>,
        ILoquiObjectSetter<BookTeachesNothing>
    {
        #region Ctor
        public BookTeachesNothing()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region RawContent
        public UInt32 RawContent { get; set; } = default;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            BookTeachesNothingMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBookTeachesNothingGetter rhs) return false;
            return ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IBookTeachesNothingGetter? obj)
        {
            return ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            BookTeachTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem RawContent)
            : base()
            {
                this.RawContent = RawContent;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem RawContent;
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
                if (!base.Equals(rhs)) return false;
                if (!object.Equals(this.RawContent, rhs.RawContent)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.RawContent);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.RawContent)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.RawContent)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new BookTeachesNothing.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.RawContent = eval(this.RawContent);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(BookTeachesNothing.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, BookTeachesNothing.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(BookTeachesNothing.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.RawContent ?? true)
                    {
                        sb.AppendItem(RawContent, "RawContent");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            BookTeachTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? RawContent;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                BookTeachesNothing_FieldIndex enu = (BookTeachesNothing_FieldIndex)index;
                switch (enu)
                {
                    case BookTeachesNothing_FieldIndex.RawContent:
                        return RawContent;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                BookTeachesNothing_FieldIndex enu = (BookTeachesNothing_FieldIndex)index;
                switch (enu)
                {
                    case BookTeachesNothing_FieldIndex.RawContent:
                        this.RawContent = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                BookTeachesNothing_FieldIndex enu = (BookTeachesNothing_FieldIndex)index;
                switch (enu)
                {
                    case BookTeachesNothing_FieldIndex.RawContent:
                        this.RawContent = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (RawContent != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
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
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
                {
                    sb.AppendItem(RawContent, "RawContent");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.RawContent = this.RawContent.Combine(rhs.RawContent);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            BookTeachTarget.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool RawContent;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.RawContent = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((RawContent, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => BookTeachesNothingBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((BookTeachesNothingBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static BookTeachesNothing CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new BookTeachesNothing();
            ((BookTeachesNothingSetterCommon)((IBookTeachesNothingGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out BookTeachesNothing item,
            TypedParseParams? translationParams = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((BookTeachesNothingSetterCommon)((IBookTeachesNothingGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new BookTeachesNothing GetNew()
        {
            return new BookTeachesNothing();
        }

    }
    #endregion

    #region Interface
    public partial interface IBookTeachesNothing :
        IBookTeachesNothingGetter,
        IBookTeachTarget,
        ILoquiObjectSetter<IBookTeachesNothing>
    {
        new UInt32 RawContent { get; set; }
    }

    public partial interface IBookTeachesNothingGetter :
        IBookTeachTargetGetter,
        IBinaryItem,
        ILoquiObject<IBookTeachesNothingGetter>
    {
        static new ILoquiRegistration StaticRegistration => BookTeachesNothing_Registration.Instance;
        UInt32 RawContent { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class BookTeachesNothingMixIn
    {
        public static void Clear(this IBookTeachesNothing item)
        {
            ((BookTeachesNothingSetterCommon)((IBookTeachesNothingGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static BookTeachesNothing.Mask<bool> GetEqualsMask(
            this IBookTeachesNothingGetter item,
            IBookTeachesNothingGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IBookTeachesNothingGetter item,
            string? name = null,
            BookTeachesNothing.Mask<bool>? printMask = null)
        {
            return ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IBookTeachesNothingGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            BookTeachesNothing.Mask<bool>? printMask = null)
        {
            ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IBookTeachesNothingGetter item,
            IBookTeachesNothingGetter rhs,
            BookTeachesNothing.TranslationMask? equalsMask = null)
        {
            return ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IBookTeachesNothing lhs,
            IBookTeachesNothingGetter rhs,
            out BookTeachesNothing.ErrorMask errorMask,
            BookTeachesNothing.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = BookTeachesNothing.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IBookTeachesNothing lhs,
            IBookTeachesNothingGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static BookTeachesNothing DeepCopy(
            this IBookTeachesNothingGetter item,
            BookTeachesNothing.TranslationMask? copyMask = null)
        {
            return ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static BookTeachesNothing DeepCopy(
            this IBookTeachesNothingGetter item,
            out BookTeachesNothing.ErrorMask errorMask,
            BookTeachesNothing.TranslationMask? copyMask = null)
        {
            return ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static BookTeachesNothing DeepCopy(
            this IBookTeachesNothingGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IBookTeachesNothing item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((BookTeachesNothingSetterCommon)((IBookTeachesNothingGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum BookTeachesNothing_FieldIndex
    {
        RawContent = 0,
    }
    #endregion

    #region Registration
    internal partial class BookTeachesNothing_Registration : ILoquiRegistration
    {
        public static readonly BookTeachesNothing_Registration Instance = new BookTeachesNothing_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 151,
            version: 0);

        public const string GUID = "8d37a460-5252-4bcb-a18d-e0a23f1a38ff";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(BookTeachesNothing.Mask<>);

        public static readonly Type ErrorMaskType = typeof(BookTeachesNothing.ErrorMask);

        public static readonly Type ClassType = typeof(BookTeachesNothing);

        public static readonly Type GetterType = typeof(IBookTeachesNothingGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IBookTeachesNothing);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.BookTeachesNothing";

        public const string Name = "BookTeachesNothing";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(BookTeachesNothingBinaryWriteTranslation);
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
    internal partial class BookTeachesNothingSetterCommon : BookTeachTargetSetterCommon
    {
        public new static readonly BookTeachesNothingSetterCommon Instance = new BookTeachesNothingSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IBookTeachesNothing item)
        {
            ClearPartial();
            item.RawContent = default;
            base.Clear(item);
        }
        
        public override void Clear(IBookTeachTarget item)
        {
            Clear(item: (IBookTeachesNothing)item);
        }
        
        #region Mutagen
        public void RemapLinks(IBookTeachesNothing obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IBookTeachesNothing item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: BookTeachesNothingBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IBookTeachTarget item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            CopyInFromBinary(
                item: (BookTeachesNothing)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class BookTeachesNothingCommon : BookTeachTargetCommon
    {
        public new static readonly BookTeachesNothingCommon Instance = new BookTeachesNothingCommon();

        public BookTeachesNothing.Mask<bool> GetEqualsMask(
            IBookTeachesNothingGetter item,
            IBookTeachesNothingGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new BookTeachesNothing.Mask<bool>(false);
            ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IBookTeachesNothingGetter item,
            IBookTeachesNothingGetter rhs,
            BookTeachesNothing.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.RawContent = item.RawContent == rhs.RawContent;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IBookTeachesNothingGetter item,
            string? name = null,
            BookTeachesNothing.Mask<bool>? printMask = null)
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
            IBookTeachesNothingGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            BookTeachesNothing.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"BookTeachesNothing =>");
            }
            else
            {
                sb.AppendLine($"{name} (BookTeachesNothing) =>");
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
            IBookTeachesNothingGetter item,
            StructuredStringBuilder sb,
            BookTeachesNothing.Mask<bool>? printMask = null)
        {
            BookTeachTargetCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.RawContent ?? true)
            {
                sb.AppendItem(item.RawContent, "RawContent");
            }
        }
        
        public static BookTeachesNothing_FieldIndex ConvertFieldIndex(BookTeachTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IBookTeachesNothingGetter? lhs,
            IBookTeachesNothingGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IBookTeachTargetGetter)lhs, (IBookTeachTargetGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)BookTeachesNothing_FieldIndex.RawContent) ?? true))
            {
                if (lhs.RawContent != rhs.RawContent) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IBookTeachTargetGetter? lhs,
            IBookTeachTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IBookTeachesNothingGetter?)lhs,
                rhs: rhs as IBookTeachesNothingGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IBookTeachesNothingGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.RawContent);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IBookTeachTargetGetter item)
        {
            return GetHashCode(item: (IBookTeachesNothingGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return BookTeachesNothing.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IBookTeachesNothingGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class BookTeachesNothingSetterTranslationCommon : BookTeachTargetSetterTranslationCommon
    {
        public new static readonly BookTeachesNothingSetterTranslationCommon Instance = new BookTeachesNothingSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IBookTeachesNothing item,
            IBookTeachesNothingGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IBookTeachTarget)item,
                (IBookTeachTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)BookTeachesNothing_FieldIndex.RawContent) ?? true))
            {
                item.RawContent = rhs.RawContent;
            }
        }
        
        
        public override void DeepCopyIn(
            IBookTeachTarget item,
            IBookTeachTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IBookTeachesNothing)item,
                rhs: (IBookTeachesNothingGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public BookTeachesNothing DeepCopy(
            IBookTeachesNothingGetter item,
            BookTeachesNothing.TranslationMask? copyMask = null)
        {
            BookTeachesNothing ret = (BookTeachesNothing)((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).GetNew();
            ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public BookTeachesNothing DeepCopy(
            IBookTeachesNothingGetter item,
            out BookTeachesNothing.ErrorMask errorMask,
            BookTeachesNothing.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            BookTeachesNothing ret = (BookTeachesNothing)((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).GetNew();
            ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = BookTeachesNothing.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public BookTeachesNothing DeepCopy(
            IBookTeachesNothingGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            BookTeachesNothing ret = (BookTeachesNothing)((BookTeachesNothingCommon)((IBookTeachesNothingGetter)item).CommonInstance()!).GetNew();
            ((BookTeachesNothingSetterTranslationCommon)((IBookTeachesNothingGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class BookTeachesNothing
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookTeachesNothing_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => BookTeachesNothing_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => BookTeachesNothingCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return BookTeachesNothingSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => BookTeachesNothingSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class BookTeachesNothingBinaryWriteTranslation :
        BookTeachTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static BookTeachesNothingBinaryWriteTranslation Instance = new BookTeachesNothingBinaryWriteTranslation();

        public static void WriteEmbedded(
            IBookTeachesNothingGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.RawContent);
        }

        public void Write(
            MutagenWriter writer,
            IBookTeachesNothingGetter item,
            TypedWriteParams? translationParams = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IBookTeachesNothingGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IBookTeachTargetGetter item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IBookTeachesNothingGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class BookTeachesNothingBinaryCreateTranslation : BookTeachTargetBinaryCreateTranslation
    {
        public new readonly static BookTeachesNothingBinaryCreateTranslation Instance = new BookTeachesNothingBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IBookTeachesNothing item,
            MutagenFrame frame)
        {
            item.RawContent = frame.ReadUInt32();
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class BookTeachesNothingBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class BookTeachesNothingBinaryOverlay :
        BookTeachTargetBinaryOverlay,
        IBookTeachesNothingGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BookTeachesNothing_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => BookTeachesNothing_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => BookTeachesNothingCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => BookTeachesNothingSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => BookTeachesNothingBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((BookTeachesNothingBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public UInt32 RawContent => BinaryPrimitives.ReadUInt32LittleEndian(_data.Slice(0x0, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected BookTeachesNothingBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static IBookTeachesNothingGetter BookTeachesNothingFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new BookTeachesNothingBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x4),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IBookTeachesNothingGetter BookTeachesNothingFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return BookTeachesNothingFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            BookTeachesNothingMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBookTeachesNothingGetter rhs) return false;
            return ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IBookTeachesNothingGetter? obj)
        {
            return ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((BookTeachesNothingCommon)((IBookTeachesNothingGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

