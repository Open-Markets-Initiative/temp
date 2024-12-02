using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Not Affected Orders Grp Comp Message Methods
    /// </summary>

    public partial class NotAffectedOrdersGrpComp
    {
        /// <summary>
        ///  Length of Not Affected Orders Grp Comp in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Not Affected Orders Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, NotAffectedOrdersGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode not affected orders grp comp ---

            if (!message.TryGetGroup(NotAffectedOrdersGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(NotAffectedOrdersGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var notAffectedOrderId = group.GetULong(NotAffectedOrderId.FixTag);
                NotAffectedOrderId.Encode(pointer, current, notAffectedOrderId, out current);

                var notAffOrigClOrdId = group.GetULong(NotAffOrigClOrdId.FixTag);
                NotAffOrigClOrdId.Encode(pointer, current, notAffOrigClOrdId, out current);

            }
        }

        /// <summary>
        ///  Decode Not Affected Orders Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode not affected orders grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode not affected orders grp comp group ---

            message.AppendInt(NotAffectedOrdersGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var notAffectedOrderId = NotAffectedOrderId.Decode(pointer, current, out current);
                message.AppendULong(NotAffectedOrderId.FixTag, notAffectedOrderId);

                var notAffOrigClOrdId = NotAffOrigClOrdId.Decode(pointer, current, out current);
                message.AppendULong(NotAffOrigClOrdId.FixTag, notAffOrigClOrdId);

            }
        }
    }
}