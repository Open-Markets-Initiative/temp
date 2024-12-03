using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Cross Request Side Grp Comp Message Methods
    /// </summary>

    public partial class CrossRequestSideGrpComp
    {
        /// <summary>
        ///  Fix Tag for Cross Request Side Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39107;

        /// <summary>
        ///  Length of Cross Request Side Grp Comp in bytes
        /// </summary>
        public const int Length = 184;

        /// <summary>
        ///  Encode Cross Request Side Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode cross request side grp comp ---

            if (!message.TryGetGroup(CrossRequestSideGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(CrossRequestSideGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
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

            }
        }

        /// <summary>
        ///  Decode Cross Request Side Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            CrossRequestSideGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}