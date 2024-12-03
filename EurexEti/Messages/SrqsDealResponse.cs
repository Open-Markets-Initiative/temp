using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Srqs Deal Response Message Methods
    /// </summary>

    public partial class SrqsDealResponse
    {
        /// <summary>
        ///  Eti Identifier for Srqs Deal Response
        /// </summary>
        public const string Identifier = "Srqs Deal Response";

        /// <summary>
        ///  Encode Srqs Deal Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsDealResponse, out current);

            // --- encode srqs deal response message ---

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            Pad4.Encode(pointer, current, out current);

            var securityId = message.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var negotiationId = (uint)message.GetInt(NegotiationId.FixTag);
            NegotiationId.Encode(pointer, current, negotiationId, out current);

            var tradeId = (uint)message.GetInt(TradeId.FixTag);
            TradeId.Encode(pointer, current, tradeId, out current);

            var secondaryTradeId = (uint)message.GetInt(SecondaryTradeId.FixTag);
            SecondaryTradeId.Encode(pointer, current, secondaryTradeId, out current);

            var noSrqsQuoteGrps = (byte)message.GetInt(NoSrqsQuoteGrps.FixTag);
            NoSrqsQuoteGrps.Encode(pointer, current, noSrqsQuoteGrps, out current);

            if (message.TryGetString(FirmTradeId.FixTag, out var firmTradeId))
            {
                FirmTradeId.Encode(pointer, current, firmTradeId, out current);
            }
            else
            {
                FirmTradeId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FirmNegotiationId.FixTag, out var firmNegotiationId))
            {
                FirmNegotiationId.Encode(pointer, current, firmNegotiationId, out current);
            }
            else
            {
                FirmNegotiationId.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            var srqsQuoteGrpComp = (byte)message.GetInt(SrqsQuoteGrpComp.FixTag);
            SrqsQuoteGrpComp.Encode(message, pointer, current, srqsQuoteGrpComp, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Deal Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsDealResponse.Identifier;

            // --- decode srqs deal response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            current += Pad4.Length;

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var negotiationId = (int)NegotiationId.Decode(pointer, current, out current);
            message.AppendInt(NegotiationId.FixTag, negotiationId);

            var tradeId = (int)TradeId.Decode(pointer, current, out current);
            message.AppendInt(TradeId.FixTag, tradeId);

            var secondaryTradeId = (int)SecondaryTradeId.Decode(pointer, current, out current);
            message.AppendInt(SecondaryTradeId.FixTag, secondaryTradeId);

            var noSrqsQuoteGrps = NoSrqsQuoteGrps.Decode(pointer, current, out current);
            message.AppendInt(NoSrqsQuoteGrps.FixTag, noSrqsQuoteGrps);

            if (FirmTradeId.TryDecode(pointer, current, out var firmTradeId, out current))
            {
                message.AppendString(FirmTradeId.FixTag, firmTradeId);
            }

            if (FirmNegotiationId.TryDecode(pointer, current, out var firmNegotiationId, out current))
            {
                message.AppendString(FirmNegotiationId.FixTag, firmNegotiationId);
            }

            current += Pad3.Length;

            SrqsQuoteGrpComp.Decode(ref message, pointer, current, out current);

            return FixErrorCode.None;
        }
    }
}