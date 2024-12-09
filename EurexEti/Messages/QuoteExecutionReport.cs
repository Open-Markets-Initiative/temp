using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Execution Report Message Methods
    /// </summary>

    public partial class QuoteExecutionReport
    {
        /// <summary>
        ///  Eti Identifier for Quote Execution Report
        /// </summary>
        public const string Identifier = "10407";

        /// <summary>
        ///  Encode Quote Execution Report Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.QuoteExecutionReport, out current);

            // --- encode quote execution report message ---

            Pad2.Encode(pointer, current, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var notificationIn = message.GetULong(NotificationIn.FixTag);
            NotificationIn.Encode(pointer, current, notificationIn, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var applResendFlag = (byte)message.GetInt(ApplResendFlag.FixTag);
            ApplResendFlag.Encode(pointer, current, applResendFlag, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad7.Encode(pointer, current, out current);

            var execId = message.GetULong(ExecId.FixTag);
            ExecId.Encode(pointer, current, execId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var isQuoteLegExecGrpComp = message.TryGetGroup(NoLegExecs.FixTag, out var quoteLegExecGrpComp) && QuoteLegExecGrpComp.sectionList.Length > 0;
            if (isQuoteLegExecGrpComp)
            {
                var noLegExecs = (ushort)quoteLegExecGrpComp.sectionList.Length;
                NoLegExecs.Encode(pointer, current, noLegExecs, out current);
            }
            else
            {
                NoLegExecs.Zero(pointer, current, out current);
            }

            var isQuoteEventGrpComp = message.TryGetGroup(NoQuoteEvents.FixTag, out var quoteEventGrpComp) && QuoteEventGrpComp.sectionList.Length > 0;
            if (isQuoteEventGrpComp)
            {
                var noQuoteEvents = (byte)quoteEventGrpComp.sectionList.Length;
                NoQuoteEvents.Encode(pointer, current, noQuoteEvents, out current);
            }
            else
            {
                NoQuoteEvents.Zero(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            if (isQuoteEventGrpComp)
            {
                QuoteEventGrpComp.Encode(pointer, current, quoteEventGrpComp, out current);
            }

            if (isQuoteLegExecGrpComp)
            {
                QuoteLegExecGrpComp.Encode(pointer, current, quoteLegExecGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Quote Execution Report Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = QuoteExecutionReport.Identifier;

            // --- decode quote execution report message ---

            current += Pad2.Length;

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var notificationIn = NotificationIn.Decode(pointer, current, out current);
            message.AppendULong(NotificationIn.FixTag, notificationIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var applResendFlag = ApplResendFlag.Decode(pointer, current, out current);
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad7.Length;

            var execId = ExecId.Decode(pointer, current, out current);
            message.AppendULong(ExecId.FixTag, execId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var noLegExecs = (int)NoLegExecs.Decode(pointer, current, out current);

            var noQuoteEvents = (int)NoQuoteEvents.Decode(pointer, current, out current);

            current += Pad1.Length;

            QuoteEventGrpComp.Decode(ref message, pointer, current, noQuoteEvents, out current);

            QuoteLegExecGrpComp.Decode(ref message, pointer, current, noLegExecs, out current);

            return FixErrorCode.None;
        }
    }
}