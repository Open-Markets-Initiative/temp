using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Order Event Grp Comp Message Methods
/// </summary>

public static partial class OrderEventGrpComp
{
    /// <summary>
    ///  Fix Tag for Order Event Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39125;

    /// <summary>
    ///  Encode Order Event Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup orderEventGrpComp, out int current)
    {
        current = offset;

        foreach (var group in orderEventGrpComp.sectionList)
        {
            if (group.TryGetDouble(OrderEventPx.FixTag, out var orderEventPx))
            {
                OrderEventPx.Encode(pointer, current, orderEventPx, out current);
            }
            else
            {
                OrderEventPx.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(OrderEventQty.FixTag, out var orderEventQty))
            {
                OrderEventQty.Encode(pointer, current, orderEventQty, out current);
            }
            else
            {
                OrderEventQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(OrderEventMatchId.FixTag, out var orderEventMatchId))
            {
                OrderEventMatchId.Encode(pointer, current, (uint)orderEventMatchId, out current);
            }
            else
            {
                OrderEventMatchId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(OrderEventReason.FixTag, out var orderEventReason))
            {
                OrderEventReason.Encode(pointer, current, (byte)orderEventReason, out current);
            }
            else
            {
                OrderEventReason.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Order Event Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoOrderEvents.FixTag, count);

        while (count-- > 0)
        {
            if (OrderEventPx.TryDecode(pointer, current, out var orderEventPx, out current))
            {
                message.AppendDouble(OrderEventPx.FixTag, orderEventPx);
            }

            if (OrderEventQty.TryDecode(pointer, current, out var orderEventQty, out current))
            {
                message.AppendDouble(OrderEventQty.FixTag, orderEventQty);
            }

            if (OrderEventMatchId.TryDecode(pointer, current, out var orderEventMatchId, out current))
            {
                message.AppendInt(OrderEventMatchId.FixTag, (int)orderEventMatchId);
            }

            if (OrderEventReason.TryDecode(pointer, current, out var orderEventReason, out current))
            {
                message.AppendInt(OrderEventReason.FixTag, orderEventReason);
            }

            current += Pad3.Length;

        }
    }
}
