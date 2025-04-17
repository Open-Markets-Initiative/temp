using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Approve Basket Trade Request Message Methods
/// </summary>

public static partial class ApproveBasketTradeRequest
{
    /// <summary>
    ///  Eti Identifier for Approve Basket Trade Request
    /// </summary>
    public const string Identifier = "10623";

    /// <summary>
    ///  Encode Approve Basket Trade Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.ApproveBasketTradeRequest, out current);

        // --- encode approve basket trade request message ---

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

        if (message.TryGetULong(BasketTrdMatchId.FixTag, out var basketTrdMatchId))
        {
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);
        }
        else
        {
            BasketTrdMatchId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketExecId.FixTag, out var basketExecId))
        {
            BasketExecId.Encode(pointer, current, (uint)basketExecId, out current);
        }
        else
        {
            BasketExecId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RootPartySubIdType.FixTag, out var rootPartySubIdType))
        {
            RootPartySubIdType.Encode(pointer, current, (ushort)rootPartySubIdType, out current);
        }
        else
        {
            RootPartySubIdType.SetNull(pointer, current, out current);
        }

        var isBasketSideAllocExtGrpComp = message.TryGetGroup(NoBasketSideAlloc.FixTag, out var basketSideAllocExtGrpComp) && basketSideAllocExtGrpComp.sectionList.Count > 0;
        if (isBasketSideAllocExtGrpComp)
        {
            var noBasketSideAlloc = (ushort)basketSideAllocExtGrpComp.sectionList.Count;
            NoBasketSideAlloc.Encode(pointer, current, noBasketSideAlloc, out current);
        }
        else
        {
            NoBasketSideAlloc.Zero(pointer, current, out current);
        }

        if (message.TryGetInt(TrdType.FixTag, out var trdType))
        {
            TrdType.Encode(pointer, current, (ushort)trdType, out current);
        }
        else
        {
            TrdType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
        {
            TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
        }
        else
        {
            TradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(BasketTradeReportText.FixTag, out var basketTradeReportText))
        {
            BasketTradeReportText.Encode(pointer, current, basketTradeReportText, out current);
        }
        else
        {
            BasketTradeReportText.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
        {
            TradeReportId.Encode(pointer, current, tradeReportId, out current);
        }
        else
        {
            TradeReportId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(BasketSideTradeReportId.FixTag, out var basketSideTradeReportId))
        {
            BasketSideTradeReportId.Encode(pointer, current, basketSideTradeReportId, out current);
        }
        else
        {
            BasketSideTradeReportId.SetNull(pointer, current, out current);
        }

        Pad5.Encode(pointer, current, out current);

        if (isBasketSideAllocExtGrpComp)
        {
            BasketSideAllocExtGrpComp.Encode(pointer, current, basketSideAllocExtGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Approve Basket Trade Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = ApproveBasketTradeRequest.Identifier;

        // --- decode approve basket trade request message ---

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

        if (BasketTrdMatchId.TryDecode(pointer, current, out var basketTrdMatchId, out current))
        {
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);
        }

        if (BasketExecId.TryDecode(pointer, current, out var basketExecId, out current))
        {
            message.AppendInt(BasketExecId.FixTag, (int)basketExecId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (RootPartySubIdType.TryDecode(pointer, current, out var rootPartySubIdType, out current))
        {
            message.AppendInt(RootPartySubIdType.FixTag, (short)rootPartySubIdType);
        }

        var noBasketSideAlloc = (int)NoBasketSideAlloc.Decode(pointer, current, out current);

        if (TrdType.TryDecode(pointer, current, out var trdType, out current))
        {
            message.AppendInt(TrdType.FixTag, (short)trdType);
        }

        if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
        {
            message.AppendInt(TradeReportType.FixTag, tradeReportType);
        }

        if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
        {
            message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
        }

        if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
        {
            message.AppendString(TradeReportId.FixTag, tradeReportId);
        }

        if (BasketSideTradeReportId.TryDecode(pointer, current, out var basketSideTradeReportId, out current))
        {
            message.AppendString(BasketSideTradeReportId.FixTag, basketSideTradeReportId);
        }

        current += Pad5.Length;

        BasketSideAllocExtGrpComp.Decode(ref message, pointer, current, noBasketSideAlloc, out current);

        return FixErrorCode.None;
    }
}
