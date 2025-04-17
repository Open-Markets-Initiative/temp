using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Basket Roll Request Message Methods
/// </summary>

public static partial class BasketRollRequest
{
    /// <summary>
    ///  Eti Identifier for Basket Roll Request
    /// </summary>
    public const string Identifier = "10633";

    /// <summary>
    ///  Encode Basket Roll Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.BasketRollRequest, out current);

        // --- encode basket roll request message ---

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

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketProfileId.FixTag, out var basketProfileId))
        {
            BasketProfileId.Encode(pointer, current, (uint)basketProfileId, out current);
        }
        else
        {
            BasketProfileId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TrdType.FixTag, out var trdType))
        {
            TrdType.Encode(pointer, current, (ushort)trdType, out current);
        }
        else
        {
            TrdType.SetNull(pointer, current, out current);
        }

        var isOldBasketSideAllocGrpComp = message.TryGetGroup(NoOldBasketSideAlloc.FixTag, out var oldBasketSideAllocGrpComp) && oldBasketSideAllocGrpComp.sectionList.Count > 0;
        if (isOldBasketSideAllocGrpComp)
        {
            var noOldBasketSideAlloc = (ushort)oldBasketSideAllocGrpComp.sectionList.Count;
            NoOldBasketSideAlloc.Encode(pointer, current, noOldBasketSideAlloc, out current);
        }
        else
        {
            NoOldBasketSideAlloc.Zero(pointer, current, out current);
        }

        var isNewBasketSideAllocGrpComp = message.TryGetGroup(NoNewBasketSideAlloc.FixTag, out var newBasketSideAllocGrpComp) && newBasketSideAllocGrpComp.sectionList.Count > 0;
        if (isNewBasketSideAllocGrpComp)
        {
            var noNewBasketSideAlloc = (ushort)newBasketSideAllocGrpComp.sectionList.Count;
            NoNewBasketSideAlloc.Encode(pointer, current, noNewBasketSideAlloc, out current);
        }
        else
        {
            NoNewBasketSideAlloc.Zero(pointer, current, out current);
        }

        if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
        {
            TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
        }
        else
        {
            TradeReportType.SetNull(pointer, current, out current);
        }

        var isBasketRootPartyGrpComp = message.TryGetGroup(NoBasketRootPartyGrps.FixTag, out var basketRootPartyGrpComp) && basketRootPartyGrpComp.sectionList.Count > 0;
        if (isBasketRootPartyGrpComp)
        {
            var noBasketRootPartyGrps = (byte)basketRootPartyGrpComp.sectionList.Count;
            NoBasketRootPartyGrps.Encode(pointer, current, noBasketRootPartyGrps, out current);
        }
        else
        {
            NoBasketRootPartyGrps.Zero(pointer, current, out current);
        }

        var isOldBasketInstrmtMatchSideGrpComp = message.TryGetGroup(NoOldBasketInstrmtMatchSides.FixTag, out var oldBasketInstrmtMatchSideGrpComp) && oldBasketInstrmtMatchSideGrpComp.sectionList.Count > 0;
        if (isOldBasketInstrmtMatchSideGrpComp)
        {
            var noOldBasketInstrmtMatchSides = (byte)oldBasketInstrmtMatchSideGrpComp.sectionList.Count;
            NoOldBasketInstrmtMatchSides.Encode(pointer, current, noOldBasketInstrmtMatchSides, out current);
        }
        else
        {
            NoOldBasketInstrmtMatchSides.Zero(pointer, current, out current);
        }

        var isNewBasketInstrmtMatchSideGrpComp = message.TryGetGroup(NoNewBasketInstrmtMatchSides.FixTag, out var newBasketInstrmtMatchSideGrpComp) && newBasketInstrmtMatchSideGrpComp.sectionList.Count > 0;
        if (isNewBasketInstrmtMatchSideGrpComp)
        {
            var noNewBasketInstrmtMatchSides = (byte)newBasketInstrmtMatchSideGrpComp.sectionList.Count;
            NoNewBasketInstrmtMatchSides.Encode(pointer, current, noNewBasketInstrmtMatchSides, out current);
        }
        else
        {
            NoNewBasketInstrmtMatchSides.Zero(pointer, current, out current);
        }

        if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
        {
            TradeReportId.Encode(pointer, current, tradeReportId, out current);
        }
        else
        {
            TradeReportId.SetNull(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

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

        if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
        {
            TradeReportId.Encode(pointer, current, tradeReportId, out current);
        }
        else
        {
            TradeReportId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MaturityMonthYear.FixTag, out var maturityMonthYear))
        {
            MaturityMonthYear.Encode(pointer, current, (uint)maturityMonthYear, out current);
        }
        else
        {
            MaturityMonthYear.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketTradeReportType.FixTag, out var basketTradeReportType))
        {
            BasketTradeReportType.Encode(pointer, current, (byte)basketTradeReportType, out current);
        }
        else
        {
            BasketTradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(BasketTradeReportText.FixTag, out var basketTradeReportText))
        {
            BasketTradeReportText.Encode(pointer, current, basketTradeReportText, out current);
        }
        else
        {
            BasketTradeReportText.SetNull(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
        {
            TradeReportId.Encode(pointer, current, tradeReportId, out current);
        }
        else
        {
            TradeReportId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MaturityMonthYear.FixTag, out var maturityMonthYear))
        {
            MaturityMonthYear.Encode(pointer, current, (uint)maturityMonthYear, out current);
        }
        else
        {
            MaturityMonthYear.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketTradeReportType.FixTag, out var basketTradeReportType))
        {
            BasketTradeReportType.Encode(pointer, current, (byte)basketTradeReportType, out current);
        }
        else
        {
            BasketTradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(BasketTradeReportText.FixTag, out var basketTradeReportText))
        {
            BasketTradeReportText.Encode(pointer, current, basketTradeReportText, out current);
        }
        else
        {
            BasketTradeReportText.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        if (isBasketRootPartyGrpComp)
        {
            BasketRootPartyGrpComp.Encode(pointer, current, basketRootPartyGrpComp, out current);
        }

        if (isOldBasketInstrmtMatchSideGrpComp)
        {
            OldBasketInstrmtMatchSideGrpComp.Encode(pointer, current, oldBasketInstrmtMatchSideGrpComp, out current);
        }

        if (isNewBasketInstrmtMatchSideGrpComp)
        {
            NewBasketInstrmtMatchSideGrpComp.Encode(pointer, current, newBasketInstrmtMatchSideGrpComp, out current);
        }

        if (isOldBasketSideAllocGrpComp)
        {
            OldBasketSideAllocGrpComp.Encode(pointer, current, oldBasketSideAllocGrpComp, out current);
        }

        if (isNewBasketSideAllocGrpComp)
        {
            NewBasketSideAllocGrpComp.Encode(pointer, current, newBasketSideAllocGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Basket Roll Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = BasketRollRequest.Identifier;

        // --- decode basket roll request message ---

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

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (BasketProfileId.TryDecode(pointer, current, out var basketProfileId, out current))
        {
            message.AppendInt(BasketProfileId.FixTag, (int)basketProfileId);
        }

        if (TrdType.TryDecode(pointer, current, out var trdType, out current))
        {
            message.AppendInt(TrdType.FixTag, (short)trdType);
        }

        var noOldBasketSideAlloc = (int)NoOldBasketSideAlloc.Decode(pointer, current, out current);

        var noNewBasketSideAlloc = (int)NoNewBasketSideAlloc.Decode(pointer, current, out current);

        if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
        {
            message.AppendInt(TradeReportType.FixTag, tradeReportType);
        }

        var noBasketRootPartyGrps = (int)NoBasketRootPartyGrps.Decode(pointer, current, out current);

        var noOldBasketInstrmtMatchSides = (int)NoOldBasketInstrmtMatchSides.Decode(pointer, current, out current);

        var noNewBasketInstrmtMatchSides = (int)NoNewBasketInstrmtMatchSides.Decode(pointer, current, out current);

        if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
        {
            message.AppendString(TradeReportId.FixTag, tradeReportId);
        }

        current += Pad2.Length;

        if (BasketTrdMatchId.TryDecode(pointer, current, out var basketTrdMatchId, out current))
        {
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);
        }

        if (BasketExecId.TryDecode(pointer, current, out var basketExecId, out current))
        {
            message.AppendInt(BasketExecId.FixTag, (int)basketExecId);
        }

        if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
        {
            message.AppendString(TradeReportId.FixTag, tradeReportId);
        }

        if (MaturityMonthYear.TryDecode(pointer, current, out var maturityMonthYear, out current))
        {
            message.AppendInt(MaturityMonthYear.FixTag, (int)maturityMonthYear);
        }

        if (BasketTradeReportType.TryDecode(pointer, current, out var basketTradeReportType, out current))
        {
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);
        }

        if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
        {
            message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
        }

        current += Pad7.Length;

        if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
        {
            message.AppendString(TradeReportId.FixTag, tradeReportId);
        }

        if (MaturityMonthYear.TryDecode(pointer, current, out var maturityMonthYear, out current))
        {
            message.AppendInt(MaturityMonthYear.FixTag, (int)maturityMonthYear);
        }

        if (BasketTradeReportType.TryDecode(pointer, current, out var basketTradeReportType, out current))
        {
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);
        }

        if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
        {
            message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
        }

        current += Pad3.Length;

        BasketRootPartyGrpComp.Decode(ref message, pointer, current, noBasketRootPartyGrps, out current);

        OldBasketInstrmtMatchSideGrpComp.Decode(ref message, pointer, current, noOldBasketInstrmtMatchSides, out current);

        NewBasketInstrmtMatchSideGrpComp.Decode(ref message, pointer, current, noNewBasketInstrmtMatchSides, out current);

        OldBasketSideAllocGrpComp.Decode(ref message, pointer, current, noOldBasketSideAlloc, out current);

        NewBasketSideAllocGrpComp.Decode(ref message, pointer, current, noNewBasketSideAlloc, out current);

        return FixErrorCode.None;
    }
}
