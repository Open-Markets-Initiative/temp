using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Srqs Negotiation Requester Notification Message Methods
/// </summary>

public static partial class SrqsNegotiationRequesterNotification
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

        if (message.TryGetULong(TrdRegTsExecutionTime.FixTag, out var trdRegTsExecutionTime))
        {
            TrdRegTsExecutionTime.Encode(pointer, current, trdRegTsExecutionTime, out current);
        }
        else
        {
            TrdRegTsExecutionTime.SetNull(pointer, current, out current);
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

        if (message.TryGetDouble(LastPx.FixTag, out var lastPx))
        {
            LastPx.Encode(pointer, current, lastPx, out current);
        }
        else
        {
            LastPx.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(LeavesQty.FixTag, out var leavesQty))
        {
            LeavesQty.Encode(pointer, current, leavesQty, out current);
        }
        else
        {
            LeavesQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(LastQty.FixTag, out var lastQty))
        {
            LastQty.Encode(pointer, current, lastQty, out current);
        }
        else
        {
            LastQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(EffectiveTime.FixTag, out var effectiveTime))
        {
            EffectiveTime.Encode(pointer, current, effectiveTime, out current);
        }
        else
        {
            EffectiveTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(LastUpdateTime.FixTag, out var lastUpdateTime))
        {
            LastUpdateTime.Encode(pointer, current, lastUpdateTime, out current);
        }
        else
        {
            LastUpdateTime.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(RespondentType.FixTag, out var respondentType))
        {
            RespondentType.Encode(pointer, current, (byte)respondentType, out current);
        }
        else
        {
            RespondentType.SetNull(pointer, current, out current);
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

        Pad6.Encode(pointer, current, out current);

        if (isTargetPartiesComp)
        {
            TargetPartiesComp.Encode(pointer, current, targetPartiesComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Srqs Negotiation Requester Notification Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SrqsNegotiationRequesterNotification.Identifier;

        // --- decode srqs negotiation requester notification message ---

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

        if (TrdRegTsExecutionTime.TryDecode(pointer, current, out var trdRegTsExecutionTime, out current))
        {
            message.AppendULong(TrdRegTsExecutionTime.FixTag, trdRegTsExecutionTime);
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

        if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
        {
            message.AppendDouble(LastPx.FixTag, lastPx);
        }

        if (LeavesQty.TryDecode(pointer, current, out var leavesQty, out current))
        {
            message.AppendDouble(LeavesQty.FixTag, leavesQty);
        }

        if (LastQty.TryDecode(pointer, current, out var lastQty, out current))
        {
            message.AppendDouble(LastQty.FixTag, lastQty);
        }

        if (EffectiveTime.TryDecode(pointer, current, out var effectiveTime, out current))
        {
            message.AppendULong(EffectiveTime.FixTag, effectiveTime);
        }

        if (LastUpdateTime.TryDecode(pointer, current, out var lastUpdateTime, out current))
        {
            message.AppendULong(LastUpdateTime.FixTag, lastUpdateTime);
        }

        if (TradeToRequestRatio.TryDecode(pointer, current, out var tradeToRequestRatio, out current))
        {
            message.AppendDouble(TradeToRequestRatio.FixTag, tradeToRequestRatio);
        }

        if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
        {
            message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
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

        if (RespondentType.TryDecode(pointer, current, out var respondentType, out current))
        {
            message.AppendInt(RespondentType.FixTag, respondentType);
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

        current += Pad6.Length;

        TargetPartiesComp.Decode(ref message, pointer, current, noTargetPartyIDs, out current);

        return FixErrorCode.None;
    }
}
