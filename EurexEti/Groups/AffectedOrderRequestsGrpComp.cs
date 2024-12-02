using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Affected Order Requests Grp Comp Message Methods
    /// </summary>

    public partial class AffectedOrderRequestsGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, AffectedOrderRequestsGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode affected order requests grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode affected order requests grp comp group ---

            message.AppendInt(AffectedOrderRequestsGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var affectedOrderRequestId = (int)AffectedOrderRequestId.Decode(pointer, current, out current);
                message.AppendInt(AffectedOrderRequestId.FixTag, affectedOrderRequestId);

                current += Pad4.Length;

            }
        }
    }
}