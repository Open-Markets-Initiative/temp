using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Sessions Grp Comp Message Methods
    /// </summary>

    public static partial class SessionsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Sessions Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39136;

        /// <summary>
        ///  Encode Sessions Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup sessionsGrpComp, out int current)
        {
            current = offset;

            foreach (var group in sessionsGrpComp.sectionList)
            {
                if (group.TryGetInt(PartyIdSessionId.FixTag, out var partyIdSessionId))
                {
                    PartyIdSessionId.Encode(pointer, current, (uint)partyIdSessionId, out current);
                }
                else
                {
                    PartyIdSessionId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(SessionMode.FixTag, out var sessionMode))
                {
                    SessionMode.Encode(pointer, current, (byte)sessionMode, out current);
                }
                else
                {
                    SessionMode.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(SessionSubMode.FixTag, out var sessionSubMode))
                {
                    SessionSubMode.Encode(pointer, current, (byte)sessionSubMode, out current);
                }
                else
                {
                    SessionSubMode.SetNull(pointer, current, out current);
                }

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

            message.AppendInt(NoSessions.FixTag, count);

            while (count-- > 0)
            {
                if (PartyIdSessionId.TryDecode(pointer, current, out var partyIdSessionId, out current))
                {
                    message.AppendInt(PartyIdSessionId.FixTag, (int)partyIdSessionId);
                }

                if (SessionMode.TryDecode(pointer, current, out var sessionMode, out current))
                {
                    message.AppendInt(SessionMode.FixTag, sessionMode);
                }

                if (SessionSubMode.TryDecode(pointer, current, out var sessionSubMode, out current))
                {
                    message.AppendInt(SessionSubMode.FixTag, sessionSubMode);
                }

                current += Pad2.Length;

            }
        }
    }
}