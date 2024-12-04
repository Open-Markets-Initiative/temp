namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Trd Clearing Price Leg Grp Comp
        /// </summary>
        public static readonly FixComponentBlock TrdClearingPriceLegGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.TrdClearingPriceLegGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v130.LegClearingTradePrice.FixTag,
            }
        };
    }
}