using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Entry Grp Comp Message Methods
    /// </summary>

    public partial class OrderEntryGrpComp
    {
        /// <summary>
        ///  Length of Order Entry Grp Comp in bytes
        /// </summary>
        public const int Length = 40;

        /// <summary>
        ///  Encode Order Entry Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, OrderEntryGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode order entry grp comp ---

            if (!message.TryGetGroup(OrderEntryGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(OrderEntryGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var price = group.GetDouble(Price.FixTag);
                Price.Encode(pointer, current, price, out current);

                var orderQty = group.GetDouble(OrderQty.FixTag);
                OrderQty.Encode(pointer, current, orderQty, out current);

                var marketSegmentId = group.GetInt(MarketSegmentId.FixTag);
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

                Pad4.Encode(pointer, current, out current);

                var securityId = group.GetLong(SecurityId.FixTag);
                SecurityId.Encode(pointer, current, securityId, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                var productComplex = (byte)group.GetInt(ProductComplex.FixTag);
                ProductComplex.Encode(pointer, current, productComplex, out current);

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Order Entry Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode order entry grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode order entry grp comp group ---

            message.AppendInt(OrderEntryGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var price = Price.Decode(pointer, current, out current);
                message.AppendDouble(Price.FixTag, price);

                var orderQty = OrderQty.Decode(pointer, current, out current);
                message.AppendDouble(OrderQty.FixTag, orderQty);

                var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

                current += Pad4.Length;

                var securityId = SecurityId.Decode(pointer, current, out current);
                message.AppendLong(SecurityId.FixTag, securityId);

                var side = Side.Decode(pointer, current, out current);
                message.AppendInt(Side.FixTag, side);

                var productComplex = ProductComplex.Decode(pointer, current, out current);
                message.AppendInt(ProductComplex.FixTag, productComplex);

                current += Pad6.Length;

            }
        }
    }
}