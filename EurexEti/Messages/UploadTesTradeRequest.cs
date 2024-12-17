using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Upload Tes Trade Request Message Methods
    /// </summary>

    public static partial class UploadTesTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Upload Tes Trade Request
        /// </summary>
        public const string Identifier = "10612";

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

            if (message.TryGetULong(TransBkdTime.FixTag, out var transBkdTime))
            {
                TransBkdTime.Encode(pointer, current, transBkdTime, out current);
            }
            else
            {
                TransBkdTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(UnderlyingPx.FixTag, out var underlyingPx))
            {
                UnderlyingPx.Encode(pointer, current, underlyingPx, out current);
            }
            else
            {
                UnderlyingPx.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(TradeReportType.FixTag, out var tradeReportType))
            {
                TradeReportType.Encode(pointer, current, (byte)tradeReportType, out current);
            }
            else
            {
                TradeReportType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradePublishIndicator.FixTag, out var tradePublishIndicator))
            {
                TradePublishIndicator.Encode(pointer, current, (byte)tradePublishIndicator, out current);
            }
            else
            {
                TradePublishIndicator.SetNull(pointer, current, out current);
            }

            var isSideAllocExtGrpComp = message.TryGetGroup(NoSideAllocs.FixTag, out var sideAllocExtGrpComp) && sideAllocExtGrpComp.sectionList.Count > 0;
            if (isSideAllocExtGrpComp)
            {
                var noSideAllocs = (byte)sideAllocExtGrpComp.sectionList.Count;
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

            if (message.TryGetInt(SkipValidations.FixTag, out var skipValidations))
            {
                SkipValidations.Encode(pointer, current, (byte)skipValidations, out current);
            }
            else
            {
                SkipValidations.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TrdRptStatus.FixTag, out var trdRptStatus))
            {
                TrdRptStatus.Encode(pointer, current, (byte)trdRptStatus, out current);
            }
            else
            {
                TrdRptStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradePlatform.FixTag, out var tradePlatform))
            {
                TradePlatform.Encode(pointer, current, (byte)tradePlatform, out current);
            }
            else
            {
                TradePlatform.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(HedgeType.FixTag, out var hedgeType))
            {
                HedgeType.Encode(pointer, current, (byte)hedgeType, out current);
            }
            else
            {
                HedgeType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdSettlementLocation.FixTag, out var partyIdSettlementLocation))
            {
                PartyIdSettlementLocation.Encode(pointer, current, (byte)partyIdSettlementLocation, out current);
            }
            else
            {
                PartyIdSettlementLocation.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ValueCheckTypeMinLotSize.FixTag, out var valueCheckTypeMinLotSize))
            {
                ValueCheckTypeMinLotSize.Encode(pointer, current, (byte)valueCheckTypeMinLotSize, out current);
            }
            else
            {
                ValueCheckTypeMinLotSize.SetNull(pointer, current, out current);
            }

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

            if (message.TryGetInt(SwapClearer.FixTag, out var swapClearer))
            {
                SwapClearer.Encode(pointer, current, (byte)swapClearer, out current);
            }
            else
            {
                SwapClearer.SetNull(pointer, current, out current);
            }

            if (isSideAllocExtGrpComp)
            {
                SideAllocExtGrpComp.Encode(pointer, current, sideAllocExtGrpComp, out current);
            }

            if (isTrdInstrmntLegGrpComp)
            {
                TrdInstrmntLegGrpComp.Encode(pointer, current, trdInstrmntLegGrpComp, out current);
            }

            if (isInstrumentEventGrpComp)
            {
                InstrumentEventGrpComp.Encode(pointer, current, instrumentEventGrpComp, out current);
            }

            if (isInstrumentAttributeGrpComp)
            {
                InstrumentAttributeGrpComp.Encode(pointer, current, instrumentAttributeGrpComp, out current);
            }

            if (isUnderlyingStipGrpComp)
            {
                UnderlyingStipGrpComp.Encode(pointer, current, underlyingStipGrpComp, out current);
            }

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

            if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
            {
                message.AppendDouble(LastPx.FixTag, lastPx);
            }

            if (TransBkdTime.TryDecode(pointer, current, out var transBkdTime, out current))
            {
                message.AppendULong(TransBkdTime.FixTag, transBkdTime);
            }

            if (UnderlyingPx.TryDecode(pointer, current, out var underlyingPx, out current))
            {
                message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);
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

            if (TrdType.TryDecode(pointer, current, out var trdType, out current))
            {
                message.AppendInt(TrdType.FixTag, (short)trdType);
            }

            if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
            {
                message.AppendInt(ProductComplex.FixTag, productComplex);
            }

            if (TradeReportType.TryDecode(pointer, current, out var tradeReportType, out current))
            {
                message.AppendInt(TradeReportType.FixTag, tradeReportType);
            }

            if (TradePublishIndicator.TryDecode(pointer, current, out var tradePublishIndicator, out current))
            {
                message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);
            }

            var noSideAllocs = (int)NoSideAllocs.Decode(pointer, current, out current);

            var noLegs = (int)NoLegs.Decode(pointer, current, out current);

            var noEvents = (int)NoEvents.Decode(pointer, current, out current);

            var noInstrAttrib = (int)NoInstrAttrib.Decode(pointer, current, out current);

            var noUnderlyingStips = (int)NoUnderlyingStips.Decode(pointer, current, out current);

            if (SkipValidations.TryDecode(pointer, current, out var skipValidations, out current))
            {
                message.AppendInt(SkipValidations.FixTag, skipValidations);
            }

            if (TrdRptStatus.TryDecode(pointer, current, out var trdRptStatus, out current))
            {
                message.AppendInt(TrdRptStatus.FixTag, trdRptStatus);
            }

            if (TradePlatform.TryDecode(pointer, current, out var tradePlatform, out current))
            {
                message.AppendInt(TradePlatform.FixTag, tradePlatform);
            }

            if (HedgeType.TryDecode(pointer, current, out var hedgeType, out current))
            {
                message.AppendInt(HedgeType.FixTag, hedgeType);
            }

            if (PartyIdSettlementLocation.TryDecode(pointer, current, out var partyIdSettlementLocation, out current))
            {
                message.AppendInt(PartyIdSettlementLocation.FixTag, partyIdSettlementLocation);
            }

            if (ValueCheckTypeMinLotSize.TryDecode(pointer, current, out var valueCheckTypeMinLotSize, out current))
            {
                message.AppendInt(ValueCheckTypeMinLotSize.FixTag, valueCheckTypeMinLotSize);
            }

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

            if (SwapClearer.TryDecode(pointer, current, out var swapClearer, out current))
            {
                message.AppendInt(SwapClearer.FixTag, swapClearer);
            }

            SideAllocExtGrpComp.Decode(ref message, pointer, current, noSideAllocs, out current);

            TrdInstrmntLegGrpComp.Decode(ref message, pointer, current, noLegs, out current);

            InstrumentEventGrpComp.Decode(ref message, pointer, current, noEvents, out current);

            InstrumentAttributeGrpComp.Decode(ref message, pointer, current, noInstrAttrib, out current);

            UnderlyingStipGrpComp.Decode(ref message, pointer, current, noUnderlyingStips, out current);

            return FixErrorCode.None;
        }
    }
}