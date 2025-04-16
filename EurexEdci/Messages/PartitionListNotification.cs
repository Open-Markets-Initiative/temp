using SRFixBase;

namespace Eurex.Edci.v130;

/// <summary>
///  Partition List Notification Message Methods
/// </summary>

public static partial class PartitionListNotification
{
    /// <summary>
    ///  Edci Identifier for Partition List Notification
    /// </summary>
    public const string Identifier = "10037";

    /// <summary>
    ///  Encode Partition List Notification Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.PartitionListNotification, out current);

        // --- encode partition list notification message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var isPartitionGrpComp = message.TryGetGroup(NoPartitions.FixTag, out var partitionGrpComp) && partitionGrpComp.sectionList.Count > 0;
        if (isPartitionGrpComp)
        {
            var noPartitions = (byte)partitionGrpComp.sectionList.Count;
            NoPartitions.Encode(pointer, current, noPartitions, out current);
        }
        else
        {
            NoPartitions.Zero(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        if (isPartitionGrpComp)
        {
            PartitionGrpComp.Encode(pointer, current, partitionGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Partition List Notification Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = PartitionListNotification.Identifier;

        // --- decode partition list notification message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        var noPartitions = (int)NoPartitions.Decode(pointer, current, out current);

        current += Pad7.Length;

        PartitionGrpComp.Decode(ref message, pointer, current, noPartitions, out current);

        return FixErrorCode.None;
    }
}
