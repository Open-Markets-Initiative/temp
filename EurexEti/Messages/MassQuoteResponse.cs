using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mass Quote Response Message Methods
    /// </summary>

    public static partial class MassQuoteResponse
    {
        /// <summary>
        ///  Eti Identifier for Mass Quote Response
        /// </summary>
        public const string Identifier = "10406";

        /// <summary>
        ///  Encode Mass Quote Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.MassQuoteResponse, out current);

            // --- encode mass quote response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad3.Encode(pointer, current, out current);

            var quoteId = message.GetULong(QuoteId.FixTag);
            QuoteId.Encode(pointer, current, quoteId, out current);

            var quoteResponseId = message.GetULong(QuoteResponseId.FixTag);
            QuoteResponseId.Encode(pointer, current, quoteResponseId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var isQuoteEntryAckGrpComp = message.TryGetGroup(NoQuoteSideEntries.FixTag, out var quoteEntryAckGrpComp) && quoteEntryAckGrpComp.sectionList.Count > 0;
            if (isQuoteEntryAckGrpComp)
            {
                var noQuoteSideEntries = (byte)quoteEntryAckGrpComp.sectionList.Count;
                NoQuoteSideEntries.Encode(pointer, current, noQuoteSideEntries, out current);
            }
            else
            {
                NoQuoteSideEntries.Zero(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            if (isQuoteEntryAckGrpComp)
            {
                QuoteEntryAckGrpComp.Encode(pointer, current, quoteEntryAckGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Mass Quote Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = MassQuoteResponse.Identifier;

            // --- decode mass quote response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var trdRegTsTimeIn = TrdRegTsTimeIn.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var responseIn = ResponseIn.Decode(pointer, current, out current);
            message.AppendULong(ResponseIn.FixTag, responseIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad3.Length;

            var quoteId = QuoteId.Decode(pointer, current, out current);
            message.AppendULong(QuoteId.FixTag, quoteId);

            var quoteResponseId = QuoteResponseId.Decode(pointer, current, out current);
            message.AppendULong(QuoteResponseId.FixTag, quoteResponseId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var noQuoteSideEntries = (int)NoQuoteSideEntries.Decode(pointer, current, out current);

            current += Pad3.Length;

            QuoteEntryAckGrpComp.Decode(ref message, pointer, current, noQuoteSideEntries, out current);

            return FixErrorCode.None;
        }
    }
}