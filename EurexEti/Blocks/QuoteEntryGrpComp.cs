namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Quote Entry Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteEntryGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.QuoteEntryGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.SecurityId.FixTag,
                Eurex.EtiDerivatives.v130.BidPx.FixTag,
                Eurex.EtiDerivatives.v130.BidSize.FixTag,
                Eurex.EtiDerivatives.v130.OfferPx.FixTag,
                Eurex.EtiDerivatives.v130.OfferSize.FixTag,
            }
        };
    }
}