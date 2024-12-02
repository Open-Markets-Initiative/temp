namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Quote Entry Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteEntryGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.QuoteEntryGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.SecurityId.FixTag,
                Eurex.EtiDerivatives.v121.BidPx.FixTag,
                Eurex.EtiDerivatives.v121.BidSize.FixTag,
                Eurex.EtiDerivatives.v121.OfferPx.FixTag,
                Eurex.EtiDerivatives.v121.OfferSize.FixTag,
            }
        };
    }
}