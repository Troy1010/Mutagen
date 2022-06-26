/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Pex;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using System.Diagnostics;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Pex
{
    #region Class
    public partial class PexObjectNamedFunction :
        IEquatable<IPexObjectNamedFunctionGetter>,
        ILoquiObjectSetter<PexObjectNamedFunction>,
        IPexObjectNamedFunction
    {
        #region Ctor
        public PexObjectNamedFunction()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region FunctionName
        public String? FunctionName { get; set; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        String? IPexObjectNamedFunctionGetter.FunctionName => this.FunctionName;
        #endregion
        #region Function
        public PexObjectFunction Function { get; set; } = new PexObjectFunction();
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IPexObjectFunctionGetter IPexObjectNamedFunctionGetter.Function => Function;
        #endregion

        #region To String

        public void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            PexObjectNamedFunctionMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPexObjectNamedFunctionGetter rhs) return false;
            return ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)this).CommonInstance()!).Equals(this, rhs, crystal: null);
        }

        public bool Equals(IPexObjectNamedFunctionGetter? obj)
        {
            return ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)this).CommonInstance()!).Equals(this, obj, crystal: null);
        }

        public override int GetHashCode() => ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.FunctionName = initialValue;
                this.Function = new MaskItem<TItem, PexObjectFunction.Mask<TItem>?>(initialValue, new PexObjectFunction.Mask<TItem>(initialValue));
            }

            public Mask(
                TItem FunctionName,
                TItem Function)
            {
                this.FunctionName = FunctionName;
                this.Function = new MaskItem<TItem, PexObjectFunction.Mask<TItem>?>(Function, new PexObjectFunction.Mask<TItem>(Function));
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem FunctionName;
            public MaskItem<TItem, PexObjectFunction.Mask<TItem>?>? Function { get; set; }
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
                if (!object.Equals(this.FunctionName, rhs.FunctionName)) return false;
                if (!object.Equals(this.Function, rhs.Function)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.FunctionName);
                hash.Add(this.Function);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.FunctionName)) return false;
                if (Function != null)
                {
                    if (!eval(this.Function.Overall)) return false;
                    if (this.Function.Specific != null && !this.Function.Specific.All(eval)) return false;
                }
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.FunctionName)) return true;
                if (Function != null)
                {
                    if (eval(this.Function.Overall)) return true;
                    if (this.Function.Specific != null && this.Function.Specific.Any(eval)) return true;
                }
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new PexObjectNamedFunction.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.FunctionName = eval(this.FunctionName);
                obj.Function = this.Function == null ? null : new MaskItem<R, PexObjectFunction.Mask<R>?>(eval(this.Function.Overall), this.Function.Specific?.Translate(eval));
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(PexObjectNamedFunction.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, PexObjectNamedFunction.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(PexObjectNamedFunction.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.FunctionName ?? true)
                    {
                        sb.AppendItem(FunctionName, "FunctionName");
                    }
                    if (printMask?.Function?.Overall ?? true)
                    {
                        Function?.Print(sb);
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
            public Exception? FunctionName;
            public MaskItem<Exception?, PexObjectFunction.ErrorMask?>? Function;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                PexObjectNamedFunction_FieldIndex enu = (PexObjectNamedFunction_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectNamedFunction_FieldIndex.FunctionName:
                        return FunctionName;
                    case PexObjectNamedFunction_FieldIndex.Function:
                        return Function;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                PexObjectNamedFunction_FieldIndex enu = (PexObjectNamedFunction_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectNamedFunction_FieldIndex.FunctionName:
                        this.FunctionName = ex;
                        break;
                    case PexObjectNamedFunction_FieldIndex.Function:
                        this.Function = new MaskItem<Exception?, PexObjectFunction.ErrorMask?>(ex, null);
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                PexObjectNamedFunction_FieldIndex enu = (PexObjectNamedFunction_FieldIndex)index;
                switch (enu)
                {
                    case PexObjectNamedFunction_FieldIndex.FunctionName:
                        this.FunctionName = (Exception?)obj;
                        break;
                    case PexObjectNamedFunction_FieldIndex.Function:
                        this.Function = (MaskItem<Exception?, PexObjectFunction.ErrorMask?>?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (FunctionName != null) return true;
                if (Function != null) return true;
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
                    sb.AppendItem(FunctionName, "FunctionName");
                }
                Function?.Print(sb);
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.FunctionName = this.FunctionName.Combine(rhs.FunctionName);
                ret.Function = this.Function.Combine(rhs.Function, (l, r) => l.Combine(r));
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
            public bool FunctionName;
            public PexObjectFunction.TranslationMask? Function;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.FunctionName = defaultOn;
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
                ret.Add((FunctionName, null));
                ret.Add((Function != null ? Function.OnOverall : DefaultOn, Function?.GetCrystal()));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((PexObjectNamedFunctionSetterCommon)((IPexObjectNamedFunctionGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static PexObjectNamedFunction GetNew()
        {
            return new PexObjectNamedFunction();
        }

    }
    #endregion

    #region Interface
    public partial interface IPexObjectNamedFunction :
        ILoquiObjectSetter<IPexObjectNamedFunction>,
        IPexObjectNamedFunctionGetter
    {
        new String? FunctionName { get; set; }
        new PexObjectFunction Function { get; set; }
    }

    public partial interface IPexObjectNamedFunctionGetter :
        ILoquiObject,
        ILoquiObject<IPexObjectNamedFunctionGetter>
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration StaticRegistration => PexObjectNamedFunction_Registration.Instance;
        String? FunctionName { get; }
        IPexObjectFunctionGetter Function { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PexObjectNamedFunctionMixIn
    {
        public static void Clear(this IPexObjectNamedFunction item)
        {
            ((PexObjectNamedFunctionSetterCommon)((IPexObjectNamedFunctionGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PexObjectNamedFunction.Mask<bool> GetEqualsMask(
            this IPexObjectNamedFunctionGetter item,
            IPexObjectNamedFunctionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IPexObjectNamedFunctionGetter item,
            string? name = null,
            PexObjectNamedFunction.Mask<bool>? printMask = null)
        {
            return ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IPexObjectNamedFunctionGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PexObjectNamedFunction.Mask<bool>? printMask = null)
        {
            ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPexObjectNamedFunctionGetter item,
            IPexObjectNamedFunctionGetter rhs,
            PexObjectNamedFunction.TranslationMask? equalsMask = null)
        {
            return ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                crystal: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IPexObjectNamedFunction lhs,
            IPexObjectNamedFunctionGetter rhs)
        {
            ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectNamedFunction lhs,
            IPexObjectNamedFunctionGetter rhs,
            PexObjectNamedFunction.TranslationMask? copyMask = null)
        {
            ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IPexObjectNamedFunction lhs,
            IPexObjectNamedFunctionGetter rhs,
            out PexObjectNamedFunction.ErrorMask errorMask,
            PexObjectNamedFunction.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PexObjectNamedFunction.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPexObjectNamedFunction lhs,
            IPexObjectNamedFunctionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PexObjectNamedFunction DeepCopy(
            this IPexObjectNamedFunctionGetter item,
            PexObjectNamedFunction.TranslationMask? copyMask = null)
        {
            return ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PexObjectNamedFunction DeepCopy(
            this IPexObjectNamedFunctionGetter item,
            out PexObjectNamedFunction.ErrorMask errorMask,
            PexObjectNamedFunction.TranslationMask? copyMask = null)
        {
            return ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PexObjectNamedFunction DeepCopy(
            this IPexObjectNamedFunctionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

    }
    #endregion

}

namespace Mutagen.Bethesda.Pex
{
    #region Field Index
    internal enum PexObjectNamedFunction_FieldIndex
    {
        FunctionName = 0,
        Function = 1,
    }
    #endregion

    #region Registration
    internal partial class PexObjectNamedFunction_Registration : ILoquiRegistration
    {
        public static readonly PexObjectNamedFunction_Registration Instance = new PexObjectNamedFunction_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Pex.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Pex.ProtocolKey,
            msgID: 13,
            version: 0);

        public const string GUID = "6d5e808d-a83c-475c-a7ae-c1c4d3aeff6a";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(PexObjectNamedFunction.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PexObjectNamedFunction.ErrorMask);

        public static readonly Type ClassType = typeof(PexObjectNamedFunction);

        public static readonly Type GetterType = typeof(IPexObjectNamedFunctionGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPexObjectNamedFunction);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Pex.PexObjectNamedFunction";

        public const string Name = "PexObjectNamedFunction";

        public const string Namespace = "Mutagen.Bethesda.Pex";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

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
    internal partial class PexObjectNamedFunctionSetterCommon
    {
        public static readonly PexObjectNamedFunctionSetterCommon Instance = new PexObjectNamedFunctionSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPexObjectNamedFunction item)
        {
            ClearPartial();
            item.FunctionName = default;
            item.Function.Clear();
        }
        
    }
    internal partial class PexObjectNamedFunctionCommon
    {
        public static readonly PexObjectNamedFunctionCommon Instance = new PexObjectNamedFunctionCommon();

        public PexObjectNamedFunction.Mask<bool> GetEqualsMask(
            IPexObjectNamedFunctionGetter item,
            IPexObjectNamedFunctionGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PexObjectNamedFunction.Mask<bool>(false);
            ((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPexObjectNamedFunctionGetter item,
            IPexObjectNamedFunctionGetter rhs,
            PexObjectNamedFunction.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.FunctionName = string.Equals(item.FunctionName, rhs.FunctionName);
            ret.Function = MaskItemExt.Factory(item.Function.GetEqualsMask(rhs.Function, include), include);
        }
        
        public string Print(
            IPexObjectNamedFunctionGetter item,
            string? name = null,
            PexObjectNamedFunction.Mask<bool>? printMask = null)
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
            IPexObjectNamedFunctionGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PexObjectNamedFunction.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"PexObjectNamedFunction =>");
            }
            else
            {
                sb.AppendLine($"{name} (PexObjectNamedFunction) =>");
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
            IPexObjectNamedFunctionGetter item,
            StructuredStringBuilder sb,
            PexObjectNamedFunction.Mask<bool>? printMask = null)
        {
            if ((printMask?.FunctionName ?? true)
                && item.FunctionName is {} FunctionNameItem)
            {
                sb.AppendItem(FunctionNameItem, "FunctionName");
            }
            if (printMask?.Function?.Overall ?? true)
            {
                item.Function?.Print(sb, "Function");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPexObjectNamedFunctionGetter? lhs,
            IPexObjectNamedFunctionGetter? rhs,
            TranslationCrystal? crystal)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if ((crystal?.GetShouldTranslate((int)PexObjectNamedFunction_FieldIndex.FunctionName) ?? true))
            {
                if (!string.Equals(lhs.FunctionName, rhs.FunctionName)) return false;
            }
            if ((crystal?.GetShouldTranslate((int)PexObjectNamedFunction_FieldIndex.Function) ?? true))
            {
                if (EqualsMaskHelper.RefEquality(lhs.Function, rhs.Function, out var lhsFunction, out var rhsFunction, out var isFunctionEqual))
                {
                    if (!((PexObjectFunctionCommon)((IPexObjectFunctionGetter)lhsFunction).CommonInstance()!).Equals(lhsFunction, rhsFunction, crystal?.GetSubCrystal((int)PexObjectNamedFunction_FieldIndex.Function))) return false;
                }
                else if (!isFunctionEqual) return false;
            }
            return true;
        }
        
        public virtual int GetHashCode(IPexObjectNamedFunctionGetter item)
        {
            var hash = new HashCode();
            if (item.FunctionName is {} FunctionNameitem)
            {
                hash.Add(FunctionNameitem);
            }
            hash.Add(item.Function);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return PexObjectNamedFunction.GetNew();
        }
        
    }
    internal partial class PexObjectNamedFunctionSetterTranslationCommon
    {
        public static readonly PexObjectNamedFunctionSetterTranslationCommon Instance = new PexObjectNamedFunctionSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPexObjectNamedFunction item,
            IPexObjectNamedFunctionGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)PexObjectNamedFunction_FieldIndex.FunctionName) ?? true))
            {
                item.FunctionName = rhs.FunctionName;
            }
            if ((copyMask?.GetShouldTranslate((int)PexObjectNamedFunction_FieldIndex.Function) ?? true))
            {
                errorMask?.PushIndex((int)PexObjectNamedFunction_FieldIndex.Function);
                try
                {
                    if ((copyMask?.GetShouldTranslate((int)PexObjectNamedFunction_FieldIndex.Function) ?? true))
                    {
                        item.Function = rhs.Function.DeepCopy(
                            copyMask: copyMask?.GetSubCrystal((int)PexObjectNamedFunction_FieldIndex.Function),
                            errorMask: errorMask);
                    }
                }
                catch (Exception ex)
                when (errorMask != null)
                {
                    errorMask.ReportException(ex);
                }
                finally
                {
                    errorMask?.PopIndex();
                }
            }
        }
        
        #endregion
        
        public PexObjectNamedFunction DeepCopy(
            IPexObjectNamedFunctionGetter item,
            PexObjectNamedFunction.TranslationMask? copyMask = null)
        {
            PexObjectNamedFunction ret = (PexObjectNamedFunction)((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).GetNew();
            ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PexObjectNamedFunction DeepCopy(
            IPexObjectNamedFunctionGetter item,
            out PexObjectNamedFunction.ErrorMask errorMask,
            PexObjectNamedFunction.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PexObjectNamedFunction ret = (PexObjectNamedFunction)((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).GetNew();
            ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PexObjectNamedFunction.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PexObjectNamedFunction DeepCopy(
            IPexObjectNamedFunctionGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PexObjectNamedFunction ret = (PexObjectNamedFunction)((PexObjectNamedFunctionCommon)((IPexObjectNamedFunctionGetter)item).CommonInstance()!).GetNew();
            ((PexObjectNamedFunctionSetterTranslationCommon)((IPexObjectNamedFunctionGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Pex
{
    public partial class PexObjectNamedFunction
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PexObjectNamedFunction_Registration.Instance;
        public static ILoquiRegistration StaticRegistration => PexObjectNamedFunction_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => PexObjectNamedFunctionCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return PexObjectNamedFunctionSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => PexObjectNamedFunctionSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IPexObjectNamedFunctionGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IPexObjectNamedFunctionGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IPexObjectNamedFunctionGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

