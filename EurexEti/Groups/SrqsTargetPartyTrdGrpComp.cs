using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Srqs Target Party Trd Grp Comp Message Methods
/// </summary>

public static partial class SrqsTargetPartyTrdGrpComp
{
    /// <summary>
    ///  Fix Tag for Srqs Target Party Trd Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39145;

    /// <summary>
    ///  Encode Srqs Target Party Trd Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup srqsTargetPartyTrdGrpComp, out int current)
    {
        current = offset;

        foreach (var group in srqsTargetPartyTrdGrpComp.sectionList)
        {
            if (group.TryGetDouble(SideLastQty.FixTag, out var sideLastQty))
            {
                SideLastQty.Encode(pointer, current, sideLastQty, out current);
            }
            else
            {
                SideLastQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetULong(QuoteId.FixTag, out var quoteId))
            {
                QuoteId.Encode(pointer, current, quoteId, out current);
            }
            else
            {
                QuoteId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(TargetPartyIdExecutingTrader.FixTag, out var targetPartyIdExecutingTrader))
            {
                TargetPartyIdExecutingTrader.Encode(pointer, current, (uint)targetPartyIdExecutingTrader, out current);
            }
            else
            {
                TargetPartyIdExecutingTrader.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(TargetPartyExecutingFirm.FixTag, out var targetPartyExecutingFirm))
            {
                TargetPartyExecutingFirm.Encode(pointer, current, targetPartyExecutingFirm, out current);
            }
            else
            {
                TargetPartyExecutingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(TargetPartyExecutingTrader.FixTag, out var targetPartyExecutingTrader))
            {
                TargetPartyExecutingTrader.Encode(pointer, current, targetPartyExecutingTrader, out current);
            }
            else
            {
                TargetPartyExecutingTrader.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(TargetPartyEnteringTrader.FixTag, out var targetPartyEnteringTrader))
            {
                TargetPartyEnteringTrader.Encode(pointer, current, targetPartyEnteringTrader, out current);
            }
            else
            {
                TargetPartyEnteringTrader.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Srqs Target Party Trd Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoSrqsTargetPartyTrdGrps.FixTag, count);

        while (count-- > 0)
        {
            if (SideLastQty.TryDecode(pointer, current, out var sideLastQty, out current))
            {
                message.AppendDouble(SideLastQty.FixTag, sideLastQty);
            }

            if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
            {
                message.AppendULong(QuoteId.FixTag, quoteId);
            }

            if (TargetPartyIdExecutingTrader.TryDecode(pointer, current, out var targetPartyIdExecutingTrader, out current))
            {
                message.AppendInt(TargetPartyIdExecutingTrader.FixTag, (int)targetPartyIdExecutingTrader);
            }

            if (TargetPartyExecutingFirm.TryDecode(pointer, current, out var targetPartyExecutingFirm, out current))
            {
                message.AppendString(TargetPartyExecutingFirm.FixTag, targetPartyExecutingFirm);
            }

            if (TargetPartyExecutingTrader.TryDecode(pointer, current, out var targetPartyExecutingTrader, out current))
            {
                message.AppendString(TargetPartyExecutingTrader.FixTag, targetPartyExecutingTrader);
            }

            if (TargetPartyEnteringTrader.TryDecode(pointer, current, out var targetPartyEnteringTrader, out current))
            {
                message.AppendString(TargetPartyEnteringTrader.FixTag, targetPartyEnteringTrader);
            }

            current += Pad3.Length;

        }
    }
}
