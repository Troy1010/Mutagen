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
    public partial class Alpha :
        IAlpha,
        IEquatable<IAlphaGetter>,
        ILoquiObjectSetter<Alpha>
    {
        #region Ctor
        public Alpha()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Cutoff
        public Byte Cutoff { get; set; } = default;
        #endregion
        #region Base
        public Byte Base { get; set; } = default;
        #endregion

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            AlphaMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IAlphaGetter rhs) return false;
            return ((AlphaCommon)((IAlphaGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IAlphaGetter? obj)
        {
            return ((AlphaCommon)((IAlphaGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((AlphaCommon)((IAlphaGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.Cutoff = initialValue;
                this.Base = initialValue;
            }

            public Mask(
                TItem Cutoff,
                TItem Base)
            {
                this.Cutoff = Cutoff;
                this.Base = Base;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Cutoff;
            public TItem Base;
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
                if (!object.Equals(this.Cutoff, rhs.Cutoff)) return false;
                if (!object.Equals(this.Base, rhs.Base)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Cutoff);
                hash.Add(this.Base);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.Cutoff)) return false;
                if (!eval(this.Base)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.Cutoff)) return true;
                if (eval(this.Base)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new Alpha.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.Cutoff = eval(this.Cutoff);
                obj.Base = eval(this.Base);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(Alpha.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, Alpha.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(Alpha.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Cutoff ?? true)
                    {
                        sb.AppendItem(Cutoff, "Cutoff");
                    }
                    if (printMask?.Base ?? true)
                    {
                        sb.AppendItem(Base, "Base");
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
            public Exception? Cutoff;
            public Exception? Base;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                Alpha_FieldIndex enu = (Alpha_FieldIndex)index;
                switch (enu)
                {
                    case Alpha_FieldIndex.Cutoff:
                        return Cutoff;
                    case Alpha_FieldIndex.Base:
                        return Base;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                Alpha_FieldIndex enu = (Alpha_FieldIndex)index;
                switch (enu)
                {
                    case Alpha_FieldIndex.Cutoff:
                        this.Cutoff = ex;
                        break;
                    case Alpha_FieldIndex.Base:
                        this.Base = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                Alpha_FieldIndex enu = (Alpha_FieldIndex)index;
                switch (enu)
                {
                    case Alpha_FieldIndex.Cutoff:
                        this.Cutoff = (Exception?)obj;
                        break;
                    case Alpha_FieldIndex.Base:
                        this.Base = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (Cutoff != null) return true;
                if (Base != null) return true;
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
                    sb.AppendItem(Cutoff, "Cutoff");
                }
                {
                    sb.AppendItem(Base, "Base");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Cutoff = this.Cutoff.Combine(rhs.Cutoff);
                ret.Base = this.Base.Combine(rhs.Base);
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
            public bool Cutoff;
            public bool Base;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.Cutoff = defaultOn;
                this.Base = defaultOn;
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
                ret.Add((Cutoff, null));
                ret.Add((Base, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => AlphaBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((AlphaBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public static Alpha CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new Alpha();
            ((AlphaSetterCommon)((IAlphaGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out Alpha item,
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
            ((AlphaSetterCommon)((IAlphaGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static Alpha GetNew()
        {
            return new Alpha();
        }

    }
    #endregion

    #region Interface
    public partial interface IAlpha :
        IAlphaGetter,
        ILoquiObjectSetter<IAlpha>
    {
        new Byte Cutoff { get; set; }
        new Byte Base { get; set; }
    }

    public partial interface IAlphaGetter :
        ILoquiObject,
        IBinaryItem,
        ILoquiObject<IAlphaGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => Alpha_Registration.Instance;
        Byte Cutoff { get; }
        Byte Base { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class AlphaMixIn
    {
        public static void Clear(this IAlpha item)
        {
            ((AlphaSetterCommon)((IAlphaGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static Alpha.Mask<bool> GetEqualsMask(
            this IAlphaGetter item,
            IAlphaGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IAlphaGetter item,
            string? name = null,
            Alpha.Mask<bool>? printMask = null)
        {
            return ((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IAlphaGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            Alpha.Mask<bool>? printMask = null)
        {
            ((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IAlphaGetter item,
            IAlphaGetter rhs,
            Alpha.TranslationMask? equalsMask = null)
        {
            return ((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IAlpha lhs,
            IAlphaGetter rhs)
        {
            ((AlphaSetterTranslationCommon)((IAlphaGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IAlpha lhs,
            IAlphaGetter rhs,
            Alpha.TranslationMask? copyMask = null)
        {
            ((AlphaSetterTranslationCommon)((IAlphaGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IAlpha lhs,
            IAlphaGetter rhs,
            out Alpha.ErrorMask errorMask,
            Alpha.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((AlphaSetterTranslationCommon)((IAlphaGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = Alpha.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IAlpha lhs,
            IAlphaGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((AlphaSetterTranslationCommon)((IAlphaGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static Alpha DeepCopy(
            this IAlphaGetter item,
            Alpha.TranslationMask? copyMask = null)
        {
            return ((AlphaSetterTranslationCommon)((IAlphaGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static Alpha DeepCopy(
            this IAlphaGetter item,
            out Alpha.ErrorMask errorMask,
            Alpha.TranslationMask? copyMask = null)
        {
            return ((AlphaSetterTranslationCommon)((IAlphaGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static Alpha DeepCopy(
            this IAlphaGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((AlphaSetterTranslationCommon)((IAlphaGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IAlpha item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((AlphaSetterCommon)((IAlphaGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum Alpha_FieldIndex
    {
        Cutoff = 0,
        Base = 1,
    }
    #endregion

    #region Registration
    internal partial class Alpha_Registration : ILoquiRegistration
    {
        public static readonly Alpha_Registration Instance = new Alpha_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Fallout4.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Fallout4.ProtocolKey,
            msgID: 495,
            version: 0);

        public const string GUID = "ff481746-c406-4ee5-8d89-cdc761cdc180";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(Alpha.Mask<>);

        public static readonly Type ErrorMaskType = typeof(Alpha.ErrorMask);

        public static readonly Type ClassType = typeof(Alpha);

        public static readonly Type GetterType = typeof(IAlphaGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IAlpha);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Fallout4.Alpha";

        public const string Name = "Alpha";

        public const string Namespace = "Mutagen.Bethesda.Fallout4";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.XALP;
        public static RecordTriggerSpecs TriggerSpecs => _recordSpecs.Value;
        private static readonly Lazy<RecordTriggerSpecs> _recordSpecs = new Lazy<RecordTriggerSpecs>(() =>
        {
            var all = RecordCollection.Factory(RecordTypes.XALP);
            return new RecordTriggerSpecs(allRecordTypes: all);
        });
        public static readonly Type BinaryWriteTranslation = typeof(AlphaBinaryWriteTranslation);
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
    internal partial class AlphaSetterCommon
    {
        public static readonly AlphaSetterCommon Instance = new AlphaSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IAlpha item)
        {
            ClearPartial();
            item.Cutoff = default;
            item.Base = default;
        }
        
        #region Mutagen
        public void RemapLinks(IAlpha obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IAlpha item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            frame = frame.SpawnWithFinalPosition(HeaderTranslation.ParseSubrecord(
                frame.Reader,
                translationParams.ConvertToCustom(RecordTypes.XALP),
                translationParams.LengthOverride));
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: AlphaBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    internal partial class AlphaCommon
    {
        public static readonly AlphaCommon Instance = new AlphaCommon();

        public Alpha.Mask<bool> GetEqualsMask(
            IAlphaGetter item,
            IAlphaGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new Alpha.Mask<bool>(false);
            ((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IAlphaGetter item,
            IAlphaGetter rhs,
            Alpha.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Cutoff = item.Cutoff == rhs.Cutoff;
            ret.Base = item.Base == rhs.Base;
        }
        
        public string Print(
            IAlphaGetter item,
            string? name = null,
            Alpha.Mask<bool>? printMask = null)
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
            IAlphaGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            Alpha.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"Alpha =>");
            }
            else
            {
                sb.AppendLine($"{name} (Alpha) =>");
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
            IAlphaGetter item,
            StructuredStringBuilder sb,
            Alpha.Mask<bool>? printMask = null)
        {
            if (printMask?.Cutoff ?? true)
            {
                sb.AppendItem(item.Cutoff, "Cutoff");
            }
            if (printMask?.Base ?? true)
            {
                sb.AppendItem(item.Base, "Base");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IAlphaGetter? lhs,
            IAlphaGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)Alpha_FieldIndex.Cutoff) ?? true))
            {
                if (lhs.Cutoff != rhs.Cutoff) return false;
            }
            if ((crystal?.GetShouldTranslate((int)Alpha_FieldIndex.Base) ?? true))
            {
                if (lhs.Base != rhs.Base) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IAlphaGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Cutoff);
            hash.Add(item.Base);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return Alpha.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IAlphaGetter obj)
        {
            yield break;
        }
        
        #endregion
        
    }
    internal partial class AlphaSetterTranslationCommon
    {
        public static readonly AlphaSetterTranslationCommon Instance = new AlphaSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IAlpha item,
            IAlphaGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)Alpha_FieldIndex.Cutoff) ?? true))
            {
                item.Cutoff = rhs.Cutoff;
            }
            if ((copyMask?.GetShouldTranslate((int)Alpha_FieldIndex.Base) ?? true))
            {
                item.Base = rhs.Base;
            }
        }
        
        #endregion
        
        public Alpha DeepCopy(
            IAlphaGetter item,
            Alpha.TranslationMask? copyMask = null)
        {
            Alpha ret = (Alpha)((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).GetNew();
            ((AlphaSetterTranslationCommon)((IAlphaGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public Alpha DeepCopy(
            IAlphaGetter item,
            out Alpha.ErrorMask errorMask,
            Alpha.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            Alpha ret = (Alpha)((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).GetNew();
            ((AlphaSetterTranslationCommon)((IAlphaGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = Alpha.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public Alpha DeepCopy(
            IAlphaGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            Alpha ret = (Alpha)((AlphaCommon)((IAlphaGetter)item).CommonInstance()!).GetNew();
            ((AlphaSetterTranslationCommon)((IAlphaGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class Alpha
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Alpha_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => Alpha_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => AlphaCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return AlphaSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => AlphaSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IAlphaGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IAlphaGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IAlphaGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Fallout4
{
    public partial class AlphaBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public static readonly AlphaBinaryWriteTranslation Instance = new AlphaBinaryWriteTranslation();

        public static void WriteEmbedded(
            IAlphaGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.Cutoff);
            writer.Write(item.Base);
        }

        public void Write(
            MutagenWriter writer,
            IAlphaGetter item,
            TypedWriteParams translationParams)
        {
            using (HeaderExport.Subrecord(
                writer: writer,
                record: translationParams.ConvertToCustom(RecordTypes.XALP),
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
                item: (IAlphaGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class AlphaBinaryCreateTranslation
    {
        public static readonly AlphaBinaryCreateTranslation Instance = new AlphaBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IAlpha item,
            MutagenFrame frame)
        {
            item.Cutoff = frame.ReadUInt8();
            item.Base = frame.ReadUInt8();
        }

    }

}
namespace Mutagen.Bethesda.Fallout4
{
    #region Binary Write Mixins
    public static class AlphaBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IAlphaGetter item,
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((AlphaBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                translationParams: translationParams);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Fallout4
{
    internal partial class AlphaBinaryOverlay :
        PluginBinaryOverlay,
        IAlphaGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Alpha_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => Alpha_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => AlphaCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => AlphaSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IAlphaGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IAlphaGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IAlphaGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => AlphaBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((AlphaBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public Byte Cutoff => _structData.Span[0x0];
        public Byte Base => _structData.Span[0x1];
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected AlphaBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IAlphaGetter AlphaFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x2,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new AlphaBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x2 + package.MetaData.Constants.SubConstants.HeaderLength;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IAlphaGetter AlphaFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return AlphaFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            AlphaMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IAlphaGetter rhs) return false;
            return ((AlphaCommon)((IAlphaGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IAlphaGetter? obj)
        {
            return ((AlphaCommon)((IAlphaGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((AlphaCommon)((IAlphaGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

