using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Inquire Smart Respondent Request Message Methods
    /// </summary>

    public static partial class SrqsInquireSmartRespondentRequest
    {
        /// <summary>
        ///  Eti Identifier for Srqs Inquire Smart Respondent Request
        /// </summary>
        public const string Identifier = "10718";

        /// <summary>
        ///  Encode Srqs Inquire Smart Respondent Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsInquireSmartRespondentRequest, out current);

            // --- encode srqs inquire smart respondent request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            if (uint.TryParse(message.senderSubID, out var senderSubId))
            {
                SenderSubId.Encode(pointer, current, senderSubId, out current);
            }
            else
            {
                SenderSubId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(EurexVolumeRanking.FixTag, out var eurexVolumeRanking))
            {
                EurexVolumeRanking.Encode(pointer, current, (byte)eurexVolumeRanking, out current);
            }
            else
            {
                EurexVolumeRanking.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(EnlightRfqAvgRespTimeRanking.FixTag, out var enlightRfqAvgRespTimeRanking))
            {
                EnlightRfqAvgRespTimeRanking.Encode(pointer, current, (byte)enlightRfqAvgRespTimeRanking, out current);
            }
            else
            {
                EnlightRfqAvgRespTimeRanking.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(EnlightRfqAvgRespRateRanking.FixTag, out var enlightRfqAvgRespRateRanking))
            {
                EnlightRfqAvgRespRateRanking.Encode(pointer, current, (byte)enlightRfqAvgRespRateRanking, out current);
            }
            else
            {
                EnlightRfqAvgRespRateRanking.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradeToQuoteRatioRanking.FixTag, out var tradeToQuoteRatioRanking))
            {
                TradeToQuoteRatioRanking.Encode(pointer, current, (byte)tradeToQuoteRatioRanking, out current);
            }
            else
            {
                TradeToQuoteRatioRanking.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Inquire Smart Respondent Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsInquireSmartRespondentRequest.Identifier;

            // --- decode srqs inquire smart respondent request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (EurexVolumeRanking.TryDecode(pointer, current, out var eurexVolumeRanking, out current))
            {
                message.AppendInt(EurexVolumeRanking.FixTag, eurexVolumeRanking);
            }

            if (EnlightRfqAvgRespTimeRanking.TryDecode(pointer, current, out var enlightRfqAvgRespTimeRanking, out current))
            {
                message.AppendInt(EnlightRfqAvgRespTimeRanking.FixTag, enlightRfqAvgRespTimeRanking);
            }

            if (EnlightRfqAvgRespRateRanking.TryDecode(pointer, current, out var enlightRfqAvgRespRateRanking, out current))
            {
                message.AppendInt(EnlightRfqAvgRespRateRanking.FixTag, enlightRfqAvgRespRateRanking);
            }

            if (TradeToQuoteRatioRanking.TryDecode(pointer, current, out var tradeToQuoteRatioRanking, out current))
            {
                message.AppendInt(TradeToQuoteRatioRanking.FixTag, tradeToQuoteRatioRanking);
            }

            return FixErrorCode.None;
        }
    }
}