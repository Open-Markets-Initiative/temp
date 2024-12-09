using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Open Negotiation Requester Notification Message Methods
    /// </summary>

    public partial class SrqsOpenNegotiationRequesterNotification
    {
        /// <summary>
        ///  Eti Identifier for Srqs Open Negotiation Requester Notification
        /// </summary>
        public const string Identifier = "10710";

        /// <summary>
        ///  Encode Srqs Open Negotiation Requester Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsOpenNegotiationRequesterNotification, out current);

            // --- encode srqs open negotiation requester notification message ---

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

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var bidPx = message.GetDouble(BidPx.FixTag);
            BidPx.Encode(pointer, current, bidPx, out current);

            var offerPx = message.GetDouble(OfferPx.FixTag);
            OfferPx.Encode(pointer, current, offerPx, out current);

            var orderQty = message.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var lastPx = message.GetDouble(LastPx.FixTag);
            LastPx.Encode(pointer, current, lastPx, out current);

            var lastQty = message.GetDouble(LastQty.FixTag);
            LastQty.Encode(pointer, current, lastQty, out current);

            var quoteRefPrice = message.GetDouble(QuoteRefPrice.FixTag);
            QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);

            var underlyingDeltaPercentage = message.GetDouble(UnderlyingDeltaPercentage.FixTag);
            UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);

            var expireTime = message.GetULong(ExpireTime.FixTag);
            ExpireTime.Encode(pointer, current, expireTime, out current);

            var tradeToRequestRatio = message.GetDouble(TradeToRequestRatio.FixTag);
            TradeToRequestRatio.Encode(pointer, current, tradeToRequestRatio, out current);

            var negotiationId = (uint)message.GetInt(NegotiationId.FixTag);
            NegotiationId.Encode(pointer, current, negotiationId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var securitySubType = message.GetInt(SecuritySubType.FixTag);
            SecuritySubType.Encode(pointer, current, securitySubType, out current);

            var numberOfRespondents = (uint)message.GetInt(NumberOfRespondents.FixTag);
            NumberOfRespondents.Encode(pointer, current, numberOfRespondents, out current);

            var quoteType = (byte)message.GetInt(QuoteType.FixTag);
            QuoteType.Encode(pointer, current, quoteType, out current);

            var quoteSubType = (byte)message.GetInt(QuoteSubType.FixTag);
            QuoteSubType.Encode(pointer, current, quoteSubType, out current);

            var isQuotReqLegsGrpComp = message.TryGetGroup(NoLegs.FixTag, out var quotReqLegsGrpComp) && QuotReqLegsGrpComp.sectionList.Length > 0;
            if (isQuotReqLegsGrpComp)
            {
                var noLegs = (byte)quotReqLegsGrpComp.sectionList.Length;
                NoLegs.Encode(pointer, current, noLegs, out current);
            }
            else
            {
                NoLegs.Zero(pointer, current, out current);
            }

            var isTargetPartiesComp = message.TryGetGroup(NoTargetPartyIDs.FixTag, out var targetPartiesComp) && TargetPartiesComp.sectionList.Length > 0;
            if (isTargetPartiesComp)
            {
                var noTargetPartyIDs = (byte)targetPartiesComp.sectionList.Length;
                NoTargetPartyIDs.Encode(pointer, current, noTargetPartyIDs, out current);
            }
            else
            {
                NoTargetPartyIDs.Zero(pointer, current, out current);
            }

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var numberOfRespDisclosureInstruction = (byte)message.GetInt(NumberOfRespDisclosureInstruction.FixTag);
            NumberOfRespDisclosureInstruction.Encode(pointer, current, numberOfRespDisclosureInstruction, out current);

            var respondentType = (byte)message.GetInt(RespondentType.FixTag);
            RespondentType.Encode(pointer, current, respondentType, out current);

            var showLastDealOnClosure = (byte)message.GetInt(ShowLastDealOnClosure.FixTag);
            ShowLastDealOnClosure.Encode(pointer, current, showLastDealOnClosure, out current);

            var bidPxIsLocked = (byte)message.GetInt(BidPxIsLocked.FixTag);
            BidPxIsLocked.Encode(pointer, current, bidPxIsLocked, out current);

            var offerPxIsLocked = (byte)message.GetInt(OfferPxIsLocked.FixTag);
            OfferPxIsLocked.Encode(pointer, current, offerPxIsLocked, out current);

            var sideIsLocked = (byte)message.GetInt(SideIsLocked.FixTag);
            SideIsLocked.Encode(pointer, current, sideIsLocked, out current);

            var orderQtyIsLocked = (byte)message.GetInt(OrderQtyIsLocked.FixTag);
            OrderQtyIsLocked.Encode(pointer, current, orderQtyIsLocked, out current);

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

            if (isQuotReqLegsGrpComp)
            {
                QuotReqLegsGrpComp.Encode(pointer, current, quotReqLegsGrpComp, out current);
            }

            if (isTargetPartiesComp)
            {
                TargetPartiesComp.Encode(pointer, current, targetPartiesComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Open Negotiation Requester Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsOpenNegotiationRequesterNotification.Identifier;

            // --- decode srqs open negotiation requester notification message ---

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

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var bidPx = BidPx.Decode(pointer, current, out current);
            message.AppendDouble(BidPx.FixTag, bidPx);

            var offerPx = OfferPx.Decode(pointer, current, out current);
            message.AppendDouble(OfferPx.FixTag, offerPx);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var lastPx = LastPx.Decode(pointer, current, out current);
            message.AppendDouble(LastPx.FixTag, lastPx);

            var lastQty = LastQty.Decode(pointer, current, out current);
            message.AppendDouble(LastQty.FixTag, lastQty);

            var quoteRefPrice = QuoteRefPrice.Decode(pointer, current, out current);
            message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);

            var underlyingDeltaPercentage = UnderlyingDeltaPercentage.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);

            var expireTime = ExpireTime.Decode(pointer, current, out current);
            message.AppendULong(ExpireTime.FixTag, expireTime);

            var tradeToRequestRatio = TradeToRequestRatio.Decode(pointer, current, out current);
            message.AppendDouble(TradeToRequestRatio.FixTag, tradeToRequestRatio);

            var negotiationId = (int)NegotiationId.Decode(pointer, current, out current);
            message.AppendInt(NegotiationId.FixTag, negotiationId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var securitySubType = SecuritySubType.Decode(pointer, current, out current);
            message.AppendInt(SecuritySubType.FixTag, securitySubType);

            var numberOfRespondents = (int)NumberOfRespondents.Decode(pointer, current, out current);
            message.AppendInt(NumberOfRespondents.FixTag, numberOfRespondents);

            var quoteType = QuoteType.Decode(pointer, current, out current);
            message.AppendInt(QuoteType.FixTag, quoteType);

            var quoteSubType = QuoteSubType.Decode(pointer, current, out current);
            message.AppendInt(QuoteSubType.FixTag, quoteSubType);

            var noLegs = (int)NoLegs.Decode(pointer, current, out current);

            var noTargetPartyIDs = (int)NoTargetPartyIDs.Decode(pointer, current, out current);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var numberOfRespDisclosureInstruction = NumberOfRespDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(NumberOfRespDisclosureInstruction.FixTag, numberOfRespDisclosureInstruction);

            var respondentType = RespondentType.Decode(pointer, current, out current);
            message.AppendInt(RespondentType.FixTag, respondentType);

            var showLastDealOnClosure = ShowLastDealOnClosure.Decode(pointer, current, out current);
            message.AppendInt(ShowLastDealOnClosure.FixTag, showLastDealOnClosure);

            var bidPxIsLocked = BidPxIsLocked.Decode(pointer, current, out current);
            message.AppendInt(BidPxIsLocked.FixTag, bidPxIsLocked);

            var offerPxIsLocked = OfferPxIsLocked.Decode(pointer, current, out current);
            message.AppendInt(OfferPxIsLocked.FixTag, offerPxIsLocked);

            var sideIsLocked = SideIsLocked.Decode(pointer, current, out current);
            message.AppendInt(SideIsLocked.FixTag, sideIsLocked);

            var orderQtyIsLocked = OrderQtyIsLocked.Decode(pointer, current, out current);
            message.AppendInt(OrderQtyIsLocked.FixTag, orderQtyIsLocked);

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

            QuotReqLegsGrpComp.Decode(ref message, pointer, current, noLegs, out current);

            TargetPartiesComp.Decode(ref message, pointer, current, noTargetPartyIDs, out current);

            return FixErrorCode.None;
        }
    }
}