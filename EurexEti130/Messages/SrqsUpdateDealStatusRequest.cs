using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Srqs Update Deal Status Request Message Methods
/// </summary>

public static partial class SrqsUpdateDealStatusRequest
{
    /// <summary>
    ///  Eti Identifier for Srqs Update Deal Status Request
    /// </summary>
    public const string Identifier = "10706";

    /// <summary>
    ///  Encode Srqs Update Deal Status Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.SrqsUpdateDealStatusRequest, out current);

        // --- encode srqs update deal status request message ---

        if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
        {
            NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
        }
        else
        {
            NetworkMsgId.SetNull(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        if (uint.TryParse(message.senderSubID, out var senderSubId))
        {
            SenderSubId.Encode(pointer, current, senderSubId, out current);
        }
        else
        {
            SenderSubId.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(UnderlyingPriceStipValue.FixTag, out var underlyingPriceStipValue))
        {
            UnderlyingPriceStipValue.Encode(pointer, current, underlyingPriceStipValue, out current);
        }
        else
        {
            UnderlyingPriceStipValue.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(UnderlyingPx.FixTag, out var underlyingPx))
        {
            UnderlyingPx.Encode(pointer, current, underlyingPx, out current);
        }
        else
        {
            UnderlyingPx.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(LastQty.FixTag, out var lastQty))
        {
            LastQty.Encode(pointer, current, lastQty, out current);
        }
        else
        {
            LastQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
        {
            TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
        }
        else
        {
            TradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TrdRptStatus.FixTag, out var trdRptStatus))
        {
            TrdRptStatus.Encode(pointer, current, (byte)trdRptStatus, out current);
        }
        else
        {
            TrdRptStatus.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
        {
            PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
        }
        else
        {
            PartyExecutingFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
        {
            PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
        }
        else
        {
            PartyExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FreeText5.FixTag, out var freeText5))
        {
            FreeText5.Encode(pointer, current, freeText5, out current);
        }
        else
        {
            FreeText5.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Srqs Update Deal Status Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SrqsUpdateDealStatusRequest.Identifier;

        // --- decode srqs update deal status request message ---

        if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
        {
            message.AppendString(NetworkMsgId.FixTag, networkMsgId);
        }

        current += Pad2.Length;

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
        {
            message.senderSubID = senderSubId.ToString();
        }

        if (UnderlyingPriceStipValue.TryDecode(pointer, current, out var underlyingPriceStipValue, out current))
        {
            message.AppendDouble(UnderlyingPriceStipValue.FixTag, underlyingPriceStipValue);
        }

        if (UnderlyingPx.TryDecode(pointer, current, out var underlyingPx, out current))
        {
            message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);
        }

        if (LastQty.TryDecode(pointer, current, out var lastQty, out current))
        {
            message.AppendDouble(LastQty.FixTag, lastQty);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
        {
            message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
        }

        if (TradeId.TryDecode(pointer, current, out var tradeId, out current))
        {
            message.AppendInt(TradeId.FixTag, (int)tradeId);
        }

        if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
        {
            message.AppendInt(TradeReportType.FixTag, tradeReportType);
        }

        if (TrdRptStatus.TryDecode(pointer, current, out var trdRptStatus, out current))
        {
            message.AppendInt(TrdRptStatus.FixTag, trdRptStatus);
        }

        if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
        {
            message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
        }

        if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
        {
            message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
        }

        if (FreeText5.TryDecode(pointer, current, out var freeText5, out current))
        {
            message.AppendString(FreeText5.FixTag, freeText5);
        }

        current += Pad3.Length;

        return FixErrorCode.None;
    }
}
