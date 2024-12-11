using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Alloc Ext Grp Comp Message Methods
    /// </summary>

    public static partial class SideAllocExtGrpComp
    {
        /// <summary>
        ///  Fix Tag for Side Alloc Ext Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39137;

        /// <summary>
        ///  Encode Side Alloc Ext Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup sideAllocExtGrpComp, out int current)
        {
            current = offset;

            foreach (var group in sideAllocExtGrpComp.sectionList)
            {
                if (group.TryGetDouble(AllocQty.FixTag, out var allocQty))
                {
                    AllocQty.Encode(pointer, current, allocQty, out current);
                }
                else
                {
                    AllocQty.SetNull(pointer, current, out current);
                }

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

                if (group.TryGetInt(IndividualAllocId.FixTag, out var individualAllocId))
                {
                    IndividualAllocId.Encode(pointer, current, (uint)individualAllocId, out current);
                }
                else
                {
                    IndividualAllocId.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
                {
                    PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
                }
                else
                {
                    PartyExecutingFirm.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
                {
                    PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
                }
                else
                {
                    PartyExecutingTrader.SetNull(pointer, current, out current);
                }

                Pad1.Encode(pointer, current, out current);

                if (group.TryGetInt(TesEnrichmentRuleId.FixTag, out var tesEnrichmentRuleId))
                {
                    TesEnrichmentRuleId.Encode(pointer, current, (uint)tesEnrichmentRuleId, out current);
                }
                else
                {
                    TesEnrichmentRuleId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(Side.FixTag, out var side))
                {
                    Side.Encode(pointer, current, (byte)side, out current);
                }
                else
                {
                    Side.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(TradeAllocStatus.FixTag, out var tradeAllocStatus))
                {
                    TradeAllocStatus.Encode(pointer, current, (byte)tradeAllocStatus, out current);
                }
                else
                {
                    TradeAllocStatus.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
                {
                    TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
                }
                else
                {
                    TradingCapacity.SetNull(pointer, current, out current);
                }

                var positionEffect = group.GetToken(PositionEffect.FixTag);
                PositionEffect.Encode(pointer, current, positionEffect, out current);

                if (group.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
                {
                    OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
                }
                else
                {
                    OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(ExecutingTraderQualifier.FixTag, out var executingTraderQualifier))
                {
                    ExecutingTraderQualifier.Encode(pointer, current, (byte)executingTraderQualifier, out current);
                }
                else
                {
                    ExecutingTraderQualifier.SetNull(pointer, current, out current);
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

                if (group.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
                {
                    PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
                }
                else
                {
                    PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
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

                if (group.TryGetString(PartyIdLocationId.FixTag, out var partyIdLocationId))
                {
                    PartyIdLocationId.Encode(pointer, current, partyIdLocationId, out current);
                }
                else
                {
                    PartyIdLocationId.SetNull(pointer, current, out current);
                }

                var custOrderHandlingInst = group.GetToken(CustOrderHandlingInst.FixTag);
                CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

                if (group.TryGetString(ComplianceText.FixTag, out var complianceText))
                {
                    ComplianceText.Encode(pointer, current, complianceText, out current);
                }
                else
                {
                    ComplianceText.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyEndClientIdentification.FixTag, out var partyEndClientIdentification))
                {
                    PartyEndClientIdentification.Encode(pointer, current, partyEndClientIdentification, out current);
                }
                else
                {
                    PartyEndClientIdentification.SetNull(pointer, current, out current);
                }

                Pad5.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Side Alloc Ext Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoSideAllocs.FixTag, count);

            while (count-- > 0)
            {
                if (AllocQty.TryDecode(pointer, current, out var allocQty, out current))
                {
                    message.AppendDouble(AllocQty.FixTag, allocQty);
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

                if (IndividualAllocId.TryDecode(pointer, current, out var individualAllocId, out current))
                {
                    message.AppendInt(IndividualAllocId.FixTag, (int)individualAllocId);
                }

                if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
                {
                    message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
                }

                if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
                {
                    message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
                }

                current += Pad1.Length;

                if (TesEnrichmentRuleId.TryDecode(pointer, current, out var tesEnrichmentRuleId, out current))
                {
                    message.AppendInt(TesEnrichmentRuleId.FixTag, (int)tesEnrichmentRuleId);
                }

                if (Side.TryDecode(pointer, current, out var side, out current))
                {
                    message.AppendInt(Side.FixTag, side);
                }

                if (TradeAllocStatus.TryDecode(pointer, current, out var tradeAllocStatus, out current))
                {
                    message.AppendInt(TradeAllocStatus.FixTag, tradeAllocStatus);
                }

                if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
                {
                    message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
                }

                var positionEffect = PositionEffect.Decode(pointer, current, out current);
                message.AppendToken(PositionEffect.FixTag, positionEffect);

                if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
                {
                    message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
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

                if (OrderOrigination.TryDecode(pointer, current, out var orderOrigination, out current))
                {
                    message.AppendInt(OrderOrigination.FixTag, orderOrigination);
                }

                if (Account.TryDecode(pointer, current, out var account, out current))
                {
                    message.AppendString(Account.FixTag, account);
                }

                if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
                {
                    message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
                }

                if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
                {
                    message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
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

                if (PartyEndClientIdentification.TryDecode(pointer, current, out var partyEndClientIdentification, out current))
                {
                    message.AppendString(PartyEndClientIdentification.FixTag, partyEndClientIdentification);
                }

                current += Pad5.Length;

            }
        }
    }
}