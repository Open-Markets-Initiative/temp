using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Retransmit Me Message Response Message Methods
    /// </summary>

    public partial class RetransmitMeMessageResponse
    {
        /// <summary>
        ///  Eti Identifier for Retransmit Me Message Response
        /// </summary>
        public const string Identifier = "Retransmit Me Message Response";

        /// <summary>
        ///  Encode Retransmit Me Message Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.RetransmitMeMessageResponse, out current);

            // --- encode retransmit me message response message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var applTotalMessageCount = (ushort)message.GetInt(ApplTotalMessageCount.FixTag);
            ApplTotalMessageCount.Encode(pointer, current, applTotalMessageCount, out current);

            var applEndMsgId = message.GetData(ApplEndMsgId.FixTag);
            ApplEndMsgId.Encode(pointer, current, applEndMsgId, out current);

            var refApplLastMsgId = message.GetData(RefApplLastMsgId.FixTag);
            RefApplLastMsgId.Encode(pointer, current, refApplLastMsgId, out current);

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Retransmit Me Message Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = RetransmitMeMessageResponse.Identifier;

            // --- decode retransmit me message response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var applTotalMessageCount = (short)ApplTotalMessageCount.Decode(pointer, current, out current);
            message.AppendInt(ApplTotalMessageCount.FixTag, applTotalMessageCount);

            var applEndMsgId = ApplEndMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplEndMsgId.FixTag, applEndMsgId);

            var refApplLastMsgId = RefApplLastMsgId.Decode(pointer, current, out current);
            message.AppendData(RefApplLastMsgId.FixTag, refApplLastMsgId);

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}