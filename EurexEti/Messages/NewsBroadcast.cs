using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  News Broadcast Message Methods
    /// </summary>

    public partial class NewsBroadcast
    {
        /// <summary>
        ///  Eti Identifier for News Broadcast
        /// </summary>
        public const string Identifier = "News Broadcast";

        /// <summary>
        ///  Encode News Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.NewsBroadcast, out current);

            // --- encode news broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
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

            var origTime = message.GetULong(OrigTime.FixTag);
            OrigTime.Encode(pointer, current, origTime, out current);

            var varTextLen = (ushort)message.GetInt(VarTextLen.FixTag);
            VarTextLen.Encode(pointer, current, varTextLen, out current);

            if (message.TryGetString(Headline.FixTag, out var headline))
            {
                Headline.Encode(pointer, current, headline, out current);
            }
            else
            {
                Headline.SetNull(pointer, current, out current);
            }

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
        ///  Decode News Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = NewsBroadcast.Identifier;

            // --- decode news broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

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

            var origTime = OrigTime.Decode(pointer, current, out current);
            message.AppendULong(OrigTime.FixTag, origTime);

            var varTextLen = (short)VarTextLen.Decode(pointer, current, out current);
            message.AppendInt(VarTextLen.FixTag, varTextLen);

            if (Headline.TryDecode(pointer, current, out var headline, out current))
            {
                message.AppendString(Headline.FixTag, headline);
            }

            if (VarText.TryDecode(pointer, current, out var varText, out current))
            {
                message.AppendString(VarText.FixTag, varText);
            }

            return FixErrorCode.None;
        }
    }
}