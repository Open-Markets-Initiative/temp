using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Modify Order Single Short Request Message Methods
/// </summary>

public static partial class ModifyOrderSingleShortRequest
{
    /// <summary>
    ///  Eti Identifier for Modify Order Single Short Request
    /// </summary>
    public const string Identifier = "10126";

    /// <summary>
    ///  Encode Modify Order Single Short Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.ModifyOrderSingleShortRequest, out current);

        // --- encode modify order single short request message ---

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

        if (message.TryGetULong(ClOrdId.FixTag, out var clOrdId))
        {
            ClOrdId.Encode(pointer, current, clOrdId, out current);
        }
        else
        {
            ClOrdId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(OrigClOrdId.FixTag, out var origClOrdId))
        {
            OrigClOrdId.Encode(pointer, current, origClOrdId, out current);
        }
        else
        {
            OrigClOrdId.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(Price.FixTag, out var price))
        {
            Price.Encode(pointer, current, price, out current);
        }
        else
        {
            Price.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(OrderQty.FixTag, out var orderQty))
        {
            OrderQty.Encode(pointer, current, orderQty, out current);
        }
        else
        {
            OrderQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(PartyIdClientId.FixTag, out var partyIdClientId))
        {
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);
        }
        else
        {
            PartyIdClientId.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(SimpleSecurityId.FixTag, out var simpleSecurityId))
        {
            SimpleSecurityId.Encode(pointer, current, (uint)simpleSecurityId, out current);
        }
        else
        {
            SimpleSecurityId.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(Side.FixTag, out var side))
        {
            Side.Encode(pointer, current, (byte)side, out current);
        }
        else
        {
            Side.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
        {
            OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
        }
        else
        {
            OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TimeInForce.FixTag, out var timeInForce))
        {
            TimeInForce.Encode(pointer, current, (byte)timeInForce, out current);
        }
        else
        {
            TimeInForce.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplSeqIndicator.FixTag, out var applSeqIndicator))
        {
            ApplSeqIndicator.Encode(pointer, current, (byte)applSeqIndicator, out current);
        }
        else
        {
            ApplSeqIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExecInst.FixTag, out var execInst))
        {
            ExecInst.Encode(pointer, current, (byte)execInst, out current);
        }
        else
        {
            ExecInst.SetNull(pointer, current, out current);
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

        if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
        {
            ComplianceText.Encode(pointer, current, complianceText, out current);
        }
        else
        {
            ComplianceText.SetNull(pointer, current, out current);
        }

        Pad6.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Modify Order Single Short Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = ModifyOrderSingleShortRequest.Identifier;

        // --- decode modify order single short request message ---

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

        if (ClOrdId.TryDecode(pointer, current, out var clOrdId, out current))
        {
            message.AppendULong(ClOrdId.FixTag, clOrdId);
        }

        if (OrigClOrdId.TryDecode(pointer, current, out var origClOrdId, out current))
        {
            message.AppendULong(OrigClOrdId.FixTag, origClOrdId);
        }

        if (Price.TryDecode(pointer, current, out var price, out current))
        {
            message.AppendDouble(Price.FixTag, price);
        }

        if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
        {
            message.AppendDouble(OrderQty.FixTag, orderQty);
        }

        if (PartyIdClientId.TryDecode(pointer, current, out var partyIdClientId, out current))
        {
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);
        }

        if (PartyIdInvestmentDecisionMaker.TryDecode(pointer, current, out var partyIdInvestmentDecisionMaker, out current))
        {
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);
        }

        if (ExecutingTrader.TryDecode(pointer, current, out var executingTrader, out current))
        {
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);
        }

        if (SimpleSecurityId.TryDecode(pointer, current, out var simpleSecurityId, out current))
        {
            message.AppendInt(SimpleSecurityId.FixTag, (int)simpleSecurityId);
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

        if (Side.TryDecode(pointer, current, out var side, out current))
        {
            message.AppendInt(Side.FixTag, side);
        }

        if (PriceValidityCheckType.TryDecode(pointer, current, out var priceValidityCheckType, out current))
        {
            message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);
        }

        if (ValueCheckTypeValue.TryDecode(pointer, current, out var valueCheckTypeValue, out current))
        {
            message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);
        }

        if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
        {
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
        }

        if (TimeInForce.TryDecode(pointer, current, out var timeInForce, out current))
        {
            message.AppendInt(TimeInForce.FixTag, timeInForce);
        }

        if (ApplSeqIndicator.TryDecode(pointer, current, out var applSeqIndicator, out current))
        {
            message.AppendInt(ApplSeqIndicator.FixTag, applSeqIndicator);
        }

        if (ExecInst.TryDecode(pointer, current, out var execInst, out current))
        {
            message.AppendInt(ExecInst.FixTag, execInst);
        }

        if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
        {
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
        }

        if (OrderOrigination.TryDecode(pointer, current, out var orderOrigination, out current))
        {
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);
        }

        if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
        {
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
        }

        if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
        {
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
        }

        if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
        {
            message.AppendString(ComplianceText.FixTag, complianceText);
        }

        current += Pad6.Length;

        return FixErrorCode.None;
    }
}
