using Loqui;
using Mutagen.Bethesda.Oblivion;

namespace Loqui
{
    public class ProtocolDefinition_Oblivion : IProtocolRegistration
    {
        public readonly static ProtocolKey ProtocolKey = new ProtocolKey("Oblivion");
        public void Register()
        {
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Header_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.TES4_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.OblivionMod_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSetting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSettingInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSettingFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GameSettingString_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Group_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Global_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GlobalInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GlobalShort_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GlobalFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Class_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ClassTraining_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Model_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Hair_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Faction_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Relation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Rank_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Race_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SkillBoost_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Spell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Eye_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceStatsGendered_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceStats_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceVoices_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.RaceHair_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.FacePart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.GenderedBodyData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.BodyData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.BodyPart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.FaceGenData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Sound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SoundData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SoundDataExtended_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.SkillRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.MagicEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Script_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptMetaSummary_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LocalVariable_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LocalVariableData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.LandTexture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.HavokData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Effect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Enchantment_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.MagicEffectSubData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.EffectShader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Grass_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.Light_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptVariableReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Oblivion.Internals.ScriptObjectReference_Registration.Instance);
        }
    }
}
