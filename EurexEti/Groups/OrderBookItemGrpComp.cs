using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Book Item Grp Comp Message Methods
    /// </summary>

    public partial class OrderBookItemGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, OrderBookItemGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode order book item grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode order book item grp comp group ---

            message.AppendInt(OrderBookItemGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
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