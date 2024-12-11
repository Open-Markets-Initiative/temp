using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Open Negotiation Request Message Methods
    /// </summary>

    public static partial class SrqsOpenNegotiationRequest
    {
        /// <summary>
        ///  Eti Identifier for Srqs Open Negotiation Request
        /// </summary>
        public const string Identifier = "10700";

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

            if (message.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(BidPx.FixTag, out var bidPx))
            {
                BidPx.Encode(pointer, current, bidPx, out current);
            }
            else
            {
                BidPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OfferPx.FixTag, out var offerPx))
            {
                OfferPx.Encode(pointer, current, offerPx, out current);
            }
            else
            {
                OfferPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OrderQty.FixTag, out var orderQty))
            {
                OrderQty.Encode(pointer, current, orderQty, out current);
            }
            else
            {
                OrderQty.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(QuoteRefPrice.FixTag, out var quoteRefPrice))
            {
                QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);
            }
            else
            {
                QuoteRefPrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(UnderlyingDeltaPercentage.FixTag, out var underlyingDeltaPercentage))
            {
                UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);
            }
            else
            {
                UnderlyingDeltaPercentage.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ValidUntilTime.FixTag, out var validUntilTime))
            {
                ValidUntilTime.Encode(pointer, current, validUntilTime, out current);
            }
            else
            {
                ValidUntilTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SecuritySubType.FixTag, out var securitySubType))
            {
                SecuritySubType.Encode(pointer, current, securitySubType, out current);
            }
            else
            {
                SecuritySubType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(QuoteType.FixTag, out var quoteType))
            {
                QuoteType.Encode(pointer, current, (byte)quoteType, out current);
            }
            else
            {
                QuoteType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(QuoteSubType.FixTag, out var quoteSubType))
            {
                QuoteSubType.Encode(pointer, current, (byte)quoteSubType, out current);
            }
            else
            {
                QuoteSubType.SetNull(pointer, current, out current);
            }

            var isQuotReqLegsGrpComp = message.TryGetGroup(NoLegs.FixTag, out var quotReqLegsGrpComp) && quotReqLegsGrpComp.sectionList.Count > 0;
            if (isQuotReqLegsGrpComp)
            {
                var noLegs = (byte)quotReqLegsGrpComp.sectionList.Count;
                NoLegs.Encode(pointer, current, noLegs, out current);
            }
            else
            {
                NoLegs.Zero(pointer, current, out current);
            }

            var isTargetPartiesComp = message.TryGetGroup(NoTargetPartyIDs.FixTag, out var targetPartiesComp) && targetPartiesComp.sectionList.Count > 0;
            if (isTargetPartiesComp)
            {
                var noTargetPartyIDs = (byte)targetPartiesComp.sectionList.Count;
                NoTargetPartyIDs.Encode(pointer, current, noTargetPartyIDs, out current);
            }
            else
            {
                NoTargetPartyIDs.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(NumberOfRespDisclosureInstruction.FixTag, out var numberOfRespDisclosureInstruction))
            {
                NumberOfRespDisclosureInstruction.Encode(pointer, current, (byte)numberOfRespDisclosureInstruction, out current);
            }
            else
            {
                NumberOfRespDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(Side.FixTag, out var side))
            {
                Side.Encode(pointer, current, (byte)side, out current);
            }
            else
            {
                Side.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
            {
                ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
            }
            else
            {
                ProductComplex.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RespondentType.FixTag, out var respondentType))
            {
                RespondentType.Encode(pointer, current, (byte)respondentType, out current);
            }
            else
            {
                RespondentType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ShowLastDealOnClosure.FixTag, out var showLastDealOnClosure))
            {
                ShowLastDealOnClosure.Encode(pointer, current, (byte)showLastDealOnClosure, out current);
            }
            else
            {
                ShowLastDealOnClosure.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(BidPxIsLocked.FixTag, out var bidPxIsLocked))
            {
                BidPxIsLocked.Encode(pointer, current, (byte)bidPxIsLocked, out current);
            }
            else
            {
                BidPxIsLocked.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OfferPxIsLocked.FixTag, out var offerPxIsLocked))
            {
                OfferPxIsLocked.Encode(pointer, current, (byte)offerPxIsLocked, out current);
            }
            else
            {
                OfferPxIsLocked.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SideIsLocked.FixTag, out var sideIsLocked))
            {
                SideIsLocked.Encode(pointer, current, (byte)sideIsLocked, out current);
            }
            else
            {
                SideIsLocked.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OrderQtyIsLocked.FixTag, out var orderQtyIsLocked))
            {
                OrderQtyIsLocked.Encode(pointer, current, (byte)orderQtyIsLocked, out current);
            }
            else
            {
                OrderQtyIsLocked.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradeAggregationTransType.FixTag, out var tradeAggregationTransType))
            {
                TradeAggregationTransType.Encode(pointer, current, (byte)tradeAggregationTransType, out current);
            }
            else
            {
                TradeAggregationTransType.SetNull(pointer, current, out current);
            }

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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (BidPx.TryDecode(pointer, current, out var bidPx, out current))
            {
                message.AppendDouble(BidPx.FixTag, bidPx);
            }

            if (OfferPx.TryDecode(pointer, current, out var offerPx, out current))
            {
                message.AppendDouble(OfferPx.FixTag, offerPx);
            }

            if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
            {
                message.AppendDouble(OrderQty.FixTag, orderQty);
            }

            if (QuoteRefPrice.TryDecode(pointer, current, out var quoteRefPrice, out current))
            {
                message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);
            }

            if (UnderlyingDeltaPercentage.TryDecode(pointer, current, out var underlyingDeltaPercentage, out current))
            {
                message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);
            }

            if (ValidUntilTime.TryDecode(pointer, current, out var validUntilTime, out current))
            {
                message.AppendULong(ValidUntilTime.FixTag, validUntilTime);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (SecuritySubType.TryDecode(pointer, current, out var securitySubType, out current))
            {
                message.AppendInt(SecuritySubType.FixTag, securitySubType);
            }

            if (QuoteType.TryDecode(pointer, current, out var quoteType, out current))
            {
                message.AppendInt(QuoteType.FixTag, quoteType);
            }

            if (QuoteSubType.TryDecode(pointer, current, out var quoteSubType, out current))
            {
                message.AppendInt(QuoteSubType.FixTag, quoteSubType);
            }

            var noLegs = (int)NoLegs.Decode(pointer, current, out current);

            var noTargetPartyIDs = (int)NoTargetPartyIDs.Decode(pointer, current, out current);

            if (NumberOfRespDisclosureInstruction.TryDecode(pointer, current, out var numberOfRespDisclosureInstruction, out current))
            {
                message.AppendInt(NumberOfRespDisclosureInstruction.FixTag, numberOfRespDisclosureInstruction);
            }

            if (Side.TryDecode(pointer, current, out var side, out current))
            {
                message.AppendInt(Side.FixTag, side);
            }

            if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
            {
                message.AppendInt(ProductComplex.FixTag, productComplex);
            }

            if (RespondentType.TryDecode(pointer, current, out var respondentType, out current))
            {
                message.AppendInt(RespondentType.FixTag, respondentType);
            }

            if (ShowLastDealOnClosure.TryDecode(pointer, current, out var showLastDealOnClosure, out current))
            {
                message.AppendInt(ShowLastDealOnClosure.FixTag, showLastDealOnClosure);
            }

            if (BidPxIsLocked.TryDecode(pointer, current, out var bidPxIsLocked, out current))
            {
                message.AppendInt(BidPxIsLocked.FixTag, bidPxIsLocked);
            }

            if (OfferPxIsLocked.TryDecode(pointer, current, out var offerPxIsLocked, out current))
            {
                message.AppendInt(OfferPxIsLocked.FixTag, offerPxIsLocked);
            }

            if (SideIsLocked.TryDecode(pointer, current, out var sideIsLocked, out current))
            {
                message.AppendInt(SideIsLocked.FixTag, sideIsLocked);
            }

            if (OrderQtyIsLocked.TryDecode(pointer, current, out var orderQtyIsLocked, out current))
            {
                message.AppendInt(OrderQtyIsLocked.FixTag, orderQtyIsLocked);
            }

            if (TradeAggregationTransType.TryDecode(pointer, current, out var tradeAggregationTransType, out current))
            {
                message.AppendInt(TradeAggregationTransType.FixTag, tradeAggregationTransType);
            }

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

            QuotReqLegsGrpComp.Decode(ref message, pointer, current, noLegs, out current);

            TargetPartiesComp.Decode(ref message, pointer, current, noTargetPartyIDs, out current);

            return FixErrorCode.None;
        }
    }
}