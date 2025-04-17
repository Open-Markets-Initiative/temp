using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Affected Order Requests Grp Comp Message Methods
/// </summary>

public static partial class AffectedOrderRequestsGrpComp
{
    /// <summary>
    ///  Fix Tag for Affected Order Requests Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39100;

    /// <summary>
    ///  Encode Affected Order Requests Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup affectedOrderRequestsGrpComp, out int current)
    {
        current = offset;

        foreach (var group in affectedOrderRequestsGrpComp.sectionList)
        {
            if (group.TryGetInt(AffectedOrderRequestId.FixTag, out var affectedOrderRequestId))
            {
                AffectedOrderRequestId.Encode(pointer, current, (uint)affectedOrderRequestId, out current);
            }
            else
            {
                AffectedOrderRequestId.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Affected Order Requests Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoAffectedOrderRequests.FixTag, count);

        while (count-- > 0)
        {
            if (AffectedOrderRequestId.TryDecode(pointer, current, out var affectedOrderRequestId, out current))
            {
                message.AppendInt(AffectedOrderRequestId.FixTag, (int)affectedOrderRequestId);
            }

            current += Pad4.Length;

        }
    }
}
