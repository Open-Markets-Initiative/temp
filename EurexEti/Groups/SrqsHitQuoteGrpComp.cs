using SRFixBase;

namespace Eurex.Eti.v131;

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
            if (group.TryGetDouble(OrderQty.FixTag, out var orderQty))
            {
                OrderQty.Encode(pointer, current, orderQty, out current);
            }
            else
            {
                OrderQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetULong(QuoteId.FixTag, out var quoteId))
            {
                QuoteId.Encode(pointer, current, quoteId, out current);
            }
            else
            {
                QuoteId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(Side.FixTag, out var side))
            {
                Side.Encode(pointer, current, (byte)side, out current);
            }
            else
            {
                Side.SetNull(pointer, current, out current);
            }

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

        message.AppendInt(NoSrqsQuoteGrps.FixTag, count);

        while (count-- > 0)
        {
            if (OrderQty.TryDecode(pointer, current, out var orderQty, out current))
            {
                message.AppendDouble(OrderQty.FixTag, orderQty);
            }

            if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
            {
                message.AppendULong(QuoteId.FixTag, quoteId);
            }

            if (Side.TryDecode(pointer, current, out var side, out current))
            {
                message.AppendInt(Side.FixTag, side);
            }

            current += Pad7.Length;

        }
    }
}
