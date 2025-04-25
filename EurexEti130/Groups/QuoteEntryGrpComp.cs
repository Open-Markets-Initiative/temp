using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Quote Entry Grp Comp Message Methods
/// </summary>

public static partial class QuoteEntryGrpComp
{
    /// <summary>
    ///  Fix Tag for Quote Entry Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39129;

    /// <summary>
    ///  Encode Quote Entry Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup quoteEntryGrpComp, out int current)
    {
        current = offset;

        foreach (var group in quoteEntryGrpComp.sectionList)
        {
            if (group.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(BidPx.FixTag, out var bidPx))
            {
                BidPx.Encode(pointer, current, bidPx, out current);
            }
            else
            {
                BidPx.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(BidSize.FixTag, out var bidSize))
            {
                BidSize.Encode(pointer, current, bidSize, out current);
            }
            else
            {
                BidSize.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(OfferPx.FixTag, out var offerPx))
            {
                OfferPx.Encode(pointer, current, offerPx, out current);
            }
            else
            {
                OfferPx.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(OfferSize.FixTag, out var offerSize))
            {
                OfferSize.Encode(pointer, current, offerSize, out current);
            }
            else
            {
                OfferSize.SetNull(pointer, current, out current);
            }

        }
    }

    /// <summary>
    ///  Decode Quote Entry Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoQuoteEntries.FixTag, count);

        while (count-- > 0)
        {
            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (BidPx.TryDecode(pointer, current, out var bidPx, out current))
            {
                message.AppendDouble(BidPx.FixTag, bidPx);
            }

            if (BidSize.TryDecode(pointer, current, out var bidSize, out current))
            {
                message.AppendDouble(BidSize.FixTag, bidSize);
            }

            if (OfferPx.TryDecode(pointer, current, out var offerPx, out current))
            {
                message.AppendDouble(OfferPx.FixTag, offerPx);
            }

            if (OfferSize.TryDecode(pointer, current, out var offerSize, out current))
            {
                message.AppendDouble(OfferSize.FixTag, offerSize);
            }

        }
    }
}
