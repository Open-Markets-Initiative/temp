namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Rra Update Base Party Ack Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RraUpdateBasePartyAckGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.RraUpdateBasePartyAckGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.PartyDetailExecutingUnit.FixTag,
                Eurex.EtiDerivatives.v130.Pad1.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitResult.FixTag,
            }
        };
    }
}