using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Srqs Hit Quote Grp Comp Message Methods
    /// </summary>

    public partial class SrqsHitQuoteGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, SrqsHitQuoteGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode srqs hit quote grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode srqs hit quote grp comp group ---

            message.AppendInt(SrqsHitQuoteGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
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