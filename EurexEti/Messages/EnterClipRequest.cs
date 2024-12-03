using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Enter Clip Request Message Methods
    /// </summary>

    public partial class EnterClipRequest
    {
        /// <summary>
        ///  Eti Identifier for Enter Clip Request
        /// </summary>
        public const string Identifier = "Enter Clip Request";

        /// <summary>
        ///  Encode Enter Clip Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.EnterClipRequest, out current);

            // --- encode enter clip request message ---

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

            var price = message.GetDouble(Price.FixTag);
            Price.Encode(pointer, current, price, out current);

            var orderQty = message.GetDouble(OrderQty.FixTag);
            OrderQty.Encode(pointer, current, orderQty, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var crossId = message.GetInt(CrossId.FixTag);
            CrossId.Encode(pointer, current, crossId, out current);

            var crossRequestId = message.GetInt(CrossRequestId.FixTag);
            CrossRequestId.Encode(pointer, current, crossRequestId, out current);

            var noSides = (byte)message.GetInt(NoSides.FixTag);
            NoSides.Encode(pointer, current, noSides, out current);

            var noCrossLegs = (byte)message.GetInt(NoCrossLegs.FixTag);
            NoCrossLegs.Encode(pointer, current, noCrossLegs, out current);

            var crossRequestType = (byte)message.GetInt(CrossRequestType.FixTag);
            CrossRequestType.Encode(pointer, current, crossRequestType, out current);

            var crossType = (byte)message.GetInt(CrossType.FixTag);
            CrossType.Encode(pointer, current, crossType, out current);

            var crossPrioritization = (byte)message.GetInt(CrossPrioritization.FixTag);
            CrossPrioritization.Encode(pointer, current, crossPrioritization, out current);

            var sideDisclosureInstruction = (byte)message.GetInt(SideDisclosureInstruction.FixTag);
            SideDisclosureInstruction.Encode(pointer, current, sideDisclosureInstruction, out current);

            var priceDisclosureInstruction = (byte)message.GetInt(PriceDisclosureInstruction.FixTag);
            PriceDisclosureInstruction.Encode(pointer, current, priceDisclosureInstruction, out current);

            var orderQtyDisclosureInstruction = (byte)message.GetInt(OrderQtyDisclosureInstruction.FixTag);
            OrderQtyDisclosureInstruction.Encode(pointer, current, orderQtyDisclosureInstruction, out current);

            var priceValidityCheckType = (byte)message.GetInt(PriceValidityCheckType.FixTag);
            PriceValidityCheckType.Encode(pointer, current, priceValidityCheckType, out current);

            var valueCheckTypeValue = (byte)message.GetInt(ValueCheckTypeValue.FixTag);
            ValueCheckTypeValue.Encode(pointer, current, valueCheckTypeValue, out current);

            if (message.TryGetString(RootPartyContraFirm.FixTag, out var rootPartyContraFirm))
            {
                RootPartyContraFirm.Encode(pointer, current, rootPartyContraFirm, out current);
            }
            else
            {
                RootPartyContraFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(RootPartyContraTrader.FixTag, out var rootPartyContraTrader))
            {
                RootPartyContraTrader.Encode(pointer, current, rootPartyContraTrader, out current);
            }
            else
            {
                RootPartyContraTrader.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            var partyIdClientId = group.GetULong(PartyIdClientId.FixTag);
            PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);

            var partyIdInvestmentDecisionMaker = group.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
            PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

            var executingTrader = group.GetULong(ExecutingTrader.FixTag);
            ExecutingTrader.Encode(pointer, current, executingTrader, out current);

            var maximumPrice = group.GetDouble(MaximumPrice.FixTag);
            MaximumPrice.Encode(pointer, current, maximumPrice, out current);

            var matchInstCrossId = (uint)group.GetInt(MatchInstCrossId.FixTag);
            MatchInstCrossId.Encode(pointer, current, matchInstCrossId, out current);

            var inputSource = (byte)group.GetInt(InputSource.FixTag);
            InputSource.Encode(pointer, current, inputSource, out current);

            var side = (byte)group.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var selfMatchPreventionInstruction = (byte)group.GetInt(SelfMatchPreventionInstruction.FixTag);
            SelfMatchPreventionInstruction.Encode(pointer, current, selfMatchPreventionInstruction, out current);

            var tradingCapacity = (byte)group.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var executingTraderQualifier = (byte)group.GetInt(ExecutingTraderQualifier.FixTag);
            ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

            var orderAttributeLiquidityProvision = (byte)group.GetInt(OrderAttributeLiquidityProvision.FixTag);
            OrderAttributeLiquidityProvision.Encode(pointer, current, orderAttributeLiquidityProvision, out current);

            var partyIdInvestmentDecisionMakerQualifier = (byte)group.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
            PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

            var orderAttributeRiskReduction = (byte)group.GetInt(OrderAttributeRiskReduction.FixTag);
            OrderAttributeRiskReduction.Encode(pointer, current, orderAttributeRiskReduction, out current);

            var orderOrigination = (byte)group.GetInt(OrderOrigination.FixTag);
            OrderOrigination.Encode(pointer, current, orderOrigination, out current);

            var positionEffect = group.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            var custOrderHandlingInst = group.GetToken(CustOrderHandlingInst.FixTag);
            CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

            if (group.TryGetString(Account.FixTag, out var account))
            {
                Account.Encode(pointer, current, account, out current);
            }
            else
            {
                Account.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
            {
                PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
            }
            else
            {
                PartyIdPositionAccount.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText1.FixTag, out var freeText1))
            {
                FreeText1.Encode(pointer, current, freeText1, out current);
            }
            else
            {
                FreeText1.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText2.FixTag, out var freeText2))
            {
                FreeText2.Encode(pointer, current, freeText2, out current);
            }
            else
            {
                FreeText2.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText3.FixTag, out var freeText3))
            {
                FreeText3.Encode(pointer, current, freeText3, out current);
            }
            else
            {
                FreeText3.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
            {
                PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
            }
            else
            {
                PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
            {
                PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
            }
            else
            {
                PartyIdBeneficiary.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
            {
                PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
            }
            else
            {
                PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(SideComplianceText.FixTag, out var sideComplianceText))
            {
                SideComplianceText.Encode(pointer, current, sideComplianceText, out current);
            }
            else
            {
                SideComplianceText.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdLocationId.FixTag, out var partyIdLocationId))
            {
                PartyIdLocationId.Encode(pointer, current, partyIdLocationId, out current);
            }
            else
            {
                PartyIdLocationId.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyEndClientIdentification.FixTag, out var partyEndClientIdentification))
            {
                PartyEndClientIdentification.Encode(pointer, current, partyEndClientIdentification, out current);
            }
            else
            {
                PartyEndClientIdentification.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            var legInputSource = (byte)group.GetInt(LegInputSource.FixTag);
            LegInputSource.Encode(pointer, current, legInputSource, out current);

            var legPositionEffect = group.GetToken(LegPositionEffect.FixTag);
            LegPositionEffect.Encode(pointer, current, legPositionEffect, out current);

            if (group.TryGetString(LegAccount.FixTag, out var legAccount))
            {
                LegAccount.Encode(pointer, current, legAccount, out current);
            }
            else
            {
                LegAccount.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, current - offset);
        }

        /// <summary>
        ///  Decode Enter Clip Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = EnterClipRequest.Identifier;

            // --- decode enter clip request message ---

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

            var price = Price.Decode(pointer, current, out current);
            message.AppendDouble(Price.FixTag, price);

            var orderQty = OrderQty.Decode(pointer, current, out current);
            message.AppendDouble(OrderQty.FixTag, orderQty);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var crossId = CrossId.Decode(pointer, current, out current);
            message.AppendInt(CrossId.FixTag, crossId);

            var crossRequestId = CrossRequestId.Decode(pointer, current, out current);
            message.AppendInt(CrossRequestId.FixTag, crossRequestId);

            var noSides = NoSides.Decode(pointer, current, out current);
            message.AppendInt(NoSides.FixTag, noSides);

            var noCrossLegs = NoCrossLegs.Decode(pointer, current, out current);
            message.AppendInt(NoCrossLegs.FixTag, noCrossLegs);

            var crossRequestType = CrossRequestType.Decode(pointer, current, out current);
            message.AppendInt(CrossRequestType.FixTag, crossRequestType);

            var crossType = CrossType.Decode(pointer, current, out current);
            message.AppendInt(CrossType.FixTag, crossType);

            var crossPrioritization = CrossPrioritization.Decode(pointer, current, out current);
            message.AppendInt(CrossPrioritization.FixTag, crossPrioritization);

            var sideDisclosureInstruction = SideDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(SideDisclosureInstruction.FixTag, sideDisclosureInstruction);

            var priceDisclosureInstruction = PriceDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(PriceDisclosureInstruction.FixTag, priceDisclosureInstruction);

            var orderQtyDisclosureInstruction = OrderQtyDisclosureInstruction.Decode(pointer, current, out current);
            message.AppendInt(OrderQtyDisclosureInstruction.FixTag, orderQtyDisclosureInstruction);

            var priceValidityCheckType = PriceValidityCheckType.Decode(pointer, current, out current);
            message.AppendInt(PriceValidityCheckType.FixTag, priceValidityCheckType);

            var valueCheckTypeValue = ValueCheckTypeValue.Decode(pointer, current, out current);
            message.AppendInt(ValueCheckTypeValue.FixTag, valueCheckTypeValue);

            if (RootPartyContraFirm.TryDecode(pointer, current, out var rootPartyContraFirm, out current))
            {
                message.AppendString(RootPartyContraFirm.FixTag, rootPartyContraFirm);
            }

            if (RootPartyContraTrader.TryDecode(pointer, current, out var rootPartyContraTrader, out current))
            {
                message.AppendString(RootPartyContraTrader.FixTag, rootPartyContraTrader);
            }

            current += Pad7.Length;

            var partyIdClientId = PartyIdClientId.Decode(pointer, current, out current);
            message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);

            var partyIdInvestmentDecisionMaker = PartyIdInvestmentDecisionMaker.Decode(pointer, current, out current);
            message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);

            var executingTrader = ExecutingTrader.Decode(pointer, current, out current);
            message.AppendULong(ExecutingTrader.FixTag, executingTrader);

            var maximumPrice = MaximumPrice.Decode(pointer, current, out current);
            message.AppendDouble(MaximumPrice.FixTag, maximumPrice);

            var matchInstCrossId = (int)MatchInstCrossId.Decode(pointer, current, out current);
            message.AppendInt(MatchInstCrossId.FixTag, matchInstCrossId);

            var inputSource = InputSource.Decode(pointer, current, out current);
            message.AppendInt(InputSource.FixTag, inputSource);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var selfMatchPreventionInstruction = SelfMatchPreventionInstruction.Decode(pointer, current, out current);
            message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var executingTraderQualifier = ExecutingTraderQualifier.Decode(pointer, current, out current);
            message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);

            var orderAttributeLiquidityProvision = OrderAttributeLiquidityProvision.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);

            var partyIdInvestmentDecisionMakerQualifier = PartyIdInvestmentDecisionMakerQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);

            var orderAttributeRiskReduction = OrderAttributeRiskReduction.Decode(pointer, current, out current);
            message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);

            var orderOrigination = OrderOrigination.Decode(pointer, current, out current);
            message.AppendInt(OrderOrigination.FixTag, orderOrigination);

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            var custOrderHandlingInst = CustOrderHandlingInst.Decode(pointer, current, out current);
            message.AppendToken(CustOrderHandlingInst.FixTag, custOrderHandlingInst);

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
            }

            if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
            {
                message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
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

            if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
            {
                message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
            }

            if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
            {
                message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
            }

            if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
            {
                message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
            }

            if (SideComplianceText.TryDecode(pointer, current, out var sideComplianceText, out current))
            {
                message.AppendString(SideComplianceText.FixTag, sideComplianceText);
            }

            if (PartyIdLocationId.TryDecode(pointer, current, out var partyIdLocationId, out current))
            {
                message.AppendString(PartyIdLocationId.FixTag, partyIdLocationId);
            }

            if (PartyEndClientIdentification.TryDecode(pointer, current, out var partyEndClientIdentification, out current))
            {
                message.AppendString(PartyEndClientIdentification.FixTag, partyEndClientIdentification);
            }

            current += Pad4.Length;

            var legInputSource = LegInputSource.Decode(pointer, current, out current);
            message.AppendInt(LegInputSource.FixTag, legInputSource);

            var legPositionEffect = LegPositionEffect.Decode(pointer, current, out current);
            message.AppendToken(LegPositionEffect.FixTag, legPositionEffect);

            if (LegAccount.TryDecode(pointer, current, out var legAccount, out current))
            {
                message.AppendString(LegAccount.FixTag, legAccount);
            }

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}