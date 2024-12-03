using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Event Grp Comp Message Methods
    /// </summary>

    public partial class OrderEventGrpComp
    {
        /// <summary>
        ///  Fix Tag for Order Event Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39121;

        /// <summary>
        ///  Length of Order Event Grp Comp in bytes
        /// </summary>
        public const int Length = 24;

        /// <summary>
        ///  Encode Order Event Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode order event grp comp ---

            if (!message.TryGetGroup(OrderEventGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(OrderEventGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            OrderEventGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}