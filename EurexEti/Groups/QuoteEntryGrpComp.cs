using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Entry Grp Comp Message Methods
    /// </summary>

    public static partial class QuoteEntryGrpComp
    {
        /// <summary>
        ///  Fix Tag for Quote Entry Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39129;

        /// <summary>
        ///  Encode Quote Entry Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup quoteEntryGrpComp, out int current)
        {
            current = offset;

            foreach (var group in quoteEntryGrpComp.sectionList)
            {
                var securityId = group.GetLong(SecurityId.FixTag);
                SecurityId.Encode(pointer, current, securityId, out current);

                var bidPx = group.GetDouble(BidPx.FixTag);
                BidPx.Encode(pointer, current, bidPx, out current);

                var bidSize = group.GetDouble(BidSize.FixTag);
                BidSize.Encode(pointer, current, bidSize, out current);

                var offerPx = group.GetDouble(OfferPx.FixTag);
                OfferPx.Encode(pointer, current, offerPx, out current);

                var offerSize = group.GetDouble(OfferSize.FixTag);
                OfferSize.Encode(pointer, current, offerSize, out current);

            }
        }

        /// <summary>
        ///  Decode Quote Entry Grp Comp
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
                var securityId = SecurityId.Decode(pointer, current, out current);
                message.AppendLong(SecurityId.FixTag, securityId);

                var bidPx = BidPx.Decode(pointer, current, out current);
                message.AppendDouble(BidPx.FixTag, bidPx);

                var bidSize = BidSize.Decode(pointer, current, out current);
                message.AppendDouble(BidSize.FixTag, bidSize);

                var offerPx = OfferPx.Decode(pointer, current, out current);
                message.AppendDouble(OfferPx.FixTag, offerPx);

                var offerSize = OfferSize.Decode(pointer, current, out current);
                message.AppendDouble(OfferSize.FixTag, offerSize);

            }
        }
    }
}