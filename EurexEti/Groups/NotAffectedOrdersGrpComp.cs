using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Not Affected Orders Grp Comp Message Methods
    /// </summary>

    public partial class NotAffectedOrdersGrpComp
    {
        /// <summary>
        ///  Fix Tag for Not Affected Orders Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39117;

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

            // --- TODO ---

            NotAffectedOrdersGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}