using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Instrmnt Leg Exec Grp Comp Message Methods
/// </summary>

public static partial class InstrmntLegExecGrpComp
{
    /// <summary>
    ///  Fix Tag for Instrmnt Leg Exec Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39110;

    /// <summary>
    ///  Encode Instrmnt Leg Exec Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup instrmntLegExecGrpComp, out int current)
    {
        current = offset;

        foreach (var group in instrmntLegExecGrpComp.sectionList)
        {
            if (group.TryGetLong(LegSecurityId.FixTag, out var legSecurityId))
            {
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);
            }
            else
            {
                LegSecurityId.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(LegLastPx.FixTag, out var legLastPx))
            {
                LegLastPx.Encode(pointer, current, legLastPx, out current);
            }
            else
            {
                LegLastPx.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(LegLastQty.FixTag, out var legLastQty))
            {
                LegLastQty.Encode(pointer, current, legLastQty, out current);
            }
            else
            {
                LegLastQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LegExecId.FixTag, out var legExecId))
            {
                LegExecId.Encode(pointer, current, legExecId, out current);
            }
            else
            {
                LegExecId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LegSide.FixTag, out var legSide))
            {
                LegSide.Encode(pointer, current, (byte)legSide, out current);
            }
            else
            {
                LegSide.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(FillRefId.FixTag, out var fillRefId))
            {
                FillRefId.Encode(pointer, current, (byte)fillRefId, out current);
            }
            else
            {
                FillRefId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Instrmnt Leg Exec Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoLegExecs.FixTag, count);

        while (count-- > 0)
        {
            if (LegSecurityId.TryDecode(pointer, current, out var legSecurityId, out current))
            {
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);
            }

            if (LegLastPx.TryDecode(pointer, current, out var legLastPx, out current))
            {
                message.AppendDouble(LegLastPx.FixTag, legLastPx);
            }

            if (LegLastQty.TryDecode(pointer, current, out var legLastQty, out current))
            {
                message.AppendDouble(LegLastQty.FixTag, legLastQty);
            }

            if (LegExecId.TryDecode(pointer, current, out var legExecId, out current))
            {
                message.AppendInt(LegExecId.FixTag, legExecId);
            }

            if (LegSide.TryDecode(pointer, current, out var legSide, out current))
            {
                message.AppendInt(LegSide.FixTag, legSide);
            }

            if (FillRefId.TryDecode(pointer, current, out var fillRefId, out current))
            {
                message.AppendInt(FillRefId.FixTag, fillRefId);
            }

            current += Pad2.Length;

        }
    }
}
