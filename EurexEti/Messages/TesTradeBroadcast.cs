using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Tes Trade Broadcast Message Methods
    /// </summary>

    public partial class TesTradeBroadcast
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

            var sendingTime = message.sendTime.Ticks;
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

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var lastPx = message.GetDouble(LastPx.FixTag);
            LastPx.Encode(pointer, current, lastPx, out current);

            var lastQty = message.GetDouble(LastQty.FixTag);
            LastQty.Encode(pointer, current, lastQty, out current);

            var clearingTradePrice = message.GetDouble(ClearingTradePrice.FixTag);
            ClearingTradePrice.Encode(pointer, current, clearingTradePrice, out current);

            var clearingTradeQty = message.GetDouble(ClearingTradeQty.FixTag);
            ClearingTradeQty.Encode(pointer, current, clearingTradeQty, out current);

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var relatedSecurityId = message.GetLong(RelatedSecurityId.FixTag);
            RelatedSecurityId.Encode(pointer, current, relatedSecurityId, out current);

            var rootPartyIdClientId = message.GetULong(RootPartyIdClientId.FixTag);
            RootPartyIdClientId.Encode(pointer, current, rootPartyIdClientId, out current);

            var executingTrader = message.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

            var rootPartyIdInvestmentDecisionMaker = message.GetULong(RootPartyIdInvestmentDecisionMaker.FixTag);
            RootPartyIdInvestmentDecisionMaker.Encode(pointer, current, rootPartyIdInvestmentDecisionMaker, out current);

            var basketTrdMatchId = message.GetULong(BasketTrdMatchId.FixTag);
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);

            var origBasketTrdMatchId = message.GetULong(OrigBasketTrdMatchId.FixTag);
            OrigBasketTrdMatchId.Encode(pointer, current, origBasketTrdMatchId, out current);

            var sideLastPx = message.GetDouble(SideLastPx.FixTag);
            SideLastPx.Encode(pointer, current, sideLastPx, out current);

            var sideLastQty = message.GetDouble(SideLastQty.FixTag);
            SideLastQty.Encode(pointer, current, sideLastQty, out current);

            var relatedClosePrice = message.GetDouble(RelatedClosePrice.FixTag);
            RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);

            var tesExecId = (uint)message.GetInt(TesExecId.FixTag);
            TesExecId.Encode(pointer, current, tesExecId, out current);

            var packageId = (uint)message.GetInt(PackageId.FixTag);
            PackageId.Encode(pointer, current, packageId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var tradeId = (uint)message.GetInt(TradeId.FixTag);
            TradeId.Encode(pointer, current, tradeId, out current);

            var tradeDate = (uint)message.GetInt(TradeDate.FixTag);
            TradeDate.Encode(pointer, current, tradeDate, out current);

            var sideTradeId = (uint)message.GetInt(SideTradeId.FixTag);
            SideTradeId.Encode(pointer, current, sideTradeId, out current);

            var rootPartyIdSessionId = (uint)message.GetInt(RootPartyIdSessionId.FixTag);
            RootPartyIdSessionId.Encode(pointer, current, rootPartyIdSessionId, out current);

            var origTradeId = (uint)message.GetInt(OrigTradeId.FixTag);
            OrigTradeId.Encode(pointer, current, origTradeId, out current);

            var rootPartyIdExecutingUnit = (uint)message.GetInt(RootPartyIdExecutingUnit.FixTag);
            RootPartyIdExecutingUnit.Encode(pointer, current, rootPartyIdExecutingUnit, out current);

            var rootPartyIdExecutingTrader = (uint)message.GetInt(RootPartyIdExecutingTrader.FixTag);
            RootPartyIdExecutingTrader.Encode(pointer, current, rootPartyIdExecutingTrader, out current);

            var rootPartyIdClearingUnit = (uint)message.GetInt(RootPartyIdClearingUnit.FixTag);
            RootPartyIdClearingUnit.Encode(pointer, current, rootPartyIdClearingUnit, out current);

            var strategyLinkId = (uint)message.GetInt(StrategyLinkId.FixTag);
            StrategyLinkId.Encode(pointer, current, strategyLinkId, out current);

            var relatedSymbol = message.GetInt(RelatedSymbol.FixTag);
            RelatedSymbol.Encode(pointer, current, relatedSymbol, out current);

            var totNumTradeReports = message.GetInt(TotNumTradeReports.FixTag);
            TotNumTradeReports.Encode(pointer, current, totNumTradeReports, out current);

            var negotiationId = (uint)message.GetInt(NegotiationId.FixTag);
            NegotiationId.Encode(pointer, current, negotiationId, out current);

            var srqsRelatedTradeId = (uint)message.GetInt(SrqsRelatedTradeId.FixTag);
            SrqsRelatedTradeId.Encode(pointer, current, srqsRelatedTradeId, out current);

            var basketProfileId = (uint)message.GetInt(BasketProfileId.FixTag);
            BasketProfileId.Encode(pointer, current, basketProfileId, out current);

            var securitySubType = message.GetInt(SecuritySubType.FixTag);
            SecuritySubType.Encode(pointer, current, securitySubType, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var relatedProductComplex = (byte)message.GetInt(RelatedProductComplex.FixTag);
            RelatedProductComplex.Encode(pointer, current, relatedProductComplex, out current);

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var tradingCapacity = (byte)message.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

            var transferReason = (byte)message.GetInt(TransferReason.FixTag);
            TransferReason.Encode(pointer, current, transferReason, out current);

            var tradePublishIndicator = (byte)message.GetInt(TradePublishIndicator.FixTag);
            TradePublishIndicator.Encode(pointer, current, tradePublishIndicator, out current);

            var optionalEarlyTerminationIndicator = (byte)message.GetInt(OptionalEarlyTerminationIndicator.FixTag);
            OptionalEarlyTerminationIndicator.Encode(pointer, current, optionalEarlyTerminationIndicator, out current);

            var multiLegReportingType = (byte)message.GetInt(MultiLegReportingType.FixTag);
            MultiLegReportingType.Encode(pointer, current, multiLegReportingType, out current);

            var positionEffect = message.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            var multilegPriceModel = (byte)message.GetInt(MultilegPriceModel.FixTag);
            MultilegPriceModel.Encode(pointer, current, multilegPriceModel, out current);

            var orderAttributeLiquidityProvision = (byte)message.GetInt(OrderAttributeLiquidityProvision.FixTag);
            OrderAttributeLiquidityProvision.Encode(pointer, current, orderAttributeLiquidityProvision, out current);

            var orderAttributeRiskReduction = (byte)message.GetInt(OrderAttributeRiskReduction.FixTag);
            OrderAttributeRiskReduction.Encode(pointer, current, orderAttributeRiskReduction, out current);

            var executingTraderQualifier = (byte)message.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

            var rootPartyIdInvestmentDecisionMakerQualifier = (byte)message.GetInt(RootPartyIdInvestmentDecisionMakerQualifier.FixTag);
            RootPartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, rootPartyIdInvestmentDecisionMakerQualifier, out current);

            var orderOrigination = (byte)message.GetInt(OrderOrigination.FixTag);
            OrderOrigination.Encode(pointer, current, orderOrigination, out current);

            var reversalIndicator = (byte)message.GetInt(ReversalIndicator.FixTag);
            ReversalIndicator.Encode(pointer, current, reversalIndicator, out current);

            var tradeAggregationTransType = (byte)message.GetInt(TradeAggregationTransType.FixTag);
            TradeAggregationTransType.Encode(pointer, current, tradeAggregationTransType, out current);

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
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = TesTradeBroadcast.Identifier;

            // --- decode tes trade broadcast message ---

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

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var lastPx = LastPx.Decode(pointer, current, out current);
            message.AppendDouble(LastPx.FixTag, lastPx);

            var lastQty = LastQty.Decode(pointer, current, out current);
            message.AppendDouble(LastQty.FixTag, lastQty);

            var clearingTradePrice = ClearingTradePrice.Decode(pointer, current, out current);
            message.AppendDouble(ClearingTradePrice.FixTag, clearingTradePrice);

            var clearingTradeQty = ClearingTradeQty.Decode(pointer, current, out current);
            message.AppendDouble(ClearingTradeQty.FixTag, clearingTradeQty);

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var relatedSecurityId = RelatedSecurityId.Decode(pointer, current, out current);
            message.AppendLong(RelatedSecurityId.FixTag, relatedSecurityId);

            var rootPartyIdClientId = RootPartyIdClientId.Decode(pointer, current, out current);
            message.AppendULong(RootPartyIdClientId.FixTag, rootPartyIdClientId);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

            var rootPartyIdInvestmentDecisionMaker = RootPartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(RootPartyIdInvestmentDecisionMaker.FixTag, rootPartyIdInvestmentDecisionMaker);

            var basketTrdMatchId = BasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);

            var origBasketTrdMatchId = OrigBasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(OrigBasketTrdMatchId.FixTag, origBasketTrdMatchId);

            var sideLastPx = SideLastPx.Decode(pointer, current, out current);
            message.AppendDouble(SideLastPx.FixTag, sideLastPx);

            var sideLastQty = SideLastQty.Decode(pointer, current, out current);
            message.AppendDouble(SideLastQty.FixTag, sideLastQty);

            var relatedClosePrice = RelatedClosePrice.Decode(pointer, current, out current);
            message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);

            var tesExecId = (int)TesExecId.Decode(pointer, current, out current);
            message.AppendInt(TesExecId.FixTag, tesExecId);

            var packageId = (int)PackageId.Decode(pointer, current, out current);
            message.AppendInt(PackageId.FixTag, packageId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var tradeId = (int)TradeId.Decode(pointer, current, out current);
            message.AppendInt(TradeId.FixTag, tradeId);

            var tradeDate = (int)TradeDate.Decode(pointer, current, out current);
            message.AppendInt(TradeDate.FixTag, tradeDate);

            var sideTradeId = (int)SideTradeId.Decode(pointer, current, out current);
            message.AppendInt(SideTradeId.FixTag, sideTradeId);

            var rootPartyIdSessionId = (int)RootPartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(RootPartyIdSessionId.FixTag, rootPartyIdSessionId);

            var origTradeId = (int)OrigTradeId.Decode(pointer, current, out current);
            message.AppendInt(OrigTradeId.FixTag, origTradeId);

            var rootPartyIdExecutingUnit = (int)RootPartyIdExecutingUnit.Decode(pointer, current, out current);
            message.AppendInt(RootPartyIdExecutingUnit.FixTag, rootPartyIdExecutingUnit);

            var rootPartyIdExecutingTrader = (int)RootPartyIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(RootPartyIdExecutingTrader.FixTag, rootPartyIdExecutingTrader);

            var rootPartyIdClearingUnit = (int)RootPartyIdClearingUnit.Decode(pointer, current, out current);
            message.AppendInt(RootPartyIdClearingUnit.FixTag, rootPartyIdClearingUnit);

            var strategyLinkId = (int)StrategyLinkId.Decode(pointer, current, out current);
            message.AppendInt(StrategyLinkId.FixTag, strategyLinkId);

            var relatedSymbol = RelatedSymbol.Decode(pointer, current, out current);
            message.AppendInt(RelatedSymbol.FixTag, relatedSymbol);

            var totNumTradeReports = TotNumTradeReports.Decode(pointer, current, out current);
            message.AppendInt(TotNumTradeReports.FixTag, totNumTradeReports);

            var negotiationId = (int)NegotiationId.Decode(pointer, current, out current);
            message.AppendInt(NegotiationId.FixTag, negotiationId);

            var srqsRelatedTradeId = (int)SrqsRelatedTradeId.Decode(pointer, current, out current);
            message.AppendInt(SrqsRelatedTradeId.FixTag, srqsRelatedTradeId);

            var basketProfileId = (int)BasketProfileId.Decode(pointer, current, out current);
            message.AppendInt(BasketProfileId.FixTag, basketProfileId);

            var securitySubType = SecuritySubType.Decode(pointer, current, out current);
            message.AppendInt(SecuritySubType.FixTag, securitySubType);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var relatedProductComplex = RelatedProductComplex.Decode(pointer, current, out current);
            message.AppendInt(RelatedProductComplex.FixTag, relatedProductComplex);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var transferReason = TransferReason.Decode(pointer, current, out current);
            message.AppendInt(TransferReason.FixTag, transferReason);

            var tradePublishIndicator = TradePublishIndicator.Decode(pointer, current, out current);
            message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);

            var optionalEarlyTerminationIndicator = OptionalEarlyTerminationIndicator.Decode(pointer, current, out current);
            message.AppendInt(OptionalEarlyTerminationIndicator.FixTag, optionalEarlyTerminationIndicator);

            var multiLegReportingType = MultiLegReportingType.Decode(pointer, current, out current);
            message.AppendInt(MultiLegReportingType.FixTag, multiLegReportingType);

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            var multilegPriceModel = MultilegPriceModel.Decode(pointer, current, out current);
            message.AppendInt(MultilegPriceModel.FixTag, multilegPriceModel);

            var orderAttributeLiquidityProvision = OrderAttributeLiquidityProvision.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);

            var orderAttributeRiskReduction = OrderAttributeRiskReduction.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

            var rootPartyIdInvestmentDecisionMakerQualifier = RootPartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(RootPartyIdInvestmentDecisionMakerQualifier.FixTag, rootPartyIdInvestmentDecisionMakerQualifier);

            var orderOrigination = OrderOrigination.Decode(pointer, current, out current);
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);

            var reversalIndicator = ReversalIndicator.Decode(pointer, current, out current);
            message.AppendInt(ReversalIndicator.FixTag, reversalIndicator);

            var tradeAggregationTransType = TradeAggregationTransType.Decode(pointer, current, out current);
            message.AppendInt(TradeAggregationTransType.FixTag, tradeAggregationTransType);

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
}