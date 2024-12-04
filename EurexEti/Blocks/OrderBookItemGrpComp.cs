namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Order Book Item Grp Comp
        /// </summary>
        public static readonly FixComponentBlock OrderBookItemGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.OrderBookItemGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.SecurityId.FixTag,
                Eurex.EtiDerivatives.v130.BestBidPx.FixTag,
                Eurex.EtiDerivatives.v130.BestBidSize.FixTag,
                Eurex.EtiDerivatives.v130.BestOfferPx.FixTag,
                Eurex.EtiDerivatives.v130.BestOfferSize.FixTag,
                Eurex.EtiDerivatives.v130.MdBookType.FixTag,
                Eurex.EtiDerivatives.v130.MdSubBookType.FixTag,
                Eurex.EtiDerivatives.v130.Pad6.FixTag,
            }
        };
    }
}