using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Retransmit Me Message Request Message Methods
    /// </summary>

    public partial class RetransmitMeMessageRequest
    {
        /// <summary>
        ///  Eti Identifier for Retransmit Me Message Request
        /// </summary>
        public const string Identifier = "Retransmit Me Message Request";

        /// <summary>
        ///  Encode Retransmit Me Message Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.RetransmitMeMessageRequest, out current);

            // --- encode retransmit me message request message ---

            var start = current;

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

            var subscriptionScope = (uint)message.GetInt(SubscriptionScope.FixTag);
            SubscriptionScope.Encode(pointer, current, subscriptionScope, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var refApplId = (byte)message.GetInt(RefApplId.FixTag);
            RefApplId.Encode(pointer, current, refApplId, out current);

            var applBegMsgId = message.GetData(ApplBegMsgId.FixTag);
            ApplBegMsgId.Encode(pointer, current, applBegMsgId, out current);

            var applEndMsgId = message.GetData(ApplEndMsgId.FixTag);
            ApplEndMsgId.Encode(pointer, current, applEndMsgId, out current);

            Pad1.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Retransmit Me Message Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = RetransmitMeMessageRequest.Identifier;

            // --- decode retransmit me message request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var subscriptionScope = (int)SubscriptionScope.Decode(pointer, current, out current);
            message.AppendInt(SubscriptionScope.FixTag, subscriptionScope);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var refApplId = RefApplId.Decode(pointer, current, out current);
            message.AppendInt(RefApplId.FixTag, refApplId);

            var applBegMsgId = ApplBegMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplBegMsgId.FixTag, applBegMsgId);

            var applEndMsgId = ApplEndMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplEndMsgId.FixTag, applEndMsgId);

            current += Pad1.Length;

            return FixErrorCode.None;
        }
    }
}