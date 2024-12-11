using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Response Message Methods
    /// </summary>

    public static partial class SrqsQuoteResponse
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

            if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
            {
                RequestTime.Encode(pointer, current, requestTime, out current);
            }
            else
            {
                RequestTime.SetNull(pointer, current, out current);
            }

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            if (message.TryGetULong(QuoteId.FixTag, out var quoteId))
            {
                QuoteId.Encode(pointer, current, quoteId, out current);
            }
            else
            {
                QuoteId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(NegotiationId.FixTag, out var negotiationId))
            {
                NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
            }
            else
            {
                NegotiationId.SetNull(pointer, current, out current);
            }

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

            if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
            {
                message.AppendULong(RequestTime.FixTag, requestTime);
            }

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            current += Pad4.Length;

            if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
            {
                message.AppendULong(QuoteId.FixTag, quoteId);
            }

            if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
            {
                message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
            }

            if (QuoteReqId.TryDecode(pointer, current, out var quoteReqId, out current))
            {
                message.AppendString(QuoteReqId.FixTag, quoteReqId);
            }

            return FixErrorCode.None;
        }
    }
}