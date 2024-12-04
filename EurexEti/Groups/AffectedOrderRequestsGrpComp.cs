using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Affected Order Requests Grp Comp Message Methods
    /// </summary>

    public partial class AffectedOrderRequestsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Affected Order Requests Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39100;

        /// <summary>
        ///  Length of Affected Order Requests Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Affected Order Requests Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode affected order requests grp comp ---

            if (!message.TryGetGroup(AffectedOrderRequestsGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(AffectedOrderRequestsGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var affectedOrderRequestId = (uint)group.GetInt(AffectedOrderRequestId.FixTag);
                AffectedOrderRequestId.Encode(pointer, current, affectedOrderRequestId, out current);

                Pad4.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Affected Order Requests Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            AffectedOrderRequestsGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}