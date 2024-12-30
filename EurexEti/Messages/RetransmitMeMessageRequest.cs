using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Retransmit Me Message Request Message Methods
    /// </summary>

    public static partial class RetransmitMeMessageRequest
    {
        /// <summary>
        ///  Eti Identifier for Retransmit Me Message Request
        /// </summary>
        public const string Identifier = "10026";

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

            if (message.TryGetInt(SubscriptionScope.FixTag, out var subscriptionScope))
            {
                SubscriptionScope.Encode(pointer, current, (uint)subscriptionScope, out current);
            }
            else
            {
                SubscriptionScope.SetNull(pointer, current, out current);
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

            var applBegMsgId = message.GetData(ApplBegMsgId.FixTag);
            ApplBegMsgId.Encode(pointer, current, applBegMsgId, out current);

            var applEndMsgId = message.GetData(ApplEndMsgId.FixTag);
            ApplEndMsgId.Encode(pointer, current, applEndMsgId, out current);

            Pad1.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Retransmit Me Message Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (SubscriptionScope.TryDecode(pointer, current, out var subscriptionScope, out current))
            {
                message.AppendInt(SubscriptionScope.FixTag, (int)subscriptionScope);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            if (RefApplId.TryDecode(pointer, current, out var refApplId, out current))
            {
                message.AppendInt(RefApplId.FixTag, refApplId);
            }

            var applBegMsgId = ApplBegMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplBegMsgId.FixTag, applBegMsgId);

            var applEndMsgId = ApplEndMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplEndMsgId.FixTag, applEndMsgId);

            current += Pad1.Length;

            return FixErrorCode.None;
        }
    }
}