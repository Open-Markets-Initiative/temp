using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Retransmit Response Message Methods
    /// </summary>

    public partial class RetransmitResponse
    {
        /// <summary>
        ///  Eti Identifier for Retransmit Response
        /// </summary>
        public const string Identifier = "10009";

        /// <summary>
        ///  Encode Retransmit Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.RetransmitResponse, out current);

            // --- encode retransmit response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.sendTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var applEndSeqNum = message.GetULong(ApplEndSeqNum.FixTag);
            ApplEndSeqNum.Encode(pointer, current, applEndSeqNum, out current);

            var refApplLastSeqNum = message.GetULong(RefApplLastSeqNum.FixTag);
            RefApplLastSeqNum.Encode(pointer, current, refApplLastSeqNum, out current);

            var applTotalMessageCount = (ushort)message.GetInt(ApplTotalMessageCount.FixTag);
            ApplTotalMessageCount.Encode(pointer, current, applTotalMessageCount, out current);

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Retransmit Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = RetransmitResponse.Identifier;

            // --- decode retransmit response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            current += Pad4.Length;

            var applEndSeqNum = ApplEndSeqNum.Decode(pointer, current, out current);
            message.AppendULong(ApplEndSeqNum.FixTag, applEndSeqNum);

            var refApplLastSeqNum = RefApplLastSeqNum.Decode(pointer, current, out current);
            message.AppendULong(RefApplLastSeqNum.FixTag, refApplLastSeqNum);

            var applTotalMessageCount = (short)ApplTotalMessageCount.Decode(pointer, current, out current);
            message.AppendInt(ApplTotalMessageCount.FixTag, applTotalMessageCount);

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}