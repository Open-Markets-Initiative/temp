using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Roll Broadcast Message Methods
    /// </summary>

    public partial class BasketRollBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Basket Roll Broadcast
        /// </summary>
        public const string Identifier = "10634";

        /// <summary>
        ///  Encode Basket Roll Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.BasketRollBroadcast, out current);

            // --- encode basket roll broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
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

            var messageEventSource = message.GetToken(MessageEventSource.FixTag);
            MessageEventSource.Encode(pointer, current, messageEventSource, out current);

            var isBasketRootPartyGrpComp = message.TryGetGroup(NoBasketRootPartyGrpsBc.FixTag, out var basketRootPartyGrpComp) && basketRootPartyGrpComp.sectionList.Count > 0;
            if (isBasketRootPartyGrpComp)
            {
                var noBasketRootPartyGrpsBc = (byte)basketRootPartyGrpComp.sectionList.Count;
                NoBasketRootPartyGrpsBc.Encode(pointer, current, noBasketRootPartyGrpsBc, out current);
            }
            else
            {
                NoBasketRootPartyGrpsBc.Zero(pointer, current, out current);
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

            Pad1.Encode(pointer, current, out current);

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

            Pad7.Encode(pointer, current, out current);

            if (isBasketRootPartyGrpComp)
            {
                BasketRootPartyGrpComp.Encode(pointer, current, basketRootPartyGrpComp, out current);
            }

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var basketTrdMatchId = message.GetULong(BasketTrdMatchId.FixTag);
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);

            var origBasketTrdMatchId = message.GetULong(OrigBasketTrdMatchId.FixTag);
            OrigBasketTrdMatchId.Encode(pointer, current, origBasketTrdMatchId, out current);

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

            var optionalEarlyTerminationIndicator = (byte)message.GetInt(OptionalEarlyTerminationIndicator.FixTag);
            OptionalEarlyTerminationIndicator.Encode(pointer, current, optionalEarlyTerminationIndicator, out current);

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

            Pad2.Encode(pointer, current, out current);

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var basketTrdMatchId = message.GetULong(BasketTrdMatchId.FixTag);
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);

            var origBasketTrdMatchId = message.GetULong(OrigBasketTrdMatchId.FixTag);
            OrigBasketTrdMatchId.Encode(pointer, current, origBasketTrdMatchId, out current);

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

            var optionalEarlyTerminationIndicator = (byte)message.GetInt(OptionalEarlyTerminationIndicator.FixTag);
            OptionalEarlyTerminationIndicator.Encode(pointer, current, optionalEarlyTerminationIndicator, out current);

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

            Pad2.Encode(pointer, current, out current);

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
        ///  Decode Basket Roll Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = BasketRollBroadcast.Identifier;

            // --- decode basket roll broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

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

            var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
            message.AppendToken(MessageEventSource.FixTag, messageEventSource);

            var noBasketRootPartyGrpsBc = (int)NoBasketRootPartyGrpsBc.Decode(pointer, current, out current);

            var noOldBasketInstrmtMatchSides = (int)NoOldBasketInstrmtMatchSides.Decode(pointer, current, out current);

            var noNewBasketInstrmtMatchSides = (int)NoNewBasketInstrmtMatchSides.Decode(pointer, current, out current);

            current += Pad1.Length;

            var noOldBasketSideAlloc = (int)NoOldBasketSideAlloc.Decode(pointer, current, out current);

            var noNewBasketSideAlloc = (int)NoNewBasketSideAlloc.Decode(pointer, current, out current);

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

            current += Pad7.Length;

            BasketRootPartyGrpComp.Decode(ref message, pointer, current, noBasketRootPartyGrpsBc, out current);

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var basketTrdMatchId = BasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);

            var origBasketTrdMatchId = OrigBasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            var maturityMonthYear = (int)MaturityMonthYear.Decode(pointer, current, out current);
            message.AppendInt(MaturityMonthYear.FixTag, maturityMonthYear);

            var optionalEarlyTerminationIndicator = OptionalEarlyTerminationIndicator.Decode(pointer, current, out current);
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);

            var basketTradeReportType = BasketTradeReportType.Decode(pointer, current, out current);
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            current += Pad2.Length;

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var basketTrdMatchId = BasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);

            var origBasketTrdMatchId = OrigBasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            var maturityMonthYear = (int)MaturityMonthYear.Decode(pointer, current, out current);
            message.AppendInt(MaturityMonthYear.FixTag, maturityMonthYear);

            var optionalEarlyTerminationIndicator = OptionalEarlyTerminationIndicator.Decode(pointer, current, out current);
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);

            var basketTradeReportType = BasketTradeReportType.Decode(pointer, current, out current);
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            current += Pad2.Length;

            OldBasketInstrmtMatchSideGrpComp.Decode(ref message, pointer, current, noOldBasketInstrmtMatchSides, out current);

            NewBasketInstrmtMatchSideGrpComp.Decode(ref message, pointer, current, noNewBasketInstrmtMatchSides, out current);

            OldBasketSideAllocGrpComp.Decode(ref message, pointer, current, noOldBasketSideAlloc, out current);

            NewBasketSideAllocGrpComp.Decode(ref message, pointer, current, noNewBasketSideAlloc, out current);

            return FixErrorCode.None;
        }
    }
}