using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mass Order Message Methods
    /// </summary>

    public partial class MassOrder
    {
        /// <summary>
        ///  Eti Identifier for Mass Order
        /// </summary>
        public const string Identifier = "Mass Order";

        /// <summary>
        ///  Encode Mass Order Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.MassOrder, out current);

            // --- encode mass order message ---

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

            var massOrderRequestId = message.GetULong(MassOrderRequestId.FixTag);
            MassOrderRequestId.Encode(pointer, current, massOrderRequestId, out current);

            var partyIdClientId = message.GetULong(PartyIdClientId.FixTag);
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);

            var partyIdInvestmentDecisionMaker = message.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

            var executingTrader = message.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

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

            var priceValidityCheckType = (byte)message.GetInt(PriceValidityCheckType.FixTag);
            PriceValidityCheckType.Encode(pointer, current, priceValidityCheckType, out current);

            var valueCheckTypeValue = (byte)message.GetInt(ValueCheckTypeValue.FixTag);
            ValueCheckTypeValue.Encode(pointer, current, valueCheckTypeValue, out current);

            var orderAttributeLiquidityProvision = (byte)message.GetInt(OrderAttributeLiquidityProvision.FixTag);
            OrderAttributeLiquidityProvision.Encode(pointer, current, orderAttributeLiquidityProvision, out current);

            var orderAttributeRiskReduction = (byte)message.GetInt(OrderAttributeRiskReduction.FixTag);
            OrderAttributeRiskReduction.Encode(pointer, current, orderAttributeRiskReduction, out current);

            var tradingSessionSubId = (byte)message.GetInt(TradingSessionSubId.FixTag);
            TradingSessionSubId.Encode(pointer, current, tradingSessionSubId, out current);

            var tradingCapacity = (byte)message.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var orderOrigination = (byte)message.GetInt(OrderOrigination.FixTag);
            OrderOrigination.Encode(pointer, current, orderOrigination, out current);

            var partyIdInvestmentDecisionMakerQualifier = (byte)message.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

            var executingTraderQualifier = (byte)message.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

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

            if (message.TryGetString(PartyEndClientIdentification.FixTag, out var partyEndClientIdentification))
            {
                PartyEndClientIdentification.Encode(pointer, current, partyEndClientIdentification, out current);
            }
            else
            {
                PartyEndClientIdentification.SetNull(pointer, current, out current);
            }

            var noOrderEntries = (byte)message.GetInt(NoOrderEntries.FixTag);
            NoOrderEntries.Encode(pointer, current, noOrderEntries, out current);

            Pad7.Encode(pointer, current, out current);

            var price = group.GetDouble(Price.FixTag);
            Price.Encode(pointer, current, price, out current);

            var orderQty = group.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var marketSegmentId = group.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            Pad4.Encode(pointer, current, out current);

            var securityId = group.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var side = (byte)group.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var productComplex = (byte)group.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Mass Order Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = MassOrder.Identifier;

            // --- decode mass order message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var massOrderRequestId = MassOrderRequestId.Decode(pointer, current, out current);
            message.AppendULong(MassOrderRequestId.FixTag, massOrderRequestId);

            var partyIdClientId = PartyIdClientId.Decode(pointer, current, out current);
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);

            var partyIdInvestmentDecisionMaker = PartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

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

            var priceValidityCheckType = PriceValidityCheckType.Decode(pointer, current, out current);
            message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);

            var valueCheckTypeValue = ValueCheckTypeValue.Decode(pointer, current, out current);
            message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);

            var orderAttributeLiquidityProvision = OrderAttributeLiquidityProvision.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);

            var orderAttributeRiskReduction = OrderAttributeRiskReduction.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);

            var tradingSessionSubId = TradingSessionSubId.Decode(pointer, current, out current);
            message.AppendInt(TradingSessionSubId.FixTag, tradingSessionSubId);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var orderOrigination = OrderOrigination.Decode(pointer, current, out current);
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);

            var partyIdInvestmentDecisionMakerQualifier = PartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

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

            if (PartyEndClientIdentification.TryDecode(pointer, current, out var partyEndClientIdentification, out current))
            {
                message.AppendString(PartyEndClientIdentification.FixTag, partyEndClientIdentification);
            }

            var noOrderEntries = NoOrderEntries.Decode(pointer, current, out current);
            message.AppendInt(NoOrderEntries.FixTag, noOrderEntries);

            current += Pad7.Length;

            var price = Price.Decode(pointer, current, out current);
            message.AppendDouble(Price.FixTag, price);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            current += Pad4.Length;

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}