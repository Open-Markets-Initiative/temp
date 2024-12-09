using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Request Ack Side Grp Comp Message Methods
    /// </summary>

    public static partial class CrossRequestAckSideGrpComp
    {
        /// <summary>
        ///  Fix Tag for Cross Request Ack Side Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39106;

        /// <summary>
        ///  Encode Cross Request Ack Side Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup crossRequestAckSideGrpComp, out int current)
        {
            current = offset;

            foreach (var group in crossRequestAckSideGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noSides.FixTag, count);

            while (count--)
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