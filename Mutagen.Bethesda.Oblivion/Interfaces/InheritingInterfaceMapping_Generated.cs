/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Loqui;

namespace Mutagen.Bethesda.Oblivion;

internal class OblivionInheritingInterfaceMapping : IInterfaceMapping
{
    public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

    public GameCategory GameCategory => GameCategory.Oblivion;

    public OblivionInheritingInterfaceMapping()
    {
        var dict = new Dictionary<Type, InterfaceMappingResult>();
        dict[typeof(IGameSettingFloat)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            GameSetting_Registration.Instance,
        });
        dict[typeof(IGameSettingFloatGetter)] = dict[typeof(IGameSettingFloat)] with { Setter = false };
        dict[typeof(IGameSettingInt)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            GameSetting_Registration.Instance,
        });
        dict[typeof(IGameSettingIntGetter)] = dict[typeof(IGameSettingInt)] with { Setter = false };
        dict[typeof(IGameSettingString)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            GameSetting_Registration.Instance,
        });
        dict[typeof(IGameSettingStringGetter)] = dict[typeof(IGameSettingString)] with { Setter = false };
        dict[typeof(IGlobalFloat)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Global_Registration.Instance,
        });
        dict[typeof(IGlobalFloatGetter)] = dict[typeof(IGlobalFloat)] with { Setter = false };
        dict[typeof(IGlobalInt)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Global_Registration.Instance,
        });
        dict[typeof(IGlobalIntGetter)] = dict[typeof(IGlobalInt)] with { Setter = false };
        dict[typeof(IGlobalShort)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Global_Registration.Instance,
        });
        dict[typeof(IGlobalShortGetter)] = dict[typeof(IGlobalShort)] with { Setter = false };
        dict[typeof(ISpellLeveled)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Spell_Registration.Instance,
        });
        dict[typeof(ISpellLeveledGetter)] = dict[typeof(ISpellLeveled)] with { Setter = false };
        InterfaceToObjectTypes = dict;
    }
}

