namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Order Book Item Grp Comp
        /// </summary>
        public static readonly FixComponentBlock OrderBookItemGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.OrderBookItemGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.SecurityId.FixTag,
                Eurex.EtiDerivatives.v121.BestBidPx.FixTag,
                Eurex.EtiDerivatives.v121.BestBidSize.FixTag,
                Eurex.EtiDerivatives.v121.BestOfferPx.FixTag,
                Eurex.EtiDerivatives.v121.BestOfferSize.FixTag,
                Eurex.EtiDerivatives.v121.MdBookType.FixTag,
                Eurex.EtiDerivatives.v121.MdSubBookType.FixTag,
                Eurex.EtiDerivatives.v121.Pad6.FixTag,
            }
        };
    }
}