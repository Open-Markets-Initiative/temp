using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Broadcast Error Notification Message Methods
    /// </summary>

    public static partial class BroadcastErrorNotification
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

            if (message.TryGetInt(ApplIdStatus.FixTag, out var applIdStatus))
            {
                ApplIdStatus.Encode(pointer, current, (uint)applIdStatus, out current);
            }
            else
            {
                ApplIdStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RefApplSubId.FixTag, out var refApplSubId))
            {
                RefApplSubId.Encode(pointer, current, (uint)refApplSubId, out current);
            }
            else
            {
                RefApplSubId.SetNull(pointer, current, out current);
            }

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

            if (message.TryGetInt(RefApplId.FixTag, out var refApplId))
            {
                RefApplId.Encode(pointer, current, (byte)refApplId, out current);
            }
            else
            {
                RefApplId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SessionStatus.FixTag, out var sessionStatus))
            {
                SessionStatus.Encode(pointer, current, (byte)sessionStatus, out current);
            }
            else
            {
                SessionStatus.SetNull(pointer, current, out current);
            }

            if (isVarText)
            {
                VarText.Encode(pointer, current, varText, out current);
            }

            var alignment = 8 - ((current - offset) % 8);
            if (alignment != 8)
            {
                AlignmentPadding.Encode(pointer, current, alignment, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Broadcast Error Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = BroadcastErrorNotification.Identifier;

            // --- decode broadcast error notification message ---

            current += Pad2.Length;

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplIdStatus.TryDecode(pointer, current, out var applIdStatus, out current))
            {
                message.AppendInt(ApplIdStatus.FixTag, (int)applIdStatus);
            }

            if (RefApplSubId.TryDecode(pointer, current, out var refApplSubId, out current))
            {
                message.AppendInt(RefApplSubId.FixTag, (int)refApplSubId);
            }

            var varTextLen = VarTextLen.Decode(pointer, current, out current);

            if (RefApplId.TryDecode(pointer, current, out var refApplId, out current))
            {
                message.AppendInt(RefApplId.FixTag, refApplId);
            }

            if (SessionStatus.TryDecode(pointer, current, out var sessionStatus, out current))
            {
                message.AppendInt(SessionStatus.FixTag, sessionStatus);
            }

            if (VarText.TryDecode(pointer, current, varTextLen, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            if (length != (current - offset))
            {
                current = offset + length;
            }

            return FixErrorCode.None;
        }
    }
}