namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Srqs Quote Entry Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsQuoteEntryGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SrqsQuoteEntryGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.TransactTime.FixTag,
                Eurex.EtiDerivatives.v130.ExpireTime.FixTag,
                Eurex.EtiDerivatives.v130.QuoteId.FixTag,
                Eurex.EtiDerivatives.v130.SecondaryQuoteId.FixTag,
                Eurex.EtiDerivatives.v130.BidPx.FixTag,
                Eurex.EtiDerivatives.v130.BidSize.FixTag,
                Eurex.EtiDerivatives.v130.OfferPx.FixTag,
                Eurex.EtiDerivatives.v130.OfferSize.FixTag,
                Eurex.EtiDerivatives.v130.UnderlyingPx.FixTag,
                Eurex.EtiDerivatives.v130.UnderlyingDeltaPercentage.FixTag,
                Eurex.EtiDerivatives.v130.QuoteRefPrice.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.NegotiationId.FixTag,
                Eurex.EtiDerivatives.v130.QuotingStatus.FixTag,
                Eurex.EtiDerivatives.v130.FirmNegotiationId.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.PartyEnteringTrader.FixTag,
                Eurex.EtiDerivatives.v130.Pad2.FixTag,
            }
        };
    }
}