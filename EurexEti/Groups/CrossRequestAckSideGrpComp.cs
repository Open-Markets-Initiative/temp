using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Cross Request Ack Side Grp Comp Message Methods
    /// </summary>

    public partial class CrossRequestAckSideGrpComp
    {
        /// <summary>
        ///  Length of Cross Request Ack Side Grp Comp in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Cross Request Ack Side Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, CrossRequestAckSideGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode cross request ack side grp comp ---

            if (!message.TryGetGroup(CrossRequestAckSideGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(CrossRequestAckSideGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var orderId = group.GetULong(OrderId.FixTag);
                OrderId.Encode(pointer, current, orderId, out current);

                var inputSource = (byte)group.GetInt(InputSource.FixTag);
                InputSource.Encode(pointer, current, inputSource, out current);

                var side = (byte)group.GetInt(Side.FixTag);
                Side.Encode(pointer, current, side, out current);

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Cross Request Ack Side Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode cross request ack side grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode cross request ack side grp comp group ---

            message.AppendInt(CrossRequestAckSideGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var orderId = OrderId.Decode(pointer, current, out current);
                message.AppendULong(OrderId.FixTag, orderId);

                var inputSource = InputSource.Decode(pointer, current, out current);
                message.AppendInt(InputSource.FixTag, inputSource);

                var side = Side.Decode(pointer, current, out current);
                message.AppendInt(Side.FixTag, side);

                current += Pad6.Length;

            }
        }
    }
}