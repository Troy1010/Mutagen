﻿using System.Text;
using Mutagen.Bethesda.Plugins.Analysis;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Utility;

namespace Mutagen.Bethesda.Plugins.Binary.Processing;

public static class ModTrimmer
{
    /// <summary>
    /// Trims mod stream of uninteresting record types
    /// </summary>
    /// <param name="streamCreator">A func to create an input stream</param>
    /// <param name="outputStream">Stream to write output to</param>
    /// <param name="interest">Specification of which record types to include</param>
    public static void Trim(
        Func<IMutagenReadStream> streamCreator,
        Stream outputStream,
        RecordInterest interest)
    {
        using var inputStream = streamCreator();
        if (inputStream.Complete) return;
        
        using var writer = new BinaryWriter(outputStream, Encoding.Default, leaveOpen: true);

        var fileLocs = RecordLocator.GetLocations(
            inputStream,
            interest: interest);
        
        // Import until first listed grup
        inputStream.Position = 0;
        if (!fileLocs.GrupLocations.TryGetInDirection(
                inputStream.Position,
                higher: true,
                result: out var nextRec))
        {
            return;
        }
        
        var recordLocation = fileLocs.ListedRecords.Keys[nextRec.Key];
        var noRecordLength = recordLocation - inputStream.Position - inputStream.MetaData.Constants.GroupConstants.HeaderLength;
        inputStream.WriteTo(outputStream, (int)noRecordLength);
        
        while (!inputStream.Complete)
        {
            var groupMeta = inputStream.GetGroupHeader(readSafe: true);
            if (interest.IsInterested(groupMeta.ContainedRecordType))
            {
                inputStream.WriteTo(outputStream, checked((int)groupMeta.TotalLength));
            }
            else
            {
                inputStream.Position += groupMeta.TotalLength;
            }
        }
    }
}