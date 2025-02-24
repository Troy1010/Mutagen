using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Noggog;
using System.Buffers.Binary;
using Mutagen.Bethesda.Fallout4.Internals;

namespace Mutagen.Bethesda.Fallout4;

public partial class Region
{
    [Flags]
    public enum MajorFlag
    {
        BorderRegion = 0x40
    }
}

partial class RegionBinaryCreateTranslation
{
    public static partial ParseResult FillBinaryRegionAreaLogicCustom(MutagenFrame frame, IRegionInternal item)
    {
        var rdat = HeaderTranslation.GetNextSubrecordType(frame.Reader, out _);
        while (rdat.Equals(RecordTypes.RDAT))
        {
            ParseRegionData(frame, item);
            if (frame.Complete) break;
            rdat = HeaderTranslation.GetNextSubrecordType(frame.Reader, out _);
        }

        return null;
    }

    private static readonly RecordType[] ObjectTypes = 
    {
        RecordTypes.ICON,
        RecordTypes.RDOT,
        RecordTypes.RLDM,
        RecordTypes.ANAM,
    };

    private static readonly RecordType[] WeatherTypes = 
    {
        RecordTypes.ICON,
        RecordTypes.RDWT,
        RecordTypes.RLDM,
        RecordTypes.ANAM,
    };

    private static readonly RecordType[] MapTypes = 
    {
        RecordTypes.ICON,
        RecordTypes.RDMP,
        RecordTypes.RLDM,
        RecordTypes.ANAM,
    };

    private static readonly RecordType[] GrassTypes =
    {
        RecordTypes.ICON,
        RecordTypes.RDGS,
        RecordTypes.RLDM,
        RecordTypes.ANAM,
    };

    private static readonly RecordType[] SoundTypes = 
    {
        RecordTypes.ICON,
        RecordTypes.RDSA,
        RecordTypes.RDMO,
        RecordTypes.RLDM,
        RecordTypes.ANAM,
    };

    private static readonly RecordType[] LandTypes = 
    {
        RecordTypes.ICON,
        RecordTypes.RLDM,
        RecordTypes.ANAM,
    };

    public static RecordType[] GetTypes(RegionData.RegionDataType type) => type switch
    {
        RegionData.RegionDataType.Object => ObjectTypes,
        RegionData.RegionDataType.Weather => WeatherTypes,
        RegionData.RegionDataType.Map => MapTypes,
        RegionData.RegionDataType.Grass => GrassTypes,
        RegionData.RegionDataType.Sound => SoundTypes,
        RegionData.RegionDataType.Land => LandTypes,
        _ => throw new ArgumentException($"Unexpected type {type}", nameof(type))
    };

    static void ParseRegionData(MutagenFrame frame, IRegionInternal item)
    {
        var rdatFrame = frame.Reader.GetSubrecord();
        RegionData.RegionDataType dataType = (RegionData.RegionDataType)BinaryPrimitives.ReadUInt32LittleEndian(rdatFrame.Content);

        frame = frame.SpawnAll();
        
        switch (dataType)
        {
            case RegionData.RegionDataType.Object:
                item.Objects = RegionObjects.CreateFromBinary(frame);
                break;
            case RegionData.RegionDataType.Map:
                item.Map = RegionMap.CreateFromBinary(frame);
                break;
            case RegionData.RegionDataType.Grass:
                item.Grasses = RegionGrasses.CreateFromBinary(frame);
                break;
            case RegionData.RegionDataType.Sound:
                item.Sounds = RegionSounds.CreateFromBinary(frame);
                break;
            case RegionData.RegionDataType.Weather:
                item.Weather = RegionWeather.CreateFromBinary(frame);
                break;
            case RegionData.RegionDataType.Land:
                item.Land = RegionLand.CreateFromBinary(frame);
                break;
            default:
                throw new NotImplementedException();
        }
    }
}

partial class RegionBinaryWriteTranslation
{
    public static partial void WriteBinaryRegionAreaLogicCustom(MutagenWriter writer, IRegionGetter item)
    {
        item.Objects?.WriteToBinary(writer);
        item.Weather?.WriteToBinary(writer);
        item.Map?.WriteToBinary(writer);
        item.Land?.WriteToBinary(writer);
        item.Grasses?.WriteToBinary(writer);
        item.Sounds?.WriteToBinary(writer);
    }
}

partial class RegionBinaryOverlay
{
    private ReadOnlyMemorySlice<byte>? _objectsSpan;
    public IRegionObjectsGetter? Objects => _objectsSpan.HasValue ? RegionObjectsBinaryOverlay.RegionObjectsFactory(new OverlayStream(_objectsSpan.Value, _package), _package) : default;

    private ReadOnlyMemorySlice<byte>? _weatherSpan;
    public IRegionWeatherGetter? Weather => _weatherSpan.HasValue ? RegionWeatherBinaryOverlay.RegionWeatherFactory(new OverlayStream(_weatherSpan.Value, _package), _package) : default;

    private ReadOnlyMemorySlice<byte>? _mapSpan;
    public IRegionMapGetter? Map => _mapSpan.HasValue ? RegionMapBinaryOverlay.RegionMapFactory(new OverlayStream(_mapSpan.Value, _package), _package) : default;

    private ReadOnlyMemorySlice<byte>? _grassesSpan;
    public IRegionGrassesGetter? Grasses => _grassesSpan.HasValue ? RegionGrassesBinaryOverlay.RegionGrassesFactory(new OverlayStream(_grassesSpan.Value, _package), _package) : default;

    private ReadOnlyMemorySlice<byte>? _soundsSpan;
    public IRegionSoundsGetter? Sounds => _soundsSpan.HasValue ? RegionSoundsBinaryOverlay.RegionSoundsFactory(new OverlayStream(_soundsSpan.Value, _package), _package) : default;

    private ReadOnlyMemorySlice<byte>? _landSpan;
    public IRegionLandGetter? Land => _landSpan.HasValue ? RegionLandBinaryOverlay.RegionLandFactory(new OverlayStream(_landSpan.Value, _package), _package) : default;

    public partial ParseResult RegionAreaLogicCustomParse(
        OverlayStream stream,
        int offset)
    {
        var rdat = stream.GetSubrecordHeader();
        while (rdat.RecordType.Equals(RecordTypes.RDAT))
        {
            ParseRegionData(stream, offset);
            if (stream.Complete) break;
            rdat = stream.GetSubrecordHeader();
        }

        return null;
    }

    private void ParseRegionData(OverlayStream stream, int offset)
    {
        int loc = stream.Position - offset; 
        var rdatFrame = stream.ReadSubrecord();
        RegionData.RegionDataType dataType = (RegionData.RegionDataType)BinaryPrimitives.ReadUInt32LittleEndian(rdatFrame.Content);
        
        switch (dataType)
        {
            case RegionData.RegionDataType.Object:
                _objectsSpan = _recordData.Slice(loc);
                break;
            case RegionData.RegionDataType.Map:
                _mapSpan = _recordData.Slice(loc);
                break;
            case RegionData.RegionDataType.Grass:
                _grassesSpan = _recordData.Slice(loc);
                break;
            case RegionData.RegionDataType.Land:
                _landSpan = _recordData.Slice(loc);
                break;
            case RegionData.RegionDataType.Sound:
                _soundsSpan = _recordData.Slice(loc);
                break;
            case RegionData.RegionDataType.Weather:
                _weatherSpan = _recordData.Slice(loc);
                break;
            default:
                throw new NotImplementedException();
        }
    }
}