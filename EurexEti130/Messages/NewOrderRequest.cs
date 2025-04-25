using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  New Order Request Message Methods
/// </summary>

public static partial class NewOrderRequest
{
    /// <summary>
    ///  Eti Identifier for New Order Request
    /// </summary>
    public const string Identifier = "10138";

    /// <summary>
    ///  Encode New Order Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.NewOrderRequest, out current);

        // --- encode new order request message ---

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

        if (message.TryGetDouble(StopPx.FixTag, out var stopPx))
        {
            StopPx.Encode(pointer, current, stopPx, out current);
        }
        else
        {
            StopPx.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(PartyIdClientId.FixTag, out var partyIdClientId))
        {
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);
        }
        else
        {
            PartyIdClientId.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ExecutingTrader.FixTag, out var executingTrader))
        {
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);
        }
        else
        {
            ExecutingTrader.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MatchInstCrossId.FixTag, out var matchInstCrossId))
        {
            MatchInstCrossId.Encode(pointer, current, (uint)matchInstCrossId, out current);
        }
        else
        {
            MatchInstCrossId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExpireDate.FixTag, out var expireDate))
        {
            ExpireDate.Encode(pointer, current, (uint)expireDate, out current);
        }
        else
        {
            ExpireDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradingSessionSubId.FixTag, out var tradingSessionSubId))
        {
            TradingSessionSubId.Encode(pointer, current, (byte)tradingSessionSubId, out current);
        }
        else
        {
            TradingSessionSubId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(SelfMatchPreventionInstruction.FixTag, out var selfMatchPreventionInstruction))
        {
            SelfMatchPreventionInstruction.Encode(pointer, current, (byte)selfMatchPreventionInstruction, out current);
        }
        else
        {
            SelfMatchPreventionInstruction.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplSeqIndicator.FixTag, out var applSeqIndicator))
        {
            ApplSeqIndicator.Encode(pointer, current, (byte)applSeqIndicator, out current);
        }
        else
        {
            ApplSeqIndicator.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrdType.FixTag, out var ordType))
        {
            OrdType.Encode(pointer, current, (byte)ordType, out current);
        }
        else
        {
            OrdType.SetNull(pointer, current, out current);
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

        if (message.TryGetInt(OrderOrigination.FixTag, out var orderOrigination))
        {
            OrderOrigination.Encode(pointer, current, (byte)orderOrigination, out current);
        }
        else
        {
            OrderOrigination.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
        {
            PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
        }
        else
        {
            PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
        {
            PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
        }
        else
        {
            PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
        {
            PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
        }
        else
        {
            PartyIdBeneficiary.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(Account.FixTag, out var account))
        {
            Account.Encode(pointer, current, account, out current);
        }
        else
        {
            Account.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
        {
            PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
        }
        else
        {
            PartyIdPositionAccount.SetNull(pointer, current, out current);
        }

        var positionEffect = message.GetToken(PositionEffect.FixTag);
        PositionEffect.Encode(pointer, current, positionEffect, out current);

        if (message.TryGetString(PartyIdLocationId.FixTag, out var partyIdLocationId))
        {
            PartyIdLocationId.Encode(pointer, current, partyIdLocationId, out current);
        }
        else
        {
            PartyIdLocationId.SetNull(pointer, current, out current);
        }

        var custOrderHandlingInst = message.GetToken(CustOrderHandlingInst.FixTag);
        CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

        if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
        {
            ComplianceText.Encode(pointer, current, complianceText, out current);
        }
        else
        {
            ComplianceText.SetNull(pointer, current, out current);
        }

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

        if (message.TryGetString(FixClOrdId.FixTag, out var fixClOrdId))
        {
            FixClOrdId.Encode(pointer, current, fixClOrdId, out current);
        }
        else
        {
            FixClOrdId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(PartyEndClientIdentification.FixTag, out var partyEndClientIdentification))
        {
            PartyEndClientIdentification.Encode(pointer, current, partyEndClientIdentification, out current);
        }
        else
        {
            PartyEndClientIdentification.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExecutingTraderQualifier.FixTag, out var executingTraderQualifier))
        {
            ExecutingTraderQualifier.Encode(pointer, current, (byte)executingTraderQualifier, out current);
        }
        else
        {
            ExecutingTraderQualifier.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, out var partyIdInvestmentDecisionMakerQualifier))
        {
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, (byte)partyIdInvestmentDecisionMakerQualifier, out current);
        }
        else
        {
            PartyIdInvestmentDecisionMakerQualifier.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrderAttributeRiskReduction.FixTag, out var orderAttributeRiskReduction))
        {
            OrderAttributeRiskReduction.Encode(pointer, current, (byte)orderAttributeRiskReduction, out current);
        }
        else
        {
            OrderAttributeRiskReduction.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        if (message.TryGetULong(PartyIdInvestmentDecisionMaker.FixTag, out var partyIdInvestmentDecisionMaker))
        {
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);
        }
        else
        {
            PartyIdInvestmentDecisionMaker.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
        {
            OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
        }
        else
        {
            OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
        {
            TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
        }
        else
        {
            TradingCapacity.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ProductComplex.FixTag, out var productComplex))
        {
            ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
        }
        else
        {
            ProductComplex.SetNull(pointer, current, out current);
        }

        var isLegOrdGrpComp = message.TryGetGroup(NoLegOnbooks.FixTag, out var legOrdGrpComp) && legOrdGrpComp.sectionList.Count > 0;
        if (isLegOrdGrpComp)
        {
            var noLegOnbooks = (byte)legOrdGrpComp.sectionList.Count;
            NoLegOnbooks.Encode(pointer, current, noLegOnbooks, out current);
        }
        else
        {
            NoLegOnbooks.Zero(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetLong(SecurityId.FixTag, out var securityId))
        {
            SecurityId.Encode(pointer, current, securityId, out current);
        }
        else
        {
            SecurityId.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(OrderQty.FixTag, out var orderQty))
        {
            OrderQty.Encode(pointer, current, orderQty, out current);
        }
        else
        {
            OrderQty.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(Price.FixTag, out var price))
        {
            Price.Encode(pointer, current, price, out current);
        }
        else
        {
            Price.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(Side.FixTag, out var side))
        {
            Side.Encode(pointer, current, (byte)side, out current);
        }
        else
        {
            Side.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ExecInst.FixTag, out var execInst))
        {
            ExecInst.Encode(pointer, current, (byte)execInst, out current);
        }
        else
        {
            ExecInst.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TimeInForce.FixTag, out var timeInForce))
        {
            TimeInForce.Encode(pointer, current, (byte)timeInForce, out current);
        }
        else
        {
            TimeInForce.SetNull(pointer, current, out current);
        }

        Pad1.Encode(pointer, current, out current);

        if (message.TryGetInt(CheckSumCorrection.FixTag, out var checkSumCorrection))
        {
            CheckSumCorrection.Encode(pointer, current, (ushort)checkSumCorrection, out current);
        }
        else
        {
            CheckSumCorrection.SetNull(pointer, current, out current);
        }

        Pad22.Encode(pointer, current, out current);

        if (isLegOrdGrpComp)
        {
            LegOrdGrpComp.Encode(pointer, current, legOrdGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode New Order Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = NewOrderRequest.Identifier;

        // --- decode new order request message ---

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

        if (StopPx.TryDecode(pointer, current, out var stopPx, out current))
        {
            message.AppendDouble(StopPx.FixTag, stopPx);
        }

        if (PartyIdClientId.TryDecode(pointer, current, out var partyIdClientId, out current))
        {
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);
        }

        if (ExecutingTrader.TryDecode(pointer, current, out var executingTrader, out current))
        {
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);
        }

        if (MatchInstCrossId.TryDecode(pointer, current, out var matchInstCrossId, out current))
        {
            message.AppendInt(MatchInstCrossId.FixTag, (int)matchInstCrossId);
        }

        if (ExpireDate.TryDecode(pointer, current, out var expireDate, out current))
        {
            message.AppendInt(ExpireDate.FixTag, (int)expireDate);
        }

        if (TradingSessionSubId.TryDecode(pointer, current, out var tradingSessionSubId, out current))
        {
            message.AppendInt(TradingSessionSubId.FixTag, tradingSessionSubId);
        }

        if (SelfMatchPreventionInstruction.TryDecode(pointer, current, out var selfMatchPreventionInstruction, out current))
        {
            message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);
        }

        if (ApplSeqIndicator.TryDecode(pointer, current, out var applSeqIndicator, out current))
        {
            message.AppendInt(ApplSeqIndicator.FixTag, applSeqIndicator);
        }

        if (OrdType.TryDecode(pointer, current, out var ordType, out current))
        {
            message.AppendInt(OrdType.FixTag, ordType);
        }

        if (PriceValidityCheckType.TryDecode(pointer, current, out var priceValidityCheckType, out current))
        {
            message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);
        }

        if (ValueCheckTypeValue.TryDecode(pointer, current, out var valueCheckTypeValue, out current))
        {
            message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);
        }

        if (OrderOrigination.TryDecode(pointer, current, out var orderOrigination, out current))
        {
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);
        }

        if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
        {
            message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
        }

        if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
        {
            message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
        }

        if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
        {
            message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
        }

        if (Account.TryDecode(pointer, current, out var account, out current))
        {
            message.AppendString(Account.FixTag, account);
        }

        if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
        {
            message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
        }

        var positionEffect = PositionEffect.Decode(pointer, current, out current);
        message.AppendToken(PositionEffect.FixTag, positionEffect);

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

        if (FixClOrdId.TryDecode(pointer, current, out var fixClOrdId, out current))
        {
            message.AppendString(FixClOrdId.FixTag, fixClOrdId);
        }

        if (PartyEndClientIdentification.TryDecode(pointer, current, out var partyEndClientIdentification, out current))
        {
            message.AppendString(PartyEndClientIdentification.FixTag, partyEndClientIdentification);
        }

        if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
        {
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
        }

        if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
        {
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
        }

        if (OrderAttributeRiskReduction.TryDecode(pointer, current, out var orderAttributeRiskReduction, out current))
        {
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);
        }

        current += Pad3.Length;

        if (PartyIdInvestmentDecisionMaker.TryDecode(pointer, current, out var partyIdInvestmentDecisionMaker, out current))
        {
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);
        }

        if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
        {
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
        }

        if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
        {
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
        }

        if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
        {
            message.AppendInt(ProductComplex.FixTag, productComplex);
        }

        var noLegOnbooks = (int)NoLegOnbooks.Decode(pointer, current, out current);

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
        {
            message.AppendLong(SecurityId.FixTag, securityId);
        }

        if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
        {
            message.AppendDouble(OrderQty.FixTag, orderQty);
        }

        if (Price.TryDecode(pointer, current, out var price, out current))
        {
            message.AppendDouble(Price.FixTag, price);
        }

        if (Side.TryDecode(pointer, current, out var side, out current))
        {
            message.AppendInt(Side.FixTag, side);
        }

        if (ExecInst.TryDecode(pointer, current, out var execInst, out current))
        {
            message.AppendInt(ExecInst.FixTag, execInst);
        }

        if (TimeInForce.TryDecode(pointer, current, out var timeInForce, out current))
        {
            message.AppendInt(TimeInForce.FixTag, timeInForce);
        }

        current += Pad1.Length;

        if (CheckSumCorrection.TryDecode(pointer, current, out var checkSumCorrection, out current))
        {
            message.AppendInt(CheckSumCorrection.FixTag, (short)checkSumCorrection);
        }

        current += Pad22.Length;

        LegOrdGrpComp.Decode(ref message, pointer, current, noLegOnbooks, out current);

        return FixErrorCode.None;
    }
}
