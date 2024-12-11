using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Service Availability Market Broadcast Message Methods
    /// </summary>

    public static partial class ServiceAvailabilityMarketBroadcast
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

            if (message.TryGetInt(ApplId.FixTag, out var applId))
            {
                ApplId.Encode(pointer, current, (byte)applId, out current);
            }
            else
            {
                ApplId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
            {
                LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
            }
            else
            {
                LastFragment.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            if (message.TryGetInt(SelectiveRequestForQuoteServiceTradeDate.FixTag, out var selectiveRequestForQuoteServiceTradeDate))
            {
                SelectiveRequestForQuoteServiceTradeDate.Encode(pointer, current, (uint)selectiveRequestForQuoteServiceTradeDate, out current);
            }
            else
            {
                SelectiveRequestForQuoteServiceTradeDate.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SelectiveRequestForQuoteServiceStatus.FixTag, out var selectiveRequestForQuoteServiceStatus))
            {
                SelectiveRequestForQuoteServiceStatus.Encode(pointer, current, (byte)selectiveRequestForQuoteServiceStatus, out current);
            }
            else
            {
                SelectiveRequestForQuoteServiceStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(SelectiveRequestForQuoteRtmServiceStatus.FixTag, out var selectiveRequestForQuoteRtmServiceStatus))
            {
                SelectiveRequestForQuoteRtmServiceStatus.Encode(pointer, current, (byte)selectiveRequestForQuoteRtmServiceStatus, out current);
            }
            else
            {
                SelectiveRequestForQuoteRtmServiceStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(NewsRtmServiceStatus.FixTag, out var newsRtmServiceStatus))
            {
                NewsRtmServiceStatus.Encode(pointer, current, (byte)newsRtmServiceStatus, out current);
            }
            else
            {
                NewsRtmServiceStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RiskControlRtmServiceStatus.FixTag, out var riskControlRtmServiceStatus))
            {
                RiskControlRtmServiceStatus.Encode(pointer, current, (byte)riskControlRtmServiceStatus, out current);
            }
            else
            {
                RiskControlRtmServiceStatus.SetNull(pointer, current, out current);
            }

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

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
            {
                message.AppendInt(ApplSubId.FixTag, (int)applSubId);
            }

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad2.Length;

            if (SelectiveRequestForQuoteServiceTradeDate.TryDecode(pointer, current, out var selectiveRequestForQuoteServiceTradeDate, out current))
            {
                message.AppendInt(SelectiveRequestForQuoteServiceTradeDate.FixTag, (int)selectiveRequestForQuoteServiceTradeDate);
            }

            if (SelectiveRequestForQuoteServiceStatus.TryDecode(pointer, current, out var selectiveRequestForQuoteServiceStatus, out current))
            {
                message.AppendInt(SelectiveRequestForQuoteServiceStatus.FixTag, selectiveRequestForQuoteServiceStatus);
            }

            if (SelectiveRequestForQuoteRtmServiceStatus.TryDecode(pointer, current, out var selectiveRequestForQuoteRtmServiceStatus, out current))
            {
                message.AppendInt(SelectiveRequestForQuoteRtmServiceStatus.FixTag, selectiveRequestForQuoteRtmServiceStatus);
            }

            if (NewsRtmServiceStatus.TryDecode(pointer, current, out var newsRtmServiceStatus, out current))
            {
                message.AppendInt(NewsRtmServiceStatus.FixTag, newsRtmServiceStatus);
            }

            if (RiskControlRtmServiceStatus.TryDecode(pointer, current, out var riskControlRtmServiceStatus, out current))
            {
                message.AppendInt(RiskControlRtmServiceStatus.FixTag, riskControlRtmServiceStatus);
            }

            return FixErrorCode.None;
        }
    }
}