namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Leg Ord Grp Comp
        /// </summary>
        public static readonly FixComponentBlock LegOrdGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.LegOrdGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.LegAccount.FixTag,
                Eurex.EtiDerivatives.v130.LegPositionEffect.FixTag,
                Eurex.EtiDerivatives.v130.Pad5.FixTag,
            }
        };
    }
}