using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
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

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var clOrdId = message.GetULong(ClOrdId.FixTag);
            ClOrdId.Encode(pointer, current, clOrdId, out current);

            var stopPx = message.GetDouble(StopPx.FixTag);
            StopPx.Encode(pointer, current, stopPx, out current);

            var partyIdClientId = message.GetULong(PartyIdClientId.FixTag);
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);

            var executingTrader = message.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

            var matchInstCrossId = (uint)message.GetInt(MatchInstCrossId.FixTag);
            MatchInstCrossId.Encode(pointer, current, matchInstCrossId, out current);

            var expireDate = (uint)message.GetInt(ExpireDate.FixTag);
            ExpireDate.Encode(pointer, current, expireDate, out current);

            var tradingSessionSubId = (byte)message.GetInt(TradingSessionSubId.FixTag);
            TradingSessionSubId.Encode(pointer, current, tradingSessionSubId, out current);

            var selfMatchPreventionInstruction = (byte)message.GetInt(SelfMatchPreventionInstruction.FixTag);
            SelfMatchPreventionInstruction.Encode(pointer, current, selfMatchPreventionInstruction, out current);

            var applSeqIndicator = (byte)message.GetInt(ApplSeqIndicator.FixTag);
            ApplSeqIndicator.Encode(pointer, current, applSeqIndicator, out current);

            var ordType = (byte)message.GetInt(OrdType.FixTag);
            OrdType.Encode(pointer, current, ordType, out current);

            var priceValidityCheckType = (byte)message.GetInt(PriceValidityCheckType.FixTag);
            PriceValidityCheckType.Encode(pointer, current, priceValidityCheckType, out current);

            var valueCheckTypeValue = (byte)message.GetInt(ValueCheckTypeValue.FixTag);
            ValueCheckTypeValue.Encode(pointer, current, valueCheckTypeValue, out current);

            var orderOrigination = (byte)message.GetInt(OrderOrigination.FixTag);
            OrderOrigination.Encode(pointer, current, orderOrigination, out current);

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

            var executingTraderQualifier = (byte)message.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

            var partyIdInvestmentDecisionMakerQualifier = (byte)message.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

            var orderAttributeRiskReduction = (byte)message.GetInt(OrderAttributeRiskReduction.FixTag);
            OrderAttributeRiskReduction.Encode(pointer, current, orderAttributeRiskReduction, out current);

            Pad3.Encode(pointer, current, out current);

            var partyIdInvestmentDecisionMaker = message.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

            var orderAttributeLiquidityProvision = (byte)message.GetInt(OrderAttributeLiquidityProvision.FixTag);
            OrderAttributeLiquidityProvision.Encode(pointer, current, orderAttributeLiquidityProvision, out current);

            var tradingCapacity = (byte)message.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var productComplex = (byte)message.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

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

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

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

            Pad1.Encode(pointer, current, out current);

            var checkSumCorrection = (ushort)message.GetInt(CheckSumCorrection.FixTag);
            CheckSumCorrection.Encode(pointer, current, checkSumCorrection, out current);

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
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = NewOrderRequest.Identifier;

            // --- decode new order request message ---

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

            var stopPx = StopPx.Decode(pointer, current, out current);
            message.AppendDouble(StopPx.FixTag, stopPx);

            var partyIdClientId = PartyIdClientId.Decode(pointer, current, out current);
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

            var matchInstCrossId = (int)MatchInstCrossId.Decode(pointer, current, out current);
            message.AppendInt(MatchInstCrossId.FixTag, matchInstCrossId);

            var expireDate = (int)ExpireDate.Decode(pointer, current, out current);
            message.AppendInt(ExpireDate.FixTag, expireDate);

            var tradingSessionSubId = TradingSessionSubId.Decode(pointer, current, out current);
            message.AppendInt(TradingSessionSubId.FixTag, tradingSessionSubId);

            var selfMatchPreventionInstruction = SelfMatchPreventionInstruction.Decode(pointer, current, out current);
            message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);

            var applSeqIndicator = ApplSeqIndicator.Decode(pointer, current, out current);
            message.AppendInt(ApplSeqIndicator.FixTag, applSeqIndicator);

            var ordType = OrdType.Decode(pointer, current, out current);
            message.AppendInt(OrdType.FixTag, ordType);

            var priceValidityCheckType = PriceValidityCheckType.Decode(pointer, current, out current);
            message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);

            var valueCheckTypeValue = ValueCheckTypeValue.Decode(pointer, current, out current);
            message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);

            var orderOrigination = OrderOrigination.Decode(pointer, current, out current);
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);

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

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

            var partyIdInvestmentDecisionMakerQualifier = PartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);

            var orderAttributeRiskReduction = OrderAttributeRiskReduction.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);

            current += Pad3.Length;

            var partyIdInvestmentDecisionMaker = PartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);

            var orderAttributeLiquidityProvision = OrderAttributeLiquidityProvision.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var noLegOnbooks = (int)NoLegOnbooks.Decode(pointer, current, out current);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

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

            current += Pad1.Length;

            var checkSumCorrection = (short)CheckSumCorrection.Decode(pointer, current, out current);
            message.AppendInt(CheckSumCorrection.FixTag, checkSumCorrection);

            current += Pad22.Length;

            LegOrdGrpComp.Decode(ref message, pointer, current, noLegOnbooks, out current);

            return FixErrorCode.None;
        }
    }
}