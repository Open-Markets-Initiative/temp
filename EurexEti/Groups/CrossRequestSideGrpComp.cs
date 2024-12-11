using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Request Side Grp Comp Message Methods
    /// </summary>

    public static partial class CrossRequestSideGrpComp
    {
        /// <summary>
        ///  Fix Tag for Cross Request Side Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39107;

        /// <summary>
        ///  Encode Cross Request Side Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup crossRequestSideGrpComp, out int current)
        {
            current = offset;

            foreach (var group in crossRequestSideGrpComp.sectionList)
            {
                if (group.TryGetULong(PartyIdClientId.FixTag, out var partyIdClientId))
                {
                    PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);
                }
                else
                {
                    PartyIdClientId.SetNull(pointer, current, out current);
                }

                if (group.TryGetULong(PartyIdInvestmentDecisionMaker.FixTag, out var partyIdInvestmentDecisionMaker))
                {
                    PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);
                }
                else
                {
                    PartyIdInvestmentDecisionMaker.SetNull(pointer, current, out current);
                }

                if (group.TryGetULong(ExecutingTrader.FixTag, out var executingTrader))
                {
                    ExecutingTrader.Encode(pointer, current, executingTrader, out current);
                }
                else
                {
                    ExecutingTrader.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(MaximumPrice.FixTag, out var maximumPrice))
                {
                    MaximumPrice.Encode(pointer, current, maximumPrice, out current);
                }
                else
                {
                    MaximumPrice.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(MatchInstCrossId.FixTag, out var matchInstCrossId))
                {
                    MatchInstCrossId.Encode(pointer, current, (uint)matchInstCrossId, out current);
                }
                else
                {
                    MatchInstCrossId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(InputSource.FixTag, out var inputSource))
                {
                    InputSource.Encode(pointer, current, (byte)inputSource, out current);
                }
                else
                {
                    InputSource.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(Side.FixTag, out var side))
                {
                    Side.Encode(pointer, current, (byte)side, out current);
                }
                else
                {
                    Side.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(SelfMatchPreventionInstruction.FixTag, out var selfMatchPreventionInstruction))
                {
                    SelfMatchPreventionInstruction.Encode(pointer, current, (byte)selfMatchPreventionInstruction, out current);
                }
                else
                {
                    SelfMatchPreventionInstruction.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
                {
                    TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
                }
                else
                {
                    TradingCapacity.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(ExecutingTraderQualifier.FixTag, out var executingTraderQualifier))
                {
                    ExecutingTraderQualifier.Encode(pointer, current, (byte)executingTraderQualifier, out current);
                }
                else
                {
                    ExecutingTraderQualifier.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
                {
                    OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
                }
                else
                {
                    OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, out var partyIdInvestmentDecisionMakerQualifier))
                {
                    PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, (byte)partyIdInvestmentDecisionMakerQualifier, out current);
                }
                else
                {
                    PartyIdInvestmentDecisionMakerQualifier.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(OrderAttributeRiskReduction.FixTag, out var orderAttributeRiskReduction))
                {
                    OrderAttributeRiskReduction.Encode(pointer, current, (byte)orderAttributeRiskReduction, out current);
                }
                else
                {
                    OrderAttributeRiskReduction.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(OrderOrigination.FixTag, out var orderOrigination))
                {
                    OrderOrigination.Encode(pointer, current, (byte)orderOrigination, out current);
                }
                else
                {
                    OrderOrigination.SetNull(pointer, current, out current);
                }

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

            }
        }

        /// <summary>
        ///  Decode Cross Request Side Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoSides.FixTag, count);

            while (count-- > 0)
            {
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

                if (MaximumPrice.TryDecode(pointer, current, out var maximumPrice, out current))
                {
                    message.AppendDouble(MaximumPrice.FixTag, maximumPrice);
                }

                if (MatchInstCrossId.TryDecode(pointer, current, out var matchInstCrossId, out current))
                {
                    message.AppendInt(MatchInstCrossId.FixTag, (int)matchInstCrossId);
                }

                if (InputSource.TryDecode(pointer, current, out var inputSource, out current))
                {
                    message.AppendInt(InputSource.FixTag, inputSource);
                }

                if (Side.TryDecode(pointer, current, out var side, out current))
                {
                    message.AppendInt(Side.FixTag, side);
                }

                if (SelfMatchPreventionInstruction.TryDecode(pointer, current, out var selfMatchPreventionInstruction, out current))
                {
                    message.AppendInt(SelfMatchPreventionInstruction.FixTag, selfMatchPreventionInstruction);
                }

                if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
                {
                    message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
                }

                if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
                {
                    message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
                }

                if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
                {
                    message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
                }

                if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
                {
                    message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
                }

                if (OrderAttributeRiskReduction.TryDecode(pointer, current, out var orderAttributeRiskReduction, out current))
                {
                    message.AppendInt(OrderAttributeRiskReduction.FixTag, orderAttributeRiskReduction);
                }

                if (OrderOrigination.TryDecode(pointer, current, out var orderOrigination, out current))
                {
                    message.AppendInt(OrderOrigination.FixTag, orderOrigination);
                }

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

            }
        }
    }
}