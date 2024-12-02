namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Risk Limits Rpt Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RiskLimitsRptGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.RiskLimitsRptGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.RiskLimitQty.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitOpenQty.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitNetPositionQty.FixTag,
                Eurex.EtiDerivatives.v121.NettingCoefficient.FixTag,
                Eurex.EtiDerivatives.v121.QuoteWeightingCoefficient.FixTag,
                Eurex.EtiDerivatives.v121.ActivationDate.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitType.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitRequestingPartyRole.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitViolationIndicator.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitGroup.FixTag,
                Eurex.EtiDerivatives.v121.Pad6.FixTag,
            }
        };
    }
}