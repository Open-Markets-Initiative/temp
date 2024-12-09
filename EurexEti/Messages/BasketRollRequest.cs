using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
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

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var basketProfileId = (uint)message.GetInt(BasketProfileId.FixTag);
            BasketProfileId.Encode(pointer, current, basketProfileId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

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

            if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
            {
                TradeReportId.Encode(pointer, current, tradeReportId, out current);
            }
            else
            {
                TradeReportId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            if (isBasketRootPartyGrpComp)
            {
                BasketRootPartyGrpComp.Encode(pointer, current, basketRootPartyGrpComp, out current);
            }

            var basketTrdMatchId = message.GetULong(BasketTrdMatchId.FixTag);
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);

            var basketExecId = (uint)message.GetInt(BasketExecId.FixTag);
            BasketExecId.Encode(pointer, current, basketExecId, out current);

            if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
            {
                TradeReportId.Encode(pointer, current, tradeReportId, out current);
            }
            else
            {
                TradeReportId.SetNull(pointer, current, out current);
            }

            var maturityMonthYear = (uint)message.GetInt(MaturityMonthYear.FixTag);
            MaturityMonthYear.Encode(pointer, current, maturityMonthYear, out current);

            var basketTradeReportType = (byte)message.GetInt(BasketTradeReportType.FixTag);
            BasketTradeReportType.Encode(pointer, current, basketTradeReportType, out current);

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

            var maturityMonthYear = (uint)message.GetInt(MaturityMonthYear.FixTag);
            MaturityMonthYear.Encode(pointer, current, maturityMonthYear, out current);

            var basketTradeReportType = (byte)message.GetInt(BasketTradeReportType.FixTag);
            BasketTradeReportType.Encode(pointer, current, basketTradeReportType, out current);

            if (message.TryGetString(BasketTradeReportText.FixTag, out var basketTradeReportText))
            {
                BasketTradeReportText.Encode(pointer, current, basketTradeReportText, out current);
            }
            else
            {
                BasketTradeReportText.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

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
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = BasketRollRequest.Identifier;

            // --- decode basket roll request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubID = senderSubId.ToString();

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var basketProfileId = (int)BasketProfileId.Decode(pointer, current, out current);
            message.AppendInt(BasketProfileId.FixTag, basketProfileId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var noBasketRootPartyGrps = (int)NoBasketRootPartyGrps.Decode(pointer, current, out current);

            var noOldBasketInstrmtMatchSides = (int)NoOldBasketInstrmtMatchSides.Decode(pointer, current, out current);

            var noNewBasketInstrmtMatchSides = (int)NoNewBasketInstrmtMatchSides.Decode(pointer, current, out current);

            var noOldBasketSideAlloc = (int)NoOldBasketSideAlloc.Decode(pointer, current, out current);

            var noNewBasketSideAlloc = (int)NoNewBasketSideAlloc.Decode(pointer, current, out current);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            current += Pad2.Length;

            BasketRootPartyGrpComp.Decode(ref message, pointer, current, noBasketRootPartyGrps, out current);

            var basketTrdMatchId = BasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);

            var basketExecId = (int)BasketExecId.Decode(pointer, current, out current);
            message.AppendInt(BasketExecId.FixTag, basketExecId);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            var maturityMonthYear = (int)MaturityMonthYear.Decode(pointer, current, out current);
            message.AppendInt(MaturityMonthYear.FixTag, maturityMonthYear);

            var basketTradeReportType = BasketTradeReportType.Decode(pointer, current, out current);
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            current += Pad7.Length;

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            var maturityMonthYear = (int)MaturityMonthYear.Decode(pointer, current, out current);
            message.AppendInt(MaturityMonthYear.FixTag, maturityMonthYear);

            var basketTradeReportType = BasketTradeReportType.Decode(pointer, current, out current);
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            current += Pad3.Length;

            OldBasketInstrmtMatchSideGrpComp.Decode(ref message, pointer, current, noOldBasketInstrmtMatchSides, out current);

            NewBasketInstrmtMatchSideGrpComp.Decode(ref message, pointer, current, noNewBasketInstrmtMatchSides, out current);

            OldBasketSideAllocGrpComp.Decode(ref message, pointer, current, noOldBasketSideAlloc, out current);

            NewBasketSideAllocGrpComp.Decode(ref message, pointer, current, noNewBasketSideAlloc, out current);

            return FixErrorCode.None;
        }
    }
}