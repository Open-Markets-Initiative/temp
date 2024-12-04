namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Side Alloc Ext Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SideAllocExtGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SideAllocExtGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.AllocQty.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdClientId.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdInvestmentDecisionMaker.FixTag,
                Eurex.EtiDerivatives.v130.ExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.IndividualAllocId.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.Pad1.FixTag,
                Eurex.EtiDerivatives.v130.TesEnrichmentRuleId.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v130.TradingCapacity.FixTag,
                Eurex.EtiDerivatives.v130.PositionEffect.FixTag,
                Eurex.EtiDerivatives.v130.OrderAttributeLiquidityProvision.FixTag,
                Eurex.EtiDerivatives.v130.ExecutingTraderQualifier.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdInvestmentDecisionMakerQualifier.FixTag,
                Eurex.EtiDerivatives.v130.OrderAttributeRiskReduction.FixTag,
                Eurex.EtiDerivatives.v130.OrderOrigination.FixTag,
                Eurex.EtiDerivatives.v130.Account.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdPositionAccount.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdTakeUpTradingFirm.FixTag,
                Eurex.EtiDerivatives.v130.FreeText1.FixTag,
                Eurex.EtiDerivatives.v130.FreeText2.FixTag,
                Eurex.EtiDerivatives.v130.FreeText3.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdOrderOriginationFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdBeneficiary.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdLocationId.FixTag,
                Eurex.EtiDerivatives.v130.CustOrderHandlingInst.FixTag,
                Eurex.EtiDerivatives.v130.ComplianceText.FixTag,
                Eurex.EtiDerivatives.v130.PartyEndClientIdentification.FixTag,
                Eurex.EtiDerivatives.v130.Pad5.FixTag,
            }
        };
    }
}