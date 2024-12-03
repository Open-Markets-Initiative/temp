using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Inquire Pre Trade Risk Limits Request Message Methods
    /// </summary>

    public partial class InquirePreTradeRiskLimitsRequest
    {
        /// <summary>
        ///  Eti Identifier for Inquire Pre Trade Risk Limits Request
        /// </summary>
        public const string Identifier = "10311";

        /// <summary>
        ///  Encode Inquire Pre Trade Risk Limits Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.InquirePreTradeRiskLimitsRequest, out current);

            // --- encode inquire pre trade risk limits request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = (uint)message.GetInt(SenderSubId.FixTag);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var riskLimitPlatform = (byte)message.GetInt(RiskLimitPlatform.FixTag);
            RiskLimitPlatform.Encode(pointer, current, riskLimitPlatform, out current);

            if (message.TryGetString(PartyExecutingUnit.FixTag, out var partyExecutingUnit))
            {
                PartyExecutingUnit.Encode(pointer, current, partyExecutingUnit, out current);
            }
            else
            {
                PartyExecutingUnit.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(RiskLimitGroup.FixTag, out var riskLimitGroup))
            {
                RiskLimitGroup.Encode(pointer, current, riskLimitGroup, out current);
            }
            else
            {
                RiskLimitGroup.SetNull(pointer, current, out current);
            }

            Pad3.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Inquire Pre Trade Risk Limits Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = InquirePreTradeRiskLimitsRequest.Identifier;

            // --- decode inquire pre trade risk limits request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var riskLimitPlatform = RiskLimitPlatform.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitPlatform.FixTag, riskLimitPlatform);

            if (PartyExecutingUnit.TryDecode(pointer, current, out var partyExecutingUnit, out current))
            {
                message.AppendString(PartyExecutingUnit.FixTag, partyExecutingUnit);
            }

            if (RiskLimitGroup.TryDecode(pointer, current, out var riskLimitGroup, out current))
            {
                message.AppendString(RiskLimitGroup.FixTag, riskLimitGroup);
            }

            current += Pad3.Length;

            return FixErrorCode.None;
        }
    }
}