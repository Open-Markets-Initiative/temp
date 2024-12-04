using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Response Message Methods
    /// </summary>

    public partial class SrqsQuoteResponse
    {
        /// <summary>
        ///  Eti Identifier for Srqs Quote Response
        /// </summary>
        public const string Identifier = "10703";

        /// <summary>
        ///  Encode Srqs Quote Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsQuoteResponse, out current);

            // --- encode srqs quote response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var quoteId = message.GetULong(QuoteId.FixTag);
            QuoteId.Encode(pointer, current, quoteId, out current);

            var negotiationId = (uint)message.GetInt(NegotiationId.FixTag);
            NegotiationId.Encode(pointer, current, negotiationId, out current);

            if (message.TryGetString(QuoteReqId.FixTag, out var quoteReqId))
            {
                QuoteReqId.Encode(pointer, current, quoteReqId, out current);
            }
            else
            {
                QuoteReqId.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Quote Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsQuoteResponse.Identifier;

            // --- decode srqs quote response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new DateTime((long)sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var quoteId = QuoteId.Decode(pointer, current, out current);
            message.AppendULong(QuoteId.FixTag, quoteId);

            var negotiationId = (int)NegotiationId.Decode(pointer, current, out current);
            message.AppendInt(NegotiationId.FixTag, negotiationId);

            if (QuoteReqId.TryDecode(pointer, current, out var quoteReqId, out current))
            {
                message.AppendString(QuoteReqId.FixTag, quoteReqId);
            }

            return FixErrorCode.None;
        }
    }
}