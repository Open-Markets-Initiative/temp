using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Enter Basket Trade Request Message Methods
    /// </summary>

    public partial class EnterBasketTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Enter Basket Trade Request
        /// </summary>
        public const string Identifier = "10620";

        /// <summary>
        ///  Encode Enter Basket Trade Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.EnterBasketTradeRequest, out current);

            // --- encode enter basket trade request message ---

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

            var maturityMonthYear = (uint)message.GetInt(MaturityMonthYear.FixTag);
            MaturityMonthYear.Encode(pointer, current, maturityMonthYear, out current);

            var basketProfileId = (uint)message.GetInt(BasketProfileId.FixTag);
            BasketProfileId.Encode(pointer, current, basketProfileId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            var isBasketSideAllocGrpComp = message.TryGetGroup(NoBasketSideAlloc.FixTag, out var basketSideAllocGrpComp) && basketSideAllocGrpComp.sectionList.Count > 0;
            if (isBasketSideAllocGrpComp)
            {
                var noBasketSideAlloc = (ushort)basketSideAllocGrpComp.sectionList.Count;
                NoBasketSideAlloc.Encode(pointer, current, noBasketSideAlloc, out current);
            }
            else
            {
                NoBasketSideAlloc.Zero(pointer, current, out current);
            }

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

            var basketTradeReportType = (byte)message.GetInt(BasketTradeReportType.FixTag);
            BasketTradeReportType.Encode(pointer, current, basketTradeReportType, out current);

            var optionalEarlyTerminationIndicator = (byte)message.GetInt(OptionalEarlyTerminationIndicator.FixTag);
            OptionalEarlyTerminationIndicator.Encode(pointer, current, optionalEarlyTerminationIndicator, out current);

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

            var isInstrmtMatchSideGrpComp = message.TryGetGroup(NoInstrmtMatchSides.FixTag, out var instrmtMatchSideGrpComp) && instrmtMatchSideGrpComp.sectionList.Count > 0;
            if (isInstrmtMatchSideGrpComp)
            {
                var noInstrmtMatchSides = (byte)instrmtMatchSideGrpComp.sectionList.Count;
                NoInstrmtMatchSides.Encode(pointer, current, noInstrmtMatchSides, out current);
            }
            else
            {
                NoInstrmtMatchSides.Zero(pointer, current, out current);
            }

            var basketAnonymity = (byte)message.GetInt(BasketAnonymity.FixTag);
            BasketAnonymity.Encode(pointer, current, basketAnonymity, out current);

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

            Pad2.Encode(pointer, current, out current);

            if (isBasketRootPartyGrpComp)
            {
                BasketRootPartyGrpComp.Encode(pointer, current, basketRootPartyGrpComp, out current);
            }

            if (isInstrmtMatchSideGrpComp)
            {
                InstrmtMatchSideGrpComp.Encode(pointer, current, instrmtMatchSideGrpComp, out current);
            }

            if (isBasketSideAllocGrpComp)
            {
                BasketSideAllocGrpComp.Encode(pointer, current, basketSideAllocGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Enter Basket Trade Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = EnterBasketTradeRequest.Identifier;

            // --- decode enter basket trade request message ---

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

            var maturityMonthYear = (int)MaturityMonthYear.Decode(pointer, current, out current);
            message.AppendInt(MaturityMonthYear.FixTag, maturityMonthYear);

            var basketProfileId = (int)BasketProfileId.Decode(pointer, current, out current);
            message.AppendInt(BasketProfileId.FixTag, basketProfileId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var noBasketSideAlloc = (int)NoBasketSideAlloc.Decode(pointer, current, out current);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var basketTradeReportType = BasketTradeReportType.Decode(pointer, current, out current);
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);

            var optionalEarlyTerminationIndicator = OptionalEarlyTerminationIndicator.Decode(pointer, current, out current);
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);

            var noBasketRootPartyGrps = (int)NoBasketRootPartyGrps.Decode(pointer, current, out current);

            var noInstrmtMatchSides = (int)NoInstrmtMatchSides.Decode(pointer, current, out current);

            var basketAnonymity = BasketAnonymity.Decode(pointer, current, out current);
            message.AppendInt(BasketAnonymity.FixTag, basketAnonymity);

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            current += Pad2.Length;

            BasketRootPartyGrpComp.Decode(ref message, pointer, current, noBasketRootPartyGrps, out current);

            InstrmtMatchSideGrpComp.Decode(ref message, pointer, current, noInstrmtMatchSides, out current);

            BasketSideAllocGrpComp.Decode(ref message, pointer, current, noBasketSideAlloc, out current);

            return FixErrorCode.None;
        }
    }
}