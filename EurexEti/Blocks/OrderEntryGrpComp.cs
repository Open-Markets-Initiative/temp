namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Order Entry Grp Comp
        /// </summary>
        public static readonly FixComponentBlock OrderEntryGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.OrderEntryGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.Price.FixTag,
                Eurex.EtiDerivatives.v130.OrderQty.FixTag,
                Eurex.EtiDerivatives.v130.MarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v130.Pad4.FixTag,
                Eurex.EtiDerivatives.v130.SecurityId.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.ProductComplex.FixTag,
                Eurex.EtiDerivatives.v130.Pad6.FixTag,
            }
        };
    }
}