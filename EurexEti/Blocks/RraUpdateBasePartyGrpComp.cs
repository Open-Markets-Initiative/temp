namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Rra Update Base Party Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RraUpdateBasePartyGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.RraUpdateBasePartyGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.RemainingRiskAllowanceBaseLong.FixTag,
                Eurex.EtiDerivatives.v121.RemainingRiskAllowanceBaseShort.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitId.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailExecutingUnit.FixTag,
                Eurex.EtiDerivatives.v121.Pad7.FixTag,
            }
        };
    }
}