namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Trd Clearing Price Leg Grp Comp
        /// </summary>
        public static readonly FixComponentBlock TrdClearingPriceLegGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.TrdClearingPriceLegGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v121.LegClearingTradePrice.FixTag,
            }
        };
    }
}