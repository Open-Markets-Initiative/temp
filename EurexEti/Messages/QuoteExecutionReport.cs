using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Execution Report Message Methods
    /// </summary>

    public static partial class QuoteExecutionReport
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

            if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
            {
                TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
            }
            else
            {
                TrdRegTsTimeOut.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(NotificationIn.FixTag, out var notificationIn))
            {
                NotificationIn.Encode(pointer, current, notificationIn, out current);
            }
            else
            {
                NotificationIn.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            if (message.TryGetInt(ApplSubId.FixTag, out var applSubId))
            {
                ApplSubId.Encode(pointer, current, (uint)applSubId, out current);
            }
            else
            {
                ApplSubId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
            {
                PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
            }
            else
            {
                PartitionId.SetNull(pointer, current, out current);
            }

            var applMsgId = message.GetData(ApplMsgId.FixTag);
            ApplMsgId.Encode(pointer, current, applMsgId, out current);

            if (message.TryGetInt(ApplId.FixTag, out var applId))
            {
                ApplId.Encode(pointer, current, (byte)applId, out current);
            }
            else
            {
                ApplId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
            {
                ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
            }
            else
            {
                ApplResendFlag.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            if (message.TryGetULong(ExecId.FixTag, out var execId))
            {
                ExecId.Encode(pointer, current, execId, out current);
            }
            else
            {
                ExecId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            var isQuoteLegExecGrpComp = message.TryGetGroup(NoLegExecs.FixTag, out var quoteLegExecGrpComp) && quoteLegExecGrpComp.sectionList.Count > 0;
            if (isQuoteLegExecGrpComp)
            {
                var noLegExecs = (ushort)quoteLegExecGrpComp.sectionList.Count;
                NoLegExecs.Encode(pointer, current, noLegExecs, out current);
            }
            else
            {
                NoLegExecs.Zero(pointer, current, out current);
            }

            var isQuoteEventGrpComp = message.TryGetGroup(NoQuoteEvents.FixTag, out var quoteEventGrpComp) && quoteEventGrpComp.sectionList.Count > 0;
            if (isQuoteEventGrpComp)
            {
                var noQuoteEvents = (byte)quoteEventGrpComp.sectionList.Count;
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
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = QuoteExecutionReport.Identifier;

            // --- decode quote execution report message ---

            current += Pad2.Length;

            if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
            {
                message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
            }

            if (NotificationIn.TryDecode(pointer, current, out var notificationIn, out current))
            {
                message.AppendULong(NotificationIn.FixTag, notificationIn);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
            {
                message.AppendInt(ApplSubId.FixTag, (int)applSubId);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            var applMsgId = ApplMsgId.Decode(pointer, current, out current);
            message.AppendData(ApplMsgId.FixTag, applMsgId);

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
            {
                message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad7.Length;

            if (ExecId.TryDecode(pointer, current, out var execId, out current))
            {
                message.AppendULong(ExecId.FixTag, execId);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            var noLegExecs = (int)NoLegExecs.Decode(pointer, current, out current);

            var noQuoteEvents = (int)NoQuoteEvents.Decode(pointer, current, out current);

            current += Pad1.Length;

            QuoteEventGrpComp.Decode(ref message, pointer, current, noQuoteEvents, out current);

            QuoteLegExecGrpComp.Decode(ref message, pointer, current, noLegExecs, out current);

            return FixErrorCode.None;
        }
    }
}