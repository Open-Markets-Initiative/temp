using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Entry Grp Comp Message Methods
    /// </summary>

    public partial class SrqsQuoteEntryGrpComp
    {
        /// <summary>
        ///  Fix Tag for Srqs Quote Entry Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39143;

        /// <summary>
        ///  Length of Srqs Quote Entry Grp Comp in bytes
        /// </summary>
        public const int Length = 136;

        /// <summary>
        ///  Encode Srqs Quote Entry Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode srqs quote entry grp comp ---

            if (!message.TryGetGroup(SrqsQuoteEntryGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SrqsQuoteEntryGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var transactTime = group.GetULong(TransactTime.FixTag);
                TransactTime.Encode(pointer, current, transactTime, out current);

                var expireTime = group.GetULong(ExpireTime.FixTag);
                ExpireTime.Encode(pointer, current, expireTime, out current);

                var quoteId = group.GetULong(QuoteId.FixTag);
                QuoteId.Encode(pointer, current, quoteId, out current);

                var secondaryQuoteId = group.GetULong(SecondaryQuoteId.FixTag);
                SecondaryQuoteId.Encode(pointer, current, secondaryQuoteId, out current);

                var bidPx = group.GetDouble(BidPx.FixTag);
                BidPx.Encode(pointer, current, bidPx, out current);

                var bidSize = group.GetDouble(BidSize.FixTag);
                BidSize.Encode(pointer, current, bidSize, out current);

                var offerPx = group.GetDouble(OfferPx.FixTag);
                OfferPx.Encode(pointer, current, offerPx, out current);

                var offerSize = group.GetDouble(OfferSize.FixTag);
                OfferSize.Encode(pointer, current, offerSize, out current);

                var underlyingPx = group.GetDouble(UnderlyingPx.FixTag);
                UnderlyingPx.Encode(pointer, current, underlyingPx, out current);

                var underlyingDeltaPercentage = group.GetDouble(UnderlyingDeltaPercentage.FixTag);
                UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);

                var quoteRefPrice = group.GetDouble(QuoteRefPrice.FixTag);
                QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);

                var partyIdExecutingTrader = (uint)group.GetInt(PartyIdExecutingTrader.FixTag);
                PartyIdExecutingTrader.Encode(pointer, current, partyIdExecutingTrader, out current);

                var negotiationId = (uint)group.GetInt(NegotiationId.FixTag);
                NegotiationId.Encode(pointer, current, negotiationId, out current);

                var quotingStatus = (byte)group.GetInt(QuotingStatus.FixTag);
                QuotingStatus.Encode(pointer, current, quotingStatus, out current);

                if (group.TryGetString(FirmNegotiationId.FixTag, out var firmNegotiationId))
                {
                    FirmNegotiationId.Encode(pointer, current, firmNegotiationId, out current);
                }
                else
                {
                    FirmNegotiationId.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
                {
                    PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
                }
                else
                {
                    PartyExecutingFirm.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
                {
                    PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
                }
                else
                {
                    PartyExecutingTrader.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(PartyEnteringTrader.FixTag, out var partyEnteringTrader))
                {
                    PartyEnteringTrader.Encode(pointer, current, partyEnteringTrader, out current);
                }
                else
                {
                    PartyEnteringTrader.SetNull(pointer, current, out current);
                }

                Pad2.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Srqs Quote Entry Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            SrqsQuoteEntryGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}