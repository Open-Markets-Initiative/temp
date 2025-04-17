using SRFixBase;

namespace Eurex.Eti.v131;

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
            if (group.TryGetULong(QuoteId.FixTag, out var quoteId))
            {
                QuoteId.Encode(pointer, current, quoteId, out current);
            }
            else
            {
                QuoteId.SetNull(pointer, current, out current);
            }

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
            if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
            {
                message.AppendULong(QuoteId.FixTag, quoteId);
            }

        }
    }
}
