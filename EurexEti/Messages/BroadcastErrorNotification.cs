using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Broadcast Error Notification Message Methods
    /// </summary>

    public partial class BroadcastErrorNotification
    {
        /// <summary>
        ///  Eti Identifier for Broadcast Error Notification
        /// </summary>
        public const string Identifier = "10032";

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

            Pad2.Encode(pointer, current, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applIdStatus = (uint)message.GetInt(ApplIdStatus.FixTag);
            ApplIdStatus.Encode(pointer, current, applIdStatus, out current);

            var refApplSubId = (uint)message.GetInt(RefApplSubId.FixTag);
            RefApplSubId.Encode(pointer, current, refApplSubId, out current);

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

            var refApplId = (byte)message.GetInt(RefApplId.FixTag);
            RefApplId.Encode(pointer, current, refApplId, out current);

            var sessionStatus = (byte)message.GetInt(SessionStatus.FixTag);
            SessionStatus.Encode(pointer, current, sessionStatus, out current);

            if (isVarText)
            {
                VarText.Encode(pointer, current, varText, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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
            message.sendingTime = new System.DateTime((long)sendingTime);

            var applIdStatus = (int)ApplIdStatus.Decode(pointer, current, out current);
            message.AppendInt(ApplIdStatus.FixTag, applIdStatus);

            var refApplSubId = (int)RefApplSubId.Decode(pointer, current, out current);
            message.AppendInt(RefApplSubId.FixTag, refApplSubId);

            var varTextLen = VarTextLen.Decode(pointer, current, out current);

            var refApplId = RefApplId.Decode(pointer, current, out current);
            message.AppendInt(RefApplId.FixTag, refApplId);

            var sessionStatus = SessionStatus.Decode(pointer, current, out current);
            message.AppendInt(SessionStatus.FixTag, sessionStatus);

            if (VarText.TryDecode(pointer, current, varTextLen, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            return FixErrorCode.None;
        }
    }
}