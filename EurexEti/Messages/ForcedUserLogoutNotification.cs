using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Forced User Logout Notification Message Methods
    /// </summary>

    public partial class ForcedUserLogoutNotification
    {
        /// <summary>
        ///  Eti Identifier for Forced User Logout Notification
        /// </summary>
        public const string Identifier = "10043";

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

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var username = (uint)message.GetInt(Username.FixTag);
            Username.Encode(pointer, current, username, out current);

            var isVarText = message.TryGetString(VarText.FixTag, out var varText);
            if (isVarText)
            {
                var varTextLen = (ushort)varText.Length;
                VarTextLen.Encode(pointer, current, varTextLen, out current);
            }
            else
            {
                VarTextLen.Zero(pointer, current, out current);
            }

            var userStatus = (byte)message.GetInt(UserStatus.FixTag);
            UserStatus.Encode(pointer, current, userStatus, out current);

            if (isVarText)
            {
                VarText.Encode(pointer, current, varText, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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
            message.sendingTime = new System.DateTime((long)sendingTime);

            var username = (int)Username.Decode(pointer, current, out current);
            message.AppendInt(Username.FixTag, username);

            var varTextLen = VarTextLen.Decode(pointer, current, out current);

            var userStatus = UserStatus.Decode(pointer, current, out current);
            message.AppendInt(UserStatus.FixTag, userStatus);

            if (VarText.TryDecode(pointer, current, varTextLen, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            return FixErrorCode.None;
        }
    }
}