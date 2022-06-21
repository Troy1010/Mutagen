using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Noggog;
using System.Buffers.Binary;

namespace Mutagen.Bethesda.Skyrim;

public partial class Book
{
    [Flags]
    public enum Flag
    {
        CantBeTaken = 0x02
    }

    public enum BookType : byte
    {
        BookOrTome = 0,
        NoteOrScroll = 255
    }
}

partial class BookBinaryCreateTranslation
{
    public const byte SkillFlag = 0x01;
    public const byte SpellFlag = 0x04;

    public static partial void FillBinaryFlagsCustom(MutagenFrame frame, IBookInternal item)
    {
        item.Flags = (Book.Flag)frame.ReadUInt8();
    }

    public static partial void FillBinaryTeachesCustom(MutagenFrame frame, IBookInternal item)
    {
        if ((((int)item.Flags) & SpellFlag) > 0)
        {
            item.Teaches = new BookSpell()
            {
                Spell = new FormLink<ISpellGetter>(FormLinkBinaryTranslation.Instance.Parse(frame))
            };
        }
        else if ((((int)item.Flags) & SkillFlag) > 0)
        {
            item.Teaches = new BookSkill
            {
                Skill = (Skill)frame.ReadInt32()
            };
        }
        else
        {
            item.Teaches = new BookTeachesNothing()
            {
                RawContent = frame.ReadUInt32()
            };
        }
    }
}

partial class BookBinaryWriteTranslation
{
    public static partial void WriteBinaryFlagsCustom(MutagenWriter writer, IBookGetter item)
    {
        byte flags = (byte)item.Flags;
        switch (item.Teaches)
        {
            case BookSpell _:
                flags = EnumExt.SetFlag(flags, BookBinaryCreateTranslation.SkillFlag, false);
                flags = EnumExt.SetFlag(flags, BookBinaryCreateTranslation.SpellFlag, true);
                break;
            case BookSkill _:
                flags = EnumExt.SetFlag(flags, BookBinaryCreateTranslation.SkillFlag, true);
                flags = EnumExt.SetFlag(flags, BookBinaryCreateTranslation.SpellFlag, false);
                break;
            case BookTeachesNothing _:
                flags = EnumExt.SetFlag(flags, BookBinaryCreateTranslation.SkillFlag, false);
                flags = EnumExt.SetFlag(flags, BookBinaryCreateTranslation.SpellFlag, false);
                break;
            default:
                break;
        }
        writer.Write(flags);
    }

    public static partial void WriteBinaryTeachesCustom(MutagenWriter writer, IBookGetter item)
    {
        switch (item.Teaches)
        {
            case IBookSpellGetter spell:
                FormLinkBinaryTranslation.Instance.Write(writer, spell.Spell);
                break;
            case IBookSkillGetter skill:
                var skillVal = skill.Skill;
                if (skillVal == null)
                {
                    writer.Write(-1);
                }
                else
                {
                    writer.Write((int)skillVal);
                }
                break;
            case IBookTeachesNothingGetter nothing:
                writer.Write(nothing.RawContent);
                break;
            default:
                writer.WriteZeros(4);
                break;
        }
    }
}

partial class BookBinaryOverlay
{
    public partial Book.Flag GetFlagsCustom()
    {
        if (!_DATALocation.HasValue) return default;
        return (Book.Flag)_recordData[_FlagsLocation];
    }

    public partial IBookTeachTargetGetter? GetTeachesCustom()
    {
        if (!_DATALocation.HasValue) return default;
        int flags = (int)this.Flags;
        if ((flags & BookBinaryCreateTranslation.SpellFlag) > 0)
        {
            return new BookSpell()
            {
                Spell = new FormLink<ISpellGetter>(FormKeyBinaryTranslation.Instance.Parse(_recordData.Slice(_TeachesLocation, 4), _package.MetaData.MasterReferences!))
            };
        }
        else if ((flags & BookBinaryCreateTranslation.SkillFlag) > 0)
        {
            return new BookSkill
            {
                Skill = (Skill)BinaryPrimitives.ReadInt32LittleEndian(_recordData.Slice(_TeachesLocation, 4))
            };
        }
        else
        {
            return new BookTeachesNothing()
            {
                RawContent = BinaryPrimitives.ReadUInt32LittleEndian(_recordData.Slice(_TeachesLocation, 4))
            };
        }
    }
}