using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Srqs Open Negotiation Request Message Methods
    /// </summary>

    public partial class SrqsOpenNegotiationRequest
    {
        /// <summary>
        ///  Eti Identifier for Srqs Open Negotiation Request
        /// </summary>
        public const string Identifier = "Srqs Open Negotiation Request";

        /// <summary>
        ///  Encode Srqs Open Negotiation Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsOpenNegotiationRequest, out current);

            // --- encode srqs open negotiation request message ---

            var start = current;

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

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var bidPx = message.GetDouble(BidPx.FixTag);
            BidPx.Encode(pointer, current, bidPx, out current);

            var offerPx = message.GetDouble(OfferPx.FixTag);
            OfferPx.Encode(pointer, current, offerPx, out current);

            var orderQty = message.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var quoteRefPrice = message.GetDouble(QuoteRefPrice.FixTag);
            QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);

            var underlyingDeltaPercentage = message.GetDouble(UnderlyingDeltaPercentage.FixTag);
            UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);

            var validUntilTime = message.GetULong(ValidUntilTime.FixTag);
            ValidUntilTime.Encode(pointer, current, validUntilTime, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var securitySubType = message.GetInt(SecuritySubType.FixTag);
            SecuritySubType.Encode(pointer, current, securitySubType, out current);

            var quoteType = (byte)message.GetInt(QuoteType.FixTag);
            QuoteType.Encode(pointer, current, quoteType, out current);

            var quoteSubType = (byte)message.GetInt(QuoteSubType.FixTag);
            QuoteSubType.Encode(pointer, current, quoteSubType, out current);

            var noLegs = (byte)message.GetInt(NoLegs.FixTag);
            NoLegs.Encode(pointer, current, noLegs, out current);

            var noTargetPartyIDs = (byte)message.GetInt(NoTargetPartyIDs.FixTag);
            NoTargetPartyIDs.Encode(pointer, current, noTargetPartyIDs, out current);

            var numberOfRespDisclosureInstruction = (byte)message.GetInt(NumberOfRespDisclosureInstruction.FixTag);
            NumberOfRespDisclosureInstruction.Encode(pointer, current, numberOfRespDisclosureInstruction, out current);

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

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

            if (message.TryGetString(FreeText5.FixTag, out var freeText5))
            {
                FreeText5.Encode(pointer, current, freeText5, out current);
            }
            else
            {
                FreeText5.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(QuoteReqId.FixTag, out var quoteReqId))
            {
                QuoteReqId.Encode(pointer, current, quoteReqId, out current);
            }
            else
            {
                QuoteReqId.SetNull(pointer, current, out current);
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

            var legSecurityId = group.GetLong(LegSecurityId.FixTag);
            LegSecurityId.Encode(pointer, current, legSecurityId, out current);

            var legRatioQty = (uint)group.GetInt(LegRatioQty.FixTag);
            LegRatioQty.Encode(pointer, current, legRatioQty, out current);

            var legSymbol = group.GetInt(LegSymbol.FixTag);
            LegSymbol.Encode(pointer, current, legSymbol, out current);

            var legSecurityType = (byte)group.GetInt(LegSecurityType.FixTag);
            LegSecurityType.Encode(pointer, current, legSecurityType, out current);

            var legSide = (byte)group.GetInt(LegSide.FixTag);
            LegSide.Encode(pointer, current, legSide, out current);

            Pad6.Encode(pointer, current, out current);

            var targetPartyIdExecutingTrader = (uint)group.GetInt(TargetPartyIdExecutingTrader.FixTag);
            TargetPartyIdExecutingTrader.Encode(pointer, current, targetPartyIdExecutingTrader, out current);

            var sideDisclosureInstruction = (byte)group.GetInt(SideDisclosureInstruction.FixTag);
            SideDisclosureInstruction.Encode(pointer, current, sideDisclosureInstruction, out current);

            var priceDisclosureInstruction = (byte)group.GetInt(PriceDisclosureInstruction.FixTag);
            PriceDisclosureInstruction.Encode(pointer, current, priceDisclosureInstruction, out current);

            var leavesQtyDisclosureInstruction = (byte)group.GetInt(LeavesQtyDisclosureInstruction.FixTag);
            LeavesQtyDisclosureInstruction.Encode(pointer, current, leavesQtyDisclosureInstruction, out current);

            var lastPxDisclosureInstruction = (byte)group.GetInt(LastPxDisclosureInstruction.FixTag);
            LastPxDisclosureInstruction.Encode(pointer, current, lastPxDisclosureInstruction, out current);

            var lastQtyDisclosureInstruction = (byte)group.GetInt(LastQtyDisclosureInstruction.FixTag);
            LastQtyDisclosureInstruction.Encode(pointer, current, lastQtyDisclosureInstruction, out current);

            var freeText5DisclosureInstruction = (byte)group.GetInt(FreeText5DisclosureInstruction.FixTag);
            FreeText5DisclosureInstruction.Encode(pointer, current, freeText5DisclosureInstruction, out current);

            var partyOrderOriginationDisclosureInstruction = (byte)group.GetInt(PartyOrderOriginationDisclosureInstruction.FixTag);
            PartyOrderOriginationDisclosureInstruction.Encode(pointer, current, partyOrderOriginationDisclosureInstruction, out current);

            var quoteInstruction = (byte)group.GetInt(QuoteInstruction.FixTag);
            QuoteInstruction.Encode(pointer, current, quoteInstruction, out current);

            var chargeIdDisclosureInstruction = (byte)group.GetInt(ChargeIdDisclosureInstruction.FixTag);
            ChargeIdDisclosureInstruction.Encode(pointer, current, chargeIdDisclosureInstruction, out current);

            if (group.TryGetString(TargetPartyExecutingFirm.FixTag, out var targetPartyExecutingFirm))
            {
                TargetPartyExecutingFirm.Encode(pointer, current, targetPartyExecutingFirm, out current);
            }
            else
            {
                TargetPartyExecutingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(TargetPartyExecutingTrader.FixTag, out var targetPartyExecutingTrader))
            {
                TargetPartyExecutingTrader.Encode(pointer, current, targetPartyExecutingTrader, out current);
            }
            else
            {
                TargetPartyExecutingTrader.SetNull(pointer, current, out current);
            }

            var partyDetailStatus = (byte)group.GetInt(PartyDetailStatus.FixTag);
            PartyDetailStatus.Encode(pointer, current, partyDetailStatus, out current);

            var partyDetailStatusInformation = (byte)group.GetInt(PartyDetailStatusInformation.FixTag);
            PartyDetailStatusInformation.Encode(pointer, current, partyDetailStatusInformation, out current);

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Srqs Open Negotiation Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsOpenNegotiationRequest.Identifier;

            // --- decode srqs open negotiation request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var bidPx = BidPx.Decode(pointer, current, out current);
            message.AppendDouble(BidPx.FixTag, bidPx);

            var offerPx = OfferPx.Decode(pointer, current, out current);
            message.AppendDouble(OfferPx.FixTag, offerPx);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var quoteRefPrice = QuoteRefPrice.Decode(pointer, current, out current);
            message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);

            var underlyingDeltaPercentage = UnderlyingDeltaPercentage.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);

            var validUntilTime = ValidUntilTime.Decode(pointer, current, out current);
            message.AppendULong(ValidUntilTime.FixTag, validUntilTime);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var securitySubType = SecuritySubType.Decode(pointer, current, out current);
            message.AppendInt(SecuritySubType.FixTag, securitySubType);

            var quoteType = QuoteType.Decode(pointer, current, out current);
            message.AppendInt(QuoteType.FixTag, quoteType);

            var quoteSubType = QuoteSubType.Decode(pointer, current, out current);
            message.AppendInt(QuoteSubType.FixTag, quoteSubType);

            var noLegs = NoLegs.Decode(pointer, current, out current);
            message.AppendInt(NoLegs.FixTag, noLegs);

            var noTargetPartyIDs = NoTargetPartyIDs.Decode(pointer, current, out current);
            message.AppendInt(NoTargetPartyIDs.FixTag, noTargetPartyIDs);

            var numberOfRespDisclosureInstruction = NumberOfRespDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(NumberOfRespDisclosureInstruction.FixTag, numberOfRespDisclosureInstruction);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

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

            if (FreeText5.TryDecode(pointer, current, out var freeText5, out current))
            {
                message.AppendString(FreeText5.FixTag, freeText5);
            }

            if (QuoteReqId.TryDecode(pointer, current, out var quoteReqId, out current))
            {
                message.AppendString(QuoteReqId.FixTag, quoteReqId);
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

            var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
            message.AppendLong(LegSecurityId.FixTag, legSecurityId);

            var legRatioQty = (int)LegRatioQty.Decode(pointer, current, out current);
            message.AppendInt(LegRatioQty.FixTag, legRatioQty);

            var legSymbol = LegSymbol.Decode(pointer, current, out current);
            message.AppendInt(LegSymbol.FixTag, legSymbol);

            var legSecurityType = LegSecurityType.Decode(pointer, current, out current);
            message.AppendInt(LegSecurityType.FixTag, legSecurityType);

            var legSide = LegSide.Decode(pointer, current, out current);
            message.AppendInt(LegSide.FixTag, legSide);

            current += Pad6.Length;

            var targetPartyIdExecutingTrader = (int)TargetPartyIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(TargetPartyIdExecutingTrader.FixTag, targetPartyIdExecutingTrader);

            var sideDisclosureInstruction = SideDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(SideDisclosureInstruction.FixTag, sideDisclosureInstruction);

            var priceDisclosureInstruction = PriceDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(PriceDisclosureInstruction.FixTag, priceDisclosureInstruction);

            var leavesQtyDisclosureInstruction = LeavesQtyDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(LeavesQtyDisclosureInstruction.FixTag, leavesQtyDisclosureInstruction);

            var lastPxDisclosureInstruction = LastPxDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(LastPxDisclosureInstruction.FixTag, lastPxDisclosureInstruction);

            var lastQtyDisclosureInstruction = LastQtyDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(LastQtyDisclosureInstruction.FixTag, lastQtyDisclosureInstruction);

            var freeText5DisclosureInstruction = FreeText5DisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(FreeText5DisclosureInstruction.FixTag, freeText5DisclosureInstruction);

            var partyOrderOriginationDisclosureInstruction = PartyOrderOriginationDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(PartyOrderOriginationDisclosureInstruction.FixTag, partyOrderOriginationDisclosureInstruction);

            var quoteInstruction = QuoteInstruction.Decode(pointer, current, out current);
            message.AppendInt(QuoteInstruction.FixTag, quoteInstruction);

            var chargeIdDisclosureInstruction = ChargeIdDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(ChargeIdDisclosureInstruction.FixTag, chargeIdDisclosureInstruction);

            if (TargetPartyExecutingFirm.TryDecode(pointer, current, out var targetPartyExecutingFirm, out current))
            {
                message.AppendString(TargetPartyExecutingFirm.FixTag, targetPartyExecutingFirm);
            }

            if (TargetPartyExecutingTrader.TryDecode(pointer, current, out var targetPartyExecutingTrader, out current))
            {
                message.AppendString(TargetPartyExecutingTrader.FixTag, targetPartyExecutingTrader);
            }

            var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

            var partyDetailStatusInformation = PartyDetailStatusInformation.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatusInformation.FixTag, partyDetailStatusInformation);

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}