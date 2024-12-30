using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Enter Basket Trade Request Message Methods
    /// </summary>

    public static partial class EnterBasketTradeRequest
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

            if (message.TryGetInt(MaturityMonthYear.FixTag, out var maturityMonthYear))
            {
                MaturityMonthYear.Encode(pointer, current, (uint)maturityMonthYear, out current);
            }
            else
            {
                MaturityMonthYear.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
            {
                TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
            }
            else
            {
                TradeReportType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(BasketTradeReportType.FixTag, out var basketTradeReportType))
            {
                BasketTradeReportType.Encode(pointer, current, (byte)basketTradeReportType, out current);
            }
            else
            {
                BasketTradeReportType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OptionalEarlyTerminationIndicator.FixTag, out var optionalEarlyTerminationIndicator))
            {
                OptionalEarlyTerminationIndicator.Encode(pointer, current, (byte)optionalEarlyTerminationIndicator, out current);
            }
            else
            {
                OptionalEarlyTerminationIndicator.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(BasketAnonymity.FixTag, out var basketAnonymity))
            {
                BasketAnonymity.Encode(pointer, current, (byte)basketAnonymity, out current);
            }
            else
            {
                BasketAnonymity.SetNull(pointer, current, out current);
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
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
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

            if (MaturityMonthYear.TryDecode(pointer, current, out var maturityMonthYear, out current))
            {
                message.AppendInt(MaturityMonthYear.FixTag, (int)maturityMonthYear);
            }

            if (BasketProfileId.TryDecode(pointer, current, out var basketProfileId, out current))
            {
                message.AppendInt(BasketProfileId.FixTag, (int)basketProfileId);
            }

            if (TrdType.TryDecode(pointer, current, out var trdType, out current))
            {
                message.AppendInt(TrdType.FixTag, (short)trdType);
            }

            var noBasketSideAlloc = (int)NoBasketSideAlloc.Decode(pointer, current, out current);

            if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
            {
                message.AppendInt(TradeReportType.FixTag, tradeReportType);
            }

            if (BasketTradeReportType.TryDecode(pointer, current, out var basketTradeReportType, out current))
            {
                message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);
            }

            if (OptionalEarlyTerminationIndicator.TryDecode(pointer, current, out var optionalEarlyTerminationIndicator, out current))
            {
                message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);
            }

            var noBasketRootPartyGrps = (int)NoBasketRootPartyGrps.Decode(pointer, current, out current);

            var noInstrmtMatchSides = (int)NoInstrmtMatchSides.Decode(pointer, current, out current);

            if (BasketAnonymity.TryDecode(pointer, current, out var basketAnonymity, out current))
            {
                message.AppendInt(BasketAnonymity.FixTag, basketAnonymity);
            }

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