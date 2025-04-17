using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Srqs Open Negotiation Requester Notification Message Methods
/// </summary>

public static partial class SrqsOpenNegotiationRequesterNotification
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

        if (message.TryGetULong(TransactTime.FixTag, out var transactTime))
        {
            TransactTime.Encode(pointer, current, transactTime, out current);
        }
        else
        {
            TransactTime.SetNull(pointer, current, out current);
        }

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

        if (message.TryGetDouble(LastPx.FixTag, out var lastPx))
        {
            LastPx.Encode(pointer, current, lastPx, out current);
        }
        else
        {
            LastPx.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(LastQty.FixTag, out var lastQty))
        {
            LastQty.Encode(pointer, current, lastQty, out current);
        }
        else
        {
            LastQty.SetNull(pointer, current, out current);
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

        if (message.TryGetULong(ExpireTime.FixTag, out var expireTime))
        {
            ExpireTime.Encode(pointer, current, expireTime, out current);
        }
        else
        {
            ExpireTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(TradeToRequestRatio.FixTag, out var tradeToRequestRatio))
        {
            TradeToRequestRatio.Encode(pointer, current, tradeToRequestRatio, out current);
        }
        else
        {
            TradeToRequestRatio.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(NegotiationId.FixTag, out var negotiationId))
        {
            NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
        }
        else
        {
            NegotiationId.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(NumberOfRespondents.FixTag, out var numberOfRespondents))
        {
            NumberOfRespondents.Encode(pointer, current, (uint)numberOfRespondents, out current);
        }
        else
        {
            NumberOfRespondents.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(NumberOfRespDisclosureInstruction.FixTag, out var numberOfRespDisclosureInstruction))
        {
            NumberOfRespDisclosureInstruction.Encode(pointer, current, (byte)numberOfRespDisclosureInstruction, out current);
        }
        else
        {
            NumberOfRespDisclosureInstruction.SetNull(pointer, current, out current);
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
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SrqsOpenNegotiationRequesterNotification.Identifier;

        // --- decode srqs open negotiation requester notification message ---

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

        if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
        {
            message.AppendULong(TransactTime.FixTag, transactTime);
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

        if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
        {
            message.AppendDouble(LastPx.FixTag, lastPx);
        }

        if (LastQty.TryDecode(pointer, current, out var lastQty, out current))
        {
            message.AppendDouble(LastQty.FixTag, lastQty);
        }

        if (QuoteRefPrice.TryDecode(pointer, current, out var quoteRefPrice, out current))
        {
            message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);
        }

        if (UnderlyingDeltaPercentage.TryDecode(pointer, current, out var underlyingDeltaPercentage, out current))
        {
            message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);
        }

        if (ExpireTime.TryDecode(pointer, current, out var expireTime, out current))
        {
            message.AppendULong(ExpireTime.FixTag, expireTime);
        }

        if (TradeToRequestRatio.TryDecode(pointer, current, out var tradeToRequestRatio, out current))
        {
            message.AppendDouble(TradeToRequestRatio.FixTag, tradeToRequestRatio);
        }

        if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
        {
            message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (SecuritySubType.TryDecode(pointer, current, out var securitySubType, out current))
        {
            message.AppendInt(SecuritySubType.FixTag, securitySubType);
        }

        if (NumberOfRespondents.TryDecode(pointer, current, out var numberOfRespondents, out current))
        {
            message.AppendInt(NumberOfRespondents.FixTag, (int)numberOfRespondents);
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

        if (Side.TryDecode(pointer, current, out var side, out current))
        {
            message.AppendInt(Side.FixTag, side);
        }

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        if (NumberOfRespDisclosureInstruction.TryDecode(pointer, current, out var numberOfRespDisclosureInstruction, out current))
        {
            message.AppendInt(NumberOfRespDisclosureInstruction.FixTag, numberOfRespDisclosureInstruction);
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
