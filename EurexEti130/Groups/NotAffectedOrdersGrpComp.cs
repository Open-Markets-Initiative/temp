using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Not Affected Orders Grp Comp Message Methods
/// </summary>

public static partial class NotAffectedOrdersGrpComp
{
    /// <summary>
    ///  Fix Tag for Not Affected Orders Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39119;

    /// <summary>
    ///  Encode Not Affected Orders Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup notAffectedOrdersGrpComp, out int current)
    {
        current = offset;

        foreach (var group in notAffectedOrdersGrpComp.sectionList)
        {
            if (group.TryGetULong(NotAffectedOrderId.FixTag, out var notAffectedOrderId))
            {
                NotAffectedOrderId.Encode(pointer, current, notAffectedOrderId, out current);
            }
            else
            {
                NotAffectedOrderId.SetNull(pointer, current, out current);
            }

            if (group.TryGetULong(NotAffOrigClOrdId.FixTag, out var notAffOrigClOrdId))
            {
                NotAffOrigClOrdId.Encode(pointer, current, notAffOrigClOrdId, out current);
            }
            else
            {
                NotAffOrigClOrdId.SetNull(pointer, current, out current);
            }

        }
    }

    /// <summary>
    ///  Decode Not Affected Orders Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoNotAffectedOrders.FixTag, count);

        while (count-- > 0)
        {
            if (NotAffectedOrderId.TryDecode(pointer, current, out var notAffectedOrderId, out current))
            {
                message.AppendULong(NotAffectedOrderId.FixTag, notAffectedOrderId);
            }

            if (NotAffOrigClOrdId.TryDecode(pointer, current, out var notAffOrigClOrdId, out current))
            {
                message.AppendULong(NotAffOrigClOrdId.FixTag, notAffOrigClOrdId);
            }

        }
    }
}
