using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Entry Grp Comp Message Methods
    /// </summary>

    public partial static class OrderEntryGrpComp
    {
        /// <summary>
        ///  Fix Tag for Order Entry Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39124;

        /// <summary>
        ///  Encode Order Entry Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int orderEntryGrpComp, out int current)
        {
            current = offset;

            foreach (var group in orderEntryGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noOrderEntries.FixTag, count);

            while (count--)
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