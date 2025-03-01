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
    public partial class BodyTemplate :
        IBodyTemplate,
        IEquatable<IBodyTemplateGetter>,
        ILoquiObjectSetter<BodyTemplate>
    {
        #region Ctor
        public BodyTemplate()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region FirstPersonFlags
        public BipedObjectFlag FirstPersonFlags { get; set; } = default;
        #endregion

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            BodyTemplateMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBodyTemplateGetter rhs) return false;
            return ((BodyTemplateCommon)((IBodyTemplateGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IBodyTemplateGetter? obj)
        {
            return ((BodyTemplateCommon)((IBodyTemplateGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((BodyTemplateCommon)((IBodyTemplateGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem FirstPersonFlags)
            {
                this.FirstPersonFlags = FirstPersonFlags;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem FirstPersonFlags;
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
                if (!object.Equals(this.FirstPersonFlags, rhs.FirstPersonFlags)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.FirstPersonFlags);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.FirstPersonFlags)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.FirstPersonFlags)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new BodyTemplate.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.FirstPersonFlags = eval(this.FirstPersonFlags);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(BodyTemplate.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, BodyTemplate.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(BodyTemplate.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.FirstPersonFlags ?? true)
                    {
                        sb.AppendItem(FirstPersonFlags, "FirstPersonFlags");
                    }
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
            public Exception? FirstPersonFlags;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                BodyTemplate_FieldIndex enu = (BodyTemplate_FieldIndex)index;
                switch (enu)
                {
                    case BodyTemplate_FieldIndex.FirstPersonFlags:
                        return FirstPersonFlags;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                BodyTemplate_FieldIndex enu = (BodyTemplate_FieldIndex)index;
                switch (enu)
                {
                    case BodyTemplate_FieldIndex.FirstPersonFlags:
                        this.FirstPersonFlags = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                BodyTemplate_FieldIndex enu = (BodyTemplate_FieldIndex)index;
                switch (enu)
                {
                    case BodyTemplate_FieldIndex.FirstPersonFlags:
                        this.FirstPersonFlags = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (FirstPersonFlags != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public void Print(StructuredStringBuilder sb, string? name = null)
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
            protected void PrintFillInternal(StructuredStringBuilder sb)
            {
                {
                    sb.AppendItem(FirstPersonFlags, "FirstPersonFlags");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.FirstPersonFlags = this.FirstPersonFlags.Combine(rhs.FirstPersonFlags);
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
            public bool FirstPersonFlags;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.FirstPersonFlags = defaultOn;
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

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((FirstPersonFlags, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => BodyTemplateBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((BodyTemplateBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static BodyTemplate CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new BodyTemplate();
            ((BodyTemplateSetterCommon)((IBodyTemplateGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out BodyTemplate item,
            TypedParseParams translationParams = default)
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
            ((BodyTemplateSetterCommon)((IBodyTemplateGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static BodyTemplate GetNew()
        {
            return new BodyTemplate();
        }

    }
    #endregion

    #region Interface
    public partial interface IBodyTemplate :
        IBodyTemplateGetter,
        ILoquiObjectSetter<IBodyTemplate>
    {
        new BipedObjectFlag FirstPersonFlags { get; set; }
    }

    public partial interface IBodyTemplateGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<IBodyTemplateGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => BodyTemplate_Registration.Instance;
        BipedObjectFlag FirstPersonFlags { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class BodyTemplateMixIn
    {
        public static void Clear(this IBodyTemplate item)
        {
            ((BodyTemplateSetterCommon)((IBodyTemplateGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static BodyTemplate.Mask<bool> GetEqualsMask(
            this IBodyTemplateGetter item,
            IBodyTemplateGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IBodyTemplateGetter item,
            string? name = null,
            BodyTemplate.Mask<bool>? printMask = null)
        {
            return ((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IBodyTemplateGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            BodyTemplate.Mask<bool>? printMask = null)
        {
            ((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IBodyTemplateGetter item,
            IBodyTemplateGetter rhs,
            BodyTemplate.TranslationMask? equalsMask = null)
        {
            return ((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IBodyTemplate lhs,
            IBodyTemplateGetter rhs)
        {
            ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IBodyTemplate lhs,
            IBodyTemplateGetter rhs,
            BodyTemplate.TranslationMask? copyMask = null)
        {
            ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IBodyTemplate lhs,
            IBodyTemplateGetter rhs,
            out BodyTemplate.ErrorMask errorMask,
            BodyTemplate.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = BodyTemplate.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IBodyTemplate lhs,
            IBodyTemplateGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static BodyTemplate DeepCopy(
            this IBodyTemplateGetter item,
            BodyTemplate.TranslationMask? copyMask = null)
        {
            return ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static BodyTemplate DeepCopy(
            this IBodyTemplateGetter item,
            out BodyTemplate.ErrorMask errorMask,
            BodyTemplate.TranslationMask? copyMask = null)
        {
            return ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static BodyTemplate DeepCopy(
            this IBodyTemplateGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IBodyTemplate item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((BodyTemplateSetterCommon)((IBodyTemplateGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum BodyTemplate_FieldIndex
    {
        FirstPersonFlags = 0,
    }
    #endregion

    #region Registration
    internal partial class BodyTemplate_Registration : ILoquiRegistration
    {
        public static readonly BodyTemplate_Registration Instance = new BodyTemplate_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 134,
            version: 0);

        public const string GUID = "ab1ebc3d-5b10-40d1-91d9-66100bd50769";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 1;

        public static readonly Type MaskType = typeof(BodyTemplate.Mask<>);

        public static readonly Type ErrorMaskType = typeof(BodyTemplate.ErrorMask);

        public static readonly Type ClassType = typeof(BodyTemplate);

        public static readonly Type GetterType = typeof(IBodyTemplateGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IBodyTemplate);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.BodyTemplate";

        public const string Name = "BodyTemplate";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.BOD2;
        public static RecordTriggerSpecs TriggerSpecs => _recordSpecs.Value;
        private static readonly Lazy<RecordTriggerSpecs> _recordSpecs = new Lazy<RecordTriggerSpecs>(() =>
        {
            var all = RecordCollection.Factory(RecordTypes.BOD2);
            return new RecordTriggerSpecs(allRecordTypes: all);
        });
        public static readonly Type BinaryWriteTranslation = typeof(BodyTemplateBinaryWriteTranslation);
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
    internal partial class BodyTemplateSetterCommon
    {
        public static readonly BodyTemplateSetterCommon Instance = new BodyTemplateSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IBodyTemplate item)
        {
            ClearPartial();
            item.FirstPersonFlags = default;
        }
        
        #region Mutagen
        public void RemapLinks(IBodyTemplate obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IBodyTemplate item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            frame = frame.SpawnWithFinalPosition(HeaderTranslation.ParseSubrecord(
                frame.Reader,
                translationParams.ConvertToCustom(RecordTypes.BOD2),
                translationParams.LengthOverride));
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: BodyTemplateBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class BodyTemplateCommon
    {
        public static readonly BodyTemplateCommon Instance = new BodyTemplateCommon();

        public BodyTemplate.Mask<bool> GetEqualsMask(
            IBodyTemplateGetter item,
            IBodyTemplateGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new BodyTemplate.Mask<bool>(false);
            ((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IBodyTemplateGetter item,
            IBodyTemplateGetter rhs,
            BodyTemplate.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.FirstPersonFlags = item.FirstPersonFlags == rhs.FirstPersonFlags;
        }
        
        public string Print(
            IBodyTemplateGetter item,
            string? name = null,
            BodyTemplate.Mask<bool>? printMask = null)
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
            IBodyTemplateGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            BodyTemplate.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"BodyTemplate =>");
            }
            else
            {
                sb.AppendLine($"{name} (BodyTemplate) =>");
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
            IBodyTemplateGetter item,
            StructuredStringBuilder sb,
            BodyTemplate.Mask<bool>? printMask = null)
        {
            if (printMask?.FirstPersonFlags ?? true)
            {
                sb.AppendItem(item.FirstPersonFlags, "FirstPersonFlags");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IBodyTemplateGetter? lhs,
            IBodyTemplateGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((equalsMask?.GetShouldTranslate((int)BodyTemplate_FieldIndex.FirstPersonFlags) ?? true))
            {
                if (lhs.FirstPersonFlags != rhs.FirstPersonFlags) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IBodyTemplateGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.FirstPersonFlags);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return BodyTemplate.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IBodyTemplateGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class BodyTemplateSetterTranslationCommon
    {
        public static readonly BodyTemplateSetterTranslationCommon Instance = new BodyTemplateSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IBodyTemplate item,
            IBodyTemplateGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)BodyTemplate_FieldIndex.FirstPersonFlags) ?? true))
            {
                item.FirstPersonFlags = rhs.FirstPersonFlags;
            }
        }
        
        #endregion
        
        public BodyTemplate DeepCopy(
            IBodyTemplateGetter item,
            BodyTemplate.TranslationMask? copyMask = null)
        {
            BodyTemplate ret = (BodyTemplate)((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).GetNew();
            ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public BodyTemplate DeepCopy(
            IBodyTemplateGetter item,
            out BodyTemplate.ErrorMask errorMask,
            BodyTemplate.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            BodyTemplate ret = (BodyTemplate)((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).GetNew();
            ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = BodyTemplate.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public BodyTemplate DeepCopy(
            IBodyTemplateGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            BodyTemplate ret = (BodyTemplate)((BodyTemplateCommon)((IBodyTemplateGetter)item).CommonInstance()!).GetNew();
            ((BodyTemplateSetterTranslationCommon)((IBodyTemplateGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class BodyTemplate
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BodyTemplate_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => BodyTemplate_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => BodyTemplateCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return BodyTemplateSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => BodyTemplateSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IBodyTemplateGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IBodyTemplateGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IBodyTemplateGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class BodyTemplateBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public static readonly BodyTemplateBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IBodyTemplateGetter item,
            MutagenWriter writer)
        {
            EnumBinaryTranslation<BipedObjectFlag, MutagenFrame, MutagenWriter>.Instance.Write(
                writer,
                item.FirstPersonFlags,
                length: 4);
        }

        public void Write(
            MutagenWriter writer,
            IBodyTemplateGetter item,
            TypedWriteParams translationParams)
        {
            using (HeaderExport.Subrecord(
                writer: writer,
                record: translationParams.ConvertToCustom(RecordTypes.BOD2),
                overflowRecord: translationParams.OverflowRecordType,
                out var writerToUse))
            {
                WriteEmbedded(
                    item: item,
                    writer: writerToUse);
            }
        }

        public void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IBodyTemplateGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class BodyTemplateBinaryCreateTranslation
    {
        public static readonly BodyTemplateBinaryCreateTranslation Instance = new BodyTemplateBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IBodyTemplate item,
            MutagenFrame frame)
        {
            item.FirstPersonFlags = EnumBinaryTranslation<BipedObjectFlag, MutagenFrame, MutagenWriter>.Instance.Parse(
                reader: frame,
                length: 4);
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class BodyTemplateBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IBodyTemplateGetter item,
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((BodyTemplateBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class BodyTemplateBinaryOverlay :
        PluginBinaryOverlay,
        IBodyTemplateGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => BodyTemplate_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => BodyTemplate_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => BodyTemplateCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => BodyTemplateSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IBodyTemplateGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IBodyTemplateGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IBodyTemplateGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => BodyTemplateBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((BodyTemplateBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public BipedObjectFlag FirstPersonFlags => (BipedObjectFlag)BinaryPrimitives.ReadInt32LittleEndian(_structData.Span.Slice(0x0, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected BodyTemplateBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IBodyTemplateGetter BodyTemplateFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x4,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new BodyTemplateBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x4 + package.MetaData.Constants.SubConstants.HeaderLength;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IBodyTemplateGetter BodyTemplateFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return BodyTemplateFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            BodyTemplateMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IBodyTemplateGetter rhs) return false;
            return ((BodyTemplateCommon)((IBodyTemplateGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IBodyTemplateGetter? obj)
        {
            return ((BodyTemplateCommon)((IBodyTemplateGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((BodyTemplateCommon)((IBodyTemplateGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

