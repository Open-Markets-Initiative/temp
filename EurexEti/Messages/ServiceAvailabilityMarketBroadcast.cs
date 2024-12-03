using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Service Availability Market Broadcast Message Methods
    /// </summary>

    public partial class ServiceAvailabilityMarketBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Service Availability Market Broadcast
        /// </summary>
        public const string Identifier = "10044";

        /// <summary>
        ///  Encode Service Availability Market Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ServiceAvailabilityMarketBroadcast, out current);

            // --- encode service availability market broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad2.Encode(pointer, current, out current);

            var selectiveRequestForQuoteServiceTradeDate = (uint)message.GetInt(SelectiveRequestForQuoteServiceTradeDate.FixTag);
            SelectiveRequestForQuoteServiceTradeDate.Encode(pointer, current, selectiveRequestForQuoteServiceTradeDate, out current);

            var selectiveRequestForQuoteServiceStatus = (byte)message.GetInt(SelectiveRequestForQuoteServiceStatus.FixTag);
            SelectiveRequestForQuoteServiceStatus.Encode(pointer, current, selectiveRequestForQuoteServiceStatus, out current);

            var selectiveRequestForQuoteRtmServiceStatus = (byte)message.GetInt(SelectiveRequestForQuoteRtmServiceStatus.FixTag);
            SelectiveRequestForQuoteRtmServiceStatus.Encode(pointer, current, selectiveRequestForQuoteRtmServiceStatus, out current);

            var newsRtmServiceStatus = (byte)message.GetInt(NewsRtmServiceStatus.FixTag);
            NewsRtmServiceStatus.Encode(pointer, current, newsRtmServiceStatus, out current);

            var riskControlRtmServiceStatus = (byte)message.GetInt(RiskControlRtmServiceStatus.FixTag);
            RiskControlRtmServiceStatus.Encode(pointer, current, riskControlRtmServiceStatus, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Service Availability Market Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ServiceAvailabilityMarketBroadcast.Identifier;

            // --- decode service availability market broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad2.Length;

            var selectiveRequestForQuoteServiceTradeDate = (int)SelectiveRequestForQuoteServiceTradeDate.Decode(pointer, current, out current);
            message.AppendInt(SelectiveRequestForQuoteServiceTradeDate.FixTag, selectiveRequestForQuoteServiceTradeDate);

            var selectiveRequestForQuoteServiceStatus = SelectiveRequestForQuoteServiceStatus.Decode(pointer, current, out current);
            message.AppendInt(SelectiveRequestForQuoteServiceStatus.FixTag, selectiveRequestForQuoteServiceStatus);

            var selectiveRequestForQuoteRtmServiceStatus = SelectiveRequestForQuoteRtmServiceStatus.Decode(pointer, current, out current);
            message.AppendInt(SelectiveRequestForQuoteRtmServiceStatus.FixTag, selectiveRequestForQuoteRtmServiceStatus);

            var newsRtmServiceStatus = NewsRtmServiceStatus.Decode(pointer, current, out current);
            message.AppendInt(NewsRtmServiceStatus.FixTag, newsRtmServiceStatus);

            var riskControlRtmServiceStatus = RiskControlRtmServiceStatus.Decode(pointer, current, out current);
            message.AppendInt(RiskControlRtmServiceStatus.FixTag, riskControlRtmServiceStatus);

            return FixErrorCode.None;
        }
    }
}