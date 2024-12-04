namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Risk Limits Rpt Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RiskLimitsRptGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.RiskLimitsRptGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.RiskLimitQty.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitOpenQty.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitNetPositionQty.FixTag,
                Eurex.EtiDerivatives.v130.NettingCoefficient.FixTag,
                Eurex.EtiDerivatives.v130.QuoteWeightingCoefficient.FixTag,
                Eurex.EtiDerivatives.v130.ActivationDate.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitType.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitRequestingPartyRole.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitViolationIndicator.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitGroup.FixTag,
                Eurex.EtiDerivatives.v130.Pad6.FixTag,
            }
        };
    }
}