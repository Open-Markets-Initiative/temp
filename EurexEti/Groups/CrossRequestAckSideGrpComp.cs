using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Cross Request Ack Side Grp Comp Message Methods
    /// </summary>

    public partial class CrossRequestAckSideGrpComp
    {
        /// <summary>
        ///  Fix Tag for Cross Request Ack Side Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39106;

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

            // --- TODO ---

            CrossRequestAckSideGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}