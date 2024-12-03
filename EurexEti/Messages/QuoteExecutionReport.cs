using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Execution Report Message Methods
    /// </summary>

    public partial class QuoteExecutionReport
    {
        /// <summary>
        ///  Eti Identifier for Quote Execution Report
        /// </summary>
        public const string Identifier = "Quote Execution Report";

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

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var notificationIn = message.GetULong(NotificationIn.FixTag);
            NotificationIn.Encode(pointer, current, notificationIn, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
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

            var noLegExecs = (ushort)message.GetInt(NoLegExecs.FixTag);
            NoLegExecs.Encode(pointer, current, noLegExecs, out current);

            var noQuoteEvents = (byte)message.GetInt(NoQuoteEvents.FixTag);
            NoQuoteEvents.Encode(pointer, current, noQuoteEvents, out current);

            Pad1.Encode(pointer, current, out current);

            var securityId = group.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var quoteEventPx = group.GetDouble(QuoteEventPx.FixTag);
            QuoteEventPx.Encode(pointer, current, quoteEventPx, out current);

            var quoteEventQty = group.GetDouble(QuoteEventQty.FixTag);
            QuoteEventQty.Encode(pointer, current, quoteEventQty, out current);

            var quoteMsgId = group.GetULong(QuoteMsgId.FixTag);
            QuoteMsgId.Encode(pointer, current, quoteMsgId, out current);

            var quoteEventMatchId = (uint)group.GetInt(QuoteEventMatchId.FixTag);
            QuoteEventMatchId.Encode(pointer, current, quoteEventMatchId, out current);

            var quoteEventExecId = group.GetInt(QuoteEventExecId.FixTag);
            QuoteEventExecId.Encode(pointer, current, quoteEventExecId, out current);

            var quoteEventType = (byte)group.GetInt(QuoteEventType.FixTag);
            QuoteEventType.Encode(pointer, current, quoteEventType, out current);

            var quoteEventSide = (byte)group.GetInt(QuoteEventSide.FixTag);
            QuoteEventSide.Encode(pointer, current, quoteEventSide, out current);

            var quoteEventLiquidityInd = (byte)group.GetInt(QuoteEventLiquidityInd.FixTag);
            QuoteEventLiquidityInd.Encode(pointer, current, quoteEventLiquidityInd, out current);

            var quoteEventReason = (byte)group.GetInt(QuoteEventReason.FixTag);
            QuoteEventReason.Encode(pointer, current, quoteEventReason, out current);

            Pad4.Encode(pointer, current, out current);

            var legSecurityId = group.GetLong(LegSecurityId.FixTag);
            LegSecurityId.Encode(pointer, current, legSecurityId, out current);

            var legLastPx = group.GetDouble(LegLastPx.FixTag);
            LegLastPx.Encode(pointer, current, legLastPx, out current);

            var legLastQty = group.GetDouble(LegLastQty.FixTag);
            LegLastQty.Encode(pointer, current, legLastQty, out current);

            var legExecId = group.GetInt(LegExecId.FixTag);
            LegExecId.Encode(pointer, current, legExecId, out current);

            var legSide = (byte)group.GetInt(LegSide.FixTag);
            LegSide.Encode(pointer, current, legSide, out current);

            var noQuoteEventsIndex = (byte)group.GetInt(NoQuoteEventsIndex.FixTag);
            NoQuoteEventsIndex.Encode(pointer, current, noQuoteEventsIndex, out current);

            Pad2.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
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
            message.AppendULong(SendingTime.FixTag, sendingTime);

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

            var noLegExecs = (short)NoLegExecs.Decode(pointer, current, out current);
            message.AppendInt(NoLegExecs.FixTag, noLegExecs);

            var noQuoteEvents = NoQuoteEvents.Decode(pointer, current, out current);
            message.AppendInt(NoQuoteEvents.FixTag, noQuoteEvents);

            current += Pad1.Length;

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var quoteEventPx = QuoteEventPx.Decode(pointer, current, out current);
            message.AppendDouble(QuoteEventPx.FixTag, quoteEventPx);

            var quoteEventQty = QuoteEventQty.Decode(pointer, current, out current);
            message.AppendDouble(QuoteEventQty.FixTag, quoteEventQty);

            var quoteMsgId = QuoteMsgId.Decode(pointer, current, out current);
            message.AppendULong(QuoteMsgId.FixTag, quoteMsgId);

            var quoteEventMatchId = (int)QuoteEventMatchId.Decode(pointer, current, out current);
            message.AppendInt(QuoteEventMatchId.FixTag, quoteEventMatchId);

            var quoteEventExecId = QuoteEventExecId.Decode(pointer, current, out current);
            message.AppendInt(QuoteEventExecId.FixTag, quoteEventExecId);

            var quoteEventType = QuoteEventType.Decode(pointer, current, out current);
            message.AppendInt(QuoteEventType.FixTag, quoteEventType);

            var quoteEventSide = QuoteEventSide.Decode(pointer, current, out current);
            message.AppendInt(QuoteEventSide.FixTag, quoteEventSide);

            var quoteEventLiquidityInd = QuoteEventLiquidityInd.Decode(pointer, current, out current);
            message.AppendInt(QuoteEventLiquidityInd.FixTag, quoteEventLiquidityInd);

            var quoteEventReason = QuoteEventReason.Decode(pointer, current, out current);
            message.AppendInt(QuoteEventReason.FixTag, quoteEventReason);

            current += Pad4.Length;

            var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
            message.AppendLong(LegSecurityId.FixTag, legSecurityId);

            var legLastPx = LegLastPx.Decode(pointer, current, out current);
            message.AppendDouble(LegLastPx.FixTag, legLastPx);

            var legLastQty = LegLastQty.Decode(pointer, current, out current);
            message.AppendDouble(LegLastQty.FixTag, legLastQty);

            var legExecId = LegExecId.Decode(pointer, current, out current);
            message.AppendInt(LegExecId.FixTag, legExecId);

            var legSide = LegSide.Decode(pointer, current, out current);
            message.AppendInt(LegSide.FixTag, legSide);

            var noQuoteEventsIndex = NoQuoteEventsIndex.Decode(pointer, current, out current);
            message.AppendInt(NoQuoteEventsIndex.FixTag, noQuoteEventsIndex);

            current += Pad2.Length;

            return FixErrorCode.None;
        }
    }
}