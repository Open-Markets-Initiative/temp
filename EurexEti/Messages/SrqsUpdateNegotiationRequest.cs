using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Update Negotiation Request Message Methods
    /// </summary>

    public static partial class SrqsUpdateNegotiationRequest
    {
        /// <summary>
        ///  Eti Identifier for Srqs Update Negotiation Request
        /// </summary>
        public const string Identifier = "10701";

        /// <summary>
        ///  Encode Srqs Update Negotiation Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsUpdateNegotiationRequest, out current);

            // --- encode srqs update negotiation request message ---

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

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(NegotiationId.FixTag, out var negotiationId))
            {
                NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
            }
            else
            {
                NegotiationId.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(ShowLastDealOnClosure.FixTag, out var showLastDealOnClosure))
            {
                ShowLastDealOnClosure.Encode(pointer, current, (byte)showLastDealOnClosure, out current);
            }
            else
            {
                ShowLastDealOnClosure.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(RespondentType.FixTag, out var respondentType))
            {
                RespondentType.Encode(pointer, current, (byte)respondentType, out current);
            }
            else
            {
                RespondentType.SetNull(pointer, current, out current);
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

            if (isTargetPartiesComp)
            {
                TargetPartiesComp.Encode(pointer, current, targetPartiesComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Update Negotiation Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = SrqsUpdateNegotiationRequest.Identifier;

            // --- decode srqs update negotiation request message ---

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

            if (QuoteRefPrice.TryDecode(pointer, current, out var quoteRefPrice, out current))
            {
                message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);
            }

            if (UnderlyingDeltaPercentage.TryDecode(pointer, current, out var underlyingDeltaPercentage, out current))
            {
                message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);
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

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
            {
                message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
            }

            var noTargetPartyIDs = (int)NoTargetPartyIDs.Decode(pointer, current, out current);

            if (NumberOfRespDisclosureInstruction.TryDecode(pointer, current, out var numberOfRespDisclosureInstruction, out current))
            {
                message.AppendInt(NumberOfRespDisclosureInstruction.FixTag, numberOfRespDisclosureInstruction);
            }

            if (Side.TryDecode(pointer, current, out var side, out current))
            {
                message.AppendInt(Side.FixTag, side);
            }

            if (ShowLastDealOnClosure.TryDecode(pointer, current, out var showLastDealOnClosure, out current))
            {
                message.AppendInt(ShowLastDealOnClosure.FixTag, showLastDealOnClosure);
            }

            if (QuoteType.TryDecode(pointer, current, out var quoteType, out current))
            {
                message.AppendInt(QuoteType.FixTag, quoteType);
            }

            if (QuoteSubType.TryDecode(pointer, current, out var quoteSubType, out current))
            {
                message.AppendInt(QuoteSubType.FixTag, quoteSubType);
            }

            if (RespondentType.TryDecode(pointer, current, out var respondentType, out current))
            {
                message.AppendInt(RespondentType.FixTag, respondentType);
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

            if (PartyOrderOriginationTrader.TryDecode(pointer, current, out var partyOrderOriginationTrader, out current))
            {
                message.AppendString(PartyOrderOriginationTrader.FixTag, partyOrderOriginationTrader);
            }

            if (ChargeId.TryDecode(pointer, current, out var chargeId, out current))
            {
                message.AppendString(ChargeId.FixTag, chargeId);
            }

            TargetPartiesComp.Decode(ref message, pointer, current, noTargetPartyIDs, out current);

            return FixErrorCode.None;
        }
    }
}