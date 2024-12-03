using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Enter Tes Trade Request Message Methods
    /// </summary>

    public partial class EnterTesTradeRequest
    {
        /// <summary>
        ///  Eti Identifier for Enter Tes Trade Request
        /// </summary>
        public const string Identifier = "Enter Tes Trade Request";

        /// <summary>
        ///  Encode Enter Tes Trade Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.EnterTesTradeRequest, out current);

            // --- encode enter tes trade request message ---

            var start = current;

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

            var noEvents = (byte)message.GetInt(NoEvents.FixTag);
            NoEvents.Encode(pointer, current, noEvents, out current);

            var noLegs = (byte)message.GetInt(NoLegs.FixTag);
            NoLegs.Encode(pointer, current, noLegs, out current);

            var noInstrAttrib = (byte)message.GetInt(NoInstrAttrib.FixTag);
            NoInstrAttrib.Encode(pointer, current, noInstrAttrib, out current);

            var noUnderlyingStips = (byte)message.GetInt(NoUnderlyingStips.FixTag);
            NoUnderlyingStips.Encode(pointer, current, noUnderlyingStips, out current);

            var partyIdSettlementLocation = (byte)message.GetInt(PartyIdSettlementLocation.FixTag);
            PartyIdSettlementLocation.Encode(pointer, current, partyIdSettlementLocation, out current);

            var hedgeType = (byte)message.GetInt(HedgeType.FixTag);
            HedgeType.Encode(pointer, current, hedgeType, out current);

            var swapClearer = (byte)message.GetInt(SwapClearer.FixTag);
            SwapClearer.Encode(pointer, current, swapClearer, out current);

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

            Pad4.Encode(pointer, current, out current);

            var allocQty = group.GetDouble(AllocQty.FixTag);
            AllocQty.Encode(pointer, current, allocQty, out current);

            var individualAllocId = (uint)group.GetInt(IndividualAllocId.FixTag);
            IndividualAllocId.Encode(pointer, current, individualAllocId, out current);

            var tesEnrichmentRuleId = (uint)group.GetInt(TesEnrichmentRuleId.FixTag);
            TesEnrichmentRuleId.Encode(pointer, current, tesEnrichmentRuleId, out current);

            var side = (byte)group.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

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

            Pad4.Encode(pointer, current, out current);

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

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Enter Tes Trade Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = EnterTesTradeRequest.Identifier;

            // --- decode enter tes trade request message ---

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

            var noEvents = NoEvents.Decode(pointer, current, out current);
            message.AppendInt(NoEvents.FixTag, noEvents);

            var noLegs = NoLegs.Decode(pointer, current, out current);
            message.AppendInt(NoLegs.FixTag, noLegs);

            var noInstrAttrib = NoInstrAttrib.Decode(pointer, current, out current);
            message.AppendInt(NoInstrAttrib.FixTag, noInstrAttrib);

            var noUnderlyingStips = NoUnderlyingStips.Decode(pointer, current, out current);
            message.AppendInt(NoUnderlyingStips.FixTag, noUnderlyingStips);

            var partyIdSettlementLocation = PartyIdSettlementLocation.Decode(pointer, current, out current);
            message.AppendInt(PartyIdSettlementLocation.FixTag, partyIdSettlementLocation);

            var hedgeType = HedgeType.Decode(pointer, current, out current);
            message.AppendInt(HedgeType.FixTag, hedgeType);

            var swapClearer = SwapClearer.Decode(pointer, current, out current);
            message.AppendInt(SwapClearer.FixTag, swapClearer);

            if (TradeReportText.TryDecode(pointer, current, out var tradeReportText, out current))
            {
                message.AppendString(TradeReportText.FixTag, tradeReportText);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
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

            current += Pad4.Length;

            var allocQty = AllocQty.Decode(pointer, current, out current);
            message.AppendDouble(AllocQty.FixTag, allocQty);

            var individualAllocId = (int)IndividualAllocId.Decode(pointer, current, out current);
            message.AppendInt(IndividualAllocId.FixTag, individualAllocId);

            var tesEnrichmentRuleId = (int)TesEnrichmentRuleId.Decode(pointer, current, out current);
            message.AppendInt(TesEnrichmentRuleId.FixTag, tesEnrichmentRuleId);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
            }

            current += Pad4.Length;

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