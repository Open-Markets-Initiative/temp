using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Instrmt Leg Grp Comp Message Methods
/// </summary>

public static partial class InstrmtLegGrpComp
{
    /// <summary>
    ///  Fix Tag for Instrmt Leg Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39111;

    /// <summary>
    ///  Encode Instrmt Leg Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup instrmtLegGrpComp, out int current)
    {
        current = offset;

        foreach (var group in instrmtLegGrpComp.sectionList)
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

            if (group.TryGetInt(LegSymbol.FixTag, out var legSymbol))
            {
                LegSymbol.Encode(pointer, current, legSymbol, out current);
            }
            else
            {
                LegSymbol.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LegRatioQty.FixTag, out var legRatioQty))
            {
                LegRatioQty.Encode(pointer, current, (uint)legRatioQty, out current);
            }
            else
            {
                LegRatioQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LegSide.FixTag, out var legSide))
            {
                LegSide.Encode(pointer, current, (byte)legSide, out current);
            }
            else
            {
                LegSide.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LegSecurityType.FixTag, out var legSecurityType))
            {
                LegSecurityType.Encode(pointer, current, (byte)legSecurityType, out current);
            }
            else
            {
                LegSecurityType.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Instrmt Leg Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoLegOnbooks.FixTag, count);

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

            if (LegSymbol.TryDecode(pointer, current, out var legSymbol, out current))
            {
                message.AppendInt(LegSymbol.FixTag, legSymbol);
            }

            if (LegRatioQty.TryDecode(pointer, current, out var legRatioQty, out current))
            {
                message.AppendInt(LegRatioQty.FixTag, (int)legRatioQty);
            }

            if (LegSide.TryDecode(pointer, current, out var legSide, out current))
            {
                message.AppendInt(LegSide.FixTag, legSide);
            }

            if (LegSecurityType.TryDecode(pointer, current, out var legSecurityType, out current))
            {
                message.AppendInt(LegSecurityType.FixTag, legSecurityType);
            }

            current += Pad6.Length;

        }
    }
}
