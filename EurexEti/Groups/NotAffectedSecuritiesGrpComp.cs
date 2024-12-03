using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Not Affected Securities Grp Comp Message Methods
    /// </summary>

    public partial class NotAffectedSecuritiesGrpComp
    {
        /// <summary>
        ///  Fix Tag for Not Affected Securities Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39118;

        /// <summary>
        ///  Length of Not Affected Securities Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Not Affected Securities Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode not affected securities grp comp ---

            if (!message.TryGetGroup(NotAffectedSecuritiesGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(NotAffectedSecuritiesGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var notAffectedSecurityId = group.GetULong(NotAffectedSecurityId.FixTag);
                NotAffectedSecurityId.Encode(pointer, current, notAffectedSecurityId, out current);

            }
        }

        /// <summary>
        ///  Decode Not Affected Securities Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            NotAffectedSecuritiesGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}