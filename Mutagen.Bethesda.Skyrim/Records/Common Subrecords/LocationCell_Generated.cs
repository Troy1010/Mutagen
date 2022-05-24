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
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Skyrim.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Skyrim.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class LocationCell :
        ALocationTarget,
        IEquatable<ILocationCellGetter>,
        ILocationCell,
        ILoquiObjectSetter<LocationCell>
    {
        #region Ctor
        public LocationCell()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Link
        private readonly IFormLink<ICellGetter> _Link = new FormLink<ICellGetter>();
        public IFormLink<ICellGetter> Link
        {
            get => _Link;
            set => _Link.SetTo(value);
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IFormLinkGetter<ICellGetter> ILocationCellGetter.Link => this.Link;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            LocationCellMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationCellGetter rhs) return false;
            return ((LocationCellCommon)((ILocationCellGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationCellGetter? obj)
        {
            return ((LocationCellCommon)((ILocationCellGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((LocationCellCommon)((ILocationCellGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ALocationTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem Link)
            : base()
            {
                this.Link = Link;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Link;
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
                if (!object.Equals(this.Link, rhs.Link)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Link);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Link)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Link)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new LocationCell.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Link = eval(this.Link);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(LocationCell.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, LocationCell.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(LocationCell.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Link ?? true)
                    {
                        sb.AppendItem(Link, "Link");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            ALocationTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Link;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                LocationCell_FieldIndex enu = (LocationCell_FieldIndex)index;
                switch (enu)
                {
                    case LocationCell_FieldIndex.Link:
                        return Link;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                LocationCell_FieldIndex enu = (LocationCell_FieldIndex)index;
                switch (enu)
                {
                    case LocationCell_FieldIndex.Link:
                        this.Link = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                LocationCell_FieldIndex enu = (LocationCell_FieldIndex)index;
                switch (enu)
                {
                    case LocationCell_FieldIndex.Link:
                        this.Link = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Link != null) return true;
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
                    sb.AppendItem(Link, "Link");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Link = this.Link.Combine(rhs.Link);
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
            ALocationTarget.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Link;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Link = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Link, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => LocationCellCommon.Instance.EnumerateFormLinks(this);
        public override void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => LocationCellSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationCellBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((LocationCellBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static LocationCell CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new LocationCell();
            ((LocationCellSetterCommon)((ILocationCellGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out LocationCell item,
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
            ((LocationCellSetterCommon)((ILocationCellGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new LocationCell GetNew()
        {
            return new LocationCell();
        }

    }
    #endregion

    #region Interface
    public partial interface ILocationCell :
        IALocationTarget,
        IFormLinkContainer,
        ILocationCellGetter,
        ILoquiObjectSetter<ILocationCell>
    {
        new IFormLink<ICellGetter> Link { get; set; }
    }

    public partial interface ILocationCellGetter :
        IALocationTargetGetter,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<ILocationCellGetter>
    {
        static new ILoquiRegistration StaticRegistration => LocationCell_Registration.Instance;
        IFormLinkGetter<ICellGetter> Link { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class LocationCellMixIn
    {
        public static void Clear(this ILocationCell item)
        {
            ((LocationCellSetterCommon)((ILocationCellGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static LocationCell.Mask<bool> GetEqualsMask(
            this ILocationCellGetter item,
            ILocationCellGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this ILocationCellGetter item,
            string? name = null,
            LocationCell.Mask<bool>? printMask = null)
        {
            return ((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this ILocationCellGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            LocationCell.Mask<bool>? printMask = null)
        {
            ((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this ILocationCellGetter item,
            ILocationCellGetter rhs,
            LocationCell.TranslationMask? equalsMask = null)
        {
            return ((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this ILocationCell lhs,
            ILocationCellGetter rhs,
            out LocationCell.ErrorMask errorMask,
            LocationCell.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((LocationCellSetterTranslationCommon)((ILocationCellGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = LocationCell.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this ILocationCell lhs,
            ILocationCellGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((LocationCellSetterTranslationCommon)((ILocationCellGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static LocationCell DeepCopy(
            this ILocationCellGetter item,
            LocationCell.TranslationMask? copyMask = null)
        {
            return ((LocationCellSetterTranslationCommon)((ILocationCellGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static LocationCell DeepCopy(
            this ILocationCellGetter item,
            out LocationCell.ErrorMask errorMask,
            LocationCell.TranslationMask? copyMask = null)
        {
            return ((LocationCellSetterTranslationCommon)((ILocationCellGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static LocationCell DeepCopy(
            this ILocationCellGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((LocationCellSetterTranslationCommon)((ILocationCellGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this ILocationCell item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((LocationCellSetterCommon)((ILocationCellGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    #region Field Index
    internal enum LocationCell_FieldIndex
    {
        Link = 0,
    }
    #endregion

    #region Registration
    internal partial class LocationCell_Registration : ILoquiRegistration
    {
        public static readonly LocationCell_Registration Instance = new LocationCell_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 225,
            version: 0);

        public const string GUID = "fa2147ed-0603-474e-a281-ef054159913a";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(LocationCell.Mask<>);

        public static readonly Type ErrorMaskType = typeof(LocationCell.ErrorMask);

        public static readonly Type ClassType = typeof(LocationCell);

        public static readonly Type GetterType = typeof(ILocationCellGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(ILocationCell);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.LocationCell";

        public const string Name = "LocationCell";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(LocationCellBinaryWriteTranslation);
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
    internal partial class LocationCellSetterCommon : ALocationTargetSetterCommon
    {
        public new static readonly LocationCellSetterCommon Instance = new LocationCellSetterCommon();

        partial void ClearPartial();
        
        public void Clear(ILocationCell item)
        {
            ClearPartial();
            item.Link.Clear();
            base.Clear(item);
        }
        
        public override void Clear(IALocationTarget item)
        {
            Clear(item: (ILocationCell)item);
        }
        
        #region Mutagen
        public void RemapLinks(ILocationCell obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
            obj.Link.Relink(mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            ILocationCell item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: LocationCellBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IALocationTarget item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            CopyInFromBinary(
                item: (LocationCell)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class LocationCellCommon : ALocationTargetCommon
    {
        public new static readonly LocationCellCommon Instance = new LocationCellCommon();

        public LocationCell.Mask<bool> GetEqualsMask(
            ILocationCellGetter item,
            ILocationCellGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new LocationCell.Mask<bool>(false);
            ((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            ILocationCellGetter item,
            ILocationCellGetter rhs,
            LocationCell.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Link = item.Link.Equals(rhs.Link);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            ILocationCellGetter item,
            string? name = null,
            LocationCell.Mask<bool>? printMask = null)
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
            ILocationCellGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            LocationCell.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"LocationCell =>");
            }
            else
            {
                sb.AppendLine($"{name} (LocationCell) =>");
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
            ILocationCellGetter item,
            StructuredStringBuilder sb,
            LocationCell.Mask<bool>? printMask = null)
        {
            ALocationTargetCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Link ?? true)
            {
                sb.AppendItem(item.Link.FormKey, "Link");
            }
        }
        
        public static LocationCell_FieldIndex ConvertFieldIndex(ALocationTarget_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            ILocationCellGetter? lhs,
            ILocationCellGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IALocationTargetGetter)lhs, (IALocationTargetGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)LocationCell_FieldIndex.Link) ?? true))
            {
                if (!lhs.Link.Equals(rhs.Link)) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IALocationTargetGetter? lhs,
            IALocationTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (ILocationCellGetter?)lhs,
                rhs: rhs as ILocationCellGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(ILocationCellGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Link);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IALocationTargetGetter item)
        {
            return GetHashCode(item: (ILocationCellGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return LocationCell.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(ILocationCellGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield return FormLinkInformation.Factory(obj.Link);
            yield break;
        }
        
        #endregion
        
    }
    internal partial class LocationCellSetterTranslationCommon : ALocationTargetSetterTranslationCommon
    {
        public new static readonly LocationCellSetterTranslationCommon Instance = new LocationCellSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            ILocationCell item,
            ILocationCellGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IALocationTarget)item,
                (IALocationTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)LocationCell_FieldIndex.Link) ?? true))
            {
                item.Link.SetTo(rhs.Link.FormKey);
            }
        }
        
        
        public override void DeepCopyIn(
            IALocationTarget item,
            IALocationTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (ILocationCell)item,
                rhs: (ILocationCellGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public LocationCell DeepCopy(
            ILocationCellGetter item,
            LocationCell.TranslationMask? copyMask = null)
        {
            LocationCell ret = (LocationCell)((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).GetNew();
            ((LocationCellSetterTranslationCommon)((ILocationCellGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public LocationCell DeepCopy(
            ILocationCellGetter item,
            out LocationCell.ErrorMask errorMask,
            LocationCell.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            LocationCell ret = (LocationCell)((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).GetNew();
            ((LocationCellSetterTranslationCommon)((ILocationCellGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = LocationCell.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public LocationCell DeepCopy(
            ILocationCellGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            LocationCell ret = (LocationCell)((LocationCellCommon)((ILocationCellGetter)item).CommonInstance()!).GetNew();
            ((LocationCellSetterTranslationCommon)((ILocationCellGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Skyrim
{
    public partial class LocationCell
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LocationCell_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => LocationCell_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => LocationCellCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return LocationCellSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => LocationCellSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class LocationCellBinaryWriteTranslation :
        ALocationTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static LocationCellBinaryWriteTranslation Instance = new LocationCellBinaryWriteTranslation();

        public static void WriteEmbedded(
            ILocationCellGetter item,
            MutagenWriter writer)
        {
            FormLinkBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Link);
        }

        public void Write(
            MutagenWriter writer,
            ILocationCellGetter item,
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
                item: (ILocationCellGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IALocationTargetGetter item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (ILocationCellGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class LocationCellBinaryCreateTranslation : ALocationTargetBinaryCreateTranslation
    {
        public new readonly static LocationCellBinaryCreateTranslation Instance = new LocationCellBinaryCreateTranslation();

        public static void FillBinaryStructs(
            ILocationCell item,
            MutagenFrame frame)
        {
            item.Link.SetTo(FormLinkBinaryTranslation.Instance.Parse(reader: frame));
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class LocationCellBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class LocationCellBinaryOverlay :
        ALocationTargetBinaryOverlay,
        ILocationCellGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => LocationCell_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => LocationCell_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => LocationCellCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => LocationCellSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        public override IEnumerable<IFormLinkGetter> EnumerateFormLinks() => LocationCellCommon.Instance.EnumerateFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => LocationCellBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((LocationCellBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public IFormLinkGetter<ICellGetter> Link => new FormLink<ICellGetter>(FormKey.Factory(_package.MetaData.MasterReferences!, BinaryPrimitives.ReadUInt32LittleEndian(_data.Span.Slice(0x0, 0x4))));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected LocationCellBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static ILocationCellGetter LocationCellFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new LocationCellBinaryOverlay(
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

        public static ILocationCellGetter LocationCellFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return LocationCellFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            LocationCellMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not ILocationCellGetter rhs) return false;
            return ((LocationCellCommon)((ILocationCellGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(ILocationCellGetter? obj)
        {
            return ((LocationCellCommon)((ILocationCellGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((LocationCellCommon)((ILocationCellGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

