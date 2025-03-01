﻿using System.Diagnostics.CodeAnalysis;
using Mutagen.Bethesda.Assets;
using Mutagen.Bethesda.Plugins.Assets;
using Mutagen.Bethesda.Plugins.Binary.Streams;

namespace Mutagen.Bethesda.Plugins.Binary.Translations;

public class AssetLinkBinaryTranslation
{
    public static readonly AssetLinkBinaryTranslation Instance = new();

    public AssetLink<TAssetType> Parse<TAssetType>(
        MutagenFrame reader,
        bool parseWhole = true,
        StringBinaryType stringBinaryType = StringBinaryType.NullTerminate)
        where TAssetType : class, IAssetType
    {
        return new AssetLink<TAssetType>(
            StringBinaryTranslation.Instance.Parse(reader, parseWhole, stringBinaryType));
    }

    public bool Parse<TAssetType>(
        MutagenFrame reader,
        bool parseWhole,
        [MaybeNullWhen(false)] out IAssetLink<TAssetType> item,
        StringBinaryType binaryType = StringBinaryType.NullTerminate)
        where TAssetType : class, IAssetType
    {
        if (StringBinaryTranslation.Instance.Parse(reader, parseWhole, out var str, binaryType))
        {
            item = new AssetLink<TAssetType>(str);
            return true;
        }

        item = default;
        return false;
    }
}