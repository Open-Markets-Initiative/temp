using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Unsubscribe Request Message Methods
    /// </summary>

    public partial class UnsubscribeRequest
    {
        /// <summary>
        ///  Eti Identifier for Unsubscribe Request
        /// </summary>
        public const string Identifier = "Unsubscribe Request";

        /// <summary>
        ///  Encode Unsubscribe Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.UnsubscribeRequest, out current);

            // --- encode unsubscribe request message ---

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

            var refApplSubId = (uint)message.GetInt(RefApplSubId.FixTag);
            RefApplSubId.Encode(pointer, current, refApplSubId, out current);

            Pad4.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Unsubscribe Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = UnsubscribeRequest.Identifier;

            // --- decode unsubscribe request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var refApplSubId = (int)RefApplSubId.Decode(pointer, current, out current);
            message.AppendInt(RefApplSubId.FixTag, refApplSubId);

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}