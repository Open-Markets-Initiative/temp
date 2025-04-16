using SRFixBase;

namespace Eurex.Edci.v130;

/// <summary>
///  Delete Order Broadcast Message Methods
/// </summary>

public static partial class DeleteOrderBroadcast
{
    /// <summary>
    ///  Eti Identifier for Delete Order Broadcast
    /// </summary>
    public const string Identifier = "10902";

    /// <summary>
    ///  Encode Delete Order Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.DeleteOrderBroadcast, out current);

        // --- encode delete order broadcast message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        if (message.TryGetInt(PartyIdExecutingUnit.FixTag, out var partyIdExecutingUnit))
        {
            PartyIdExecutingUnit.Encode(pointer, current, (uint)partyIdExecutingUnit, out current);
        }
        else
        {
            PartyIdExecutingUnit.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
        {
            PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
        }
        else
        {
            PartitionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplId.FixTag, out var applId))
        {
            ApplId.Encode(pointer, current, (byte)applId, out current);
        }
        else
        {
            ApplId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ExecId.FixTag, out var execId))
        {
            ExecId.Encode(pointer, current, execId, out current);
        }
        else
        {
            ExecId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        var isAffectedOrdGrpComp = message.TryGetGroup(NoAffectedOrders.FixTag, out var affectedOrdGrpComp) && affectedOrdGrpComp.sectionList.Count > 0;
        if (isAffectedOrdGrpComp)
        {
            var noAffectedOrders = (ushort)affectedOrdGrpComp.sectionList.Count;
            NoAffectedOrders.Encode(pointer, current, noAffectedOrders, out current);
        }
        else
        {
            NoAffectedOrders.Zero(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

        if (isAffectedOrdGrpComp)
        {
            AffectedOrdGrpComp.Encode(pointer, current, affectedOrdGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Delete Order Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = DeleteOrderBroadcast.Identifier;

        // --- decode delete order broadcast message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (PartyIdExecutingUnit.TryDecode(pointer, current, out var partyIdExecutingUnit, out current))
        {
            message.AppendInt(PartyIdExecutingUnit.FixTag, (int)partyIdExecutingUnit);
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        if (ExecId.TryDecode(pointer, current, out var execId, out current))
        {
            message.AppendULong(ExecId.FixTag, execId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        var noAffectedOrders = (int)NoAffectedOrders.Decode(pointer, current, out current);

        current += Pad2.Length;

        AffectedOrdGrpComp.Decode(ref message, pointer, current, noAffectedOrders, out current);

        return FixErrorCode.None;
    }
}
