using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Side Alloc Grp Comp Message Methods
/// </summary>

public static partial class SideAllocGrpComp
{
    /// <summary>
    ///  Fix Tag for Side Alloc Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39139;

    /// <summary>
    ///  Encode Side Alloc Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup sideAllocGrpComp, out int current)
    {
        current = offset;

        foreach (var group in sideAllocGrpComp.sectionList)
        {
            if (group.TryGetDouble(AllocQty.FixTag, out var allocQty))
            {
                AllocQty.Encode(pointer, current, allocQty, out current);
            }
            else
            {
                AllocQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(IndividualAllocId.FixTag, out var individualAllocId))
            {
                IndividualAllocId.Encode(pointer, current, (uint)individualAllocId, out current);
            }
            else
            {
                IndividualAllocId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(TesEnrichmentRuleId.FixTag, out var tesEnrichmentRuleId))
            {
                TesEnrichmentRuleId.Encode(pointer, current, (uint)tesEnrichmentRuleId, out current);
            }
            else
            {
                TesEnrichmentRuleId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(Side.FixTag, out var side))
            {
                Side.Encode(pointer, current, (byte)side, out current);
            }
            else
            {
                Side.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
            {
                PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
            }
            else
            {
                PartyExecutingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
            {
                PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
            }
            else
            {
                PartyExecutingTrader.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Side Alloc Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoSideAllocs.FixTag, count);

        while (count-- > 0)
        {
            if (AllocQty.TryDecode(pointer, current, out var allocQty, out current))
            {
                message.AppendDouble(AllocQty.FixTag, allocQty);
            }

            if (IndividualAllocId.TryDecode(pointer, current, out var individualAllocId, out current))
            {
                message.AppendInt(IndividualAllocId.FixTag, (int)individualAllocId);
            }

            if (TesEnrichmentRuleId.TryDecode(pointer, current, out var tesEnrichmentRuleId, out current))
            {
                message.AppendInt(TesEnrichmentRuleId.FixTag, (int)tesEnrichmentRuleId);
            }

            if (Side.TryDecode(pointer, current, out var side, out current))
            {
                message.AppendInt(Side.FixTag, side);
            }

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
            }

            current += Pad4.Length;

        }
    }
}
