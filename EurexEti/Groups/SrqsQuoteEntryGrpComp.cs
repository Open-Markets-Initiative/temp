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
                var transactTime = TransactTime.Decode(pointer, current, out current);
                message.AppendULong(TransactTime.FixTag, transactTime);

                var expireTime = ExpireTime.Decode(pointer, current, out current);
                message.AppendULong(ExpireTime.FixTag, expireTime);

                var quoteId = QuoteId.Decode(pointer, current, out current);
                message.AppendULong(QuoteId.FixTag, quoteId);

                var secondaryQuoteId = SecondaryQuoteId.Decode(pointer, current, out current);
                message.AppendULong(SecondaryQuoteId.FixTag, secondaryQuoteId);

                var bidPx = BidPx.Decode(pointer, current, out current);
                message.AppendDouble(BidPx.FixTag, bidPx);

                var bidSize = BidSize.Decode(pointer, current, out current);
                message.AppendDouble(BidSize.FixTag, bidSize);

                var offerPx = OfferPx.Decode(pointer, current, out current);
                message.AppendDouble(OfferPx.FixTag, offerPx);

                var offerSize = OfferSize.Decode(pointer, current, out current);
                message.AppendDouble(OfferSize.FixTag, offerSize);

                var underlyingPx = UnderlyingPx.Decode(pointer, current, out current);
                message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);

                var underlyingDeltaPercentage = UnderlyingDeltaPercentage.Decode(pointer, current, out current);
                message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);

                var quoteRefPrice = QuoteRefPrice.Decode(pointer, current, out current);
                message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);

                var partyIdExecutingTrader = (int)PartyIdExecutingTrader.Decode(pointer, current, out current);
                message.AppendInt(PartyIdExecutingTrader.FixTag, partyIdExecutingTrader);

                var negotiationId = (int)NegotiationId.Decode(pointer, current, out current);
                message.AppendInt(NegotiationId.FixTag, negotiationId);

                var quotingStatus = QuotingStatus.Decode(pointer, current, out current);
                message.AppendInt(QuotingStatus.FixTag, quotingStatus);

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