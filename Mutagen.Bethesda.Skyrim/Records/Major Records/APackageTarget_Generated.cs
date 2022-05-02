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
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Cache;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
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
    /// <summary>
    /// Implemented by: [PackageTargetSpecificReference, PackageTargetObjectID, PackageTargetObjectType, PackageTargetReference, PackageTargetAlias, PackageTargetUnknown, PackageTargetSelf]
    /// </summary>
    public abstract partial class APackageTarget :
        IAPackageTarget,
        IEquatable<IAPackageTargetGetter>,
        ILoquiObjectSetter<APackageTarget>
    {
        #region Ctor
        public APackageTarget()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region CountOrDistance
        public Int32 CountOrDistance { get; set; } = default;
        #endregion

        #region To String

        public virtual void ToString(
            StructuredStringBuilder sb,
            string? name = null)
        {
            APackageTargetMixIn.ToString(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IAPackageTargetGetter rhs) return false;
            return ((APackageTargetCommon)((IAPackageTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IAPackageTargetGetter? obj)
        {
            return ((APackageTargetCommon)((IAPackageTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((APackageTargetCommon)((IAPackageTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem CountOrDistance)
            {
                this.CountOrDistance = CountOrDistance;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem CountOrDistance;
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
                if (!object.Equals(this.CountOrDistance, rhs.CountOrDistance)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.CountOrDistance);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public virtual bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.CountOrDistance)) return false;
                return true;
            }
            #endregion

            #region Any
            public virtual bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.CountOrDistance)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new APackageTarget.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.CountOrDistance = eval(this.CountOrDistance);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(APackageTarget.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                ToString(sb, printMask);
                return sb.ToString();
            }

            public void ToString(StructuredStringBuilder sb, APackageTarget.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(APackageTarget.Mask<TItem>)} =>");
                sb.AppendLine("[");
                using (sb.IncreaseDepth())
                {
                    if (printMask?.CountOrDistance ?? true)
                    {
                        sb.AppendItem(CountOrDistance, "CountOrDistance");
                    }
                }
                sb.AppendLine("]");
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
            public Exception? CountOrDistance;
            #endregion

            #region IErrorMask
            public virtual object? GetNthMask(int index)
            {
                APackageTarget_FieldIndex enu = (APackageTarget_FieldIndex)index;
                switch (enu)
                {
                    case APackageTarget_FieldIndex.CountOrDistance:
                        return CountOrDistance;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthException(int index, Exception ex)
            {
                APackageTarget_FieldIndex enu = (APackageTarget_FieldIndex)index;
                switch (enu)
                {
                    case APackageTarget_FieldIndex.CountOrDistance:
                        this.CountOrDistance = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual void SetNthMask(int index, object obj)
            {
                APackageTarget_FieldIndex enu = (APackageTarget_FieldIndex)index;
                switch (enu)
                {
                    case APackageTarget_FieldIndex.CountOrDistance:
                        this.CountOrDistance = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public virtual bool IsInError()
            {
                if (Overall != null) return true;
                if (CountOrDistance != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var sb = new StructuredStringBuilder();
                ToString(sb, null);
                return sb.ToString();
            }

            public virtual void ToString(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                sb.AppendLine("[");
                using (sb.IncreaseDepth())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        sb.AppendLine("[");
                        using (sb.IncreaseDepth())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                        sb.AppendLine("]");
                    }
                    ToString_FillInternal(sb);
                }
                sb.AppendLine("]");
            }
            protected virtual void ToString_FillInternal(StructuredStringBuilder sb)
            {
                {
                    sb.AppendItem(CountOrDistance, "CountOrDistance");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.CountOrDistance = this.CountOrDistance.Combine(rhs.CountOrDistance);
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
            public bool CountOrDistance;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.CountOrDistance = defaultOn;
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
                ret.Add((CountOrDistance, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Mutagen
        public virtual IEnumerable<IFormLinkGetter> EnumerateFormLinks() => APackageTargetCommon.Instance.EnumerateFormLinks(this);
        public virtual void RemapLinks(IReadOnlyDictionary<FormKey, FormKey> mapping) => APackageTargetSetterCommon.Instance.RemapLinks(this, mapping);
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => APackageTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((APackageTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #endregion

        void IPrintable.ToString(StructuredStringBuilder sb, string? name) => this.ToString(sb, name);

        void IClearable.Clear()
        {
            ((APackageTargetSetterCommon)((IAPackageTargetGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static APackageTarget GetNew()
        {
            throw new ArgumentException("New called on an abstract class.");
        }

    }
    #endregion

    #region Interface
    /// <summary>
    /// Implemented by: [PackageTargetSpecificReference, PackageTargetObjectID, PackageTargetObjectType, PackageTargetReference, PackageTargetAlias, PackageTargetUnknown, PackageTargetSelf]
    /// </summary>
    public partial interface IAPackageTarget :
        IAPackageTargetGetter,
        IFormLinkContainer,
        ILoquiObjectSetter<IAPackageTarget>
    {
        new Int32 CountOrDistance { get; set; }
    }

    /// <summary>
    /// Implemented by: [PackageTargetSpecificReference, PackageTargetObjectID, PackageTargetObjectType, PackageTargetReference, PackageTargetAlias, PackageTargetUnknown, PackageTargetSelf]
    /// </summary>
    public partial interface IAPackageTargetGetter :
        ILoquiObject,
        IBinaryItem,
        IFormLinkContainerGetter,
        ILoquiObject<IAPackageTargetGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => APackageTarget_Registration.Instance;
        Int32 CountOrDistance { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class APackageTargetMixIn
    {
        public static void Clear(this IAPackageTarget item)
        {
            ((APackageTargetSetterCommon)((IAPackageTargetGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static APackageTarget.Mask<bool> GetEqualsMask(
            this IAPackageTargetGetter item,
            IAPackageTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IAPackageTargetGetter item,
            string? name = null,
            APackageTarget.Mask<bool>? printMask = null)
        {
            return ((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IAPackageTargetGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            APackageTarget.Mask<bool>? printMask = null)
        {
            ((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).ToString(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IAPackageTargetGetter item,
            IAPackageTargetGetter rhs,
            APackageTarget.TranslationMask? equalsMask = null)
        {
            return ((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IAPackageTarget lhs,
            IAPackageTargetGetter rhs)
        {
            ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IAPackageTarget lhs,
            IAPackageTargetGetter rhs,
            APackageTarget.TranslationMask? copyMask = null)
        {
            ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IAPackageTarget lhs,
            IAPackageTargetGetter rhs,
            out APackageTarget.ErrorMask errorMask,
            APackageTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = APackageTarget.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IAPackageTarget lhs,
            IAPackageTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static APackageTarget DeepCopy(
            this IAPackageTargetGetter item,
            APackageTarget.TranslationMask? copyMask = null)
        {
            return ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static APackageTarget DeepCopy(
            this IAPackageTargetGetter item,
            out APackageTarget.ErrorMask errorMask,
            APackageTarget.TranslationMask? copyMask = null)
        {
            return ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static APackageTarget DeepCopy(
            this IAPackageTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IAPackageTarget item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((APackageTargetSetterCommon)((IAPackageTargetGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum APackageTarget_FieldIndex
    {
        CountOrDistance = 0,
    }
    #endregion

    #region Registration
    internal partial class APackageTarget_Registration : ILoquiRegistration
    {
        public static readonly APackageTarget_Registration Instance = new APackageTarget_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 375,
            version: 0);

        public const string GUID = "d99aa9dc-0c39-4321-ac3f-9fd29accd256";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(APackageTarget.Mask<>);

        public static readonly Type ErrorMaskType = typeof(APackageTarget.ErrorMask);

        public static readonly Type ClassType = typeof(APackageTarget);

        public static readonly Type GetterType = typeof(IAPackageTargetGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IAPackageTarget);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.APackageTarget";

        public const string Name = "APackageTarget";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(APackageTargetBinaryWriteTranslation);
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
    internal partial class APackageTargetSetterCommon
    {
        public static readonly APackageTargetSetterCommon Instance = new APackageTargetSetterCommon();

        partial void ClearPartial();
        
        public virtual void Clear(IAPackageTarget item)
        {
            ClearPartial();
            item.CountOrDistance = default;
        }
        
        #region Mutagen
        public void RemapLinks(IAPackageTarget obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IAPackageTarget item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
        }
        
        #endregion
        
    }
    internal partial class APackageTargetCommon
    {
        public static readonly APackageTargetCommon Instance = new APackageTargetCommon();

        public APackageTarget.Mask<bool> GetEqualsMask(
            IAPackageTargetGetter item,
            IAPackageTargetGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new APackageTarget.Mask<bool>(false);
            ((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IAPackageTargetGetter item,
            IAPackageTargetGetter rhs,
            APackageTarget.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.CountOrDistance = item.CountOrDistance == rhs.CountOrDistance;
        }
        
        public string ToString(
            IAPackageTargetGetter item,
            string? name = null,
            APackageTarget.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            ToString(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void ToString(
            IAPackageTargetGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            APackageTarget.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"APackageTarget =>");
            }
            else
            {
                sb.AppendLine($"{name} (APackageTarget) =>");
            }
            sb.AppendLine("[");
            using (sb.IncreaseDepth())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
            sb.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IAPackageTargetGetter item,
            StructuredStringBuilder sb,
            APackageTarget.Mask<bool>? printMask = null)
        {
            if (printMask?.CountOrDistance ?? true)
            {
                sb.AppendItem(item.CountOrDistance, "CountOrDistance");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IAPackageTargetGetter? lhs,
            IAPackageTargetGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)APackageTarget_FieldIndex.CountOrDistance) ?? true))
            {
                if (lhs.CountOrDistance != rhs.CountOrDistance) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IAPackageTargetGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.CountOrDistance);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public virtual object GetNew()
        {
            return APackageTarget.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IAPackageTargetGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class APackageTargetSetterTranslationCommon
    {
        public static readonly APackageTargetSetterTranslationCommon Instance = new APackageTargetSetterTranslationCommon();

        #region DeepCopyIn
        public virtual void DeepCopyIn(
            IAPackageTarget item,
            IAPackageTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)APackageTarget_FieldIndex.CountOrDistance) ?? true))
            {
                item.CountOrDistance = rhs.CountOrDistance;
            }
        }
        
        #endregion
        
        public APackageTarget DeepCopy(
            IAPackageTargetGetter item,
            APackageTarget.TranslationMask? copyMask = null)
        {
            APackageTarget ret = (APackageTarget)((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).GetNew();
            ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public APackageTarget DeepCopy(
            IAPackageTargetGetter item,
            out APackageTarget.ErrorMask errorMask,
            APackageTarget.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            APackageTarget ret = (APackageTarget)((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).GetNew();
            ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = APackageTarget.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public APackageTarget DeepCopy(
            IAPackageTargetGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            APackageTarget ret = (APackageTarget)((APackageTargetCommon)((IAPackageTargetGetter)item).CommonInstance()!).GetNew();
            ((APackageTargetSetterTranslationCommon)((IAPackageTargetGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class APackageTarget
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => APackageTarget_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => APackageTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => APackageTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterInstance()
        {
            return APackageTargetSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => APackageTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IAPackageTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IAPackageTargetGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IAPackageTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class APackageTargetBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static APackageTargetBinaryWriteTranslation Instance = new APackageTargetBinaryWriteTranslation();

        public static void WriteEmbedded(
            IAPackageTargetGetter item,
            MutagenWriter writer)
        {
            APackageTargetBinaryWriteTranslation.WriteBinaryDataParse(
                writer: writer,
                item: item);
            writer.Write(item.CountOrDistance, length: 4);
        }

        public static partial void WriteBinaryDataParseCustom(
            MutagenWriter writer,
            IAPackageTargetGetter item);

        public static void WriteBinaryDataParse(
            MutagenWriter writer,
            IAPackageTargetGetter item)
        {
            WriteBinaryDataParseCustom(
                writer: writer,
                item: item);
        }

        public virtual void Write(
            MutagenWriter writer,
            IAPackageTargetGetter item,
            TypedWriteParams? translationParams = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public virtual void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IAPackageTargetGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class APackageTargetBinaryCreateTranslation
    {
        public readonly static APackageTargetBinaryCreateTranslation Instance = new APackageTargetBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IAPackageTarget item,
            MutagenFrame frame)
        {
            APackageTargetBinaryCreateTranslation.FillBinaryDataParseCustom(
                frame: frame,
                item: item);
            item.CountOrDistance = frame.ReadInt32();
        }

        public static partial void FillBinaryDataParseCustom(
            MutagenFrame frame,
            IAPackageTarget item);

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class APackageTargetBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IAPackageTargetGetter item,
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((APackageTargetBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal abstract partial class APackageTargetBinaryOverlay :
        PluginBinaryOverlay,
        IAPackageTargetGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => APackageTarget_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => APackageTarget_Registration.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonInstance() => APackageTargetCommon.Instance;
        [DebuggerStepThrough]
        protected virtual object CommonSetterTranslationInstance() => APackageTargetSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IAPackageTargetGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IAPackageTargetGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IAPackageTargetGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(StructuredStringBuilder sb, string? name) => this.ToString(sb, name);

        public virtual IEnumerable<IFormLinkGetter> EnumerateFormLinks() => APackageTargetCommon.Instance.EnumerateFormLinks(this);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected virtual object BinaryWriteTranslator => APackageTargetBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((APackageTargetBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        #region DataParse
        partial void DataParseCustomParse(
            OverlayStream stream,
            int offset);
        #endregion
        public Int32 CountOrDistance => BinaryPrimitives.ReadInt32LittleEndian(_data.Slice(0x8, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected APackageTargetBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }


        #region To String

        public virtual void ToString(
            StructuredStringBuilder sb,
            string? name = null)
        {
            APackageTargetMixIn.ToString(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IAPackageTargetGetter rhs) return false;
            return ((APackageTargetCommon)((IAPackageTargetGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IAPackageTargetGetter? obj)
        {
            return ((APackageTargetCommon)((IAPackageTargetGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((APackageTargetCommon)((IAPackageTargetGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

