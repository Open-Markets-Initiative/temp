using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Srqs Quote Snapshot Notification Message Methods
/// </summary>

public static partial class SrqsQuoteSnapshotNotification
{
    /// <summary>
    ///  Eti Identifier for Srqs Quote Snapshot Notification
    /// </summary>
    public const string Identifier = "10723";

    /// <summary>
    ///  Encode Srqs Quote Snapshot Notification Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.SrqsQuoteSnapshotNotification, out current);

        // --- encode srqs quote snapshot notification message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        if (message.TryGetULong(ApplSeqNum.FixTag, out var applSeqNum))
        {
            ApplSeqNum.Encode(pointer, current, applSeqNum, out current);
        }
        else
        {
            ApplSeqNum.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplSubId.FixTag, out var applSubId))
        {
            ApplSubId.Encode(pointer, current, (uint)applSubId, out current);
        }
        else
        {
            ApplSubId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
        {
            PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
        }
        else
        {
            PartitionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
        {
            ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
        }
        else
        {
            ApplResendFlag.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplId.FixTag, out var applId))
        {
            ApplId.Encode(pointer, current, (byte)applId, out current);
        }
        else
        {
            ApplId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        var isSrqsQuoteEntryGrpComp = message.TryGetGroup(NoQuoteEntries.FixTag, out var srqsQuoteEntryGrpComp) && srqsQuoteEntryGrpComp.sectionList.Count > 0;
        if (isSrqsQuoteEntryGrpComp)
        {
            var noQuoteEntries = (byte)srqsQuoteEntryGrpComp.sectionList.Count;
            NoQuoteEntries.Encode(pointer, current, noQuoteEntries, out current);
        }
        else
        {
            NoQuoteEntries.Zero(pointer, current, out current);
        }

        var messageEventSource = message.GetToken(MessageEventSource.FixTag);
        MessageEventSource.Encode(pointer, current, messageEventSource, out current);

        Pad6.Encode(pointer, current, out current);

        if (isSrqsQuoteEntryGrpComp)
        {
            SrqsQuoteEntryGrpComp.Encode(pointer, current, srqsQuoteEntryGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Srqs Quote Snapshot Notification Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SrqsQuoteSnapshotNotification.Identifier;

        // --- decode srqs quote snapshot notification message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (ApplSeqNum.TryDecode(pointer, current, out var applSeqNum, out current))
        {
            message.AppendULong(ApplSeqNum.FixTag, applSeqNum);
        }

        if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
        {
            message.AppendInt(ApplSubId.FixTag, (int)applSubId);
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
        {
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
        }

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad7.Length;

        var noQuoteEntries = (int)NoQuoteEntries.Decode(pointer, current, out current);

        var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
        message.AppendToken(MessageEventSource.FixTag, messageEventSource);

        current += Pad6.Length;

        SrqsQuoteEntryGrpComp.Decode(ref message, pointer, current, noQuoteEntries, out current);

        return FixErrorCode.None;
    }
}
