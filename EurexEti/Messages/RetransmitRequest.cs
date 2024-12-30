using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Retransmit Request Message Methods
    /// </summary>

    public static partial class RetransmitRequest
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

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            if (uint.TryParse(message.senderSubID, out var senderSubId))
            {
                SenderSubId.Encode(pointer, current, senderSubId, out current);
            }
            else
            {
                SenderSubId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ApplBegSeqNum.FixTag, out var applBegSeqNum))
            {
                ApplBegSeqNum.Encode(pointer, current, applBegSeqNum, out current);
            }
            else
            {
                ApplBegSeqNum.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ApplEndSeqNum.FixTag, out var applEndSeqNum))
            {
                ApplEndSeqNum.Encode(pointer, current, applEndSeqNum, out current);
            }
            else
            {
                ApplEndSeqNum.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
            {
                PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
            }
            else
            {
                PartitionId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RefApplId.FixTag, out var refApplId))
            {
                RefApplId.Encode(pointer, current, (byte)refApplId, out current);
            }
            else
            {
                RefApplId.SetNull(pointer, current, out current);
            }

            Pad5.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Retransmit Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (ApplBegSeqNum.TryDecode(pointer, current, out var applBegSeqNum, out current))
            {
                message.AppendULong(ApplBegSeqNum.FixTag, applBegSeqNum);
            }

            if (ApplEndSeqNum.TryDecode(pointer, current, out var applEndSeqNum, out current))
            {
                message.AppendULong(ApplEndSeqNum.FixTag, applEndSeqNum);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            if (RefApplId.TryDecode(pointer, current, out var refApplId, out current))
            {
                message.AppendInt(RefApplId.FixTag, refApplId);
            }

            current += Pad5.Length;

            return FixErrorCode.None;
        }
    }
}