using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Snapshot Notification Message Methods
    /// </summary>

    public static partial class SrqsQuoteSnapshotNotification
    {
        /// <summary>
        ///  Eti Identifier for Srqs Quote Snapshot Notification
        /// </summary>
        public const string Identifier = "10723";

        /// <summary>
        ///  Encode Srqs Quote Snapshot Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsQuoteSnapshotNotification, out current);

            // --- encode srqs quote snapshot notification message ---

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

            var isSrqsQuoteEntryGrpComp = message.TryGetGroup(NoQuoteEntries.FixTag, out var srqsQuoteEntryGrpComp) && srqsQuoteEntryGrpComp.sectionList.Count > 0;
            if (isSrqsQuoteEntryGrpComp)
            {
                var noQuoteEntries = (byte)srqsQuoteEntryGrpComp.sectionList.Count;
                NoQuoteEntries.Encode(pointer, current, noQuoteEntries, out current);
            }
            else
            {
                NoQuoteEntries.Zero(pointer, current, out current);
            }

            var messageEventSource = message.GetToken(MessageEventSource.FixTag);
            MessageEventSource.Encode(pointer, current, messageEventSource, out current);

            Pad6.Encode(pointer, current, out current);

            if (isSrqsQuoteEntryGrpComp)
            {
                SrqsQuoteEntryGrpComp.Encode(pointer, current, srqsQuoteEntryGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Quote Snapshot Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsQuoteSnapshotNotification.Identifier;

            // --- decode srqs quote snapshot notification message ---

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

            var noQuoteEntries = (int)NoQuoteEntries.Decode(pointer, current, out current);

            var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
            message.AppendToken(MessageEventSource.FixTag, messageEventSource);

            current += Pad6.Length;

            SrqsQuoteEntryGrpComp.Decode(ref message, pointer, current, noQuoteEntries, out current);

            return FixErrorCode.None;
        }
    }
}