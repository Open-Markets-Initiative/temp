using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Grp Comp Message Methods
    /// </summary>

    public static partial class SrqsQuoteGrpComp
    {
        /// <summary>
        ///  Fix Tag for Srqs Quote Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39144;

        /// <summary>
        ///  Encode Srqs Quote Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup srqsQuoteGrpComp, out int current)
        {
            current = offset;

            foreach (var group in srqsQuoteGrpComp.sectionList)
            {
                var quoteId = group.GetULong(QuoteId.FixTag);
                QuoteId.Encode(pointer, current, quoteId, out current);

            }
        }

        /// <summary>
        ///  Decode Srqs Quote Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoSrqsQuoteGrps.FixTag, count);

            while (count-- > 0)
            {
                var quoteId = QuoteId.Decode(pointer, current, out current);
                message.AppendULong(QuoteId.FixTag, quoteId);

            }
        }
    }
}