using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Entry Grp Comp Message Methods
    /// </summary>

    public static partial class OrderEntryGrpComp
    {
        /// <summary>
        ///  Fix Tag for Order Entry Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39124;

        /// <summary>
        ///  Encode Order Entry Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup orderEntryGrpComp, out int current)
        {
            current = offset;

            foreach (var group in orderEntryGrpComp.sectionList)
            {
                if (group.TryGetDouble(Price.FixTag, out var price))
                {
                    Price.Encode(pointer, current, price, out current);
                }
                else
                {
                    Price.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(OrderQty.FixTag, out var orderQty))
                {
                    OrderQty.Encode(pointer, current, orderQty, out current);
                }
                else
                {
                    OrderQty.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
                {
                    MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
                }
                else
                {
                    MarketSegmentId.SetNull(pointer, current, out current);
                }

                Pad4.Encode(pointer, current, out current);

                if (group.TryGetLong(SecurityId.FixTag, out var securityId))
                {
                    SecurityId.Encode(pointer, current, securityId, out current);
                }
                else
                {
                    SecurityId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(Side.FixTag, out var side))
                {
                    Side.Encode(pointer, current, (byte)side, out current);
                }
                else
                {
                    Side.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(ProductComplex.FixTag, out var productComplex))
                {
                    ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
                }
                else
                {
                    ProductComplex.SetNull(pointer, current, out current);
                }

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

            message.AppendInt(NoOrderEntries.FixTag, count);

            while (count-- > 0)
            {
                if (Price.TryDecode(pointer, current, out var price, out current))
                {
                    message.AppendDouble(Price.FixTag, price);
                }

                if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
                {
                    message.AppendDouble(OrderQty.FixTag, orderQty);
                }

                if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
                {
                    message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
                }

                current += Pad4.Length;

                if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
                {
                    message.AppendLong(SecurityId.FixTag, securityId);
                }

                if (Side.TryDecode(pointer, current, out var side, out current))
                {
                    message.AppendInt(Side.FixTag, side);
                }

                if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
                {
                    message.AppendInt(ProductComplex.FixTag, productComplex);
                }

                current += Pad6.Length;

            }
        }
    }
}