using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
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
                var orderEventPx = group.GetDouble(OrderEventPx.FixTag);
                OrderEventPx.Encode(pointer, current, orderEventPx, out current);

                var orderEventQty = group.GetDouble(OrderEventQty.FixTag);
                OrderEventQty.Encode(pointer, current, orderEventQty, out current);

                var orderEventMatchId = (uint)group.GetInt(OrderEventMatchId.FixTag);
                OrderEventMatchId.Encode(pointer, current, orderEventMatchId, out current);

                var orderEventReason = (byte)group.GetInt(OrderEventReason.FixTag);
                OrderEventReason.Encode(pointer, current, orderEventReason, out current);

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

            message.AppendInt(noOrderEvents.FixTag, count);

            while (count--)
            {
                var orderEventPx = OrderEventPx.Decode(pointer, current, out current);
                message.AppendDouble(OrderEventPx.FixTag, orderEventPx);

                var orderEventQty = OrderEventQty.Decode(pointer, current, out current);
                message.AppendDouble(OrderEventQty.FixTag, orderEventQty);

                var orderEventMatchId = (int)OrderEventMatchId.Decode(pointer, current, out current);
                message.AppendInt(OrderEventMatchId.FixTag, orderEventMatchId);

                var orderEventReason = OrderEventReason.Decode(pointer, current, out current);
                message.AppendInt(OrderEventReason.FixTag, orderEventReason);

                current += Pad3.Length;

            }
        }
    }
}