using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Broadcast Error Notification Message Methods
    /// </summary>

    public partial class BroadcastErrorNotification
    {
        /// <summary>
        ///  Eti Identifier for Broadcast Error Notification
        /// </summary>
        public const string Identifier = "Broadcast Error Notification";

        /// <summary>
        ///  Encode Broadcast Error Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.BroadcastErrorNotification, out current);

            // --- encode broadcast error notification message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applIdStatus = (uint)message.GetInt(ApplIdStatus.FixTag);
            ApplIdStatus.Encode(pointer, current, applIdStatus, out current);

            var refApplSubId = (uint)message.GetInt(RefApplSubId.FixTag);
            RefApplSubId.Encode(pointer, current, refApplSubId, out current);

            var varTextLen = (ushort)message.GetInt(VarTextLen.FixTag);
            VarTextLen.Encode(pointer, current, varTextLen, out current);

            var refApplId = (byte)message.GetInt(RefApplId.FixTag);
            RefApplId.Encode(pointer, current, refApplId, out current);

            var sessionStatus = (byte)message.GetInt(SessionStatus.FixTag);
            SessionStatus.Encode(pointer, current, sessionStatus, out current);

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
        ///  Decode Broadcast Error Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = BroadcastErrorNotification.Identifier;

            // --- decode broadcast error notification message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var applIdStatus = (int)ApplIdStatus.Decode(pointer, current, out current);
            message.AppendInt(ApplIdStatus.FixTag, applIdStatus);

            var refApplSubId = (int)RefApplSubId.Decode(pointer, current, out current);
            message.AppendInt(RefApplSubId.FixTag, refApplSubId);

            var varTextLen = (short)VarTextLen.Decode(pointer, current, out current);
            message.AppendInt(VarTextLen.FixTag, varTextLen);

            var refApplId = RefApplId.Decode(pointer, current, out current);
            message.AppendInt(RefApplId.FixTag, refApplId);

            var sessionStatus = SessionStatus.Decode(pointer, current, out current);
            message.AppendInt(SessionStatus.FixTag, sessionStatus);

            if (VarText.TryDecode(pointer, current, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            return FixErrorCode.None;
        }
    }
}