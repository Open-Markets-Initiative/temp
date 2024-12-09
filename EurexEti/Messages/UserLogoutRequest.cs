using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  User Logout Request Message Methods
    /// </summary>

    public static partial class UserLogoutRequest
    {
        /// <summary>
        ///  Eti Identifier for User Logout Request
        /// </summary>
        public const string Identifier = "10029";

        /// <summary>
        ///  Encode User Logout Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.UserLogoutRequest, out current);

            // --- encode user logout request message ---

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

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var username = (uint)message.GetInt(Username.FixTag);
            Username.Encode(pointer, current, username, out current);

            Pad4.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode User Logout Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = UserLogoutRequest.Identifier;

            // --- decode user logout request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubID = senderSubId.ToString();

            var username = (int)Username.Decode(pointer, current, out current);
            message.AppendInt(Username.FixTag, username);

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}