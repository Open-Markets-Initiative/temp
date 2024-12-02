namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Instrmt Leg Grp Comp
        /// </summary>
        public static readonly FixComponentBlock InstrmtLegGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.InstrmtLegGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v121.LegPrice.FixTag,
                Eurex.EtiDerivatives.v121.LegSymbol.FixTag,
                Eurex.EtiDerivatives.v121.LegRatioQty.FixTag,
                Eurex.EtiDerivatives.v121.LegSide.FixTag,
                Eurex.EtiDerivatives.v121.LegSecurityType.FixTag,
                Eurex.EtiDerivatives.v121.Pad6.FixTag,
            }
        };
    }
}