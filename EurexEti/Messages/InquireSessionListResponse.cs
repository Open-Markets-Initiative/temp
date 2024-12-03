using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Inquire Session List Response Message Methods
    /// </summary>

    public partial class InquireSessionListResponse
    {
        /// <summary>
        ///  Eti Identifier for Inquire Session List Response
        /// </summary>
        public const string Identifier = "Inquire Session List Response";

        /// <summary>
        ///  Encode Inquire Session List Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquireSessionListResponse, out current);

            // --- encode inquire session list response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var noSessions = (ushort)message.GetInt(NoSessions.FixTag);
            NoSessions.Encode(pointer, current, noSessions, out current);

            Pad6.Encode(pointer, current, out current);

            var partyIdSessionId = (uint)group.GetInt(PartyIdSessionId.FixTag);
            PartyIdSessionId.Encode(pointer, current, partyIdSessionId, out current);

            var sessionMode = (byte)group.GetInt(SessionMode.FixTag);
            SessionMode.Encode(pointer, current, sessionMode, out current);

            var sessionSubMode = (byte)group.GetInt(SessionSubMode.FixTag);
            SessionSubMode.Encode(pointer, current, sessionSubMode, out current);

            Pad2.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, current - offset);
        }

        /// <summary>
        ///  Decode Inquire Session List Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquireSessionListResponse.Identifier;

            // --- decode inquire session list response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var noSessions = (short)NoSessions.Decode(pointer, current, out current);
            message.AppendInt(NoSessions.FixTag, noSessions);

            current += Pad6.Length;

            var partyIdSessionId = (int)PartyIdSessionId.Decode(pointer, current, out current);
            message.AppendInt(PartyIdSessionId.FixTag, partyIdSessionId);

            var sessionMode = SessionMode.Decode(pointer, current, out current);
            message.AppendInt(SessionMode.FixTag, sessionMode);

            var sessionSubMode = SessionSubMode.Decode(pointer, current, out current);
            message.AppendInt(SessionSubMode.FixTag, sessionSubMode);

            current += Pad2.Length;

            return FixErrorCode.None;
        }
    }
}