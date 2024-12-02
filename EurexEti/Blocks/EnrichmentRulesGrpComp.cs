namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Enrichment Rules Grp Comp
        /// </summary>
        public static readonly FixComponentBlock EnrichmentRulesGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.EnrichmentRulesGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.EnrichmentRuleId.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdOriginationMarket.FixTag,
                Eurex.EtiDerivatives.v121.Account.FixTag,
                Eurex.EtiDerivatives.v121.PositionEffect.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdTakeUpTradingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdOrderOriginationFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdBeneficiary.FixTag,
                Eurex.EtiDerivatives.v121.FreeText1.FixTag,
                Eurex.EtiDerivatives.v121.FreeText2.FixTag,
                Eurex.EtiDerivatives.v121.FreeText3.FixTag,
                Eurex.EtiDerivatives.v121.Pad1.FixTag,
            }
        };
    }
}