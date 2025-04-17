using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Underlying Stip Grp Comp Message Methods
/// </summary>

public static partial class UnderlyingStipGrpComp
{
    /// <summary>
    ///  Fix Tag for Underlying Stip Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39149;

    /// <summary>
    ///  Encode Underlying Stip Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup underlyingStipGrpComp, out int current)
    {
        current = offset;

        foreach (var group in underlyingStipGrpComp.sectionList)
        {
            if (group.TryGetString(UnderlyingStipValue.FixTag, out var underlyingStipValue))
            {
                UnderlyingStipValue.Encode(pointer, current, underlyingStipValue, out current);
            }
            else
            {
                UnderlyingStipValue.SetNull(pointer, current, out current);
            }

            if (group.TryGetToken(UnderlyingStipType.FixTag, out var underlyingStipType))
            {
                UnderlyingStipType.Encode(pointer, current, underlyingStipType, out current);
            }
            else
            {
                UnderlyingStipType.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Underlying Stip Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoUnderlyingStips.FixTag, count);

        while (count-- > 0)
        {
            if (UnderlyingStipValue.TryDecode(pointer, current, out var underlyingStipValue, out current))
            {
                message.AppendString(UnderlyingStipValue.FixTag, underlyingStipValue);
            }

            if (UnderlyingStipType.TryDecode(pointer, current, out var underlyingStipType, out current))
            {
                message.AppendToken(UnderlyingStipType.FixTag, underlyingStipType);
            }

            current += Pad1.Length;

        }
    }
}
