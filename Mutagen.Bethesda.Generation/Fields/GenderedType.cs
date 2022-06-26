using System.Xml.Linq;
using Loqui.Generation;
using Mutagen.Bethesda.Generation.Modules.Plugin;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;

namespace Mutagen.Bethesda.Generation.Fields;

public class GenderedType : WrapperType
{
    public override bool HasDefault => false;
    public override bool CopyNeedsTryCatch => true;
    public override bool IsEnumerable => true;
    public override bool IsClass => true;
    public bool ItemNullable
    {
        get
        {
            if (MaleMarker.HasValue) return true;
            if (this.SubTypeGeneration is LoquiType loqui)
            {
                return loqui.GetFieldData().HasTrigger;
            }
            return false;
        }
    }
    public override bool CanBeNullable(bool getter) => true;
    public RecordTypeConverter? FemaleConversions;
    public RecordTypeConverter? MaleConversions;

    public RecordType? MaleMarker;
    public RecordType? FemaleMarker;
    public bool MarkerPerGender;

    public override void GenerateClear(StructuredStringBuilder sb, Accessor accessorPrefix)
    {
        if (this.Nullable)
        {
            sb.AppendLine($"{accessorPrefix} = null;");
        }
        else if (SubTypeGeneration is FormLinkType linkType)
        {
            sb.AppendLine($"{accessorPrefix}.Male = {linkType.DirectTypeName(getter: false)}.Null;");
            sb.AppendLine($"{accessorPrefix}.Female = {linkType.DirectTypeName(getter: false)}.Null;");
        }
        else
        {
            SubTypeGeneration.GenerateClear(sb, $"{accessorPrefix}.Male");
            SubTypeGeneration.GenerateClear(sb, $"{accessorPrefix}.Female");
        }
    }

    public override async Task GenerateForClass(StructuredStringBuilder sb)
    {
        sb.AppendLine($"public IGenderedItem<{SubTypeGeneration.TypeName(getter: false, needsCovariance: true)}{SubTypeGeneration.NullChar}>{(this.Nullable ? "?" : null)} {this.Name} {{ get; set; }}{(this.Nullable ? null : $" = new GenderedItem<{SubTypeGeneration.TypeName(getter: false, needsCovariance: true)}{SubTypeGeneration.NullChar}>({this.SubTypeGeneration.GetDefault(getter: false)}, {this.SubTypeGeneration.GetDefault(getter: false)});")}");
        sb.AppendLine($"IGenderedItemGetter<{SubTypeGeneration.TypeName(getter: true, needsCovariance: true)}{SubTypeGeneration.NullChar}>{(this.Nullable ? "?" : null)} {this.ObjectGen.Interface(getter: true, internalInterface: true)}.{this.Name} => this.{this.Name};");
    }

    public override string GenerateACopy(string rhsAccessor)
    {
        throw new NotImplementedException();
    }

    public override void GenerateForCopy(StructuredStringBuilder sb, Accessor accessor, Accessor rhs, Accessor copyMaskAccessor, bool protectedMembers, bool deepCopy)
    {
        if (!deepCopy)
        {
            throw new NotImplementedException();
        }
        if (this.Nullable)
        {
            sb.AppendLine($"if ({rhs} is not {{}} rhs{this.Name}item)");
            using (sb.CurlyBrace())
            {
                sb.AppendLine($"{accessor} = null;");
            }
            sb.AppendLine("else");
            rhs = $"rhs{this.Name}item";
        }
        using (sb.CurlyBrace(doIt: this.Nullable))
        {
            using (var args = sb.Call(
                       $"{accessor} = new GenderedItem<{this.SubTypeGeneration.TypeName(getter: false, needsCovariance: true)}{this.SubTypeGeneration.NullChar}>"))
            {
                if (this.isLoquiSingle)
                {
                    LoquiType loqui = this.SubTypeGeneration as LoquiType;
                    args.Add(subFg =>
                    {
                        loqui.GenerateTypicalMakeCopy(
                            subFg,
                            retAccessor: $"male: ",
                            rhsAccessor: $"{rhs}.Male{this.SubTypeGeneration.NullChar}",
                            copyMaskAccessor: $"{copyMaskAccessor}.Male",
                            deepCopy: deepCopy,
                            doTranslationMask: false);
                    });
                    args.Add(subFg =>
                    {
                        loqui.GenerateTypicalMakeCopy(
                            subFg,
                            retAccessor: $"female: ",
                            rhsAccessor: $"{rhs}.Female{this.SubTypeGeneration.NullChar}",
                            copyMaskAccessor: $"{copyMaskAccessor}.Female",
                            deepCopy: deepCopy,
                            doTranslationMask: false);
                    });
                }
                else
                {
                    args.Add($"male: {this.SubTypeGeneration.GetDuplicate($"{rhs}.Male")}");
                    args.Add($"female: {this.SubTypeGeneration.GetDuplicate($"{rhs}.Female")}");
                }
            }
        }
    }

    public override void GenerateForEquals(StructuredStringBuilder sb, Accessor accessor, Accessor rhsAccessor, Accessor maskAccessor)
    {
        sb.AppendLine($"if ({this.GetTranslationIfAccessor(maskAccessor)})");
        using (sb.CurlyBrace())
        {
            sb.AppendLine($"if (!Equals({accessor}, {rhsAccessor})) return false;");
        }
    }

    public override void GenerateForEqualsMask(StructuredStringBuilder sb, Accessor accessor, Accessor rhsAccessor, string retAccessor)
    {
        LoquiType loqui = this.SubTypeGeneration as LoquiType;

        if (this.Nullable || loqui != null)
        {
            using (var args = sb.Call(
                       $"ret.{this.Name} = {nameof(GenderedItem)}.{nameof(GenderedItem.EqualityMaskHelper)}"))
            {
                args.Add($"lhs: {accessor}");
                args.Add($"rhs: {rhsAccessor}");
                if (loqui == null)
                {
                    args.Add($"maskGetter: (l, r, i) => EqualityComparer<{this.SubTypeGeneration.TypeName(getter: true, needsCovariance: true)}{this.SubTypeGeneration.NullChar}>.Default.Equals(l, r)");
                }
                else
                {
                    if (this.ItemNullable)
                    {
                        args.Add($"maskGetter: (l, r, i) => EqualsMaskHelper.EqualsHelper(l, r, (loqLhs, loqRhs, incl) => loqLhs.GetEqualsMask(loqRhs, incl), i)");
                    }
                    else
                    {
                        args.Add("maskGetter: (l, r, i) => l.GetEqualsMask(r, i)");
                    }
                }
                args.AddPassArg("include");
            }
        }
        else
        {
            using (var args = sb.Call(
                       $"ret.{this.Name} = new GenderedItem<bool>"))
            {
                args.Add($"male: {this.SubTypeGeneration.GenerateEqualsSnippet($"{accessor}.Male", $"{rhsAccessor}.Male")}");
                args.Add($"female: {this.SubTypeGeneration.GenerateEqualsSnippet($"{accessor}.Female", $"{rhsAccessor}.Female")}");
            }
        }
    }

    public override void GenerateForNullableCheck(StructuredStringBuilder sb, Accessor accessor, string checkMaskAccessor)
    {
        if (this.Nullable)
        {
            sb.AppendLine($"if ({checkMaskAccessor}?.Overall ?? false) return false;");
        }
        else if (this.ItemNullable)
        {
            sb.AppendLine($"throw new NotImplementedException();");
        }
    }

    public override void GenerateForHash(StructuredStringBuilder sb, Accessor accessor, string hashResultAccessor)
    {
        if (this.Nullable)
        {
            sb.AppendLine($"if ({accessor} is {{}} {this.Name}item)");
            using (sb.CurlyBrace())
            {
                sb.AppendLine($"{hashResultAccessor}.Add(HashCode.Combine({this.Name}item.Male, {this.Name}item.Female));");
            }
        }
        else
        {
            sb.AppendLine($"{hashResultAccessor}.Add(HashCode.Combine({accessor}.Male, {accessor}.Female));");
        }
    }

    public override void GenerateForInterface(StructuredStringBuilder sb, bool getter, bool internalInterface)
    {
        if (getter)
        {
            sb.AppendLine($"IGenderedItemGetter<{SubTypeGeneration.TypeName(getter: true, needsCovariance: true)}{SubTypeGeneration.NullChar}>{(this.Nullable ? "?" : null)} {this.Name} {{ get; }}");
        }
        else
        {
            sb.AppendLine($"new IGenderedItem<{SubTypeGeneration.TypeName(getter: false, needsCovariance: true)}{SubTypeGeneration.NullChar}>{(this.Nullable ? "?" : null)} {this.Name} {{ get; set; }}");
        }
    }

    public override void GenerateGetNth(StructuredStringBuilder sb, Accessor identifier)
    {
        throw new NotImplementedException();
    }

    public override void GenerateSetNth(StructuredStringBuilder sb, Accessor accessor, Accessor rhs, bool internalUse)
    {
        throw new NotImplementedException();
    }

    public override void GenerateToString(StructuredStringBuilder sb, string name, Accessor accessor, string sbAccessor)
    {
        sb.AppendLine($"{accessor}{(this.Nullable ? "?" : null)}.Print({sbAccessor}, \"{name}\");");
    }

    public override void GenerateUnsetNth(StructuredStringBuilder sb, Accessor identifier)
    {
        throw new NotImplementedException();
    }

    public override string SkipCheck(Accessor copyMaskAccessor, bool deepCopy)
    {
        throw new NotImplementedException();
    }

    public override string TypeName(bool getter, bool needsCovariance = false)
    {
        return $"{(getter ? "IGenderedItemGetter" : "IGenderedItem")}<{SubTypeGeneration.TypeName(getter, needsCovariance: true)}{this.SubTypeGeneration.NullChar}>";
    }

    public override string GetDuplicate(Accessor accessor)
    {
        throw new NotImplementedException();
    }

    public override async Task Load(XElement node, bool requireName = true)
    {
        await base.Load(node, requireName);

        if (node.TryGetAttribute<string>("maleMarker", out var maleMarker))
        {
            MaleMarker = new RecordType(maleMarker);
        }

        if (node.TryGetAttribute<string>("femaleMarker", out var femaleMarker))
        {
            FemaleMarker = new RecordType(femaleMarker);
        }

        if (MaleMarker.HasValue != FemaleMarker.HasValue)
        {
            throw new ArgumentException("Both submarkers must be set at once.");
        }

        this.MarkerPerGender = node.GetAttribute<bool>("markerPerGender");

        if (MaleMarker.HasValue)
        {
            this.SubTypeGeneration.NullableProperty.OnNext((true, true));
        }

        FemaleConversions = RecordTypeConverterModule.GetConverter(node.Element(XName.Get("FemaleTypeOverrides", LoquiGenerator.Namespace)));
        MaleConversions = RecordTypeConverterModule.GetConverter(node.Element(XName.Get("MaleTypeOverrides", LoquiGenerator.Namespace)));
    }

    public override void GenerateInRegistration(StructuredStringBuilder sb)
    {
        base.GenerateInRegistration(sb);
        RecordTypeConverterModule.GenerateConverterMember(sb, this.ObjectGen, this.FemaleConversions, $"{this.Name}Female");
        RecordTypeConverterModule.GenerateConverterMember(sb, this.ObjectGen, this.MaleConversions, $"{this.Name}Male");
    }
}