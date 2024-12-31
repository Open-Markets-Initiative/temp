using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Order Message Methods
    /// </summary>

    public static partial class MassOrder
    {
        /// <summary>
        ///  Eti Identifier for Mass Order
        /// </summary>
        public const string Identifier = "10115";

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

            if (message.TryGetULong(MassOrderRequestId.FixTag, out var massOrderRequestId))
            {
                MassOrderRequestId.Encode(pointer, current, massOrderRequestId, out current);
            }
            else
            {
                MassOrderRequestId.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(OrderAttributeRiskReduction.FixTag, out var orderAttributeRiskReduction))
            {
                OrderAttributeRiskReduction.Encode(pointer, current, (byte)orderAttributeRiskReduction, out current);
            }
            else
            {
                OrderAttributeRiskReduction.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradingSessionSubId.FixTag, out var tradingSessionSubId))
            {
                TradingSessionSubId.Encode(pointer, current, (byte)tradingSessionSubId, out current);
            }
            else
            {
                TradingSessionSubId.SetNull(pointer, current, out current);
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

            var isOrderEntryGrpComp = message.TryGetGroup(NoOrderEntries.FixTag, out var orderEntryGrpComp) && orderEntryGrpComp.sectionList.Count > 0;
            if (isOrderEntryGrpComp)
            {
                var noOrderEntries = (byte)orderEntryGrpComp.sectionList.Count;
                NoOrderEntries.Encode(pointer, current, noOrderEntries, out current);
            }
            else
            {
                NoOrderEntries.Zero(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            if (isOrderEntryGrpComp)
            {
                OrderEntryGrpComp.Encode(pointer, current, orderEntryGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Mass Order Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = MassOrder.Identifier;

            // --- decode mass order message ---

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

            if (MassOrderRequestId.TryDecode(pointer, current, out var massOrderRequestId, out current))
            {
                message.AppendULong(MassOrderRequestId.FixTag, massOrderRequestId);
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

            if (OrderAttributeRiskReduction.TryDecode(pointer, current, out var orderAttributeRiskReduction, out current))
            {
                message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);
            }

            if (TradingSessionSubId.TryDecode(pointer, current, out var tradingSessionSubId, out current))
            {
                message.AppendInt(TradingSessionSubId.FixTag, tradingSessionSubId);
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

            var noOrderEntries = (int)NoOrderEntries.Decode(pointer, current, out current);

            current += Pad7.Length;

            OrderEntryGrpComp.Decode(ref message, pointer, current, noOrderEntries, out current);

            return FixErrorCode.None;
        }
    }
}