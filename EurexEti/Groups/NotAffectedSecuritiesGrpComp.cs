using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Not Affected Securities Grp Comp Message Methods
    /// </summary>

    public partial class NotAffectedSecuritiesGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, NotAffectedSecuritiesGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode not affected securities grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode not affected securities grp comp group ---

            message.AppendInt(NotAffectedSecuritiesGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var notAffectedSecurityId = NotAffectedSecurityId.Decode(pointer, current, out current);
                message.AppendULong(NotAffectedSecurityId.FixTag, notAffectedSecurityId);

            }
        }
    }
}