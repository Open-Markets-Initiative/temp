namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Srqs Quote Entry Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsQuoteEntryGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SrqsQuoteEntryGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.TransactTime.FixTag,
                Eurex.EtiDerivatives.v121.ExpireTime.FixTag,
                Eurex.EtiDerivatives.v121.QuoteId.FixTag,
                Eurex.EtiDerivatives.v121.SecondaryQuoteId.FixTag,
                Eurex.EtiDerivatives.v121.BidPx.FixTag,
                Eurex.EtiDerivatives.v121.BidSize.FixTag,
                Eurex.EtiDerivatives.v121.OfferPx.FixTag,
                Eurex.EtiDerivatives.v121.OfferSize.FixTag,
                Eurex.EtiDerivatives.v121.UnderlyingPx.FixTag,
                Eurex.EtiDerivatives.v121.UnderlyingDeltaPercentage.FixTag,
                Eurex.EtiDerivatives.v121.QuoteRefPrice.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.NegotiationId.FixTag,
                Eurex.EtiDerivatives.v121.QuotingStatus.FixTag,
                Eurex.EtiDerivatives.v121.FirmNegotiationId.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.PartyEnteringTrader.FixTag,
                Eurex.EtiDerivatives.v121.Pad2.FixTag,
            }
        };
    }
}