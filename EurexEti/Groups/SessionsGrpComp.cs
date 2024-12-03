using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Sessions Grp Comp Message Methods
    /// </summary>

    public partial class SessionsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Sessions Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39132;

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

            // --- TODO ---

            SessionsGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}