using SRFixBase;

namespace Eurex.Edci.v130;

/// <summary>
///  Partition Grp Comp Message Methods
/// </summary>

public static partial class PartitionGrpComp
{
    /// <summary>
    ///  Fix Tag for Partition Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39102;

    /// <summary>
    ///  Encode Partition Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup partitionGrpComp, out int current)
    {
        current = offset;

        foreach (var group in partitionGrpComp.sectionList)
        {
            if (group.TryGetInt(PartitionId.FixTag, out var partitionId))
            {
                PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
            }
            else
            {
                PartitionId.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Partition Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoPartitions.FixTag, count);

        while (count-- > 0)
        {
            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            current += Pad6.Length;

        }
    }
}
