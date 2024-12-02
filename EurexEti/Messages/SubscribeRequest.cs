using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Subscribe Request Message Methods
    /// </summary>

    public partial class SubscribeRequest
    {
        /// <summary>
        ///  Eti Identifier for Subscribe Request
        /// </summary>
        public const string Identifier = "Subscribe Request";

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

            var refApplId = (byte)message.GetInt(RefApplId.FixTag);
            RefApplId.Encode(pointer, current, refApplId, out current);

            Pad3.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Subscribe Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
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

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var subscriptionScope = (int)SubscriptionScope.Decode(pointer, current, out current);
            message.AppendInt(SubscriptionScope.FixTag, subscriptionScope);

            var refApplId = RefApplId.Decode(pointer, current, out current);
            message.AppendInt(RefApplId.FixTag, refApplId);

            current += Pad3.Length;

            return FixErrorCode.None;
        }
    }
}