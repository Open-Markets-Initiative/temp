using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Affected Order Requests Grp Comp Message Methods
    /// </summary>

    public static partial class AffectedOrderRequestsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Affected Order Requests Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39100;

        /// <summary>
        ///  Encode Affected Order Requests Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup affectedOrderRequestsGrpComp, out int current)
        {
            current = offset;

            foreach (var group in affectedOrderRequestsGrpComp.sectionList)
            {
                var affectedOrderRequestId = (uint)group.GetInt(AffectedOrderRequestId.FixTag);
                AffectedOrderRequestId.Encode(pointer, current, affectedOrderRequestId, out current);

                Pad4.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Affected Order Requests Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoAffectedOrderRequests.FixTag, count);

            while (count-- > 0)
            {
                var affectedOrderRequestId = (int)AffectedOrderRequestId.Decode(pointer, current, out current);
                message.AppendInt(AffectedOrderRequestId.FixTag, affectedOrderRequestId);

                current += Pad4.Length;

            }
        }
    }
}