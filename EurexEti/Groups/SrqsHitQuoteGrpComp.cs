using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Hit Quote Grp Comp Message Methods
    /// </summary>

    public partial class SrqsHitQuoteGrpComp
    {
        /// <summary>
        ///  Fix Tag for Srqs Hit Quote Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39142;

        /// <summary>
        ///  Length of Srqs Hit Quote Grp Comp in bytes
        /// </summary>
        public const int Length = 24;

        /// <summary>
        ///  Encode Srqs Hit Quote Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode srqs hit quote grp comp ---

            if (!message.TryGetGroup(SrqsHitQuoteGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SrqsHitQuoteGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            SrqsHitQuoteGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}