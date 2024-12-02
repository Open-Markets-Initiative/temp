using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Srqs Quote Grp Comp Message Methods
    /// </summary>

    public partial class SrqsQuoteGrpComp
    {
        /// <summary>
        ///  Length of Srqs Quote Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Srqs Quote Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, SrqsQuoteGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode srqs quote grp comp ---

            if (!message.TryGetGroup(SrqsQuoteGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SrqsQuoteGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var quoteId = group.GetULong(QuoteId.FixTag);
                QuoteId.Encode(pointer, current, quoteId, out current);

            }
        }

        /// <summary>
        ///  Decode Srqs Quote Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode srqs quote grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode srqs quote grp comp group ---

            message.AppendInt(SrqsQuoteGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var quoteId = QuoteId.Decode(pointer, current, out current);
                message.AppendULong(QuoteId.FixTag, quoteId);

            }
        }
    }
}