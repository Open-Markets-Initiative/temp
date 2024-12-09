using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Hit Quote Grp Comp Message Methods
    /// </summary>

    public static partial class SrqsHitQuoteGrpComp
    {
        /// <summary>
        ///  Fix Tag for Srqs Hit Quote Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39142;

        /// <summary>
        ///  Encode Srqs Hit Quote Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup srqsHitQuoteGrpComp, out int current)
        {
            current = offset;

            foreach (var group in srqsHitQuoteGrpComp.sectionList)
            {
                var orderQty = group.GetDouble(OrderQty.FixTag);
                OrderQty.Encode(pointer, current, orderQty, out current);

                var quoteId = group.GetULong(QuoteId.FixTag);
                QuoteId.Encode(pointer, current, quoteId, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Srqs Hit Quote Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noSrqsQuoteGrps.FixTag, count);

            while (count--)
            {
                var orderQty = OrderQty.Decode(pointer, current, out current);
                message.AppendDouble(OrderQty.FixTag, orderQty);

                var quoteId = QuoteId.Decode(pointer, current, out current);
                message.AppendULong(QuoteId.FixTag, quoteId);

                var side = Side.Decode(pointer, current, out current);
                message.AppendInt(Side.FixTag, side);

                current += Pad7.Length;

            }
        }
    }
}