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

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var underlyingPx = message.GetDouble(UnderlyingPx.FixTag);
            UnderlyingPx.Encode(pointer, current, underlyingPx, out current);

            var transBkdTime = message.GetULong(TransBkdTime.FixTag);
            TransBkdTime.Encode(pointer, current, transBkdTime, out current);

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

            var packageId = (uint)message.GetInt(PackageId.FixTag);
            PackageId.Encode(pointer, current, packageId, out current);

            var tesExecId = (uint)message.GetInt(TesExecId.FixTag);
            TesExecId.Encode(pointer, current, tesExecId, out current);

            var underlyingSettlementDate = (uint)message.GetInt(UnderlyingSettlementDate.FixTag);
            UnderlyingSettlementDate.Encode(pointer, current, underlyingSettlementDate, out current);

            var underlyingMaturityDate = (uint)message.GetInt(UnderlyingMaturityDate.FixTag);
            UnderlyingMaturityDate.Encode(pointer, current, underlyingMaturityDate, out current);

            var relatedTradeId = (uint)message.GetInt(RelatedTradeId.FixTag);
            RelatedTradeId.Encode(pointer, current, relatedTradeId, out current);

            var relatedMarketSegmentId = message.GetInt(RelatedMarketSegmentId.FixTag);
            RelatedMarketSegmentId.Encode(pointer, current, relatedMarketSegmentId, out current);

            var autoApprovalRuleId = (uint)message.GetInt(AutoApprovalRuleId.FixTag);
            AutoApprovalRuleId.Encode(pointer, current, autoApprovalRuleId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

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

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

            var trdRptStatus = (byte)message.GetInt(TrdRptStatus.FixTag);
            TrdRptStatus.Encode(pointer, current, trdRptStatus, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var tradePublishIndicator = (byte)message.GetInt(TradePublishIndicator.FixTag);
            TradePublishIndicator.Encode(pointer, current, tradePublishIndicator, out current);

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

            var partyIdSettlementLocation = (byte)message.GetInt(PartyIdSettlementLocation.FixTag);
            PartyIdSettlementLocation.Encode(pointer, current, partyIdSettlementLocation, out current);

            var hedgeType = (byte)message.GetInt(HedgeType.FixTag);
            HedgeType.Encode(pointer, current, hedgeType, out current);

            var swapClearer = (byte)message.GetInt(SwapClearer.FixTag);
            SwapClearer.Encode(pointer, current, swapClearer, out current);

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

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Tes Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = TesBroadcast.Identifier;

            // --- decode tes broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

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

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var underlyingPx = UnderlyingPx.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);

            var transBkdTime = TransBkdTime.Decode(pointer, current, out current);
            message.AppendULong(TransBkdTime.FixTag, transBkdTime);

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

            var packageId = (int)PackageId.Decode(pointer, current, out current);
            message.AppendInt(PackageId.FixTag, packageId);

            var tesExecId = (int)TesExecId.Decode(pointer, current, out current);
            message.AppendInt(TesExecId.FixTag, tesExecId);

            var underlyingSettlementDate = (int)UnderlyingSettlementDate.Decode(pointer, current, out current);
            message.AppendInt(UnderlyingSettlementDate.FixTag, underlyingSettlementDate);

            var underlyingMaturityDate = (int)UnderlyingMaturityDate.Decode(pointer, current, out current);
            message.AppendInt(UnderlyingMaturityDate.FixTag, underlyingMaturityDate);

            var relatedTradeId = (int)RelatedTradeId.Decode(pointer, current, out current);
            message.AppendInt(RelatedTradeId.FixTag, relatedTradeId);

            var relatedMarketSegmentId = RelatedMarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(RelatedMarketSegmentId.FixTag, relatedMarketSegmentId);

            var autoApprovalRuleId = (int)AutoApprovalRuleId.Decode(pointer, current, out current);
            message.AppendInt(AutoApprovalRuleId.FixTag, autoApprovalRuleId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var varTextLen = VarTextLen.Decode(pointer, current, out current);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var trdRptStatus = TrdRptStatus.Decode(pointer, current, out current);
            message.AppendInt(TrdRptStatus.FixTag, trdRptStatus);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var tradePublishIndicator = TradePublishIndicator.Decode(pointer, current, out current);
            message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);

            var noEvents = (int)NoEvents.Decode(pointer, current, out current);

            var noInstrAttrib = (int)NoInstrAttrib.Decode(pointer, current, out current);

            var noUnderlyingStips = (int)NoUnderlyingStips.Decode(pointer, current, out current);

            var noSideAllocs = (int)NoSideAllocs.Decode(pointer, current, out current);

            var noLegs = (int)NoLegs.Decode(pointer, current, out current);

            var noLegClearingPrices = (int)NoLegClearingPrices.Decode(pointer, current, out current);

            var partyIdSettlementLocation = PartyIdSettlementLocation.Decode(pointer, current, out current);
            message.AppendInt(PartyIdSettlementLocation.FixTag, partyIdSettlementLocation);

            var hedgeType = HedgeType.Decode(pointer, current, out current);
            message.AppendInt(HedgeType.FixTag, hedgeType);

            var swapClearer = SwapClearer.Decode(pointer, current, out current);
            message.AppendInt(SwapClearer.FixTag, swapClearer);

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

            return FixErrorCode.None;
        }
    }
}