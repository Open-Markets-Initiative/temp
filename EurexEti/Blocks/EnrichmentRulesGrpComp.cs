namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Enrichment Rules Grp Comp
        /// </summary>
        public static readonly FixComponentBlock EnrichmentRulesGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.EnrichmentRulesGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.EnrichmentRuleId.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdOriginationMarket.FixTag,
                Eurex.EtiDerivatives.v130.Account.FixTag,
                Eurex.EtiDerivatives.v130.PositionEffect.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdTakeUpTradingFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdOrderOriginationFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdBeneficiary.FixTag,
                Eurex.EtiDerivatives.v130.FreeText1.FixTag,
                Eurex.EtiDerivatives.v130.FreeText2.FixTag,
                Eurex.EtiDerivatives.v130.FreeText3.FixTag,
                Eurex.EtiDerivatives.v130.Pad1.FixTag,
            }
        };
    }
}