using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Book Item Grp Comp Message Methods
    /// </summary>

    public static partial class OrderBookItemGrpComp
    {
        /// <summary>
        ///  Fix Tag for Order Book Item Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39123;

        /// <summary>
        ///  Encode Order Book Item Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup orderBookItemGrpComp, out int current)
        {
            current = offset;

            foreach (var group in orderBookItemGrpComp.sectionList)
            {
                if (group.TryGetLong(SecurityId.FixTag, out var securityId))
                {
                    SecurityId.Encode(pointer, current, securityId, out current);
                }
                else
                {
                    SecurityId.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(BestBidPx.FixTag, out var bestBidPx))
                {
                    BestBidPx.Encode(pointer, current, bestBidPx, out current);
                }
                else
                {
                    BestBidPx.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(BestBidSize.FixTag, out var bestBidSize))
                {
                    BestBidSize.Encode(pointer, current, bestBidSize, out current);
                }
                else
                {
                    BestBidSize.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(BestOfferPx.FixTag, out var bestOfferPx))
                {
                    BestOfferPx.Encode(pointer, current, bestOfferPx, out current);
                }
                else
                {
                    BestOfferPx.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(BestOfferSize.FixTag, out var bestOfferSize))
                {
                    BestOfferSize.Encode(pointer, current, bestOfferSize, out current);
                }
                else
                {
                    BestOfferSize.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(MdBookType.FixTag, out var mdBookType))
                {
                    MdBookType.Encode(pointer, current, (byte)mdBookType, out current);
                }
                else
                {
                    MdBookType.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(MdSubBookType.FixTag, out var mdSubBookType))
                {
                    MdSubBookType.Encode(pointer, current, (byte)mdSubBookType, out current);
                }
                else
                {
                    MdSubBookType.SetNull(pointer, current, out current);
                }

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

            message.AppendInt(NoOrderBookItems.FixTag, count);

            while (count-- > 0)
            {
                if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
                {
                    message.AppendLong(SecurityId.FixTag, securityId);
                }

                if (BestBidPx.TryDecode(pointer, current, out var bestBidPx, out current))
                {
                    message.AppendDouble(BestBidPx.FixTag, bestBidPx);
                }

                if (BestBidSize.TryDecode(pointer, current, out var bestBidSize, out current))
                {
                    message.AppendDouble(BestBidSize.FixTag, bestBidSize);
                }

                if (BestOfferPx.TryDecode(pointer, current, out var bestOfferPx, out current))
                {
                    message.AppendDouble(BestOfferPx.FixTag, bestOfferPx);
                }

                if (BestOfferSize.TryDecode(pointer, current, out var bestOfferSize, out current))
                {
                    message.AppendDouble(BestOfferSize.FixTag, bestOfferSize);
                }

                if (MdBookType.TryDecode(pointer, current, out var mdBookType, out current))
                {
                    message.AppendInt(MdBookType.FixTag, mdBookType);
                }

                if (MdSubBookType.TryDecode(pointer, current, out var mdSubBookType, out current))
                {
                    message.AppendInt(MdSubBookType.FixTag, mdSubBookType);
                }

                current += Pad6.Length;

            }
        }
    }
}