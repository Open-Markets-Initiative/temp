using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Grp Comp Message Methods
    /// </summary>

    public partial class SrqsQuoteGrpComp
    {
        /// <summary>
        ///  Fix Tag for Srqs Quote Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39144;

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

            // --- TODO ---

            SrqsQuoteGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}