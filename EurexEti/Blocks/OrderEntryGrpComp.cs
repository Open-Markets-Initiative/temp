namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Order Entry Grp Comp
        /// </summary>
        public static readonly FixComponentBlock OrderEntryGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.OrderEntryGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.Price.FixTag,
                Eurex.EtiDerivatives.v121.OrderQty.FixTag,
                Eurex.EtiDerivatives.v121.MarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
                Eurex.EtiDerivatives.v121.SecurityId.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.ProductComplex.FixTag,
                Eurex.EtiDerivatives.v121.Pad6.FixTag,
            }
        };
    }
}