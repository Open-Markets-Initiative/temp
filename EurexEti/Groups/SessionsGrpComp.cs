using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Sessions Grp Comp Message Methods
    /// </summary>

    public partial class SessionsGrpComp
    {
        /// <summary>
        ///  Length of Sessions Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Sessions Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, SessionsGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode sessions grp comp ---

            if (!message.TryGetGroup(SessionsGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SessionsGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var partyIdSessionId = (uint)group.GetInt(PartyIdSessionId.FixTag);
                PartyIdSessionId.Encode(pointer, current, partyIdSessionId, out current);

                var sessionMode = (byte)group.GetInt(SessionMode.FixTag);
                SessionMode.Encode(pointer, current, sessionMode, out current);

                var sessionSubMode = (byte)group.GetInt(SessionSubMode.FixTag);
                SessionSubMode.Encode(pointer, current, sessionSubMode, out current);

                Pad2.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Sessions Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode sessions grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode sessions grp comp group ---

            message.AppendInt(SessionsGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var partyIdSessionId = (int)PartyIdSessionId.Decode(pointer, current, out current);
                message.AppendInt(PartyIdSessionId.FixTag, partyIdSessionId);

                var sessionMode = SessionMode.Decode(pointer, current, out current);
                message.AppendInt(SessionMode.FixTag, sessionMode);

                var sessionSubMode = SessionSubMode.Decode(pointer, current, out current);
                message.AppendInt(SessionSubMode.FixTag, sessionSubMode);

                current += Pad2.Length;

            }
        }
    }
}