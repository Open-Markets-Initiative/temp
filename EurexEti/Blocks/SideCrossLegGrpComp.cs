namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Side Cross Leg Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SideCrossLegGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SideCrossLegGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.LegInputSource.FixTag,
                Eurex.EtiDerivatives.v121.LegPositionEffect.FixTag,
                Eurex.EtiDerivatives.v121.LegAccount.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
            }
        };
    }
}