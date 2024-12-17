using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Quote Request Message Methods
    /// </summary>

    public static partial class MassQuoteRequest
    {
        /// <summary>
        ///  Eti Identifier for Mass Quote Request
        /// </summary>
        public const string Identifier = "10405";

        /// <summary>
        ///  Encode Mass Quote Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.MassQuoteRequest, out current);

            // --- encode mass quote request message ---

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

            if (message.TryGetULong(QuoteId.FixTag, out var quoteId))
            {
                QuoteId.Encode(pointer, current, quoteId, out current);
            }
            else
            {
                QuoteId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(PartyIdInvestmentDecisionMaker.FixTag, out var partyIdInvestmentDecisionMaker))
            {
                PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);
            }
            else
            {
                PartyIdInvestmentDecisionMaker.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ExecutingTrader.FixTag, out var executingTrader))
            {
                ExecutingTrader.Encode(pointer, current, executingTrader, out current);
            }
            else
            {
                ExecutingTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MatchInstCrossId.FixTag, out var matchInstCrossId))
            {
                MatchInstCrossId.Encode(pointer, current, (uint)matchInstCrossId, out current);
            }
            else
            {
                MatchInstCrossId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(EnrichmentRuleId.FixTag, out var enrichmentRuleId))
            {
                EnrichmentRuleId.Encode(pointer, current, (ushort)enrichmentRuleId, out current);
            }
            else
            {
                EnrichmentRuleId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SelfMatchPreventionInstruction.FixTag, out var selfMatchPreventionInstruction))
            {
                SelfMatchPreventionInstruction.Encode(pointer, current, (byte)selfMatchPreventionInstruction, out current);
            }
            else
            {
                SelfMatchPreventionInstruction.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PriceValidityCheckType.FixTag, out var priceValidityCheckType))
            {
                PriceValidityCheckType.Encode(pointer, current, (byte)priceValidityCheckType, out current);
            }
            else
            {
                PriceValidityCheckType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ValueCheckTypeValue.FixTag, out var valueCheckTypeValue))
            {
                ValueCheckTypeValue.Encode(pointer, current, (byte)valueCheckTypeValue, out current);
            }
            else
            {
                ValueCheckTypeValue.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(QuoteSizeType.FixTag, out var quoteSizeType))
            {
                QuoteSizeType.Encode(pointer, current, (byte)quoteSizeType, out current);
            }
            else
            {
                QuoteSizeType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(QuoteType.FixTag, out var quoteType))
            {
                QuoteType.Encode(pointer, current, (byte)quoteType, out current);
            }
            else
            {
                QuoteType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
            {
                OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
            }
            else
            {
                OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
            }

            var isQuoteEntryGrpComp = message.TryGetGroup(NoQuoteEntries.FixTag, out var quoteEntryGrpComp) && quoteEntryGrpComp.sectionList.Count > 0;
            if (isQuoteEntryGrpComp)
            {
                var noQuoteEntries = (byte)quoteEntryGrpComp.sectionList.Count;
                NoQuoteEntries.Encode(pointer, current, noQuoteEntries, out current);
            }
            else
            {
                NoQuoteEntries.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, out var partyIdInvestmentDecisionMakerQualifier))
            {
                PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, (byte)partyIdInvestmentDecisionMakerQualifier, out current);
            }
            else
            {
                PartyIdInvestmentDecisionMakerQualifier.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ExecutingTraderQualifier.FixTag, out var executingTraderQualifier))
            {
                ExecutingTraderQualifier.Encode(pointer, current, (byte)executingTraderQualifier, out current);
            }
            else
            {
                ExecutingTraderQualifier.SetNull(pointer, current, out current);
            }

            Pad5.Encode(pointer, current, out current);

            if (isQuoteEntryGrpComp)
            {
                QuoteEntryGrpComp.Encode(pointer, current, quoteEntryGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Mass Quote Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = MassQuoteRequest.Identifier;

            // --- decode mass quote request message ---

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

            if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
            {
                message.AppendULong(QuoteId.FixTag, quoteId);
            }

            if (PartyIdInvestmentDecisionMaker.TryDecode(pointer, current, out var partyIdInvestmentDecisionMaker, out current))
            {
                message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);
            }

            if (ExecutingTrader.TryDecode(pointer, current, out var executingTrader, out current))
            {
                message.AppendULong(ExecutingTrader.FixTag, executingTrader);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (MatchInstCrossId.TryDecode(pointer, current, out var matchInstCrossId, out current))
            {
                message.AppendInt(MatchInstCrossId.FixTag, (int)matchInstCrossId);
            }

            if (EnrichmentRuleId.TryDecode(pointer, current, out var enrichmentRuleId, out current))
            {
                message.AppendInt(EnrichmentRuleId.FixTag, (short)enrichmentRuleId);
            }

            if (SelfMatchPreventionInstruction.TryDecode(pointer, current, out var selfMatchPreventionInstruction, out current))
            {
                message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);
            }

            if (PriceValidityCheckType.TryDecode(pointer, current, out var priceValidityCheckType, out current))
            {
                message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);
            }

            if (ValueCheckTypeValue.TryDecode(pointer, current, out var valueCheckTypeValue, out current))
            {
                message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);
            }

            if (QuoteSizeType.TryDecode(pointer, current, out var quoteSizeType, out current))
            {
                message.AppendInt(QuoteSizeType.FixTag, quoteSizeType);
            }

            if (QuoteType.TryDecode(pointer, current, out var quoteType, out current))
            {
                message.AppendInt(QuoteType.FixTag, quoteType);
            }

            if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
            {
                message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
            }

            var noQuoteEntries = (int)NoQuoteEntries.Decode(pointer, current, out current);

            if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
            {
                message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
            }

            if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
            {
                message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
            }

            current += Pad5.Length;

            QuoteEntryGrpComp.Decode(ref message, pointer, current, noQuoteEntries, out current);

            return FixErrorCode.None;
        }
    }
}