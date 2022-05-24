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
using Mutagen.Bethesda.Plugins.Aspects;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
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
    public partial class ScriptBoolProperty :
        ScriptProperty,
        IEquatable<IScriptBoolPropertyGetter>,
        ILoquiObjectSetter<ScriptBoolProperty>,
        IScriptBoolProperty
    {
        #region Ctor
        public ScriptBoolProperty()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Data
        public Boolean Data { get; set; } = default;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ScriptBoolPropertyMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IScriptBoolPropertyGetter rhs) return false;
            return ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IScriptBoolPropertyGetter? obj)
        {
            return ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ScriptProperty.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Data = initialValue;
            }

            public Mask(
                TItem Name,
                TItem Flags,
                TItem Data)
            : base(
                Name: Name,
                Flags: Flags)
            {
                this.Data = Data;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Data;
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
                if (!object.Equals(this.Data, rhs.Data)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Data);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Data)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Data)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ScriptBoolProperty.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Data = eval(this.Data);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(ScriptBoolProperty.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, ScriptBoolProperty.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(ScriptBoolProperty.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Data ?? true)
                    {
                        sb.AppendItem(Data, "Data");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            ScriptProperty.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Data;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                ScriptBoolProperty_FieldIndex enu = (ScriptBoolProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptBoolProperty_FieldIndex.Data:
                        return Data;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                ScriptBoolProperty_FieldIndex enu = (ScriptBoolProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptBoolProperty_FieldIndex.Data:
                        this.Data = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                ScriptBoolProperty_FieldIndex enu = (ScriptBoolProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptBoolProperty_FieldIndex.Data:
                        this.Data = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Data != null) return true;
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
                    sb.AppendItem(Data, "Data");
                }
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Data = this.Data.Combine(rhs.Data);
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
            ScriptProperty.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Data;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Data = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Data, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ScriptBoolPropertyBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((ScriptBoolPropertyBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static ScriptBoolProperty CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            var ret = new ScriptBoolProperty();
            ((ScriptBoolPropertySetterCommon)((IScriptBoolPropertyGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out ScriptBoolProperty item,
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
            ((ScriptBoolPropertySetterCommon)((IScriptBoolPropertyGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new ScriptBoolProperty GetNew()
        {
            return new ScriptBoolProperty();
        }

    }
    #endregion

    #region Interface
    public partial interface IScriptBoolProperty :
        ILoquiObjectSetter<IScriptBoolProperty>,
        INamedRequired,
        IScriptBoolPropertyGetter,
        IScriptProperty
    {
        new Boolean Data { get; set; }
    }

    public partial interface IScriptBoolPropertyGetter :
        IScriptPropertyGetter,
        IBinaryItem,
        ILoquiObject<IScriptBoolPropertyGetter>,
        INamedRequiredGetter
    {
        static new ILoquiRegistration StaticRegistration => ScriptBoolProperty_Registration.Instance;
        Boolean Data { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class ScriptBoolPropertyMixIn
    {
        public static void Clear(this IScriptBoolProperty item)
        {
            ((ScriptBoolPropertySetterCommon)((IScriptBoolPropertyGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ScriptBoolProperty.Mask<bool> GetEqualsMask(
            this IScriptBoolPropertyGetter item,
            IScriptBoolPropertyGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IScriptBoolPropertyGetter item,
            string? name = null,
            ScriptBoolProperty.Mask<bool>? printMask = null)
        {
            return ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IScriptBoolPropertyGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ScriptBoolProperty.Mask<bool>? printMask = null)
        {
            ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IScriptBoolPropertyGetter item,
            IScriptBoolPropertyGetter rhs,
            ScriptBoolProperty.TranslationMask? equalsMask = null)
        {
            return ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IScriptBoolProperty lhs,
            IScriptBoolPropertyGetter rhs,
            out ScriptBoolProperty.ErrorMask errorMask,
            ScriptBoolProperty.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ScriptBoolProperty.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IScriptBoolProperty lhs,
            IScriptBoolPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ScriptBoolProperty DeepCopy(
            this IScriptBoolPropertyGetter item,
            ScriptBoolProperty.TranslationMask? copyMask = null)
        {
            return ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ScriptBoolProperty DeepCopy(
            this IScriptBoolPropertyGetter item,
            out ScriptBoolProperty.ErrorMask errorMask,
            ScriptBoolProperty.TranslationMask? copyMask = null)
        {
            return ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ScriptBoolProperty DeepCopy(
            this IScriptBoolPropertyGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IScriptBoolProperty item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            ((ScriptBoolPropertySetterCommon)((IScriptBoolPropertyGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum ScriptBoolProperty_FieldIndex
    {
        Name = 0,
        Flags = 1,
        Data = 2,
    }
    #endregion

    #region Registration
    internal partial class ScriptBoolProperty_Registration : ILoquiRegistration
    {
        public static readonly ScriptBoolProperty_Registration Instance = new ScriptBoolProperty_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 98,
            version: 0);

        public const string GUID = "5321b8e0-dcc9-4624-8248-ecb7aff031ac";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(ScriptBoolProperty.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ScriptBoolProperty.ErrorMask);

        public static readonly Type ClassType = typeof(ScriptBoolProperty);

        public static readonly Type GetterType = typeof(IScriptBoolPropertyGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IScriptBoolProperty);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.ScriptBoolProperty";

        public const string Name = "ScriptBoolProperty";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ScriptBoolPropertyBinaryWriteTranslation);
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
    internal partial class ScriptBoolPropertySetterCommon : ScriptPropertySetterCommon
    {
        public new static readonly ScriptBoolPropertySetterCommon Instance = new ScriptBoolPropertySetterCommon();

        partial void ClearPartial();
        
        public void Clear(IScriptBoolProperty item)
        {
            ClearPartial();
            item.Data = default;
            base.Clear(item);
        }
        
        public override void Clear(IScriptProperty item)
        {
            Clear(item: (IScriptBoolProperty)item);
        }
        
        #region Mutagen
        public void RemapLinks(IScriptBoolProperty obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IScriptBoolProperty item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: ScriptBoolPropertyBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IScriptProperty item,
            MutagenFrame frame,
            TypedParseParams? translationParams = null)
        {
            CopyInFromBinary(
                item: (ScriptBoolProperty)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class ScriptBoolPropertyCommon : ScriptPropertyCommon
    {
        public new static readonly ScriptBoolPropertyCommon Instance = new ScriptBoolPropertyCommon();

        public ScriptBoolProperty.Mask<bool> GetEqualsMask(
            IScriptBoolPropertyGetter item,
            IScriptBoolPropertyGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ScriptBoolProperty.Mask<bool>(false);
            ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IScriptBoolPropertyGetter item,
            IScriptBoolPropertyGetter rhs,
            ScriptBoolProperty.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Data = item.Data == rhs.Data;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IScriptBoolPropertyGetter item,
            string? name = null,
            ScriptBoolProperty.Mask<bool>? printMask = null)
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
            IScriptBoolPropertyGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ScriptBoolProperty.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"ScriptBoolProperty =>");
            }
            else
            {
                sb.AppendLine($"{name} (ScriptBoolProperty) =>");
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
            IScriptBoolPropertyGetter item,
            StructuredStringBuilder sb,
            ScriptBoolProperty.Mask<bool>? printMask = null)
        {
            ScriptPropertyCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Data ?? true)
            {
                sb.AppendItem(item.Data, "Data");
            }
        }
        
        public static ScriptBoolProperty_FieldIndex ConvertFieldIndex(ScriptProperty_FieldIndex index)
        {
            switch (index)
            {
                case ScriptProperty_FieldIndex.Name:
                    return (ScriptBoolProperty_FieldIndex)((int)index);
                case ScriptProperty_FieldIndex.Flags:
                    return (ScriptBoolProperty_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IScriptBoolPropertyGetter? lhs,
            IScriptBoolPropertyGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IScriptPropertyGetter)lhs, (IScriptPropertyGetter)rhs, crystal)) return false;
            if ((crystal?.GetShouldTranslate((int)ScriptBoolProperty_FieldIndex.Data) ?? true))
            {
                if (lhs.Data != rhs.Data) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IScriptPropertyGetter? lhs,
            IScriptPropertyGetter? rhs,
            TranslationCrystal? crystal)
        {
            return Equals(
                lhs: (IScriptBoolPropertyGetter?)lhs,
                rhs: rhs as IScriptBoolPropertyGetter,
                crystal: crystal);
        }
        
        public virtual int GetHashCode(IScriptBoolPropertyGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Data);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IScriptPropertyGetter item)
        {
            return GetHashCode(item: (IScriptBoolPropertyGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return ScriptBoolProperty.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IScriptBoolPropertyGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class ScriptBoolPropertySetterTranslationCommon : ScriptPropertySetterTranslationCommon
    {
        public new static readonly ScriptBoolPropertySetterTranslationCommon Instance = new ScriptBoolPropertySetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IScriptBoolProperty item,
            IScriptBoolPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IScriptProperty)item,
                (IScriptPropertyGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)ScriptBoolProperty_FieldIndex.Data) ?? true))
            {
                item.Data = rhs.Data;
            }
        }
        
        
        public override void DeepCopyIn(
            IScriptProperty item,
            IScriptPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IScriptBoolProperty)item,
                rhs: (IScriptBoolPropertyGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public ScriptBoolProperty DeepCopy(
            IScriptBoolPropertyGetter item,
            ScriptBoolProperty.TranslationMask? copyMask = null)
        {
            ScriptBoolProperty ret = (ScriptBoolProperty)((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ScriptBoolProperty DeepCopy(
            IScriptBoolPropertyGetter item,
            out ScriptBoolProperty.ErrorMask errorMask,
            ScriptBoolProperty.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ScriptBoolProperty ret = (ScriptBoolProperty)((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ScriptBoolProperty.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ScriptBoolProperty DeepCopy(
            IScriptBoolPropertyGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ScriptBoolProperty ret = (ScriptBoolProperty)((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptBoolPropertySetterTranslationCommon)((IScriptBoolPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ScriptBoolProperty
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ScriptBoolProperty_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ScriptBoolProperty_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ScriptBoolPropertyCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return ScriptBoolPropertySetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ScriptBoolPropertySetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim
{
    public partial class ScriptBoolPropertyBinaryWriteTranslation :
        ScriptPropertyBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static ScriptBoolPropertyBinaryWriteTranslation Instance = new ScriptBoolPropertyBinaryWriteTranslation();

        public static void WriteEmbedded(
            IScriptBoolPropertyGetter item,
            MutagenWriter writer)
        {
            ScriptPropertyBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            writer.Write(item.Data);
        }

        public void Write(
            MutagenWriter writer,
            IScriptBoolPropertyGetter item,
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
                item: (IScriptBoolPropertyGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IScriptPropertyGetter item,
            TypedWriteParams? translationParams = null)
        {
            Write(
                item: (IScriptBoolPropertyGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class ScriptBoolPropertyBinaryCreateTranslation : ScriptPropertyBinaryCreateTranslation
    {
        public new readonly static ScriptBoolPropertyBinaryCreateTranslation Instance = new ScriptBoolPropertyBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IScriptBoolProperty item,
            MutagenFrame frame)
        {
            ScriptPropertyBinaryCreateTranslation.FillBinaryStructs(
                item: item,
                frame: frame);
            item.Data = frame.ReadBoolean();
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ScriptBoolPropertyBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim
{
    internal partial class ScriptBoolPropertyBinaryOverlay :
        ScriptPropertyBinaryOverlay,
        IScriptBoolPropertyGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ScriptBoolProperty_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ScriptBoolProperty_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ScriptBoolPropertyCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ScriptBoolPropertySetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ScriptBoolPropertyBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams? translationParams = null)
        {
            ((ScriptBoolPropertyBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public Boolean Data => _data.Slice(0x0, 0x1)[0] >= 1;
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ScriptBoolPropertyBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static IScriptBoolPropertyGetter ScriptBoolPropertyFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            var ret = new ScriptBoolPropertyBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x1),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x1;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IScriptBoolPropertyGetter ScriptBoolPropertyFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams? parseParams = null)
        {
            return ScriptBoolPropertyFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                parseParams: parseParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ScriptBoolPropertyMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IScriptBoolPropertyGetter rhs) return false;
            return ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IScriptBoolPropertyGetter? obj)
        {
            return ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((ScriptBoolPropertyCommon)((IScriptBoolPropertyGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

