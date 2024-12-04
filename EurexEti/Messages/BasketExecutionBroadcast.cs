using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Execution Broadcast Message Methods
    /// </summary>

    public partial class BasketExecutionBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Basket Execution Broadcast
        /// </summary>
        public const string Identifier = "10628";

        /// <summary>
        ///  Encode Basket Execution Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.BasketExecutionBroadcast, out current);

            // --- encode basket execution broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.sendTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSeqNum = message.GetULong(ApplSeqNum.FixTag);
            ApplSeqNum.Encode(pointer, current, applSeqNum, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applResendFlag = (byte)message.GetInt(ApplResendFlag.FixTag);
            ApplResendFlag.Encode(pointer, current, applResendFlag, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad7.Encode(pointer, current, out current);

            var basketTrdMatchId = message.GetULong(BasketTrdMatchId.FixTag);
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);

            var origBasketTrdMatchId = message.GetULong(OrigBasketTrdMatchId.FixTag);
            OrigBasketTrdMatchId.Encode(pointer, current, origBasketTrdMatchId, out current);

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var basketExecId = (uint)message.GetInt(BasketExecId.FixTag);
            BasketExecId.Encode(pointer, current, basketExecId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var basketProfileId = (uint)message.GetInt(BasketProfileId.FixTag);
            BasketProfileId.Encode(pointer, current, basketProfileId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

            var optionalEarlyTerminationIndicator = (byte)message.GetInt(OptionalEarlyTerminationIndicator.FixTag);
            OptionalEarlyTerminationIndicator.Encode(pointer, current, optionalEarlyTerminationIndicator, out current);

            var noInstrmtMatchSides = (byte)message.GetInt(NoInstrmtMatchSides.FixTag);
            NoInstrmtMatchSides.Encode(pointer, current, noInstrmtMatchSides, out current);

            var messageEventSource = message.GetToken(MessageEventSource.FixTag);
            MessageEventSource.Encode(pointer, current, messageEventSource, out current);

            if (message.TryGetString(BasketSideTradeReportId.FixTag, out var basketSideTradeReportId))
            {
                BasketSideTradeReportId.Encode(pointer, current, basketSideTradeReportId, out current);
            }
            else
            {
                BasketSideTradeReportId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var basketExecGrpComp = (byte)message.GetInt(BasketExecGrpComp.FixTag);
            BasketExecGrpComp.Encode(message, pointer, current, basketExecGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Basket Execution Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = BasketExecutionBroadcast.Identifier;

            // --- decode basket execution broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new DateTime((long)sendingTime);

            var applSeqNum = ApplSeqNum.Decode(pointer, current, out current);
            message.AppendULong(ApplSeqNum.FixTag, applSeqNum);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applResendFlag = ApplResendFlag.Decode(pointer, current, out current);
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad7.Length;

            var basketTrdMatchId = BasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);

            var origBasketTrdMatchId = OrigBasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var basketExecId = (int)BasketExecId.Decode(pointer, current, out current);
            message.AppendInt(BasketExecId.FixTag, basketExecId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var basketProfileId = (int)BasketProfileId.Decode(pointer, current, out current);
            message.AppendInt(BasketProfileId.FixTag, basketProfileId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var optionalEarlyTerminationIndicator = OptionalEarlyTerminationIndicator.Decode(pointer, current, out current);
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);

            var noInstrmtMatchSides = NoInstrmtMatchSides.Decode(pointer, current, out current);
            message.AppendInt(NoInstrmtMatchSides.FixTag, noInstrmtMatchSides);

            var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
            message.AppendToken(MessageEventSource.FixTag, messageEventSource);

            if (BasketSideTradeReportId.TryDecode(pointer, current, out var basketSideTradeReportId, out current))
            {
                message.AppendString(BasketSideTradeReportId.FixTag, basketSideTradeReportId);
            }

            current += Pad2.Length;

            BasketExecGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}