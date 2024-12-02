using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Forced Logout Notification Message Methods
    /// </summary>

    public partial class ForcedLogoutNotification
    {
        /// <summary>
        ///  Eti Identifier for Forced Logout Notification
        /// </summary>
        public const string Identifier = "Forced Logout Notification";

        /// <summary>
        ///  Encode Forced Logout Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ForcedLogoutNotification, out current);

            // --- encode forced logout notification message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var varTextLen = (ushort)message.GetInt(VarTextLen.FixTag);
            VarTextLen.Encode(pointer, current, varTextLen, out current);

            if (message.TryGetString(VarText.FixTag, out var varText))
            {
                VarText.Encode(pointer, current, varText, out current);
            }
            else
            {
                VarText.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Forced Logout Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ForcedLogoutNotification.Identifier;

            // --- decode forced logout notification message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var varTextLen = (short)VarTextLen.Decode(pointer, current, out current);
            message.AppendInt(VarTextLen.FixTag, varTextLen);

            if (VarText.TryDecode(pointer, current, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            return FixErrorCode.None;
        }
    }
}