using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Modify Order Short Request Message Methods
    /// </summary>

    public static partial class ModifyOrderShortRequest
    {
        /// <summary>
        ///  Eti Identifier for Modify Order Short Request
        /// </summary>
        public const string Identifier = "10141";

        /// <summary>
        ///  Encode Modify Order Short Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ModifyOrderShortRequest, out current);

            // --- encode modify order short request message ---

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

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var clOrdId = message.GetULong(ClOrdId.FixTag);
            ClOrdId.Encode(pointer, current, clOrdId, out current);

            var origClOrdId = message.GetULong(OrigClOrdId.FixTag);
            OrigClOrdId.Encode(pointer, current, origClOrdId, out current);

            var partyIdClientId = message.GetULong(PartyIdClientId.FixTag);
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);

            var executingTrader = message.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

            var matchInstCrossId = (uint)message.GetInt(MatchInstCrossId.FixTag);
            MatchInstCrossId.Encode(pointer, current, matchInstCrossId, out current);

            var applSeqIndicator = (byte)message.GetInt(ApplSeqIndicator.FixTag);
            ApplSeqIndicator.Encode(pointer, current, applSeqIndicator, out current);

            var priceValidityCheckType = (byte)message.GetInt(PriceValidityCheckType.FixTag);
            PriceValidityCheckType.Encode(pointer, current, priceValidityCheckType, out current);

            var valueCheckTypeValue = (byte)message.GetInt(ValueCheckTypeValue.FixTag);
            ValueCheckTypeValue.Encode(pointer, current, valueCheckTypeValue, out current);

            var tradingCapacity = (byte)message.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var orderOrigination = (byte)message.GetInt(OrderOrigination.FixTag);
            OrderOrigination.Encode(pointer, current, orderOrigination, out current);

            var executingTraderQualifier = (byte)message.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

            var partyIdInvestmentDecisionMakerQualifier = (byte)message.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

            if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            var partyIdInvestmentDecisionMaker = message.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

            var enrichmentRuleId = (ushort)message.GetInt(EnrichmentRuleId.FixTag);
            EnrichmentRuleId.Encode(pointer, current, enrichmentRuleId, out current);

            var orderAttributeLiquidityProvision = (byte)message.GetInt(OrderAttributeLiquidityProvision.FixTag);
            OrderAttributeLiquidityProvision.Encode(pointer, current, orderAttributeLiquidityProvision, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var selfMatchPreventionInstruction = (byte)message.GetInt(SelfMatchPreventionInstruction.FixTag);
            SelfMatchPreventionInstruction.Encode(pointer, current, selfMatchPreventionInstruction, out current);

            Pad3.Encode(pointer, current, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            Pad41.Encode(pointer, current, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var orderQty = message.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var price = message.GetDouble(Price.FixTag);
            Price.Encode(pointer, current, price, out current);

            var side = (byte)message.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var execInst = (byte)message.GetInt(ExecInst.FixTag);
            ExecInst.Encode(pointer, current, execInst, out current);

            var timeInForce = (byte)message.GetInt(TimeInForce.FixTag);
            TimeInForce.Encode(pointer, current, timeInForce, out current);

            Pad11.Encode(pointer, current, out current);

            var checkSumCorrection = (ushort)message.GetInt(CheckSumCorrection.FixTag);
            CheckSumCorrection.Encode(pointer, current, checkSumCorrection, out current);

            Pad2.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Modify Order Short Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ModifyOrderShortRequest.Identifier;

            // --- decode modify order short request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubID = senderSubId.ToString();

            var clOrdId = ClOrdId.Decode(pointer, current, out current);
            message.AppendULong(ClOrdId.FixTag, clOrdId);

            var origClOrdId = OrigClOrdId.Decode(pointer, current, out current);
            message.AppendULong(OrigClOrdId.FixTag, origClOrdId);

            var partyIdClientId = PartyIdClientId.Decode(pointer, current, out current);
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

            var matchInstCrossId = (int)MatchInstCrossId.Decode(pointer, current, out current);
            message.AppendInt(MatchInstCrossId.FixTag, matchInstCrossId);

            var applSeqIndicator = ApplSeqIndicator.Decode(pointer, current, out current);
            message.AppendInt(ApplSeqIndicator.FixTag, applSeqIndicator);

            var priceValidityCheckType = PriceValidityCheckType.Decode(pointer, current, out current);
            message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);

            var valueCheckTypeValue = ValueCheckTypeValue.Decode(pointer, current, out current);
            message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var orderOrigination = OrderOrigination.Decode(pointer, current, out current);
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

            var partyIdInvestmentDecisionMakerQualifier = PartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            current += Pad1.Length;

            var partyIdInvestmentDecisionMaker = PartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);

            var enrichmentRuleId = (short)EnrichmentRuleId.Decode(pointer, current, out current);
            message.AppendInt(EnrichmentRuleId.FixTag, enrichmentRuleId);

            var orderAttributeLiquidityProvision = OrderAttributeLiquidityProvision.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var selfMatchPreventionInstruction = SelfMatchPreventionInstruction.Decode(pointer, current, out current);
            message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);

            current += Pad3.Length;

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            current += Pad41.Length;

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var price = Price.Decode(pointer, current, out current);
            message.AppendDouble(Price.FixTag, price);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var execInst = ExecInst.Decode(pointer, current, out current);
            message.AppendInt(ExecInst.FixTag, execInst);

            var timeInForce = TimeInForce.Decode(pointer, current, out current);
            message.AppendInt(TimeInForce.FixTag, timeInForce);

            current += Pad11.Length;

            var checkSumCorrection = (short)CheckSumCorrection.Decode(pointer, current, out current);
            message.AppendInt(CheckSumCorrection.FixTag, checkSumCorrection);

            current += Pad2.Length;

            return FixErrorCode.None;
        }
    }
}