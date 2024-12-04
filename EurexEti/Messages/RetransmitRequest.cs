using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Retransmit Request Message Methods
    /// </summary>

    public partial class RetransmitRequest
    {
        /// <summary>
        ///  Eti Identifier for Retransmit Request
        /// </summary>
        public const string Identifier = "10008";

        /// <summary>
        ///  Encode Retransmit Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.RetransmitRequest, out current);

            // --- encode retransmit request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = (uint)message.GetInt(SenderSubId.FixTag);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var applBegSeqNum = message.GetULong(ApplBegSeqNum.FixTag);
            ApplBegSeqNum.Encode(pointer, current, applBegSeqNum, out current);

            var applEndSeqNum = message.GetULong(ApplEndSeqNum.FixTag);
            ApplEndSeqNum.Encode(pointer, current, applEndSeqNum, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var refApplId = (byte)message.GetInt(RefApplId.FixTag);
            RefApplId.Encode(pointer, current, refApplId, out current);

            Pad5.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Retransmit Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = RetransmitRequest.Identifier;

            // --- decode retransmit request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var applBegSeqNum = ApplBegSeqNum.Decode(pointer, current, out current);
            message.AppendULong(ApplBegSeqNum.FixTag, applBegSeqNum);

            var applEndSeqNum = ApplEndSeqNum.Decode(pointer, current, out current);
            message.AppendULong(ApplEndSeqNum.FixTag, applEndSeqNum);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var refApplId = RefApplId.Decode(pointer, current, out current);
            message.AppendInt(RefApplId.FixTag, refApplId);

            current += Pad5.Length;

            return FixErrorCode.None;
        }
    }
}