using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Srqs Deal Response Message Methods
/// </summary>

public static partial class SrqsDealResponse
{
    /// <summary>
    ///  Eti Identifier for Srqs Deal Response
    /// </summary>
    public const string Identifier = "10705";

    /// <summary>
    ///  Encode Srqs Deal Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.SrqsDealResponse, out current);

        // --- encode srqs deal response message ---

        Pad2.Encode(pointer, current, out current);

        if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
        {
            RequestTime.Encode(pointer, current, requestTime, out current);
        }
        else
        {
            RequestTime.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        Pad4.Encode(pointer, current, out current);

        if (message.TryGetLong(SecurityId.FixTag, out var securityId))
        {
            SecurityId.Encode(pointer, current, securityId, out current);
        }
        else
        {
            SecurityId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(NegotiationId.FixTag, out var negotiationId))
        {
            NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
        }
        else
        {
            NegotiationId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeId.FixTag, out var tradeId))
        {
            TradeId.Encode(pointer, current, (uint)tradeId, out current);
        }
        else
        {
            TradeId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(SecondaryTradeId.FixTag, out var secondaryTradeId))
        {
            SecondaryTradeId.Encode(pointer, current, (uint)secondaryTradeId, out current);
        }
        else
        {
            SecondaryTradeId.SetNull(pointer, current, out current);
        }

        var isSrqsQuoteGrpComp = message.TryGetGroup(NoSrqsQuoteGrps.FixTag, out var srqsQuoteGrpComp) && srqsQuoteGrpComp.sectionList.Count > 0;
        if (isSrqsQuoteGrpComp)
        {
            var noSrqsQuoteGrps = (byte)srqsQuoteGrpComp.sectionList.Count;
            NoSrqsQuoteGrps.Encode(pointer, current, noSrqsQuoteGrps, out current);
        }
        else
        {
            NoSrqsQuoteGrps.Zero(pointer, current, out current);
        }

        if (message.TryGetString(FirmTradeId.FixTag, out var firmTradeId))
        {
            FirmTradeId.Encode(pointer, current, firmTradeId, out current);
        }
        else
        {
            FirmTradeId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FirmNegotiationId.FixTag, out var firmNegotiationId))
        {
            FirmNegotiationId.Encode(pointer, current, firmNegotiationId, out current);
        }
        else
        {
            FirmNegotiationId.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        if (isSrqsQuoteGrpComp)
        {
            SrqsQuoteGrpComp.Encode(pointer, current, srqsQuoteGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Srqs Deal Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SrqsDealResponse.Identifier;

        // --- decode srqs deal response message ---

        current += Pad2.Length;

        if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
        {
            message.AppendULong(RequestTime.FixTag, requestTime);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        current += Pad4.Length;

        if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
        {
            message.AppendLong(SecurityId.FixTag, securityId);
        }

        if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
        {
            message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
        }

        if (TradeId.TryDecode(pointer, current, out var tradeId, out current))
        {
            message.AppendInt(TradeId.FixTag, (int)tradeId);
        }

        if (SecondaryTradeId.TryDecode(pointer, current, out var secondaryTradeId, out current))
        {
            message.AppendInt(SecondaryTradeId.FixTag, (int)secondaryTradeId);
        }

        var noSrqsQuoteGrps = (int)NoSrqsQuoteGrps.Decode(pointer, current, out current);

        if (FirmTradeId.TryDecode(pointer, current, out var firmTradeId, out current))
        {
            message.AppendString(FirmTradeId.FixTag, firmTradeId);
        }

        if (FirmNegotiationId.TryDecode(pointer, current, out var firmNegotiationId, out current))
        {
            message.AppendString(FirmNegotiationId.FixTag, firmNegotiationId);
        }

        current += Pad3.Length;

        SrqsQuoteGrpComp.Decode(ref message, pointer, current, noSrqsQuoteGrps, out current);

        return FixErrorCode.None;
    }
}
