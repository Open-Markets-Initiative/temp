using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Basket Side Alloc Ext Grp Comp Message Methods
    /// </summary>

    public partial class BasketSideAllocExtGrpComp
    {
        /// <summary>
        ///  Fix Tag for Basket Side Alloc Ext Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39104;

        /// <summary>
        ///  Length of Basket Side Alloc Ext Grp Comp in bytes
        /// </summary>
        public const int Length = 184;

        /// <summary>
        ///  Encode Basket Side Alloc Ext Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode basket side alloc ext grp comp ---

            if (!message.TryGetGroup(BasketSideAllocExtGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(BasketSideAllocExtGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var allocQty = group.GetDouble(AllocQty.FixTag);
                AllocQty.Encode(pointer, current, allocQty, out current);

                var partyIdClientId = group.GetULong(PartyIdClientId.FixTag);
                PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);

                var partyIdInvestmentDecisionMaker = group.GetULong(PartyIdInvestmentDecisionMaker.FixTag);
                PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);

                var executingTrader = group.GetULong(ExecutingTrader.FixTag);
                ExecutingTrader.Encode(pointer, current, executingTrader, out current);

                var packageId = (uint)group.GetInt(PackageId.FixTag);
                PackageId.Encode(pointer, current, packageId, out current);

                var sideMarketSegmentId = group.GetInt(SideMarketSegmentId.FixTag);
                SideMarketSegmentId.Encode(pointer, current, sideMarketSegmentId, out current);

                var allocId = (uint)group.GetInt(AllocId.FixTag);
                AllocId.Encode(pointer, current, allocId, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                var positionEffect = group.GetToken(PositionEffect.FixTag);
                PositionEffect.Encode(pointer, current, positionEffect, out current);

                var tradingCapacity = (byte)group.GetInt(TradingCapacity.FixTag);
                TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

                var orderAttributeLiquidityProvision = (byte)group.GetInt(OrderAttributeLiquidityProvision.FixTag);
                OrderAttributeLiquidityProvision.Encode(pointer, current, orderAttributeLiquidityProvision, out current);

                var executingTraderQualifier = (byte)group.GetInt(ExecutingTraderQualifier.FixTag);
                ExecutingTraderQualifier.Encode(pointer, current, executingTraderQualifier, out current);

                var partyIdInvestmentDecisionMakerQualifier = (byte)group.GetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag);
                PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, partyIdInvestmentDecisionMakerQualifier, out current);

                var orderAttributeRiskReduction = (byte)group.GetInt(OrderAttributeRiskReduction.FixTag);
                OrderAttributeRiskReduction.Encode(pointer, current, orderAttributeRiskReduction, out current);

                var orderOrigination = (byte)group.GetInt(OrderOrigination.FixTag);
                OrderOrigination.Encode(pointer, current, orderOrigination, out current);

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

                if (group.TryGetString(Account.FixTag, out var account))
                {
                    Account.Encode(pointer, current, account, out current);
                }
                else
                {
                    Account.SetNull(pointer, current, out current);
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

                if (group.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
                {
                    PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
                }
                else
                {
                    PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
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

                if (group.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
                {
                    PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
                }
                else
                {
                    PartyIdPositionAccount.SetNull(pointer, current, out current);
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

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Basket Side Alloc Ext Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            BasketSideAllocExtGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}