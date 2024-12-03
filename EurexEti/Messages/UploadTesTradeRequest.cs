using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Upload Tes Trade Request Message Methods
    /// </summary>

    public partial class UploadTesTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Upload Tes Trade Request
        /// </summary>
        public const string Identifier = "Upload Tes Trade Request";

        /// <summary>
        ///  Encode Upload Tes Trade Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.UploadTesTradeRequest, out current);

            // --- encode upload tes trade request message ---

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

            var lastPx = message.GetDouble(LastPx.FixTag);
            LastPx.Encode(pointer, current, lastPx, out current);

            var transBkdTime = message.GetULong(TransBkdTime.FixTag);
            TransBkdTime.Encode(pointer, current, transBkdTime, out current);

            var underlyingPx = message.GetDouble(UnderlyingPx.FixTag);
            UnderlyingPx.Encode(pointer, current, underlyingPx, out current);

            var relatedClosePrice = message.GetDouble(RelatedClosePrice.FixTag);
            RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);

            var relatedTradeQuantity = message.GetDouble(RelatedTradeQuantity.FixTag);
            RelatedTradeQuantity.Encode(pointer, current, relatedTradeQuantity, out current);

            var relatedSecurityId = message.GetLong(RelatedSecurityId.FixTag);
            RelatedSecurityId.Encode(pointer, current, relatedSecurityId, out current);

            var relatedPx = message.GetDouble(RelatedPx.FixTag);
            RelatedPx.Encode(pointer, current, relatedPx, out current);

            var underlyingQty = message.GetDouble(UnderlyingQty.FixTag);
            UnderlyingQty.Encode(pointer, current, underlyingQty, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var underlyingSettlementDate = (uint)message.GetInt(UnderlyingSettlementDate.FixTag);
            UnderlyingSettlementDate.Encode(pointer, current, underlyingSettlementDate, out current);

            var underlyingMaturityDate = (uint)message.GetInt(UnderlyingMaturityDate.FixTag);
            UnderlyingMaturityDate.Encode(pointer, current, underlyingMaturityDate, out current);

            var relatedTradeId = (uint)message.GetInt(RelatedTradeId.FixTag);
            RelatedTradeId.Encode(pointer, current, relatedTradeId, out current);

            var relatedMarketSegmentId = message.GetInt(RelatedMarketSegmentId.FixTag);
            RelatedMarketSegmentId.Encode(pointer, current, relatedMarketSegmentId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

            var tradePublishIndicator = (byte)message.GetInt(TradePublishIndicator.FixTag);
            TradePublishIndicator.Encode(pointer, current, tradePublishIndicator, out current);

            var noSideAllocs = (byte)message.GetInt(NoSideAllocs.FixTag);
            NoSideAllocs.Encode(pointer, current, noSideAllocs, out current);

            var noLegs = (byte)message.GetInt(NoLegs.FixTag);
            NoLegs.Encode(pointer, current, noLegs, out current);

            var noEvents = (byte)message.GetInt(NoEvents.FixTag);
            NoEvents.Encode(pointer, current, noEvents, out current);

            var noInstrAttrib = (byte)message.GetInt(NoInstrAttrib.FixTag);
            NoInstrAttrib.Encode(pointer, current, noInstrAttrib, out current);

            var noUnderlyingStips = (byte)message.GetInt(NoUnderlyingStips.FixTag);
            NoUnderlyingStips.Encode(pointer, current, noUnderlyingStips, out current);

            var skipValidations = (byte)message.GetInt(SkipValidations.FixTag);
            SkipValidations.Encode(pointer, current, skipValidations, out current);

            var trdRptStatus = (byte)message.GetInt(TrdRptStatus.FixTag);
            TrdRptStatus.Encode(pointer, current, trdRptStatus, out current);

            var tradePlatform = (byte)message.GetInt(TradePlatform.FixTag);
            TradePlatform.Encode(pointer, current, tradePlatform, out current);

            var hedgeType = (byte)message.GetInt(HedgeType.FixTag);
            HedgeType.Encode(pointer, current, hedgeType, out current);

            var partyIdSettlementLocation = (byte)message.GetInt(PartyIdSettlementLocation.FixTag);
            PartyIdSettlementLocation.Encode(pointer, current, partyIdSettlementLocation, out current);

            var valueCheckTypeMinLotSize = (byte)message.GetInt(ValueCheckTypeMinLotSize.FixTag);
            ValueCheckTypeMinLotSize.Encode(pointer, current, valueCheckTypeMinLotSize, out current);

            if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
            {
                TradeReportId.Encode(pointer, current, tradeReportId, out current);
            }
            else
            {
                TradeReportId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(TradeReportText.FixTag, out var tradeReportText))
            {
                TradeReportText.Encode(pointer, current, tradeReportText, out current);
            }
            else
            {
                TradeReportText.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(UnderlyingSecurityId.FixTag, out var underlyingSecurityId))
            {
                UnderlyingSecurityId.Encode(pointer, current, underlyingSecurityId, out current);
            }
            else
            {
                UnderlyingSecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(UnderlyingSecurityDesc.FixTag, out var underlyingSecurityDesc))
            {
                UnderlyingSecurityDesc.Encode(pointer, current, underlyingSecurityDesc, out current);
            }
            else
            {
                UnderlyingSecurityDesc.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(UnderlyingCurrency.FixTag, out var underlyingCurrency))
            {
                UnderlyingCurrency.Encode(pointer, current, underlyingCurrency, out current);
            }
            else
            {
                UnderlyingCurrency.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(UnderlyingIssuer.FixTag, out var underlyingIssuer))
            {
                UnderlyingIssuer.Encode(pointer, current, underlyingIssuer, out current);
            }
            else
            {
                UnderlyingIssuer.SetNull(pointer, current, out current);
            }

            var swapClearer = (byte)message.GetInt(SwapClearer.FixTag);
            SwapClearer.Encode(pointer, current, swapClearer, out current);

            var allocQty = group.GetDouble(AllocQty.FixTag);
            AllocQty.Encode(pointer, current, allocQty, out current);

            var partyIdClientId = group.GetULong(PartyIdClientId.FixTag);
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);

            var partyIdInvestmentDecisionMaker = group.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

            var executingTrader = group.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

            var individualAllocId = (uint)group.GetInt(IndividualAllocId.FixTag);
            IndividualAllocId.Encode(pointer, current, individualAllocId, out current);

            if (group.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
            {
                PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
            }
            else
            {
                PartyExecutingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
            {
                PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
            }
            else
            {
                PartyExecutingTrader.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            var tesEnrichmentRuleId = (uint)group.GetInt(TesEnrichmentRuleId.FixTag);
            TesEnrichmentRuleId.Encode(pointer, current, tesEnrichmentRuleId, out current);

            var side = (byte)group.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var tradeAllocStatus = (byte)group.GetInt(TradeAllocStatus.FixTag);
            TradeAllocStatus.Encode(pointer, current, tradeAllocStatus, out current);

            var tradingCapacity = (byte)group.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var positionEffect = group.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            var orderAttributeLiquidityProvision = (byte)group.GetInt(OrderAttributeLiquidityProvision.FixTag);
            OrderAttributeLiquidityProvision.Encode(pointer, current, orderAttributeLiquidityProvision, out current);

            var executingTraderQualifier = (byte)group.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

            var partyIdInvestmentDecisionMakerQualifier = (byte)group.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

            var orderAttributeRiskReduction = (byte)group.GetInt(OrderAttributeRiskReduction.FixTag);
            OrderAttributeRiskReduction.Encode(pointer, current, orderAttributeRiskReduction, out current);

            var orderOrigination = (byte)group.GetInt(OrderOrigination.FixTag);
            OrderOrigination.Encode(pointer, current, orderOrigination, out current);

            if (group.TryGetString(Account.FixTag, out var account))
            {
                Account.Encode(pointer, current, account, out current);
            }
            else
            {
                Account.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
            {
                PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
            }
            else
            {
                PartyIdPositionAccount.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
            {
                PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
            }
            else
            {
                PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText1.FixTag, out var freeText1))
            {
                FreeText1.Encode(pointer, current, freeText1, out current);
            }
            else
            {
                FreeText1.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText2.FixTag, out var freeText2))
            {
                FreeText2.Encode(pointer, current, freeText2, out current);
            }
            else
            {
                FreeText2.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText3.FixTag, out var freeText3))
            {
                FreeText3.Encode(pointer, current, freeText3, out current);
            }
            else
            {
                FreeText3.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
            {
                PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
            }
            else
            {
                PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
            {
                PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
            }
            else
            {
                PartyIdBeneficiary.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdLocationId.FixTag, out var partyIdLocationId))
            {
                PartyIdLocationId.Encode(pointer, current, partyIdLocationId, out current);
            }
            else
            {
                PartyIdLocationId.SetNull(pointer, current, out current);
            }

            var custOrderHandlingInst = group.GetToken(CustOrderHandlingInst.FixTag);
            CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

            if (group.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyEndClientIdentification.FixTag, out var partyEndClientIdentification))
            {
                PartyEndClientIdentification.Encode(pointer, current, partyEndClientIdentification, out current);
            }
            else
            {
                PartyEndClientIdentification.SetNull(pointer, current, out current);
            }

            Pad5.Encode(pointer, current, out current);

            var legSecurityId = group.GetLong(LegSecurityId.FixTag);
            LegSecurityId.Encode(pointer, current, legSecurityId, out current);

            var legPrice = group.GetDouble(LegPrice.FixTag);
            LegPrice.Encode(pointer, current, legPrice, out current);

            var legQty = group.GetDouble(LegQty.FixTag);
            LegQty.Encode(pointer, current, legQty, out current);

            var eventDate = (uint)group.GetInt(EventDate.FixTag);
            EventDate.Encode(pointer, current, eventDate, out current);

            var eventType = (byte)group.GetInt(EventType.FixTag);
            EventType.Encode(pointer, current, eventType, out current);

            Pad3.Encode(pointer, current, out current);

            var instrAttribType = (byte)group.GetInt(InstrAttribType.FixTag);
            InstrAttribType.Encode(pointer, current, instrAttribType, out current);

            if (group.TryGetString(InstrAttribValue.FixTag, out var instrAttribValue))
            {
                InstrAttribValue.Encode(pointer, current, instrAttribValue, out current);
            }
            else
            {
                InstrAttribValue.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            if (group.TryGetString(UnderlyingStipValue.FixTag, out var underlyingStipValue))
            {
                UnderlyingStipValue.Encode(pointer, current, underlyingStipValue, out current);
            }
            else
            {
                UnderlyingStipValue.SetNull(pointer, current, out current);
            }

            if (group.TryGetToken(UnderlyingStipType.FixTag, out var underlyingStipType))
            {
                UnderlyingStipType.Encode(pointer, current, underlyingStipType, out current);
            }
            else
            {
                UnderlyingStipType.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Upload Tes Trade Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = UploadTesTradeRequest.Identifier;

            // --- decode upload tes trade request message ---

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

            var lastPx = LastPx.Decode(pointer, current, out current);
            message.AppendDouble(LastPx.FixTag, lastPx);

            var transBkdTime = TransBkdTime.Decode(pointer, current, out current);
            message.AppendULong(TransBkdTime.FixTag, transBkdTime);

            var underlyingPx = UnderlyingPx.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);

            var relatedClosePrice = RelatedClosePrice.Decode(pointer, current, out current);
            message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);

            var relatedTradeQuantity = RelatedTradeQuantity.Decode(pointer, current, out current);
            message.AppendDouble(RelatedTradeQuantity.FixTag, relatedTradeQuantity);

            var relatedSecurityId = RelatedSecurityId.Decode(pointer, current, out current);
            message.AppendLong(RelatedSecurityId.FixTag, relatedSecurityId);

            var relatedPx = RelatedPx.Decode(pointer, current, out current);
            message.AppendDouble(RelatedPx.FixTag, relatedPx);

            var underlyingQty = UnderlyingQty.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingQty.FixTag, underlyingQty);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var underlyingSettlementDate = (int)UnderlyingSettlementDate.Decode(pointer, current, out current);
            message.AppendInt(UnderlyingSettlementDate.FixTag, underlyingSettlementDate);

            var underlyingMaturityDate = (int)UnderlyingMaturityDate.Decode(pointer, current, out current);
            message.AppendInt(UnderlyingMaturityDate.FixTag, underlyingMaturityDate);

            var relatedTradeId = (int)RelatedTradeId.Decode(pointer, current, out current);
            message.AppendInt(RelatedTradeId.FixTag, relatedTradeId);

            var relatedMarketSegmentId = RelatedMarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(RelatedMarketSegmentId.FixTag, relatedMarketSegmentId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var tradePublishIndicator = TradePublishIndicator.Decode(pointer, current, out current);
            message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);

            var noSideAllocs = NoSideAllocs.Decode(pointer, current, out current);
            message.AppendInt(NoSideAllocs.FixTag, noSideAllocs);

            var noLegs = NoLegs.Decode(pointer, current, out current);
            message.AppendInt(NoLegs.FixTag, noLegs);

            var noEvents = NoEvents.Decode(pointer, current, out current);
            message.AppendInt(NoEvents.FixTag, noEvents);

            var noInstrAttrib = NoInstrAttrib.Decode(pointer, current, out current);
            message.AppendInt(NoInstrAttrib.FixTag, noInstrAttrib);

            var noUnderlyingStips = NoUnderlyingStips.Decode(pointer, current, out current);
            message.AppendInt(NoUnderlyingStips.FixTag, noUnderlyingStips);

            var skipValidations = SkipValidations.Decode(pointer, current, out current);
            message.AppendInt(SkipValidations.FixTag, skipValidations);

            var trdRptStatus = TrdRptStatus.Decode(pointer, current, out current);
            message.AppendInt(TrdRptStatus.FixTag, trdRptStatus);

            var tradePlatform = TradePlatform.Decode(pointer, current, out current);
            message.AppendInt(TradePlatform.FixTag, tradePlatform);

            var hedgeType = HedgeType.Decode(pointer, current, out current);
            message.AppendInt(HedgeType.FixTag, hedgeType);

            var partyIdSettlementLocation = PartyIdSettlementLocation.Decode(pointer, current, out current);
            message.AppendInt(PartyIdSettlementLocation.FixTag, partyIdSettlementLocation);

            var valueCheckTypeMinLotSize = ValueCheckTypeMinLotSize.Decode(pointer, current, out current);
            message.AppendInt(ValueCheckTypeMinLotSize.FixTag, valueCheckTypeMinLotSize);

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            if (TradeReportText.TryDecode(pointer, current, out var tradeReportText, out current))
            {
                message.AppendString(TradeReportText.FixTag, tradeReportText);
            }

            if (UnderlyingSecurityId.TryDecode(pointer, current, out var underlyingSecurityId, out current))
            {
                message.AppendString(UnderlyingSecurityId.FixTag, underlyingSecurityId);
            }

            if (UnderlyingSecurityDesc.TryDecode(pointer, current, out var underlyingSecurityDesc, out current))
            {
                message.AppendString(UnderlyingSecurityDesc.FixTag, underlyingSecurityDesc);
            }

            if (UnderlyingCurrency.TryDecode(pointer, current, out var underlyingCurrency, out current))
            {
                message.AppendString(UnderlyingCurrency.FixTag, underlyingCurrency);
            }

            if (UnderlyingIssuer.TryDecode(pointer, current, out var underlyingIssuer, out current))
            {
                message.AppendString(UnderlyingIssuer.FixTag, underlyingIssuer);
            }

            var swapClearer = SwapClearer.Decode(pointer, current, out current);
            message.AppendInt(SwapClearer.FixTag, swapClearer);

            var allocQty = AllocQty.Decode(pointer, current, out current);
            message.AppendDouble(AllocQty.FixTag, allocQty);

            var partyIdClientId = PartyIdClientId.Decode(pointer, current, out current);
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);

            var partyIdInvestmentDecisionMaker = PartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

            var individualAllocId = (int)IndividualAllocId.Decode(pointer, current, out current);
            message.AppendInt(IndividualAllocId.FixTag, individualAllocId);

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
            }

            current += Pad1.Length;

            var tesEnrichmentRuleId = (int)TesEnrichmentRuleId.Decode(pointer, current, out current);
            message.AppendInt(TesEnrichmentRuleId.FixTag, tesEnrichmentRuleId);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var tradeAllocStatus = TradeAllocStatus.Decode(pointer, current, out current);
            message.AppendInt(TradeAllocStatus.FixTag, tradeAllocStatus);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            var orderAttributeLiquidityProvision = OrderAttributeLiquidityProvision.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

            var partyIdInvestmentDecisionMakerQualifier = PartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);

            var orderAttributeRiskReduction = OrderAttributeRiskReduction.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);

            var orderOrigination = OrderOrigination.Decode(pointer, current, out current);
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
            }

            if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
            {
                message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
            }

            if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
            {
                message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
            }

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

            if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
            {
                message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
            }

            if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
            {
                message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
            }

            if (PartyIdLocationId.TryDecode(pointer, current, out var partyIdLocationId, out current))
            {
                message.AppendString(PartyIdLocationId.FixTag, partyIdLocationId);
            }

            var custOrderHandlingInst = CustOrderHandlingInst.Decode(pointer, current, out current);
            message.AppendToken(CustOrderHandlingInst.FixTag, custOrderHandlingInst);

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            if (PartyEndClientIdentification.TryDecode(pointer, current, out var partyEndClientIdentification, out current))
            {
                message.AppendString(PartyEndClientIdentification.FixTag, partyEndClientIdentification);
            }

            current += Pad5.Length;

            var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
            message.AppendLong(LegSecurityId.FixTag, legSecurityId);

            var legPrice = LegPrice.Decode(pointer, current, out current);
            message.AppendDouble(LegPrice.FixTag, legPrice);

            var legQty = LegQty.Decode(pointer, current, out current);
            message.AppendDouble(LegQty.FixTag, legQty);

            var eventDate = (int)EventDate.Decode(pointer, current, out current);
            message.AppendInt(EventDate.FixTag, eventDate);

            var eventType = EventType.Decode(pointer, current, out current);
            message.AppendInt(EventType.FixTag, eventType);

            current += Pad3.Length;

            var instrAttribType = InstrAttribType.Decode(pointer, current, out current);
            message.AppendInt(InstrAttribType.FixTag, instrAttribType);

            if (InstrAttribValue.TryDecode(pointer, current, out var instrAttribValue, out current))
            {
                message.AppendString(InstrAttribValue.FixTag, instrAttribValue);
            }

            current += Pad7.Length;

            if (UnderlyingStipValue.TryDecode(pointer, current, out var underlyingStipValue, out current))
            {
                message.AppendString(UnderlyingStipValue.FixTag, underlyingStipValue);
            }

            if (UnderlyingStipType.TryDecode(pointer, current, out var underlyingStipType, out current))
            {
                message.AppendToken(UnderlyingStipType.FixTag, underlyingStipType);
            }

            current += Pad1.Length;

            return FixErrorCode.None;
        }
    }
}