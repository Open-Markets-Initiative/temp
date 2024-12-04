namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Side Cross Leg Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SideCrossLegGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SideCrossLegGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.LegInputSource.FixTag,
                Eurex.EtiDerivatives.v130.LegPositionEffect.FixTag,
                Eurex.EtiDerivatives.v130.LegAccount.FixTag,
                Eurex.EtiDerivatives.v130.Pad4.FixTag,
            }
        };
    }
}