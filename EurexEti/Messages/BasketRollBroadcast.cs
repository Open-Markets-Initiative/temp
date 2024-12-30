using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Roll Broadcast Message Methods
    /// </summary>

    public static partial class BasketRollBroadcast
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

            if (message.TryGetULong(ApplSeqNum.FixTag, out var applSeqNum))
            {
                ApplSeqNum.Encode(pointer, current, applSeqNum, out current);
            }
            else
            {
                ApplSeqNum.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplSubId.FixTag, out var applSubId))
            {
                ApplSubId.Encode(pointer, current, (uint)applSubId, out current);
            }
            else
            {
                ApplSubId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
            {
                PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
            }
            else
            {
                PartitionId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
            {
                ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
            }
            else
            {
                ApplResendFlag.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplId.FixTag, out var applId))
            {
                ApplId.Encode(pointer, current, (byte)applId, out current);
            }
            else
            {
                ApplId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

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

            if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
            {
                TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
            }
            else
            {
                TradeReportType.SetNull(pointer, current, out current);
            }

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

            Pad7.Encode(pointer, current, out current);

            if (isBasketRootPartyGrpComp)
            {
                BasketRootPartyGrpComp.Encode(pointer, current, basketRootPartyGrpComp, out current);
            }

            if (message.TryGetULong(TransactTime.FixTag, out var transactTime))
            {
                TransactTime.Encode(pointer, current, transactTime, out current);
            }
            else
            {
                TransactTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(BasketTrdMatchId.FixTag, out var basketTrdMatchId))
            {
                BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);
            }
            else
            {
                BasketTrdMatchId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(OrigBasketTrdMatchId.FixTag, out var origBasketTrdMatchId))
            {
                OrigBasketTrdMatchId.Encode(pointer, current, origBasketTrdMatchId, out current);
            }
            else
            {
                OrigBasketTrdMatchId.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(OptionalEarlyTerminationIndicator.FixTag, out var optionalEarlyTerminationIndicator))
            {
                OptionalEarlyTerminationIndicator.Encode(pointer, current, (byte)optionalEarlyTerminationIndicator, out current);
            }
            else
            {
                OptionalEarlyTerminationIndicator.SetNull(pointer, current, out current);
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

            Pad2.Encode(pointer, current, out current);

            if (message.TryGetULong(TransactTime.FixTag, out var transactTime))
            {
                TransactTime.Encode(pointer, current, transactTime, out current);
            }
            else
            {
                TransactTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(BasketTrdMatchId.FixTag, out var basketTrdMatchId))
            {
                BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);
            }
            else
            {
                BasketTrdMatchId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(OrigBasketTrdMatchId.FixTag, out var origBasketTrdMatchId))
            {
                OrigBasketTrdMatchId.Encode(pointer, current, origBasketTrdMatchId, out current);
            }
            else
            {
                OrigBasketTrdMatchId.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(OptionalEarlyTerminationIndicator.FixTag, out var optionalEarlyTerminationIndicator))
            {
                OptionalEarlyTerminationIndicator.Encode(pointer, current, (byte)optionalEarlyTerminationIndicator, out current);
            }
            else
            {
                OptionalEarlyTerminationIndicator.SetNull(pointer, current, out current);
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
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = BasketRollBroadcast.Identifier;

            // --- decode basket roll broadcast message ---

            current += Pad2.Length;

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplSeqNum.TryDecode(pointer, current, out var applSeqNum, out current))
            {
                message.AppendULong(ApplSeqNum.FixTag, applSeqNum);
            }

            if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
            {
                message.AppendInt(ApplSubId.FixTag, (int)applSubId);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
            {
                message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
            }

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad7.Length;

            if (BasketExecId.TryDecode(pointer, current, out var basketExecId, out current))
            {
                message.AppendInt(BasketExecId.FixTag, (int)basketExecId);
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

            if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
            {
                message.AppendInt(TradeReportType.FixTag, tradeReportType);
            }

            var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
            message.AppendToken(MessageEventSource.FixTag, messageEventSource);

            var noBasketRootPartyGrpsBc = (int)NoBasketRootPartyGrpsBc.Decode(pointer, current, out current);

            var noOldBasketInstrmtMatchSides = (int)NoOldBasketInstrmtMatchSides.Decode(pointer, current, out current);

            var noNewBasketInstrmtMatchSides = (int)NoNewBasketInstrmtMatchSides.Decode(pointer, current, out current);

            current += Pad1.Length;

            var noOldBasketSideAlloc = (int)NoOldBasketSideAlloc.Decode(pointer, current, out current);

            var noNewBasketSideAlloc = (int)NoNewBasketSideAlloc.Decode(pointer, current, out current);

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

            current += Pad7.Length;

            BasketRootPartyGrpComp.Decode(ref message, pointer, current, noBasketRootPartyGrpsBc, out current);

            if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
            {
                message.AppendULong(TransactTime.FixTag, transactTime);
            }

            if (BasketTrdMatchId.TryDecode(pointer, current, out var basketTrdMatchId, out current))
            {
                message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);
            }

            if (OrigBasketTrdMatchId.TryDecode(pointer, current, out var origBasketTrdMatchId, out current))
            {
                message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            if (MaturityMonthYear.TryDecode(pointer, current, out var maturityMonthYear, out current))
            {
                message.AppendInt(MaturityMonthYear.FixTag, (int)maturityMonthYear);
            }

            if (OptionalEarlyTerminationIndicator.TryDecode(pointer, current, out var optionalEarlyTerminationIndicator, out current))
            {
                message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);
            }

            if (BasketTradeReportType.TryDecode(pointer, current, out var basketTradeReportType, out current))
            {
                message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);
            }

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            current += Pad2.Length;

            if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
            {
                message.AppendULong(TransactTime.FixTag, transactTime);
            }

            if (BasketTrdMatchId.TryDecode(pointer, current, out var basketTrdMatchId, out current))
            {
                message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);
            }

            if (OrigBasketTrdMatchId.TryDecode(pointer, current, out var origBasketTrdMatchId, out current))
            {
                message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            if (MaturityMonthYear.TryDecode(pointer, current, out var maturityMonthYear, out current))
            {
                message.AppendInt(MaturityMonthYear.FixTag, (int)maturityMonthYear);
            }

            if (OptionalEarlyTerminationIndicator.TryDecode(pointer, current, out var optionalEarlyTerminationIndicator, out current))
            {
                message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);
            }

            if (BasketTradeReportType.TryDecode(pointer, current, out var basketTradeReportType, out current))
            {
                message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);
            }

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