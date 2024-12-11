using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Entry Grp Comp Message Methods
    /// </summary>

    public static partial class SrqsQuoteEntryGrpComp
    {
        /// <summary>
        ///  Fix Tag for Srqs Quote Entry Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39143;

        /// <summary>
        ///  Encode Srqs Quote Entry Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup srqsQuoteEntryGrpComp, out int current)
        {
            current = offset;

            foreach (var group in srqsQuoteEntryGrpComp.sectionList)
            {
                if (group.TryGetULong(TransactTime.FixTag, out var transactTime))
                {
                    TransactTime.Encode(pointer, current, transactTime, out current);
                }
                else
                {
                    TransactTime.SetNull(pointer, current, out current);
                }

                if (group.TryGetULong(ExpireTime.FixTag, out var expireTime))
                {
                    ExpireTime.Encode(pointer, current, expireTime, out current);
                }
                else
                {
                    ExpireTime.SetNull(pointer, current, out current);
                }

                if (group.TryGetULong(QuoteId.FixTag, out var quoteId))
                {
                    QuoteId.Encode(pointer, current, quoteId, out current);
                }
                else
                {
                    QuoteId.SetNull(pointer, current, out current);
                }

                if (group.TryGetULong(SecondaryQuoteId.FixTag, out var secondaryQuoteId))
                {
                    SecondaryQuoteId.Encode(pointer, current, secondaryQuoteId, out current);
                }
                else
                {
                    SecondaryQuoteId.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(BidPx.FixTag, out var bidPx))
                {
                    BidPx.Encode(pointer, current, bidPx, out current);
                }
                else
                {
                    BidPx.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(BidSize.FixTag, out var bidSize))
                {
                    BidSize.Encode(pointer, current, bidSize, out current);
                }
                else
                {
                    BidSize.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(OfferPx.FixTag, out var offerPx))
                {
                    OfferPx.Encode(pointer, current, offerPx, out current);
                }
                else
                {
                    OfferPx.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(OfferSize.FixTag, out var offerSize))
                {
                    OfferSize.Encode(pointer, current, offerSize, out current);
                }
                else
                {
                    OfferSize.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(UnderlyingPx.FixTag, out var underlyingPx))
                {
                    UnderlyingPx.Encode(pointer, current, underlyingPx, out current);
                }
                else
                {
                    UnderlyingPx.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(UnderlyingDeltaPercentage.FixTag, out var underlyingDeltaPercentage))
                {
                    UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);
                }
                else
                {
                    UnderlyingDeltaPercentage.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(QuoteRefPrice.FixTag, out var quoteRefPrice))
                {
                    QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);
                }
                else
                {
                    QuoteRefPrice.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(PartyIdExecutingTrader.FixTag, out var partyIdExecutingTrader))
                {
                    PartyIdExecutingTrader.Encode(pointer, current, (uint)partyIdExecutingTrader, out current);
                }
                else
                {
                    PartyIdExecutingTrader.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(NegotiationId.FixTag, out var negotiationId))
                {
                    NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
                }
                else
                {
                    NegotiationId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(QuotingStatus.FixTag, out var quotingStatus))
                {
                    QuotingStatus.Encode(pointer, current, (byte)quotingStatus, out current);
                }
                else
                {
                    QuotingStatus.SetNull(pointer, current, out current);
                }

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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoQuoteEntries.FixTag, count);

            while (count-- > 0)
            {
                if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
                {
                    message.AppendULong(TransactTime.FixTag, transactTime);
                }

                if (ExpireTime.TryDecode(pointer, current, out var expireTime, out current))
                {
                    message.AppendULong(ExpireTime.FixTag, expireTime);
                }

                if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
                {
                    message.AppendULong(QuoteId.FixTag, quoteId);
                }

                if (SecondaryQuoteId.TryDecode(pointer, current, out var secondaryQuoteId, out current))
                {
                    message.AppendULong(SecondaryQuoteId.FixTag, secondaryQuoteId);
                }

                if (BidPx.TryDecode(pointer, current, out var bidPx, out current))
                {
                    message.AppendDouble(BidPx.FixTag, bidPx);
                }

                if (BidSize.TryDecode(pointer, current, out var bidSize, out current))
                {
                    message.AppendDouble(BidSize.FixTag, bidSize);
                }

                if (OfferPx.TryDecode(pointer, current, out var offerPx, out current))
                {
                    message.AppendDouble(OfferPx.FixTag, offerPx);
                }

                if (OfferSize.TryDecode(pointer, current, out var offerSize, out current))
                {
                    message.AppendDouble(OfferSize.FixTag, offerSize);
                }

                if (UnderlyingPx.TryDecode(pointer, current, out var underlyingPx, out current))
                {
                    message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);
                }

                if (UnderlyingDeltaPercentage.TryDecode(pointer, current, out var underlyingDeltaPercentage, out current))
                {
                    message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);
                }

                if (QuoteRefPrice.TryDecode(pointer, current, out var quoteRefPrice, out current))
                {
                    message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);
                }

                if (PartyIdExecutingTrader.TryDecode(pointer, current, out var partyIdExecutingTrader, out current))
                {
                    message.AppendInt(PartyIdExecutingTrader.FixTag, (int)partyIdExecutingTrader);
                }

                if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
                {
                    message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
                }

                if (QuotingStatus.TryDecode(pointer, current, out var quotingStatus, out current))
                {
                    message.AppendInt(QuotingStatus.FixTag, quotingStatus);
                }

                if (FirmNegotiationId.TryDecode(pointer, current, out var firmNegotiationId, out current))
                {
                    message.AppendString(FirmNegotiationId.FixTag, firmNegotiationId);
                }

                if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
                {
                    message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
                }

                if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
                {
                    message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
                }

                if (PartyEnteringTrader.TryDecode(pointer, current, out var partyEnteringTrader, out current))
                {
                    message.AppendString(PartyEnteringTrader.FixTag, partyEnteringTrader);
                }

                current += Pad2.Length;

            }
        }
    }
}