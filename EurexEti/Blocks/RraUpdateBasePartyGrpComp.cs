namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Rra Update Base Party Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RraUpdateBasePartyGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.RraUpdateBasePartyGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.RemainingRiskAllowanceBaseLong.FixTag,
                Eurex.EtiDerivatives.v130.RemainingRiskAllowanceBaseShort.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitId.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailExecutingUnit.FixTag,
                Eurex.EtiDerivatives.v130.Pad7.FixTag,
            }
        };
    }
}