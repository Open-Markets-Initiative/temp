using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Modify Basket Trade Request Message Methods
    /// </summary>

    public partial class ModifyBasketTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Modify Basket Trade Request
        /// </summary>
        public const string Identifier = "10621";

        /// <summary>
        ///  Encode Modify Basket Trade Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ModifyBasketTradeRequest, out current);

            // --- encode modify basket trade request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = (uint)message.GetInt(SenderSubId.FixTag);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var basketTrdMatchId = message.GetULong(BasketTrdMatchId.FixTag);
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);

            var basketExecId = (uint)message.GetInt(BasketExecId.FixTag);
            BasketExecId.Encode(pointer, current, basketExecId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var maturityMonthYear = (uint)message.GetInt(MaturityMonthYear.FixTag);
            MaturityMonthYear.Encode(pointer, current, maturityMonthYear, out current);

            var basketProfileId = (uint)message.GetInt(BasketProfileId.FixTag);
            BasketProfileId.Encode(pointer, current, basketProfileId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            var noBasketSideAlloc = (ushort)message.GetInt(NoBasketSideAlloc.FixTag);
            NoBasketSideAlloc.Encode(pointer, current, noBasketSideAlloc, out current);

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

            var noBasketRootPartyGrps = (byte)message.GetInt(NoBasketRootPartyGrps.FixTag);
            NoBasketRootPartyGrps.Encode(pointer, current, noBasketRootPartyGrps, out current);

            var noInstrmtMatchSides = (byte)message.GetInt(NoInstrmtMatchSides.FixTag);
            NoInstrmtMatchSides.Encode(pointer, current, noInstrmtMatchSides, out current);

            var optionalEarlyTerminationIndicator = (byte)message.GetInt(OptionalEarlyTerminationIndicator.FixTag);
            OptionalEarlyTerminationIndicator.Encode(pointer, current, optionalEarlyTerminationIndicator, out current);

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

            var basketRootPartyGrpComp = (byte)message.GetInt(BasketRootPartyGrpComp.FixTag);
            BasketRootPartyGrpComp.Encode(message, pointer, current, basketRootPartyGrpComp, out current);

            var instrmtMatchSideGrpComp = (byte)message.GetInt(InstrmtMatchSideGrpComp.FixTag);
            InstrmtMatchSideGrpComp.Encode(message, pointer, current, instrmtMatchSideGrpComp, out current);

            var basketSideAllocGrpComp = (byte)message.GetInt(BasketSideAllocGrpComp.FixTag);
            BasketSideAllocGrpComp.Encode(message, pointer, current, basketSideAllocGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Modify Basket Trade Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ModifyBasketTradeRequest.Identifier;

            // --- decode modify basket trade request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var basketTrdMatchId = BasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);

            var basketExecId = (int)BasketExecId.Decode(pointer, current, out current);
            message.AppendInt(BasketExecId.FixTag, basketExecId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var maturityMonthYear = (int)MaturityMonthYear.Decode(pointer, current, out current);
            message.AppendInt(MaturityMonthYear.FixTag, maturityMonthYear);

            var basketProfileId = (int)BasketProfileId.Decode(pointer, current, out current);
            message.AppendInt(BasketProfileId.FixTag, basketProfileId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var noBasketSideAlloc = (short)NoBasketSideAlloc.Decode(pointer, current, out current);
            message.AppendInt(NoBasketSideAlloc.FixTag, noBasketSideAlloc);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var noBasketRootPartyGrps = NoBasketRootPartyGrps.Decode(pointer, current, out current);
            message.AppendInt(NoBasketRootPartyGrps.FixTag, noBasketRootPartyGrps);

            var noInstrmtMatchSides = NoInstrmtMatchSides.Decode(pointer, current, out current);
            message.AppendInt(NoInstrmtMatchSides.FixTag, noInstrmtMatchSides);

            var optionalEarlyTerminationIndicator = OptionalEarlyTerminationIndicator.Decode(pointer, current, out current);
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            BasketRootPartyGrpComp.Decode(ref message, pointer, current, out current);

            InstrmtMatchSideGrpComp.Decode(ref message, pointer, current, out current);

            BasketSideAllocGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}