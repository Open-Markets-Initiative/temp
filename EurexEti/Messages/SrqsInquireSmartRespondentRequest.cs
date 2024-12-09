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

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var eurexVolumeRanking = (byte)message.GetInt(EurexVolumeRanking.FixTag);
            EurexVolumeRanking.Encode(pointer, current, eurexVolumeRanking, out current);

            var enlightRfqAvgRespTimeRanking = (byte)message.GetInt(EnlightRfqAvgRespTimeRanking.FixTag);
            EnlightRfqAvgRespTimeRanking.Encode(pointer, current, enlightRfqAvgRespTimeRanking, out current);

            var enlightRfqAvgRespRateRanking = (byte)message.GetInt(EnlightRfqAvgRespRateRanking.FixTag);
            EnlightRfqAvgRespRateRanking.Encode(pointer, current, enlightRfqAvgRespRateRanking, out current);

            var tradeToQuoteRatioRanking = (byte)message.GetInt(TradeToQuoteRatioRanking.FixTag);
            TradeToQuoteRatioRanking.Encode(pointer, current, tradeToQuoteRatioRanking, out current);

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

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var senderSubId = SenderSubId.Decode(pointer, current, out current);
            message.senderSubID = senderSubId.ToString();

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var eurexVolumeRanking = EurexVolumeRanking.Decode(pointer, current, out current);
            message.AppendInt(EurexVolumeRanking.FixTag, eurexVolumeRanking);

            var enlightRfqAvgRespTimeRanking = EnlightRfqAvgRespTimeRanking.Decode(pointer, current, out current);
            message.AppendInt(EnlightRfqAvgRespTimeRanking.FixTag, enlightRfqAvgRespTimeRanking);

            var enlightRfqAvgRespRateRanking = EnlightRfqAvgRespRateRanking.Decode(pointer, current, out current);
            message.AppendInt(EnlightRfqAvgRespRateRanking.FixTag, enlightRfqAvgRespRateRanking);

            var tradeToQuoteRatioRanking = TradeToQuoteRatioRanking.Decode(pointer, current, out current);
            message.AppendInt(TradeToQuoteRatioRanking.FixTag, tradeToQuoteRatioRanking);

            return FixErrorCode.None;
        }
    }
}