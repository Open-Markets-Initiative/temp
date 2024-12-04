using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Inquire Session List Response Message Methods
    /// </summary>

    public partial class InquireSessionListResponse
    {
        /// <summary>
        ///  Eti Identifier for Inquire Session List Response
        /// </summary>
        public const string Identifier = "10036";

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

            var sessionsGrpComp = (byte)message.GetInt(SessionsGrpComp.FixTag);
            SessionsGrpComp.Encode(message, pointer, current, sessionsGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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
            message.sendingTime = new DateTime((long)sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var noSessions = (short)NoSessions.Decode(pointer, current, out current);
            message.AppendInt(NoSessions.FixTag, noSessions);

            current += Pad6.Length;

            SessionsGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}