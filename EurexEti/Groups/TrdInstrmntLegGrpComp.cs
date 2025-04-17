using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Trd Instrmnt Leg Grp Comp Message Methods
/// </summary>

public static partial class TrdInstrmntLegGrpComp
{
    /// <summary>
    ///  Fix Tag for Trd Instrmnt Leg Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39148;

    /// <summary>
    ///  Encode Trd Instrmnt Leg Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup trdInstrmntLegGrpComp, out int current)
    {
        current = offset;

        foreach (var group in trdInstrmntLegGrpComp.sectionList)
        {
            if (group.TryGetLong(LegSecurityId.FixTag, out var legSecurityId))
            {
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);
            }
            else
            {
                LegSecurityId.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(LegPrice.FixTag, out var legPrice))
            {
                LegPrice.Encode(pointer, current, legPrice, out current);
            }
            else
            {
                LegPrice.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(LegQty.FixTag, out var legQty))
            {
                LegQty.Encode(pointer, current, legQty, out current);
            }
            else
            {
                LegQty.SetNull(pointer, current, out current);
            }

        }
    }

    /// <summary>
    ///  Decode Trd Instrmnt Leg Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoLegs.FixTag, count);

        while (count-- > 0)
        {
            if (LegSecurityId.TryDecode(pointer, current, out var legSecurityId, out current))
            {
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);
            }

            if (LegPrice.TryDecode(pointer, current, out var legPrice, out current))
            {
                message.AppendDouble(LegPrice.FixTag, legPrice);
            }

            if (LegQty.TryDecode(pointer, current, out var legQty, out current))
            {
                message.AppendDouble(LegQty.FixTag, legQty);
            }

        }
    }
}
