using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Book Item Grp Comp Message Methods
    /// </summary>

    public partial class OrderBookItemGrpComp
    {
        /// <summary>
        ///  Fix Tag for Order Book Item Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39119;

        /// <summary>
        ///  Length of Order Book Item Grp Comp in bytes
        /// </summary>
        public const int Length = 48;

        /// <summary>
        ///  Encode Order Book Item Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode order book item grp comp ---

            if (!message.TryGetGroup(OrderBookItemGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(OrderBookItemGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            OrderBookItemGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}