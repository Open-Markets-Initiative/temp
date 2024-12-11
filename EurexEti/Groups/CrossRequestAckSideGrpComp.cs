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
                if (group.TryGetULong(OrderId.FixTag, out var orderId))
                {
                    OrderId.Encode(pointer, current, orderId, out current);
                }
                else
                {
                    OrderId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(InputSource.FixTag, out var inputSource))
                {
                    InputSource.Encode(pointer, current, (byte)inputSource, out current);
                }
                else
                {
                    InputSource.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(Side.FixTag, out var side))
                {
                    Side.Encode(pointer, current, (byte)side, out current);
                }
                else
                {
                    Side.SetNull(pointer, current, out current);
                }

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

            message.AppendInt(NoSides.FixTag, count);

            while (count-- > 0)
            {
                if (OrderId.TryDecode(pointer, current, out var orderId, out current))
                {
                    message.AppendULong(OrderId.FixTag, orderId);
                }

                if (InputSource.TryDecode(pointer, current, out var inputSource, out current))
                {
                    message.AppendInt(InputSource.FixTag, inputSource);
                }

                if (Side.TryDecode(pointer, current, out var side, out current))
                {
                    message.AppendInt(Side.FixTag, side);
                }

                current += Pad6.Length;

            }
        }
    }
}