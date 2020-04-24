using Loqui;
using Mutagen.Bethesda.Skyrim;

namespace Loqui
{
    public class ProtocolDefinition_Skyrim : IProtocolRegistration
    {
        public readonly static ProtocolKey ProtocolKey = new ProtocolKey("Skyrim");
        void IProtocolRegistration.Register() => Register();
        public static void Register()
        {
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSetting_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingString_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Global_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GlobalInt_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GlobalShort_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GlobalFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GameSettingBool_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Keyword_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LocationReferenceType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ActionRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ObjectBounds_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TextureSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Textures_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Decal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Class_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Relation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Faction_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FormList_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Outfit_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.PlacedObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Rank_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VendorValues_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VendorLocation_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Condition_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ConditionGlobal_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ConditionFloat_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FunctionConditionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.GetEventData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ConditionData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Model_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AlternateTexture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.HeadPart_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Part_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Hair_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Eyes_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Armor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Race_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BodyTemplate_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RaceData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SkillBoost_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VoiceType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ColorRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Attack_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AttackData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BodyData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BodyPartData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Group_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ModHeader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ModStats_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SkyrimMajorRecord_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SkyrimMod_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.RaceMovementType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SpeedOverrides_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.EquipType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.FaceFxPhonemes_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Phoneme_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.HeadData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.HeadPartReference_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AvailableMorphs_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Npc_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TintAssets_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TintPreset_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ArtObject_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ImpactDataSet_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MaterialType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MovementType_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SoundDescriptor_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SimpleModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Morph_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SoundMarker_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ReverbParameters_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Region_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.AcousticSpace_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.VirtualMachineAdapter_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptEntry_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptObjectProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptStringProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptIntProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptFloatProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptBoolProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptObjectListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptIntListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptFloatListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScriptBoolListProperty_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Static_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.EffectShader_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Light_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Explosion_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectLightArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Projectile_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DualCastData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ImageSpaceAdapter_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Perk_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Spell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectSound_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectBoundArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectNpcArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectSpellArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectWerewolfArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectEnchantmentArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectKeywordArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Hazard_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectGuideArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectSpawnHazardArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.MagicEffectVampireArchetype_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ObjectEffect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Grass_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LandTexture_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.HavokData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.CrimeValues_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ClassData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Effect_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.EffectData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ObjectEffectData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.SpellData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Destructible_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Scroll_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DestructionStage_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DestructionStageData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Debris_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ScrollData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Activator_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ASpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.LeveledSpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Shout_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Water_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.DestructableData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.TalkingActivator_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ArmorModel_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ArmorData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.ArmorAddon_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.Book_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookData_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookTeachTarget_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookSkill_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookSpell_Registration.Instance);
            LoquiRegistration.Register(Mutagen.Bethesda.Skyrim.Internals.BookTeachesNothing_Registration.Instance);
        }
    }
}
