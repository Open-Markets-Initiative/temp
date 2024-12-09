using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Book Item Grp Comp Message Methods
    /// </summary>

    public partial static class OrderBookItemGrpComp
    {
        /// <summary>
        ///  Fix Tag for Order Book Item Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39123;

        /// <summary>
        ///  Encode Order Book Item Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int orderBookItemGrpComp, out int current)
        {
            current = offset;

            foreach (var group in orderBookItemGrpComp.sectionList)
            {
                var securityId = group.GetLong(SecurityId.FixTag);
                SecurityId.Encode(pointer, current, securityId, out current);

                var bestBidPx = group.GetDouble(BestBidPx.FixTag);
                BestBidPx.Encode(pointer, current, bestBidPx, out current);

                var bestBidSize = group.GetDouble(BestBidSize.FixTag);
                BestBidSize.Encode(pointer, current, bestBidSize, out current);

                var bestOfferPx = group.GetDouble(BestOfferPx.FixTag);
                BestOfferPx.Encode(pointer, current, bestOfferPx, out current);

                var bestOfferSize = group.GetDouble(BestOfferSize.FixTag);
                BestOfferSize.Encode(pointer, current, bestOfferSize, out current);

                var mdBookType = (byte)group.GetInt(MdBookType.FixTag);
                MdBookType.Encode(pointer, current, mdBookType, out current);

                var mdSubBookType = (byte)group.GetInt(MdSubBookType.FixTag);
                MdSubBookType.Encode(pointer, current, mdSubBookType, out current);

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Order Book Item Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noOrderBookItems.FixTag, count);

            while (count--)
            {
                var securityId = SecurityId.Decode(pointer, current, out current);
                message.AppendLong(SecurityId.FixTag, securityId);

                var bestBidPx = BestBidPx.Decode(pointer, current, out current);
                message.AppendDouble(BestBidPx.FixTag, bestBidPx);

                var bestBidSize = BestBidSize.Decode(pointer, current, out current);
                message.AppendDouble(BestBidSize.FixTag, bestBidSize);

                var bestOfferPx = BestOfferPx.Decode(pointer, current, out current);
                message.AppendDouble(BestOfferPx.FixTag, bestOfferPx);

                var bestOfferSize = BestOfferSize.Decode(pointer, current, out current);
                message.AppendDouble(BestOfferSize.FixTag, bestOfferSize);

                var mdBookType = MdBookType.Decode(pointer, current, out current);
                message.AppendInt(MdBookType.FixTag, mdBookType);

                var mdSubBookType = MdSubBookType.Decode(pointer, current, out current);
                message.AppendInt(MdSubBookType.FixTag, mdSubBookType);

                current += Pad6.Length;

            }
        }
    }
}