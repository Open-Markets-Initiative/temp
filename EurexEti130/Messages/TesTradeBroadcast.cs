using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Tes Trade Broadcast Message Methods
/// </summary>

public static partial class TesTradeBroadcast
{
    /// <summary>
    ///  Eti Identifier for Tes Trade Broadcast
    /// </summary>
    public const string Identifier = "10614";

    /// <summary>
    ///  Encode Tes Trade Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.TesTradeBroadcast, out current);

        // --- encode tes trade broadcast message ---

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

        if (message.TryGetLong(SecurityId.FixTag, out var securityId))
        {
            SecurityId.Encode(pointer, current, securityId, out current);
        }
        else
        {
            SecurityId.SetNull(pointer, current, out current);
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

        if (message.TryGetDouble(ClearingTradePrice.FixTag, out var clearingTradePrice))
        {
            ClearingTradePrice.Encode(pointer, current, clearingTradePrice, out current);
        }
        else
        {
            ClearingTradePrice.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(ClearingTradeQty.FixTag, out var clearingTradeQty))
        {
            ClearingTradeQty.Encode(pointer, current, clearingTradeQty, out current);
        }
        else
        {
            ClearingTradeQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TransactTime.FixTag, out var transactTime))
        {
            TransactTime.Encode(pointer, current, transactTime, out current);
        }
        else
        {
            TransactTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetLong(RelatedSecurityId.FixTag, out var relatedSecurityId))
        {
            RelatedSecurityId.Encode(pointer, current, relatedSecurityId, out current);
        }
        else
        {
            RelatedSecurityId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(RootPartyIdClientId.FixTag, out var rootPartyIdClientId))
        {
            RootPartyIdClientId.Encode(pointer, current, rootPartyIdClientId, out current);
        }
        else
        {
            RootPartyIdClientId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ExecutingTrader.FixTag, out var executingTrader))
        {
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);
        }
        else
        {
            ExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(RootPartyIdInvestmentDecisionMaker.FixTag, out var rootPartyIdInvestmentDecisionMaker))
        {
            RootPartyIdInvestmentDecisionMaker.Encode(pointer, current, rootPartyIdInvestmentDecisionMaker, out current);
        }
        else
        {
            RootPartyIdInvestmentDecisionMaker.SetNull(pointer, current, out current);
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

        if (message.TryGetDouble(SideLastPx.FixTag, out var sideLastPx))
        {
            SideLastPx.Encode(pointer, current, sideLastPx, out current);
        }
        else
        {
            SideLastPx.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(SideLastQty.FixTag, out var sideLastQty))
        {
            SideLastQty.Encode(pointer, current, sideLastQty, out current);
        }
        else
        {
            SideLastQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(RelatedClosePrice.FixTag, out var relatedClosePrice))
        {
            RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);
        }
        else
        {
            RelatedClosePrice.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TesExecId.FixTag, out var tesExecId))
        {
            TesExecId.Encode(pointer, current, (uint)tesExecId, out current);
        }
        else
        {
            TesExecId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PackageId.FixTag, out var packageId))
        {
            PackageId.Encode(pointer, current, (uint)packageId, out current);
        }
        else
        {
            PackageId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeId.FixTag, out var tradeId))
        {
            TradeId.Encode(pointer, current, (uint)tradeId, out current);
        }
        else
        {
            TradeId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeDate.FixTag, out var tradeDate))
        {
            TradeDate.Encode(pointer, current, (uint)tradeDate, out current);
        }
        else
        {
            TradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(SideTradeId.FixTag, out var sideTradeId))
        {
            SideTradeId.Encode(pointer, current, (uint)sideTradeId, out current);
        }
        else
        {
            SideTradeId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RootPartyIdSessionId.FixTag, out var rootPartyIdSessionId))
        {
            RootPartyIdSessionId.Encode(pointer, current, (uint)rootPartyIdSessionId, out current);
        }
        else
        {
            RootPartyIdSessionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrigTradeId.FixTag, out var origTradeId))
        {
            OrigTradeId.Encode(pointer, current, (uint)origTradeId, out current);
        }
        else
        {
            OrigTradeId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RootPartyIdExecutingUnit.FixTag, out var rootPartyIdExecutingUnit))
        {
            RootPartyIdExecutingUnit.Encode(pointer, current, (uint)rootPartyIdExecutingUnit, out current);
        }
        else
        {
            RootPartyIdExecutingUnit.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RootPartyIdExecutingTrader.FixTag, out var rootPartyIdExecutingTrader))
        {
            RootPartyIdExecutingTrader.Encode(pointer, current, (uint)rootPartyIdExecutingTrader, out current);
        }
        else
        {
            RootPartyIdExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RootPartyIdClearingUnit.FixTag, out var rootPartyIdClearingUnit))
        {
            RootPartyIdClearingUnit.Encode(pointer, current, (uint)rootPartyIdClearingUnit, out current);
        }
        else
        {
            RootPartyIdClearingUnit.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(StrategyLinkId.FixTag, out var strategyLinkId))
        {
            StrategyLinkId.Encode(pointer, current, (uint)strategyLinkId, out current);
        }
        else
        {
            StrategyLinkId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RelatedSymbol.FixTag, out var relatedSymbol))
        {
            RelatedSymbol.Encode(pointer, current, relatedSymbol, out current);
        }
        else
        {
            RelatedSymbol.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TotNumTradeReports.FixTag, out var totNumTradeReports))
        {
            TotNumTradeReports.Encode(pointer, current, totNumTradeReports, out current);
        }
        else
        {
            TotNumTradeReports.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(NegotiationId.FixTag, out var negotiationId))
        {
            NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
        }
        else
        {
            NegotiationId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(SrqsRelatedTradeId.FixTag, out var srqsRelatedTradeId))
        {
            SrqsRelatedTradeId.Encode(pointer, current, (uint)srqsRelatedTradeId, out current);
        }
        else
        {
            SrqsRelatedTradeId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(BasketProfileId.FixTag, out var basketProfileId))
        {
            BasketProfileId.Encode(pointer, current, (uint)basketProfileId, out current);
        }
        else
        {
            BasketProfileId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(SecuritySubType.FixTag, out var securitySubType))
        {
            SecuritySubType.Encode(pointer, current, securitySubType, out current);
        }
        else
        {
            SecuritySubType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TrdType.FixTag, out var trdType))
        {
            TrdType.Encode(pointer, current, (ushort)trdType, out current);
        }
        else
        {
            TrdType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
        {
            ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
        }
        else
        {
            ProductComplex.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RelatedProductComplex.FixTag, out var relatedProductComplex))
        {
            RelatedProductComplex.Encode(pointer, current, (byte)relatedProductComplex, out current);
        }
        else
        {
            RelatedProductComplex.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(Side.FixTag, out var side))
        {
            Side.Encode(pointer, current, (byte)side, out current);
        }
        else
        {
            Side.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
        {
            TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
        }
        else
        {
            TradingCapacity.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
        {
            TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
        }
        else
        {
            TradeReportType.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TransferReason.FixTag, out var transferReason))
        {
            TransferReason.Encode(pointer, current, (byte)transferReason, out current);
        }
        else
        {
            TransferReason.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradePublishIndicator.FixTag, out var tradePublishIndicator))
        {
            TradePublishIndicator.Encode(pointer, current, (byte)tradePublishIndicator, out current);
        }
        else
        {
            TradePublishIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OptionalEarlyTerminationIndicator.FixTag, out var optionalEarlyTerminationIndicator))
        {
            OptionalEarlyTerminationIndicator.Encode(pointer, current, (byte)optionalEarlyTerminationIndicator, out current);
        }
        else
        {
            OptionalEarlyTerminationIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MultiLegReportingType.FixTag, out var multiLegReportingType))
        {
            MultiLegReportingType.Encode(pointer, current, (byte)multiLegReportingType, out current);
        }
        else
        {
            MultiLegReportingType.SetNull(pointer, current, out current);
        }

        var positionEffect = message.GetToken(PositionEffect.FixTag);
        PositionEffect.Encode(pointer, current, positionEffect, out current);

        if (message.TryGetInt(MultilegPriceModel.FixTag, out var multilegPriceModel))
        {
            MultilegPriceModel.Encode(pointer, current, (byte)multilegPriceModel, out current);
        }
        else
        {
            MultilegPriceModel.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
        {
            OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
        }
        else
        {
            OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrderAttributeRiskReduction.FixTag, out var orderAttributeRiskReduction))
        {
            OrderAttributeRiskReduction.Encode(pointer, current, (byte)orderAttributeRiskReduction, out current);
        }
        else
        {
            OrderAttributeRiskReduction.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExecutingTraderQualifier.FixTag, out var executingTraderQualifier))
        {
            ExecutingTraderQualifier.Encode(pointer, current, (byte)executingTraderQualifier, out current);
        }
        else
        {
            ExecutingTraderQualifier.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RootPartyIdInvestmentDecisionMakerQualifier.FixTag, out var rootPartyIdInvestmentDecisionMakerQualifier))
        {
            RootPartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, (byte)rootPartyIdInvestmentDecisionMakerQualifier, out current);
        }
        else
        {
            RootPartyIdInvestmentDecisionMakerQualifier.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrderOrigination.FixTag, out var orderOrigination))
        {
            OrderOrigination.Encode(pointer, current, (byte)orderOrigination, out current);
        }
        else
        {
            OrderOrigination.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ReversalIndicator.FixTag, out var reversalIndicator))
        {
            ReversalIndicator.Encode(pointer, current, (byte)reversalIndicator, out current);
        }
        else
        {
            ReversalIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeAggregationTransType.FixTag, out var tradeAggregationTransType))
        {
            TradeAggregationTransType.Encode(pointer, current, (byte)tradeAggregationTransType, out current);
        }
        else
        {
            TradeAggregationTransType.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(Account.FixTag, out var account))
        {
            Account.Encode(pointer, current, account, out current);
        }
        else
        {
            Account.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyIdPositionAccount.FixTag, out var rootPartyIdPositionAccount))
        {
            RootPartyIdPositionAccount.Encode(pointer, current, rootPartyIdPositionAccount, out current);
        }
        else
        {
            RootPartyIdPositionAccount.SetNull(pointer, current, out current);
        }

        var custOrderHandlingInst = message.GetToken(CustOrderHandlingInst.FixTag);
        CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

        if (message.TryGetString(FreeText1.FixTag, out var freeText1))
        {
            FreeText1.Encode(pointer, current, freeText1, out current);
        }
        else
        {
            FreeText1.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FreeText2.FixTag, out var freeText2))
        {
            FreeText2.Encode(pointer, current, freeText2, out current);
        }
        else
        {
            FreeText2.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FreeText3.FixTag, out var freeText3))
        {
            FreeText3.Encode(pointer, current, freeText3, out current);
        }
        else
        {
            FreeText3.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyExecutingFirm.FixTag, out var rootPartyExecutingFirm))
        {
            RootPartyExecutingFirm.Encode(pointer, current, rootPartyExecutingFirm, out current);
        }
        else
        {
            RootPartyExecutingFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyExecutingTrader.FixTag, out var rootPartyExecutingTrader))
        {
            RootPartyExecutingTrader.Encode(pointer, current, rootPartyExecutingTrader, out current);
        }
        else
        {
            RootPartyExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyClearingFirm.FixTag, out var rootPartyClearingFirm))
        {
            RootPartyClearingFirm.Encode(pointer, current, rootPartyClearingFirm, out current);
        }
        else
        {
            RootPartyClearingFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyClearingOrganization.FixTag, out var rootPartyClearingOrganization))
        {
            RootPartyClearingOrganization.Encode(pointer, current, rootPartyClearingOrganization, out current);
        }
        else
        {
            RootPartyClearingOrganization.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyIdBeneficiary.FixTag, out var rootPartyIdBeneficiary))
        {
            RootPartyIdBeneficiary.Encode(pointer, current, rootPartyIdBeneficiary, out current);
        }
        else
        {
            RootPartyIdBeneficiary.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyIdTakeUpTradingFirm.FixTag, out var rootPartyIdTakeUpTradingFirm))
        {
            RootPartyIdTakeUpTradingFirm.Encode(pointer, current, rootPartyIdTakeUpTradingFirm, out current);
        }
        else
        {
            RootPartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyIdOrderOriginationFirm.FixTag, out var rootPartyIdOrderOriginationFirm))
        {
            RootPartyIdOrderOriginationFirm.Encode(pointer, current, rootPartyIdOrderOriginationFirm, out current);
        }
        else
        {
            RootPartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RootPartyIdExecutionVenue.FixTag, out var rootPartyIdExecutionVenue))
        {
            RootPartyIdExecutionVenue.Encode(pointer, current, rootPartyIdExecutionVenue, out current);
        }
        else
        {
            RootPartyIdExecutionVenue.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(RegulatoryTradeId.FixTag, out var regulatoryTradeId))
        {
            RegulatoryTradeId.Encode(pointer, current, regulatoryTradeId, out current);
        }
        else
        {
            RegulatoryTradeId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(BasketPartyContraFirm.FixTag, out var basketPartyContraFirm))
        {
            BasketPartyContraFirm.Encode(pointer, current, basketPartyContraFirm, out current);
        }
        else
        {
            BasketPartyContraFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(BasketSideTradeReportId.FixTag, out var basketSideTradeReportId))
        {
            BasketSideTradeReportId.Encode(pointer, current, basketSideTradeReportId, out current);
        }
        else
        {
            BasketSideTradeReportId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(FeeIdntCode.FixTag, out var feeIdntCode))
        {
            FeeIdntCode.Encode(pointer, current, feeIdntCode, out current);
        }
        else
        {
            FeeIdntCode.SetNull(pointer, current, out current);
        }

        Pad4.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Tes Trade Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = TesTradeBroadcast.Identifier;

        // --- decode tes trade broadcast message ---

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

        if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
        {
            message.AppendLong(SecurityId.FixTag, securityId);
        }

        if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
        {
            message.AppendDouble(LastPx.FixTag, lastPx);
        }

        if (LastQty.TryDecode(pointer, current, out var lastQty, out current))
        {
            message.AppendDouble(LastQty.FixTag, lastQty);
        }

        if (ClearingTradePrice.TryDecode(pointer, current, out var clearingTradePrice, out current))
        {
            message.AppendDouble(ClearingTradePrice.FixTag, clearingTradePrice);
        }

        if (ClearingTradeQty.TryDecode(pointer, current, out var clearingTradeQty, out current))
        {
            message.AppendDouble(ClearingTradeQty.FixTag, clearingTradeQty);
        }

        if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
        {
            message.AppendULong(TransactTime.FixTag, transactTime);
        }

        if (RelatedSecurityId.TryDecode(pointer, current, out var relatedSecurityId, out current))
        {
            message.AppendLong(RelatedSecurityId.FixTag, relatedSecurityId);
        }

        if (RootPartyIdClientId.TryDecode(pointer, current, out var rootPartyIdClientId, out current))
        {
            message.AppendULong(RootPartyIdClientId.FixTag, rootPartyIdClientId);
        }

        if (ExecutingTrader.TryDecode(pointer, current, out var executingTrader, out current))
        {
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);
        }

        if (RootPartyIdInvestmentDecisionMaker.TryDecode(pointer, current, out var rootPartyIdInvestmentDecisionMaker, out current))
        {
            message.AppendULong(RootPartyIdInvestmentDecisionMaker.FixTag, rootPartyIdInvestmentDecisionMaker);
        }

        if (BasketTrdMatchId.TryDecode(pointer, current, out var basketTrdMatchId, out current))
        {
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);
        }

        if (OrigBasketTrdMatchId.TryDecode(pointer, current, out var origBasketTrdMatchId, out current))
        {
            message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);
        }

        if (SideLastPx.TryDecode(pointer, current, out var sideLastPx, out current))
        {
            message.AppendDouble(SideLastPx.FixTag, sideLastPx);
        }

        if (SideLastQty.TryDecode(pointer, current, out var sideLastQty, out current))
        {
            message.AppendDouble(SideLastQty.FixTag, sideLastQty);
        }

        if (RelatedClosePrice.TryDecode(pointer, current, out var relatedClosePrice, out current))
        {
            message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);
        }

        if (TesExecId.TryDecode(pointer, current, out var tesExecId, out current))
        {
            message.AppendInt(TesExecId.FixTag, (int)tesExecId);
        }

        if (PackageId.TryDecode(pointer, current, out var packageId, out current))
        {
            message.AppendInt(PackageId.FixTag, (int)packageId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (TradeId.TryDecode(pointer, current, out var tradeId, out current))
        {
            message.AppendInt(TradeId.FixTag, (int)tradeId);
        }

        if (TradeDate.TryDecode(pointer, current, out var tradeDate, out current))
        {
            message.AppendInt(TradeDate.FixTag, (int)tradeDate);
        }

        if (SideTradeId.TryDecode(pointer, current, out var sideTradeId, out current))
        {
            message.AppendInt(SideTradeId.FixTag, (int)sideTradeId);
        }

        if (RootPartyIdSessionId.TryDecode(pointer, current, out var rootPartyIdSessionId, out current))
        {
            message.AppendInt(RootPartyIdSessionId.FixTag, (int)rootPartyIdSessionId);
        }

        if (OrigTradeId.TryDecode(pointer, current, out var origTradeId, out current))
        {
            message.AppendInt(OrigTradeId.FixTag, (int)origTradeId);
        }

        if (RootPartyIdExecutingUnit.TryDecode(pointer, current, out var rootPartyIdExecutingUnit, out current))
        {
            message.AppendInt(RootPartyIdExecutingUnit.FixTag, (int)rootPartyIdExecutingUnit);
        }

        if (RootPartyIdExecutingTrader.TryDecode(pointer, current, out var rootPartyIdExecutingTrader, out current))
        {
            message.AppendInt(RootPartyIdExecutingTrader.FixTag, (int)rootPartyIdExecutingTrader);
        }

        if (RootPartyIdClearingUnit.TryDecode(pointer, current, out var rootPartyIdClearingUnit, out current))
        {
            message.AppendInt(RootPartyIdClearingUnit.FixTag, (int)rootPartyIdClearingUnit);
        }

        if (StrategyLinkId.TryDecode(pointer, current, out var strategyLinkId, out current))
        {
            message.AppendInt(StrategyLinkId.FixTag, (int)strategyLinkId);
        }

        if (RelatedSymbol.TryDecode(pointer, current, out var relatedSymbol, out current))
        {
            message.AppendInt(RelatedSymbol.FixTag, relatedSymbol);
        }

        if (TotNumTradeReports.TryDecode(pointer, current, out var totNumTradeReports, out current))
        {
            message.AppendInt(TotNumTradeReports.FixTag, totNumTradeReports);
        }

        if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
        {
            message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
        }

        if (SrqsRelatedTradeId.TryDecode(pointer, current, out var srqsRelatedTradeId, out current))
        {
            message.AppendInt(SrqsRelatedTradeId.FixTag, (int)srqsRelatedTradeId);
        }

        if (BasketProfileId.TryDecode(pointer, current, out var basketProfileId, out current))
        {
            message.AppendInt(BasketProfileId.FixTag, (int)basketProfileId);
        }

        if (SecuritySubType.TryDecode(pointer, current, out var securitySubType, out current))
        {
            message.AppendInt(SecuritySubType.FixTag, securitySubType);
        }

        if (TrdType.TryDecode(pointer, current, out var trdType, out current))
        {
            message.AppendInt(TrdType.FixTag, (short)trdType);
        }

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        if (RelatedProductComplex.TryDecode(pointer, current, out var relatedProductComplex, out current))
        {
            message.AppendInt(RelatedProductComplex.FixTag, relatedProductComplex);
        }

        if (Side.TryDecode(pointer, current, out var side, out current))
        {
            message.AppendInt(Side.FixTag, side);
        }

        if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
        {
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
        }

        if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
        {
            message.AppendInt(TradeReportType.FixTag, tradeReportType);
        }

        if (TransferReason.TryDecode(pointer, current, out var transferReason, out current))
        {
            message.AppendInt(TransferReason.FixTag, transferReason);
        }

        if (TradePublishIndicator.TryDecode(pointer, current, out var tradePublishIndicator, out current))
        {
            message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);
        }

        if (OptionalEarlyTerminationIndicator.TryDecode(pointer, current, out var optionalEarlyTerminationIndicator, out current))
        {
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);
        }

        if (MultiLegReportingType.TryDecode(pointer, current, out var multiLegReportingType, out current))
        {
            message.AppendInt(MultiLegReportingType.FixTag, multiLegReportingType);
        }

        var positionEffect = PositionEffect.Decode(pointer, current, out current);
        message.AppendToken(PositionEffect.FixTag, positionEffect);

        if (MultilegPriceModel.TryDecode(pointer, current, out var multilegPriceModel, out current))
        {
            message.AppendInt(MultilegPriceModel.FixTag, multilegPriceModel);
        }

        if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
        {
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
        }

        if (OrderAttributeRiskReduction.TryDecode(pointer, current, out var orderAttributeRiskReduction, out current))
        {
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);
        }

        if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
        {
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
        }

        if (RootPartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var rootPartyIdInvestmentDecisionMakerQualifier, out current))
        {
            message.AppendInt(RootPartyIdInvestmentDecisionMakerQualifier.FixTag, rootPartyIdInvestmentDecisionMakerQualifier);
        }

        if (OrderOrigination.TryDecode(pointer, current, out var orderOrigination, out current))
        {
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);
        }

        if (ReversalIndicator.TryDecode(pointer, current, out var reversalIndicator, out current))
        {
            message.AppendInt(ReversalIndicator.FixTag, reversalIndicator);
        }

        if (TradeAggregationTransType.TryDecode(pointer, current, out var tradeAggregationTransType, out current))
        {
            message.AppendInt(TradeAggregationTransType.FixTag, tradeAggregationTransType);
        }

        if (Account.TryDecode(pointer, current, out var account, out current))
        {
            message.AppendString(Account.FixTag, account);
        }

        if (RootPartyIdPositionAccount.TryDecode(pointer, current, out var rootPartyIdPositionAccount, out current))
        {
            message.AppendString(RootPartyIdPositionAccount.FixTag, rootPartyIdPositionAccount);
        }

        var custOrderHandlingInst = CustOrderHandlingInst.Decode(pointer, current, out current);
        message.AppendToken(CustOrderHandlingInst.FixTag, custOrderHandlingInst);

        if (FreeText1.TryDecode(pointer, current, out var freeText1, out current))
        {
            message.AppendString(FreeText1.FixTag, freeText1);
        }

        if (FreeText2.TryDecode(pointer, current, out var freeText2, out current))
        {
            message.AppendString(FreeText2.FixTag, freeText2);
        }

        if (FreeText3.TryDecode(pointer, current, out var freeText3, out current))
        {
            message.AppendString(FreeText3.FixTag, freeText3);
        }

        if (RootPartyExecutingFirm.TryDecode(pointer, current, out var rootPartyExecutingFirm, out current))
        {
            message.AppendString(RootPartyExecutingFirm.FixTag, rootPartyExecutingFirm);
        }

        if (RootPartyExecutingTrader.TryDecode(pointer, current, out var rootPartyExecutingTrader, out current))
        {
            message.AppendString(RootPartyExecutingTrader.FixTag, rootPartyExecutingTrader);
        }

        if (RootPartyClearingFirm.TryDecode(pointer, current, out var rootPartyClearingFirm, out current))
        {
            message.AppendString(RootPartyClearingFirm.FixTag, rootPartyClearingFirm);
        }

        if (RootPartyClearingOrganization.TryDecode(pointer, current, out var rootPartyClearingOrganization, out current))
        {
            message.AppendString(RootPartyClearingOrganization.FixTag, rootPartyClearingOrganization);
        }

        if (RootPartyIdBeneficiary.TryDecode(pointer, current, out var rootPartyIdBeneficiary, out current))
        {
            message.AppendString(RootPartyIdBeneficiary.FixTag, rootPartyIdBeneficiary);
        }

        if (RootPartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var rootPartyIdTakeUpTradingFirm, out current))
        {
            message.AppendString(RootPartyIdTakeUpTradingFirm.FixTag, rootPartyIdTakeUpTradingFirm);
        }

        if (RootPartyIdOrderOriginationFirm.TryDecode(pointer, current, out var rootPartyIdOrderOriginationFirm, out current))
        {
            message.AppendString(RootPartyIdOrderOriginationFirm.FixTag, rootPartyIdOrderOriginationFirm);
        }

        if (RootPartyIdExecutionVenue.TryDecode(pointer, current, out var rootPartyIdExecutionVenue, out current))
        {
            message.AppendString(RootPartyIdExecutionVenue.FixTag, rootPartyIdExecutionVenue);
        }

        if (RegulatoryTradeId.TryDecode(pointer, current, out var regulatoryTradeId, out current))
        {
            message.AppendString(RegulatoryTradeId.FixTag, regulatoryTradeId);
        }

        if (BasketPartyContraFirm.TryDecode(pointer, current, out var basketPartyContraFirm, out current))
        {
            message.AppendString(BasketPartyContraFirm.FixTag, basketPartyContraFirm);
        }

        if (BasketSideTradeReportId.TryDecode(pointer, current, out var basketSideTradeReportId, out current))
        {
            message.AppendString(BasketSideTradeReportId.FixTag, basketSideTradeReportId);
        }

        if (FeeIdntCode.TryDecode(pointer, current, out var feeIdntCode, out current))
        {
            message.AppendString(FeeIdntCode.FixTag, feeIdntCode);
        }

        current += Pad4.Length;

        return FixErrorCode.None;
    }
}
