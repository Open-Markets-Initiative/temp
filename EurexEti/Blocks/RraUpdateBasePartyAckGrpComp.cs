namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Rra Update Base Party Ack Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RraUpdateBasePartyAckGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.RraUpdateBasePartyAckGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.PartyDetailExecutingUnit.FixTag,
                Eurex.EtiDerivatives.v121.Pad1.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitResult.FixTag,
            }
        };
    }
}