namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Side Alloc Ext Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SideAllocExtGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SideAllocExtGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.AllocQty.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdClientId.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdInvestmentDecisionMaker.FixTag,
                Eurex.EtiDerivatives.v121.ExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.IndividualAllocId.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.Pad1.FixTag,
                Eurex.EtiDerivatives.v121.TesEnrichmentRuleId.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v121.TradingCapacity.FixTag,
                Eurex.EtiDerivatives.v121.PositionEffect.FixTag,
                Eurex.EtiDerivatives.v121.OrderAttributeLiquidityProvision.FixTag,
                Eurex.EtiDerivatives.v121.ExecutingTraderQualifier.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdInvestmentDecisionMakerQualifier.FixTag,
                Eurex.EtiDerivatives.v121.OrderAttributeRiskReduction.FixTag,
                Eurex.EtiDerivatives.v121.OrderOrigination.FixTag,
                Eurex.EtiDerivatives.v121.Account.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdPositionAccount.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdTakeUpTradingFirm.FixTag,
                Eurex.EtiDerivatives.v121.FreeText1.FixTag,
                Eurex.EtiDerivatives.v121.FreeText2.FixTag,
                Eurex.EtiDerivatives.v121.FreeText3.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdOrderOriginationFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdBeneficiary.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdLocationId.FixTag,
                Eurex.EtiDerivatives.v121.CustOrderHandlingInst.FixTag,
                Eurex.EtiDerivatives.v121.ComplianceText.FixTag,
                Eurex.EtiDerivatives.v121.PartyEndClientIdentification.FixTag,
                Eurex.EtiDerivatives.v121.Pad5.FixTag,
            }
        };
    }
}