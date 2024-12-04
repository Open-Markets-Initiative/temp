using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  User Login Request Encrypted Message Methods
    /// </summary>

    public partial class UserLoginRequestEncrypted
    {
        /// <summary>
        ///  Eti Identifier for User Login Request Encrypted
        /// </summary>
        public const string Identifier = "19018";

        /// <summary>
        ///  Encode User Login Request Encrypted Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.UserLoginRequestEncrypted, out current);

            // --- encode user login request encrypted message ---

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

            var senderSubId = uint.Parse(message.sendersubid);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var username = (uint)message.GetInt(Username.FixTag);
            Username.Encode(pointer, current, username, out current);

            if (message.TryGetString(EncryptedPassword.FixTag, out var encryptedPassword))
            {
                EncryptedPassword.Encode(pointer, current, encryptedPassword, out current);
            }
            else
            {
                EncryptedPassword.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode User Login Request Encrypted Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = UserLoginRequestEncrypted.Identifier;

            // --- decode user login request encrypted message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubId = senderSubId.ToString();

            var username = (int)Username.Decode(pointer, current, out current);
            message.AppendInt(Username.FixTag, username);

            if (EncryptedPassword.TryDecode(pointer, current, out var encryptedPassword, out current))
            {
                message.AppendString(EncryptedPassword.FixTag, encryptedPassword);
            }

            return FixErrorCode.None;
        }
    }
}