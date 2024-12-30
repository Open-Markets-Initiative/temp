using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Subscribe Request Message Methods
    /// </summary>

    public static partial class SubscribeRequest
    {
        /// <summary>
        ///  Eti Identifier for Subscribe Request
        /// </summary>
        public const string Identifier = "10025";

        /// <summary>
        ///  Encode Subscribe Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SubscribeRequest, out current);

            // --- encode subscribe request message ---

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

            if (message.TryGetInt(RefApplId.FixTag, out var refApplId))
            {
                RefApplId.Encode(pointer, current, (byte)refApplId, out current);
            }
            else
            {
                RefApplId.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Subscribe Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SubscribeRequest.Identifier;

            // --- decode subscribe request message ---

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

            if (RefApplId.TryDecode(pointer, current, out var refApplId, out current))
            {
                message.AppendInt(RefApplId.FixTag, refApplId);
            }

            current += Pad3.Length;

            return FixErrorCode.None;
        }
    }
}