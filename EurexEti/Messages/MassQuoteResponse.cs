using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Mass Quote Response Message Methods
/// </summary>

public static partial class MassQuoteResponse
{
    /// <summary>
    ///  Eti Identifier for Mass Quote Response
    /// </summary>
    public const string Identifier = "10406";

    /// <summary>
    ///  Encode Mass Quote Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.MassQuoteResponse, out current);

        // --- encode mass quote response message ---

        Pad2.Encode(pointer, current, out current);

        if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
        {
            RequestTime.Encode(pointer, current, requestTime, out current);
        }
        else
        {
            RequestTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeIn.FixTag, out var trdRegTsTimeIn))
        {
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);
        }
        else
        {
            TrdRegTsTimeIn.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
        {
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
        }
        else
        {
            TrdRegTsTimeOut.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ResponseIn.FixTag, out var responseIn))
        {
            ResponseIn.Encode(pointer, current, responseIn, out current);
        }
        else
        {
            ResponseIn.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        if (message.TryGetULong(QuoteId.FixTag, out var quoteId))
        {
            QuoteId.Encode(pointer, current, quoteId, out current);
        }
        else
        {
            QuoteId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(QuoteResponseId.FixTag, out var quoteResponseId))
        {
            QuoteResponseId.Encode(pointer, current, quoteResponseId, out current);
        }
        else
        {
            QuoteResponseId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        var isQuoteEntryAckGrpComp = message.TryGetGroup(NoQuoteSideEntries.FixTag, out var quoteEntryAckGrpComp) && quoteEntryAckGrpComp.sectionList.Count > 0;
        if (isQuoteEntryAckGrpComp)
        {
            var noQuoteSideEntries = (byte)quoteEntryAckGrpComp.sectionList.Count;
            NoQuoteSideEntries.Encode(pointer, current, noQuoteSideEntries, out current);
        }
        else
        {
            NoQuoteSideEntries.Zero(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        if (isQuoteEntryAckGrpComp)
        {
            QuoteEntryAckGrpComp.Encode(pointer, current, quoteEntryAckGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Mass Quote Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = MassQuoteResponse.Identifier;

        // --- decode mass quote response message ---

        current += Pad2.Length;

        if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
        {
            message.AppendULong(RequestTime.FixTag, requestTime);
        }

        if (TrdRegTsTimeIn.TryDecode(pointer, current, out var trdRegTsTimeIn, out current))
        {
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);
        }

        if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
        {
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
        }

        if (ResponseIn.TryDecode(pointer, current, out var responseIn, out current))
        {
            message.AppendULong(ResponseIn.FixTag, responseIn);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad3.Length;

        if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
        {
            message.AppendULong(QuoteId.FixTag, quoteId);
        }

        if (QuoteResponseId.TryDecode(pointer, current, out var quoteResponseId, out current))
        {
            message.AppendULong(QuoteResponseId.FixTag, quoteResponseId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        var noQuoteSideEntries = (int)NoQuoteSideEntries.Decode(pointer, current, out current);

        current += Pad3.Length;

        QuoteEntryAckGrpComp.Decode(ref message, pointer, current, noQuoteSideEntries, out current);

        return FixErrorCode.None;
    }
}
