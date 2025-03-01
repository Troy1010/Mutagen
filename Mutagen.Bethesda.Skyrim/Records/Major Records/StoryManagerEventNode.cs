using Mutagen.Bethesda.Skyrim.Internals;

namespace Mutagen.Bethesda.Skyrim;

partial class StoryManagerEventNode
{
    public enum Types
    {
        BountyEvent = RecordTypeInts.ADBO,
        CrimeGoldEvent = RecordTypeInts.ADCR,
        ActorDialogueEvent = RecordTypeInts.ADIA,
        PlayerActivateActor = RecordTypeInts.AFAV,
        ActorHelloEvent = RecordTypeInts.AHEL,
        PlayerAddItem = RecordTypeInts.AIPL,
        AttractionObjectEvent = RecordTypeInts.AOBJ,
        ArrestEvent = RecordTypeInts.ARRT,
        AssaultActorEvent = RecordTypeInts.ASSU,
        Bribe = RecordTypeInts.BRIB,
        CastMagicEvent = RecordTypeInts.CAST,
        ChangeRelationshipRank = RecordTypeInts.CHRR,
        ChangeLocationEvent = RecordTypeInts.CLOC,
        ClearLocationEvent = RecordTypeInts.CLRL,
        CraftItem = RecordTypeInts.CRFT,
        PlayerCured = RecordTypeInts.CURE,
        DeadBody = RecordTypeInts.DEAD,
        EscapeJail = RecordTypeInts.ESJA,
        Flatter = RecordTypeInts.FLAT,
        HackComputer = RecordTypeInts.HACK,
        InstancedLocationCreatedEvent = RecordTypeInts.ILOC,
        PlayerInfected = RecordTypeInts.INFC,
        Intimidate = RecordTypeInts.INTM,
        IronSights = RecordTypeInts.IRON,
        JailEvent = RecordTypeInts.JAIL,
        KillActorEvent = RecordTypeInts.KILL,
        LocationLoaded = RecordTypeInts.LCLD,
        LCPGlobalValueEvent = RecordTypeInts.LCPG,
        IncreaseLevel = RecordTypeInts.LEVL,
        LockPick = RecordTypeInts.LOCK,
        NewVoicePower = RecordTypeInts.NVPE,
        OnActorAttach = RecordTypeInts.OAAT,
        PlayerConnect = RecordTypeInts.PCON,
        PayFineEvent = RecordTypeInts.PFIN,
        PlayerRecievesFavor = RecordTypeInts.PRFV,
        QuickPlayMatchEvent = RecordTypeInts.QPMT,
        QuestStart = RecordTypeInts.QSTR,
        PlayerRemoveItem = RecordTypeInts.REMP,
        ScriptEvent = RecordTypeInts.SCPT,
        SkillIncrease = RecordTypeInts.SKIL,
        ServedTime = RecordTypeInts.STIJ,
        TriggerMineExplosionEvent = RecordTypeInts.TMEE,
        TrespassActorEvent = RecordTypeInts.TRES,
    }
}
