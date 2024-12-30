using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Tes Broadcast Message Methods
    /// </summary>

    public static partial class TesBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Tes Broadcast
        /// </summary>
        public const string Identifier = "10604";

        /// <summary>
        ///  Encode Tes Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.TesBroadcast, out current);

            // --- encode tes broadcast message ---

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

            if (message.TryGetULong(TransactTime.FixTag, out var transactTime))
            {
                TransactTime.Encode(pointer, current, transactTime, out current);
            }
            else
            {
                TransactTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(UnderlyingPx.FixTag, out var underlyingPx))
            {
                UnderlyingPx.Encode(pointer, current, underlyingPx, out current);
            }
            else
            {
                UnderlyingPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(TransBkdTime.FixTag, out var transBkdTime))
            {
                TransBkdTime.Encode(pointer, current, transBkdTime, out current);
            }
            else
            {
                TransBkdTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(RelatedClosePrice.FixTag, out var relatedClosePrice))
            {
                RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);
            }
            else
            {
                RelatedClosePrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(RelatedTradeQuantity.FixTag, out var relatedTradeQuantity))
            {
                RelatedTradeQuantity.Encode(pointer, current, relatedTradeQuantity, out current);
            }
            else
            {
                RelatedTradeQuantity.SetNull(pointer, current, out current);
            }

            if (message.TryGetLong(RelatedSecurityId.FixTag, out var relatedSecurityId))
            {
                RelatedSecurityId.Encode(pointer, current, relatedSecurityId, out current);
            }
            else
            {
                RelatedSecurityId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(RelatedPx.FixTag, out var relatedPx))
            {
                RelatedPx.Encode(pointer, current, relatedPx, out current);
            }
            else
            {
                RelatedPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(UnderlyingQty.FixTag, out var underlyingQty))
            {
                UnderlyingQty.Encode(pointer, current, underlyingQty, out current);
            }
            else
            {
                UnderlyingQty.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PackageId.FixTag, out var packageId))
            {
                PackageId.Encode(pointer, current, (uint)packageId, out current);
            }
            else
            {
                PackageId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TesExecId.FixTag, out var tesExecId))
            {
                TesExecId.Encode(pointer, current, (uint)tesExecId, out current);
            }
            else
            {
                TesExecId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(UnderlyingSettlementDate.FixTag, out var underlyingSettlementDate))
            {
                UnderlyingSettlementDate.Encode(pointer, current, (uint)underlyingSettlementDate, out current);
            }
            else
            {
                UnderlyingSettlementDate.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(UnderlyingMaturityDate.FixTag, out var underlyingMaturityDate))
            {
                UnderlyingMaturityDate.Encode(pointer, current, (uint)underlyingMaturityDate, out current);
            }
            else
            {
                UnderlyingMaturityDate.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RelatedTradeId.FixTag, out var relatedTradeId))
            {
                RelatedTradeId.Encode(pointer, current, (uint)relatedTradeId, out current);
            }
            else
            {
                RelatedTradeId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RelatedMarketSegmentId.FixTag, out var relatedMarketSegmentId))
            {
                RelatedMarketSegmentId.Encode(pointer, current, relatedMarketSegmentId, out current);
            }
            else
            {
                RelatedMarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(AutoApprovalRuleId.FixTag, out var autoApprovalRuleId))
            {
                AutoApprovalRuleId.Encode(pointer, current, (uint)autoApprovalRuleId, out current);
            }
            else
            {
                AutoApprovalRuleId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TrdType.FixTag, out var trdType))
            {
                TrdType.Encode(pointer, current, (ushort)trdType, out current);
            }
            else
            {
                TrdType.SetNull(pointer, current, out current);
            }

            var isVarText = message.TryGetString(VarText.FixTag, out var varText);
            if (isVarText)
            {
                var varTextLen = (ushort)varText.Length;
                VarTextLen.Encode(pointer, current, varTextLen, out current);
            }
            else
            {
                VarTextLen.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
            {
                TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
            }
            else
            {
                TradeReportType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TrdRptStatus.FixTag, out var trdRptStatus))
            {
                TrdRptStatus.Encode(pointer, current, (byte)trdRptStatus, out current);
            }
            else
            {
                TrdRptStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
            {
                ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
            }
            else
            {
                ProductComplex.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradePublishIndicator.FixTag, out var tradePublishIndicator))
            {
                TradePublishIndicator.Encode(pointer, current, (byte)tradePublishIndicator, out current);
            }
            else
            {
                TradePublishIndicator.SetNull(pointer, current, out current);
            }

            var isInstrumentEventGrpComp = message.TryGetGroup(NoEvents.FixTag, out var instrumentEventGrpComp) && instrumentEventGrpComp.sectionList.Count > 0;
            if (isInstrumentEventGrpComp)
            {
                var noEvents = (byte)instrumentEventGrpComp.sectionList.Count;
                NoEvents.Encode(pointer, current, noEvents, out current);
            }
            else
            {
                NoEvents.Zero(pointer, current, out current);
            }

            var isInstrumentAttributeGrpComp = message.TryGetGroup(NoInstrAttrib.FixTag, out var instrumentAttributeGrpComp) && instrumentAttributeGrpComp.sectionList.Count > 0;
            if (isInstrumentAttributeGrpComp)
            {
                var noInstrAttrib = (byte)instrumentAttributeGrpComp.sectionList.Count;
                NoInstrAttrib.Encode(pointer, current, noInstrAttrib, out current);
            }
            else
            {
                NoInstrAttrib.Zero(pointer, current, out current);
            }

            var isUnderlyingStipGrpComp = message.TryGetGroup(NoUnderlyingStips.FixTag, out var underlyingStipGrpComp) && underlyingStipGrpComp.sectionList.Count > 0;
            if (isUnderlyingStipGrpComp)
            {
                var noUnderlyingStips = (byte)underlyingStipGrpComp.sectionList.Count;
                NoUnderlyingStips.Encode(pointer, current, noUnderlyingStips, out current);
            }
            else
            {
                NoUnderlyingStips.Zero(pointer, current, out current);
            }

            var isSideAllocGrpBcComp = message.TryGetGroup(NoSideAllocs.FixTag, out var sideAllocGrpBcComp) && sideAllocGrpBcComp.sectionList.Count > 0;
            if (isSideAllocGrpBcComp)
            {
                var noSideAllocs = (byte)sideAllocGrpBcComp.sectionList.Count;
                NoSideAllocs.Encode(pointer, current, noSideAllocs, out current);
            }
            else
            {
                NoSideAllocs.Zero(pointer, current, out current);
            }

            var isTrdInstrmntLegGrpComp = message.TryGetGroup(NoLegs.FixTag, out var trdInstrmntLegGrpComp) && trdInstrmntLegGrpComp.sectionList.Count > 0;
            if (isTrdInstrmntLegGrpComp)
            {
                var noLegs = (byte)trdInstrmntLegGrpComp.sectionList.Count;
                NoLegs.Encode(pointer, current, noLegs, out current);
            }
            else
            {
                NoLegs.Zero(pointer, current, out current);
            }

            var isTrdClearingPriceLegGrpComp = message.TryGetGroup(NoLegClearingPrices.FixTag, out var trdClearingPriceLegGrpComp) && trdClearingPriceLegGrpComp.sectionList.Count > 0;
            if (isTrdClearingPriceLegGrpComp)
            {
                var noLegClearingPrices = (byte)trdClearingPriceLegGrpComp.sectionList.Count;
                NoLegClearingPrices.Encode(pointer, current, noLegClearingPrices, out current);
            }
            else
            {
                NoLegClearingPrices.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdSettlementLocation.FixTag, out var partyIdSettlementLocation))
            {
                PartyIdSettlementLocation.Encode(pointer, current, (byte)partyIdSettlementLocation, out current);
            }
            else
            {
                PartyIdSettlementLocation.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(HedgeType.FixTag, out var hedgeType))
            {
                HedgeType.Encode(pointer, current, (byte)hedgeType, out current);
            }
            else
            {
                HedgeType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SwapClearer.FixTag, out var swapClearer))
            {
                SwapClearer.Encode(pointer, current, (byte)swapClearer, out current);
            }
            else
            {
                SwapClearer.SetNull(pointer, current, out current);
            }

            var messageEventSource = message.GetToken(MessageEventSource.FixTag);
            MessageEventSource.Encode(pointer, current, messageEventSource, out current);

            if (message.TryGetString(TradeReportText.FixTag, out var tradeReportText))
            {
                TradeReportText.Encode(pointer, current, tradeReportText, out current);
            }
            else
            {
                TradeReportText.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
            {
                TradeReportId.Encode(pointer, current, tradeReportId, out current);
            }
            else
            {
                TradeReportId.SetNull(pointer, current, out current);
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

            if (isSideAllocGrpBcComp)
            {
                SideAllocGrpBcComp.Encode(pointer, current, sideAllocGrpBcComp, out current);
            }

            if (isTrdInstrmntLegGrpComp)
            {
                TrdInstrmntLegGrpComp.Encode(pointer, current, trdInstrmntLegGrpComp, out current);
            }

            if (isInstrumentEventGrpComp)
            {
                InstrumentEventGrpComp.Encode(pointer, current, instrumentEventGrpComp, out current);
            }

            if (isTrdClearingPriceLegGrpComp)
            {
                TrdClearingPriceLegGrpComp.Encode(pointer, current, trdClearingPriceLegGrpComp, out current);
            }

            if (isInstrumentAttributeGrpComp)
            {
                InstrumentAttributeGrpComp.Encode(pointer, current, instrumentAttributeGrpComp, out current);
            }

            if (isUnderlyingStipGrpComp)
            {
                UnderlyingStipGrpComp.Encode(pointer, current, underlyingStipGrpComp, out current);
            }

            if (isVarText)
            {
                VarText.Encode(pointer, current, varText, out current);
            }

            var alignment = (current - offset) % 8;
            if (alignment != 0)
            {
                AlignmentPadding.Encode(pointer, current, alignment, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Tes Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = TesBroadcast.Identifier;

            // --- decode tes broadcast message ---

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

            if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
            {
                message.AppendULong(TransactTime.FixTag, transactTime);
            }

            if (UnderlyingPx.TryDecode(pointer, current, out var underlyingPx, out current))
            {
                message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);
            }

            if (TransBkdTime.TryDecode(pointer, current, out var transBkdTime, out current))
            {
                message.AppendULong(TransBkdTime.FixTag, transBkdTime);
            }

            if (RelatedClosePrice.TryDecode(pointer, current, out var relatedClosePrice, out current))
            {
                message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);
            }

            if (RelatedTradeQuantity.TryDecode(pointer, current, out var relatedTradeQuantity, out current))
            {
                message.AppendDouble(RelatedTradeQuantity.FixTag, relatedTradeQuantity);
            }

            if (RelatedSecurityId.TryDecode(pointer, current, out var relatedSecurityId, out current))
            {
                message.AppendLong(RelatedSecurityId.FixTag, relatedSecurityId);
            }

            if (RelatedPx.TryDecode(pointer, current, out var relatedPx, out current))
            {
                message.AppendDouble(RelatedPx.FixTag, relatedPx);
            }

            if (UnderlyingQty.TryDecode(pointer, current, out var underlyingQty, out current))
            {
                message.AppendDouble(UnderlyingQty.FixTag, underlyingQty);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (PackageId.TryDecode(pointer, current, out var packageId, out current))
            {
                message.AppendInt(PackageId.FixTag, (int)packageId);
            }

            if (TesExecId.TryDecode(pointer, current, out var tesExecId, out current))
            {
                message.AppendInt(TesExecId.FixTag, (int)tesExecId);
            }

            if (UnderlyingSettlementDate.TryDecode(pointer, current, out var underlyingSettlementDate, out current))
            {
                message.AppendInt(UnderlyingSettlementDate.FixTag, (int)underlyingSettlementDate);
            }

            if (UnderlyingMaturityDate.TryDecode(pointer, current, out var underlyingMaturityDate, out current))
            {
                message.AppendInt(UnderlyingMaturityDate.FixTag, (int)underlyingMaturityDate);
            }

            if (RelatedTradeId.TryDecode(pointer, current, out var relatedTradeId, out current))
            {
                message.AppendInt(RelatedTradeId.FixTag, (int)relatedTradeId);
            }

            if (RelatedMarketSegmentId.TryDecode(pointer, current, out var relatedMarketSegmentId, out current))
            {
                message.AppendInt(RelatedMarketSegmentId.FixTag, relatedMarketSegmentId);
            }

            if (AutoApprovalRuleId.TryDecode(pointer, current, out var autoApprovalRuleId, out current))
            {
                message.AppendInt(AutoApprovalRuleId.FixTag, (int)autoApprovalRuleId);
            }

            if (TrdType.TryDecode(pointer, current, out var trdType, out current))
            {
                message.AppendInt(TrdType.FixTag, (short)trdType);
            }

            var varTextLen = VarTextLen.Decode(pointer, current, out current);

            if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
            {
                message.AppendInt(TradeReportType.FixTag, tradeReportType);
            }

            if (TrdRptStatus.TryDecode(pointer, current, out var trdRptStatus, out current))
            {
                message.AppendInt(TrdRptStatus.FixTag, trdRptStatus);
            }

            if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
            {
                message.AppendInt(ProductComplex.FixTag, productComplex);
            }

            if (TradePublishIndicator.TryDecode(pointer, current, out var tradePublishIndicator, out current))
            {
                message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);
            }

            var noEvents = (int)NoEvents.Decode(pointer, current, out current);

            var noInstrAttrib = (int)NoInstrAttrib.Decode(pointer, current, out current);

            var noUnderlyingStips = (int)NoUnderlyingStips.Decode(pointer, current, out current);

            var noSideAllocs = (int)NoSideAllocs.Decode(pointer, current, out current);

            var noLegs = (int)NoLegs.Decode(pointer, current, out current);

            var noLegClearingPrices = (int)NoLegClearingPrices.Decode(pointer, current, out current);

            if (PartyIdSettlementLocation.TryDecode(pointer, current, out var partyIdSettlementLocation, out current))
            {
                message.AppendInt(PartyIdSettlementLocation.FixTag, partyIdSettlementLocation);
            }

            if (HedgeType.TryDecode(pointer, current, out var hedgeType, out current))
            {
                message.AppendInt(HedgeType.FixTag, hedgeType);
            }

            if (SwapClearer.TryDecode(pointer, current, out var swapClearer, out current))
            {
                message.AppendInt(SwapClearer.FixTag, swapClearer);
            }

            var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
            message.AppendToken(MessageEventSource.FixTag, messageEventSource);

            if (TradeReportText.TryDecode(pointer, current, out var tradeReportText, out current))
            {
                message.AppendString(TradeReportText.FixTag, tradeReportText);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            if (RootPartyExecutingFirm.TryDecode(pointer, current, out var rootPartyExecutingFirm, out current))
            {
                message.AppendString(RootPartyExecutingFirm.FixTag, rootPartyExecutingFirm);
            }

            if (RootPartyExecutingTrader.TryDecode(pointer, current, out var rootPartyExecutingTrader, out current))
            {
                message.AppendString(RootPartyExecutingTrader.FixTag, rootPartyExecutingTrader);
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

            SideAllocGrpBcComp.Decode(ref message, pointer, current, noSideAllocs, out current);

            TrdInstrmntLegGrpComp.Decode(ref message, pointer, current, noLegs, out current);

            InstrumentEventGrpComp.Decode(ref message, pointer, current, noEvents, out current);

            TrdClearingPriceLegGrpComp.Decode(ref message, pointer, current, noLegClearingPrices, out current);

            InstrumentAttributeGrpComp.Decode(ref message, pointer, current, noInstrAttrib, out current);

            UnderlyingStipGrpComp.Decode(ref message, pointer, current, noUnderlyingStips, out current);

            if (VarText.TryDecode(pointer, current, varTextLen, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            if (length != (current - offset))
            {
                current = offset + length;
            }

            return FixErrorCode.None;
        }
    }
}