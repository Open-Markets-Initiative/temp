using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Forced User Logout Notification Message Methods
    /// </summary>

    public partial class ForcedUserLogoutNotification
    {
        /// <summary>
        ///  Eti Identifier for Forced User Logout Notification
        /// </summary>
        public const string Identifier = "Forced User Logout Notification";

        /// <summary>
        ///  Encode Forced User Logout Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ForcedUserLogoutNotification, out current);

            // --- encode forced user logout notification message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var username = (uint)message.GetInt(Username.FixTag);
            Username.Encode(pointer, current, username, out current);

            var varTextLen = (ushort)message.GetInt(VarTextLen.FixTag);
            VarTextLen.Encode(pointer, current, varTextLen, out current);

            var userStatus = (byte)message.GetInt(UserStatus.FixTag);
            UserStatus.Encode(pointer, current, userStatus, out current);

            if (message.TryGetString(VarText.FixTag, out var varText))
            {
                VarText.Encode(pointer, current, varText, out current);
            }
            else
            {
                VarText.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, current - offset);
        }

        /// <summary>
        ///  Decode Forced User Logout Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ForcedUserLogoutNotification.Identifier;

            // --- decode forced user logout notification message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var username = (int)Username.Decode(pointer, current, out current);
            message.AppendInt(Username.FixTag, username);

            var varTextLen = (short)VarTextLen.Decode(pointer, current, out current);
            message.AppendInt(VarTextLen.FixTag, varTextLen);

            var userStatus = UserStatus.Decode(pointer, current, out current);
            message.AppendInt(UserStatus.FixTag, userStatus);

            if (VarText.TryDecode(pointer, current, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            return FixErrorCode.None;
        }
    }
}