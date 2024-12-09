using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Legal Notification Broadcast Message Methods
    /// </summary>

    public static partial class LegalNotificationBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Legal Notification Broadcast
        /// </summary>
        public const string Identifier = "10037";

        /// <summary>
        ///  Encode Legal Notification Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.LegalNotificationBroadcast, out current);

            // --- encode legal notification broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSeqNum = message.GetULong(ApplSeqNum.FixTag);
            ApplSeqNum.Encode(pointer, current, applSeqNum, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applResendFlag = (byte)message.GetInt(ApplResendFlag.FixTag);
            ApplResendFlag.Encode(pointer, current, applResendFlag, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad7.Encode(pointer, current, out current);

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

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
        ///  Decode Legal Notification Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = LegalNotificationBroadcast.Identifier;

            // --- decode legal notification broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

            var applSeqNum = ApplSeqNum.Decode(pointer, current, out current);
            message.AppendULong(ApplSeqNum.FixTag, applSeqNum);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applResendFlag = ApplResendFlag.Decode(pointer, current, out current);
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad7.Length;

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

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