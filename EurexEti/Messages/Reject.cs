using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Reject Message Methods
    /// </summary>

    public partial class Reject
    {
        /// <summary>
        ///  Eti Identifier for Reject
        /// </summary>
        public const string Identifier = "10010";

        /// <summary>
        ///  Encode Reject Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.Reject, out current);

            // --- encode reject message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad3.Encode(pointer, current, out current);

            var sessionRejectReason = (uint)message.GetInt(SessionRejectReason.FixTag);
            SessionRejectReason.Encode(pointer, current, sessionRejectReason, out current);

            var isVarText = message.TryGetString(VarText.FixTag, out var varText);
            if (isVarText)
            {
                var varTextLen = (ushort)varText.Length;
                VarTextLen.Encode(pointer, current, varTextLen, out current);
            }
            else
            {
                VarTextLen.Zero(pointer, current, out current);
            }

            var sessionStatus = (byte)message.GetInt(SessionStatus.FixTag);
            SessionStatus.Encode(pointer, current, sessionStatus, out current);

            if (isVarText)
            {
                VarText.Encode(pointer, current, varText, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Reject Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = Reject.Identifier;

            // --- decode reject message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var trdRegTsTimeIn = TrdRegTsTimeIn.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var responseIn = ResponseIn.Decode(pointer, current, out current);
            message.AppendULong(ResponseIn.FixTag, responseIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad3.Length;

            var sessionRejectReason = (int)SessionRejectReason.Decode(pointer, current, out current);
            message.AppendInt(SessionRejectReason.FixTag, sessionRejectReason);

            var varTextLen = VarTextLen.Decode(pointer, current, out current);

            var sessionStatus = SessionStatus.Decode(pointer, current, out current);
            message.AppendInt(SessionStatus.FixTag, sessionStatus);

            if (VarText.TryDecode(pointer, current, varTextLen, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            return FixErrorCode.None;
        }
    }
}