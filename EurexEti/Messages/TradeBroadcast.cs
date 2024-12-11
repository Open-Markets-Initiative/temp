using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade Broadcast Message Methods
    /// </summary>

    public static partial class TradeBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Trade Broadcast
        /// </summary>
        public const string Identifier = "10500";

        /// <summary>
        ///  Encode Trade Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.TradeBroadcast, out current);

            // --- encode trade broadcast message ---

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

            if (message.TryGetLong(RelatedSecurityId.FixTag, out var relatedSecurityId))
            {
                RelatedSecurityId.Encode(pointer, current, relatedSecurityId, out current);
            }
            else
            {
                RelatedSecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(Price.FixTag, out var price))
            {
                Price.Encode(pointer, current, price, out current);
            }
            else
            {
                Price.SetNull(pointer, current, out current);
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

            if (message.TryGetULong(OrderId.FixTag, out var orderId))
            {
                OrderId.Encode(pointer, current, orderId, out current);
            }
            else
            {
                OrderId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ClOrdId.FixTag, out var clOrdId))
            {
                ClOrdId.Encode(pointer, current, clOrdId, out current);
            }
            else
            {
                ClOrdId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(LeavesQty.FixTag, out var leavesQty))
            {
                LeavesQty.Encode(pointer, current, leavesQty, out current);
            }
            else
            {
                LeavesQty.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(CumQty.FixTag, out var cumQty))
            {
                CumQty.Encode(pointer, current, cumQty, out current);
            }
            else
            {
                CumQty.SetNull(pointer, current, out current);
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

            if (message.TryGetDouble(UnderlyingPx.FixTag, out var underlyingPx))
            {
                UnderlyingPx.Encode(pointer, current, underlyingPx, out current);
            }
            else
            {
                UnderlyingPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradeId.FixTag, out var tradeId))
            {
                TradeId.Encode(pointer, current, (uint)tradeId, out current);
            }
            else
            {
                TradeId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OrigTradeId.FixTag, out var origTradeId))
            {
                OrigTradeId.Encode(pointer, current, (uint)origTradeId, out current);
            }
            else
            {
                OrigTradeId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MassOrderReportId.FixTag, out var massOrderReportId))
            {
                MassOrderReportId.Encode(pointer, current, (uint)massOrderReportId, out current);
            }
            else
            {
                MassOrderReportId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RootPartyIdExecutingUnit.FixTag, out var rootPartyIdExecutingUnit))
            {
                RootPartyIdExecutingUnit.Encode(pointer, current, (uint)rootPartyIdExecutingUnit, out current);
            }
            else
            {
                RootPartyIdExecutingUnit.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RootPartyIdSessionId.FixTag, out var rootPartyIdSessionId))
            {
                RootPartyIdSessionId.Encode(pointer, current, (uint)rootPartyIdSessionId, out current);
            }
            else
            {
                RootPartyIdSessionId.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RelatedSymbol.FixTag, out var relatedSymbol))
            {
                RelatedSymbol.Encode(pointer, current, relatedSymbol, out current);
            }
            else
            {
                RelatedSymbol.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SideTradeId.FixTag, out var sideTradeId))
            {
                SideTradeId.Encode(pointer, current, (uint)sideTradeId, out current);
            }
            else
            {
                SideTradeId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MatchDate.FixTag, out var matchDate))
            {
                MatchDate.Encode(pointer, current, (uint)matchDate, out current);
            }
            else
            {
                MatchDate.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TrdMatchId.FixTag, out var trdMatchId))
            {
                TrdMatchId.Encode(pointer, current, (uint)trdMatchId, out current);
            }
            else
            {
                TrdMatchId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(StrategyLinkId.FixTag, out var strategyLinkId))
            {
                StrategyLinkId.Encode(pointer, current, (uint)strategyLinkId, out current);
            }
            else
            {
                StrategyLinkId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TotNumTradeReports.FixTag, out var totNumTradeReports))
            {
                TotNumTradeReports.Encode(pointer, current, totNumTradeReports, out current);
            }
            else
            {
                TotNumTradeReports.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SecuritySubType.FixTag, out var securitySubType))
            {
                SecuritySubType.Encode(pointer, current, securitySubType, out current);
            }
            else
            {
                SecuritySubType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MultiLegReportingType.FixTag, out var multiLegReportingType))
            {
                MultiLegReportingType.Encode(pointer, current, (byte)multiLegReportingType, out current);
            }
            else
            {
                MultiLegReportingType.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(MatchType.FixTag, out var matchType))
            {
                MatchType.Encode(pointer, current, (byte)matchType, out current);
            }
            else
            {
                MatchType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MatchSubType.FixTag, out var matchSubType))
            {
                MatchSubType.Encode(pointer, current, (byte)matchSubType, out current);
            }
            else
            {
                MatchSubType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(Side.FixTag, out var side))
            {
                Side.Encode(pointer, current, (byte)side, out current);
            }
            else
            {
                Side.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SideLiquidityInd.FixTag, out var sideLiquidityInd))
            {
                SideLiquidityInd.Encode(pointer, current, (byte)sideLiquidityInd, out current);
            }
            else
            {
                SideLiquidityInd.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
            {
                TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
            }
            else
            {
                TradingCapacity.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OrderOrigination.FixTag, out var orderOrigination))
            {
                OrderOrigination.Encode(pointer, current, (byte)orderOrigination, out current);
            }
            else
            {
                OrderOrigination.SetNull(pointer, current, out current);
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

            var positionEffect = message.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

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

            var orderCategory = message.GetToken(OrderCategory.FixTag);
            OrderCategory.Encode(pointer, current, orderCategory, out current);

            if (message.TryGetInt(OrdType.FixTag, out var ordType))
            {
                OrdType.Encode(pointer, current, (byte)ordType, out current);
            }
            else
            {
                OrdType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RelatedProductComplex.FixTag, out var relatedProductComplex))
            {
                RelatedProductComplex.Encode(pointer, current, (byte)relatedProductComplex, out current);
            }
            else
            {
                RelatedProductComplex.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OrderSide.FixTag, out var orderSide))
            {
                OrderSide.Encode(pointer, current, (byte)orderSide, out current);
            }
            else
            {
                OrderSide.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(RootPartyClearingOrganization.FixTag, out var rootPartyClearingOrganization))
            {
                RootPartyClearingOrganization.Encode(pointer, current, rootPartyClearingOrganization, out current);
            }
            else
            {
                RootPartyClearingOrganization.SetNull(pointer, current, out current);
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

            if (message.TryGetString(RegulatoryTradeId.FixTag, out var regulatoryTradeId))
            {
                RegulatoryTradeId.Encode(pointer, current, regulatoryTradeId, out current);
            }
            else
            {
                RegulatoryTradeId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(RootPartyIdExecutionVenue.FixTag, out var rootPartyIdExecutionVenue))
            {
                RootPartyIdExecutionVenue.Encode(pointer, current, rootPartyIdExecutionVenue, out current);
            }
            else
            {
                RootPartyIdExecutionVenue.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FeeIdntCode.FixTag, out var feeIdntCode))
            {
                FeeIdntCode.Encode(pointer, current, feeIdntCode, out current);
            }
            else
            {
                FeeIdntCode.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Trade Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = TradeBroadcast.Identifier;

            // --- decode trade broadcast message ---

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

            if (RelatedSecurityId.TryDecode(pointer, current, out var relatedSecurityId, out current))
            {
                message.AppendLong(RelatedSecurityId.FixTag, relatedSecurityId);
            }

            if (Price.TryDecode(pointer, current, out var price, out current))
            {
                message.AppendDouble(Price.FixTag, price);
            }

            if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
            {
                message.AppendDouble(LastPx.FixTag, lastPx);
            }

            if (LastQty.TryDecode(pointer, current, out var lastQty, out current))
            {
                message.AppendDouble(LastQty.FixTag, lastQty);
            }

            if (SideLastPx.TryDecode(pointer, current, out var sideLastPx, out current))
            {
                message.AppendDouble(SideLastPx.FixTag, sideLastPx);
            }

            if (SideLastQty.TryDecode(pointer, current, out var sideLastQty, out current))
            {
                message.AppendDouble(SideLastQty.FixTag, sideLastQty);
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

            if (OrderId.TryDecode(pointer, current, out var orderId, out current))
            {
                message.AppendULong(OrderId.FixTag, orderId);
            }

            if (ClOrdId.TryDecode(pointer, current, out var clOrdId, out current))
            {
                message.AppendULong(ClOrdId.FixTag, clOrdId);
            }

            if (LeavesQty.TryDecode(pointer, current, out var leavesQty, out current))
            {
                message.AppendDouble(LeavesQty.FixTag, leavesQty);
            }

            if (CumQty.TryDecode(pointer, current, out var cumQty, out current))
            {
                message.AppendDouble(CumQty.FixTag, cumQty);
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

            if (UnderlyingPx.TryDecode(pointer, current, out var underlyingPx, out current))
            {
                message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);
            }

            if (TradeId.TryDecode(pointer, current, out var tradeId, out current))
            {
                message.AppendInt(TradeId.FixTag, (int)tradeId);
            }

            if (OrigTradeId.TryDecode(pointer, current, out var origTradeId, out current))
            {
                message.AppendInt(OrigTradeId.FixTag, (int)origTradeId);
            }

            if (MassOrderReportId.TryDecode(pointer, current, out var massOrderReportId, out current))
            {
                message.AppendInt(MassOrderReportId.FixTag, (int)massOrderReportId);
            }

            if (RootPartyIdExecutingUnit.TryDecode(pointer, current, out var rootPartyIdExecutingUnit, out current))
            {
                message.AppendInt(RootPartyIdExecutingUnit.FixTag, (int)rootPartyIdExecutingUnit);
            }

            if (RootPartyIdSessionId.TryDecode(pointer, current, out var rootPartyIdSessionId, out current))
            {
                message.AppendInt(RootPartyIdSessionId.FixTag, (int)rootPartyIdSessionId);
            }

            if (RootPartyIdExecutingTrader.TryDecode(pointer, current, out var rootPartyIdExecutingTrader, out current))
            {
                message.AppendInt(RootPartyIdExecutingTrader.FixTag, (int)rootPartyIdExecutingTrader);
            }

            if (RootPartyIdClearingUnit.TryDecode(pointer, current, out var rootPartyIdClearingUnit, out current))
            {
                message.AppendInt(RootPartyIdClearingUnit.FixTag, (int)rootPartyIdClearingUnit);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (RelatedSymbol.TryDecode(pointer, current, out var relatedSymbol, out current))
            {
                message.AppendInt(RelatedSymbol.FixTag, relatedSymbol);
            }

            if (SideTradeId.TryDecode(pointer, current, out var sideTradeId, out current))
            {
                message.AppendInt(SideTradeId.FixTag, (int)sideTradeId);
            }

            if (MatchDate.TryDecode(pointer, current, out var matchDate, out current))
            {
                message.AppendInt(MatchDate.FixTag, (int)matchDate);
            }

            if (TrdMatchId.TryDecode(pointer, current, out var trdMatchId, out current))
            {
                message.AppendInt(TrdMatchId.FixTag, (int)trdMatchId);
            }

            if (StrategyLinkId.TryDecode(pointer, current, out var strategyLinkId, out current))
            {
                message.AppendInt(StrategyLinkId.FixTag, (int)strategyLinkId);
            }

            if (TotNumTradeReports.TryDecode(pointer, current, out var totNumTradeReports, out current))
            {
                message.AppendInt(TotNumTradeReports.FixTag, totNumTradeReports);
            }

            if (SecuritySubType.TryDecode(pointer, current, out var securitySubType, out current))
            {
                message.AppendInt(SecuritySubType.FixTag, securitySubType);
            }

            if (MultiLegReportingType.TryDecode(pointer, current, out var multiLegReportingType, out current))
            {
                message.AppendInt(MultiLegReportingType.FixTag, multiLegReportingType);
            }

            if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
            {
                message.AppendInt(TradeReportType.FixTag, tradeReportType);
            }

            if (TransferReason.TryDecode(pointer, current, out var transferReason, out current))
            {
                message.AppendInt(TransferReason.FixTag, transferReason);
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

            if (MatchType.TryDecode(pointer, current, out var matchType, out current))
            {
                message.AppendInt(MatchType.FixTag, matchType);
            }

            if (MatchSubType.TryDecode(pointer, current, out var matchSubType, out current))
            {
                message.AppendInt(MatchSubType.FixTag, matchSubType);
            }

            if (Side.TryDecode(pointer, current, out var side, out current))
            {
                message.AppendInt(Side.FixTag, side);
            }

            if (SideLiquidityInd.TryDecode(pointer, current, out var sideLiquidityInd, out current))
            {
                message.AppendInt(SideLiquidityInd.FixTag, sideLiquidityInd);
            }

            if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
            {
                message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
            }

            if (OrderOrigination.TryDecode(pointer, current, out var orderOrigination, out current))
            {
                message.AppendInt(OrderOrigination.FixTag, orderOrigination);
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

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
            }

            if (RootPartyIdPositionAccount.TryDecode(pointer, current, out var rootPartyIdPositionAccount, out current))
            {
                message.AppendString(RootPartyIdPositionAccount.FixTag, rootPartyIdPositionAccount);
            }

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

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

            var orderCategory = OrderCategory.Decode(pointer, current, out current);
            message.AppendToken(OrderCategory.FixTag, orderCategory);

            if (OrdType.TryDecode(pointer, current, out var ordType, out current))
            {
                message.AppendInt(OrdType.FixTag, ordType);
            }

            if (RelatedProductComplex.TryDecode(pointer, current, out var relatedProductComplex, out current))
            {
                message.AppendInt(RelatedProductComplex.FixTag, relatedProductComplex);
            }

            if (OrderSide.TryDecode(pointer, current, out var orderSide, out current))
            {
                message.AppendInt(OrderSide.FixTag, orderSide);
            }

            if (RootPartyClearingOrganization.TryDecode(pointer, current, out var rootPartyClearingOrganization, out current))
            {
                message.AppendString(RootPartyClearingOrganization.FixTag, rootPartyClearingOrganization);
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

            if (RegulatoryTradeId.TryDecode(pointer, current, out var regulatoryTradeId, out current))
            {
                message.AppendString(RegulatoryTradeId.FixTag, regulatoryTradeId);
            }

            if (RootPartyIdExecutionVenue.TryDecode(pointer, current, out var rootPartyIdExecutionVenue, out current))
            {
                message.AppendString(RootPartyIdExecutionVenue.FixTag, rootPartyIdExecutionVenue);
            }

            if (FeeIdntCode.TryDecode(pointer, current, out var feeIdntCode, out current))
            {
                message.AppendString(FeeIdntCode.FixTag, feeIdntCode);
            }

            current += Pad3.Length;

            return FixErrorCode.None;
        }
    }
}