using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Sessions Grp Comp Message Methods
    /// </summary>

    public partial static class SessionsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Sessions Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39136;

        /// <summary>
        ///  Encode Sessions Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int sessionsGrpComp, out int current)
        {
            current = offset;

            foreach (var group in sessionsGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noSessions.FixTag, count);

            while (count--)
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