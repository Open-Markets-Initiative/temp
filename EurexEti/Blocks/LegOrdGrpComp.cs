namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Leg Ord Grp Comp
        /// </summary>
        public static readonly FixComponentBlock LegOrdGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.LegOrdGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.LegAccount.FixTag,
                Eurex.EtiDerivatives.v121.LegPositionEffect.FixTag,
                Eurex.EtiDerivatives.v121.Pad5.FixTag,
            }
        };
    }
}