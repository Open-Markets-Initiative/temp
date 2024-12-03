using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Entry Grp Comp Message Methods
    /// </summary>

    public partial class OrderEntryGrpComp
    {
        /// <summary>
        ///  Fix Tag for Order Entry Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39120;

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

            // --- TODO ---

            OrderEntryGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}