using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Negotiation Requester Notification Message Methods
    /// </summary>

    public partial class SrqsNegotiationRequesterNotification
    {
        /// <summary>
        ///  Eti Identifier for Srqs Negotiation Requester Notification
        /// </summary>
        public const string Identifier = "10712";

        /// <summary>
        ///  Encode Srqs Negotiation Requester Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsNegotiationRequesterNotification, out current);

            // --- encode srqs negotiation requester notification message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.sendingTime.Ticks;
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

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var trdRegTsExecutionTime = message.GetULong(TrdRegTsExecutionTime.FixTag);
            TrdRegTsExecutionTime.Encode(pointer, current, trdRegTsExecutionTime, out current);

            var quoteRefPrice = message.GetDouble(QuoteRefPrice.FixTag);
            QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);

            var underlyingDeltaPercentage = message.GetDouble(UnderlyingDeltaPercentage.FixTag);
            UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);

            var bidPx = message.GetDouble(BidPx.FixTag);
            BidPx.Encode(pointer, current, bidPx, out current);

            var offerPx = message.GetDouble(OfferPx.FixTag);
            OfferPx.Encode(pointer, current, offerPx, out current);

            var orderQty = message.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var lastPx = message.GetDouble(LastPx.FixTag);
            LastPx.Encode(pointer, current, lastPx, out current);

            var leavesQty = message.GetDouble(LeavesQty.FixTag);
            LeavesQty.Encode(pointer, current, leavesQty, out current);

            var lastQty = message.GetDouble(LastQty.FixTag);
            LastQty.Encode(pointer, current, lastQty, out current);

            var effectiveTime = message.GetULong(EffectiveTime.FixTag);
            EffectiveTime.Encode(pointer, current, effectiveTime, out current);

            var lastUpdateTime = message.GetULong(LastUpdateTime.FixTag);
            LastUpdateTime.Encode(pointer, current, lastUpdateTime, out current);

            var tradeToRequestRatio = message.GetDouble(TradeToRequestRatio.FixTag);
            TradeToRequestRatio.Encode(pointer, current, tradeToRequestRatio, out current);

            var negotiationId = (uint)message.GetInt(NegotiationId.FixTag);
            NegotiationId.Encode(pointer, current, negotiationId, out current);

            var numberOfRespondents = (uint)message.GetInt(NumberOfRespondents.FixTag);
            NumberOfRespondents.Encode(pointer, current, numberOfRespondents, out current);

            var quoteType = (byte)message.GetInt(QuoteType.FixTag);
            QuoteType.Encode(pointer, current, quoteType, out current);

            var quoteSubType = (byte)message.GetInt(QuoteSubType.FixTag);
            QuoteSubType.Encode(pointer, current, quoteSubType, out current);

            var respondentType = (byte)message.GetInt(RespondentType.FixTag);
            RespondentType.Encode(pointer, current, respondentType, out current);

            var noTargetPartyIDs = (byte)message.GetInt(NoTargetPartyIDs.FixTag);
            NoTargetPartyIDs.Encode(pointer, current, noTargetPartyIDs, out current);

            var numberOfRespDisclosureInstruction = (byte)message.GetInt(NumberOfRespDisclosureInstruction.FixTag);
            NumberOfRespDisclosureInstruction.Encode(pointer, current, numberOfRespDisclosureInstruction, out current);

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var showLastDealOnClosure = (byte)message.GetInt(ShowLastDealOnClosure.FixTag);
            ShowLastDealOnClosure.Encode(pointer, current, showLastDealOnClosure, out current);

            var tradeAggregationTransType = (byte)message.GetInt(TradeAggregationTransType.FixTag);
            TradeAggregationTransType.Encode(pointer, current, tradeAggregationTransType, out current);

            var quoteCondition = message.GetToken(QuoteCondition.FixTag);
            QuoteCondition.Encode(pointer, current, quoteCondition, out current);

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

            if (message.TryGetString(PartyEnteringTrader.FixTag, out var partyEnteringTrader))
            {
                PartyEnteringTrader.Encode(pointer, current, partyEnteringTrader, out current);
            }
            else
            {
                PartyEnteringTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FirmNegotiationId.FixTag, out var firmNegotiationId))
            {
                FirmNegotiationId.Encode(pointer, current, firmNegotiationId, out current);
            }
            else
            {
                FirmNegotiationId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FreeText5.FixTag, out var freeText5))
            {
                FreeText5.Encode(pointer, current, freeText5, out current);
            }
            else
            {
                FreeText5.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyOrderOriginationTrader.FixTag, out var partyOrderOriginationTrader))
            {
                PartyOrderOriginationTrader.Encode(pointer, current, partyOrderOriginationTrader, out current);
            }
            else
            {
                PartyOrderOriginationTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ChargeId.FixTag, out var chargeId))
            {
                ChargeId.Encode(pointer, current, chargeId, out current);
            }
            else
            {
                ChargeId.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            if (isTargetPartiesComp)
            {
                message.Encode(pointer, current, targetPartiesComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Negotiation Requester Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsNegotiationRequesterNotification.Identifier;

            // --- decode srqs negotiation requester notification message ---

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

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var trdRegTsExecutionTime = TrdRegTsExecutionTime.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsExecutionTime.FixTag, trdRegTsExecutionTime);

            var quoteRefPrice = QuoteRefPrice.Decode(pointer, current, out current);
            message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);

            var underlyingDeltaPercentage = UnderlyingDeltaPercentage.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);

            var bidPx = BidPx.Decode(pointer, current, out current);
            message.AppendDouble(BidPx.FixTag, bidPx);

            var offerPx = OfferPx.Decode(pointer, current, out current);
            message.AppendDouble(OfferPx.FixTag, offerPx);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var lastPx = LastPx.Decode(pointer, current, out current);
            message.AppendDouble(LastPx.FixTag, lastPx);

            var leavesQty = LeavesQty.Decode(pointer, current, out current);
            message.AppendDouble(LeavesQty.FixTag, leavesQty);

            var lastQty = LastQty.Decode(pointer, current, out current);
            message.AppendDouble(LastQty.FixTag, lastQty);

            var effectiveTime = EffectiveTime.Decode(pointer, current, out current);
            message.AppendULong(EffectiveTime.FixTag, effectiveTime);

            var lastUpdateTime = LastUpdateTime.Decode(pointer, current, out current);
            message.AppendULong(LastUpdateTime.FixTag, lastUpdateTime);

            var tradeToRequestRatio = TradeToRequestRatio.Decode(pointer, current, out current);
            message.AppendDouble(TradeToRequestRatio.FixTag, tradeToRequestRatio);

            var negotiationId = (int)NegotiationId.Decode(pointer, current, out current);
            message.AppendInt(NegotiationId.FixTag, negotiationId);

            var numberOfRespondents = (int)NumberOfRespondents.Decode(pointer, current, out current);
            message.AppendInt(NumberOfRespondents.FixTag, numberOfRespondents);

            var quoteType = QuoteType.Decode(pointer, current, out current);
            message.AppendInt(QuoteType.FixTag, quoteType);

            var quoteSubType = QuoteSubType.Decode(pointer, current, out current);
            message.AppendInt(QuoteSubType.FixTag, quoteSubType);

            var respondentType = RespondentType.Decode(pointer, current, out current);
            message.AppendInt(RespondentType.FixTag, respondentType);

            var noTargetPartyIDs = NoTargetPartyIDs.Decode(pointer, current, out current);
            message.AppendInt(NoTargetPartyIDs.FixTag, noTargetPartyIDs);

            var numberOfRespDisclosureInstruction = NumberOfRespDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(NumberOfRespDisclosureInstruction.FixTag, numberOfRespDisclosureInstruction);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var showLastDealOnClosure = ShowLastDealOnClosure.Decode(pointer, current, out current);
            message.AppendInt(ShowLastDealOnClosure.FixTag, showLastDealOnClosure);

            var tradeAggregationTransType = TradeAggregationTransType.Decode(pointer, current, out current);
            message.AppendInt(TradeAggregationTransType.FixTag, tradeAggregationTransType);

            var quoteCondition = QuoteCondition.Decode(pointer, current, out current);
            message.AppendToken(QuoteCondition.FixTag, quoteCondition);

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
            }

            if (PartyEnteringTrader.TryDecode(pointer, current, out var partyEnteringTrader, out current))
            {
                message.AppendString(PartyEnteringTrader.FixTag, partyEnteringTrader);
            }

            if (FirmNegotiationId.TryDecode(pointer, current, out var firmNegotiationId, out current))
            {
                message.AppendString(FirmNegotiationId.FixTag, firmNegotiationId);
            }

            if (FreeText5.TryDecode(pointer, current, out var freeText5, out current))
            {
                message.AppendString(FreeText5.FixTag, freeText5);
            }

            if (PartyOrderOriginationTrader.TryDecode(pointer, current, out var partyOrderOriginationTrader, out current))
            {
                message.AppendString(PartyOrderOriginationTrader.FixTag, partyOrderOriginationTrader);
            }

            if (ChargeId.TryDecode(pointer, current, out var chargeId, out current))
            {
                message.AppendString(ChargeId.FixTag, chargeId);
            }

            current += Pad6.Length;

            TargetPartiesComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}