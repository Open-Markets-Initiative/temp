using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  User Login Request Message Methods
    /// </summary>

    public partial class UserLoginRequest
    {
        /// <summary>
        ///  Eti Identifier for User Login Request
        /// </summary>
        public const string Identifier = "User Login Request";

        /// <summary>
        ///  Encode User Login Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.UserLoginRequest, out current);

            // --- encode user login request message ---

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

            var username = (uint)message.GetInt(Username.FixTag);
            Username.Encode(pointer, current, username, out current);

            if (message.TryGetString(Password.FixTag, out var password))
            {
                Password.Encode(pointer, current, password, out current);
            }
            else
            {
                Password.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode User Login Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = UserLoginRequest.Identifier;

            // --- decode user login request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var username = (int)Username.Decode(pointer, current, out current);
            message.AppendInt(Username.FixTag, username);

            if (Password.TryDecode(pointer, current, out var password, out current))
            {
                message.AppendString(Password.FixTag, password);
            }

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}