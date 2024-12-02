using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Pre Trade Risk Limits Definition Request Message Methods
    /// </summary>

    public partial class PreTradeRiskLimitsDefinitionRequest
    {
        /// <summary>
        ///  Eti Identifier for Pre Trade Risk Limits Definition Request
        /// </summary>
        public const string Identifier = "Pre Trade Risk Limits Definition Request";

        /// <summary>
        ///  Encode Pre Trade Risk Limits Definition Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.PreTradeRiskLimitsDefinitionRequest, out current);

            // --- encode pre trade risk limits definition request message ---

            var start = current;

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

            var nettingCoefficient = message.GetDouble(NettingCoefficient.FixTag);
            NettingCoefficient.Encode(pointer, current, nettingCoefficient, out current);

            var quoteWeightingCoefficient = message.GetDouble(QuoteWeightingCoefficient.FixTag);
            QuoteWeightingCoefficient.Encode(pointer, current, quoteWeightingCoefficient, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var riskLimitPlatform = (byte)message.GetInt(RiskLimitPlatform.FixTag);
            RiskLimitPlatform.Encode(pointer, current, riskLimitPlatform, out current);

            var noRiskLimitsQty = (byte)message.GetInt(NoRiskLimitsQty.FixTag);
            NoRiskLimitsQty.Encode(pointer, current, noRiskLimitsQty, out current);

            var partyDetailStatus = (byte)message.GetInt(PartyDetailStatus.FixTag);
            PartyDetailStatus.Encode(pointer, current, partyDetailStatus, out current);

            if (message.TryGetString(RiskLimitGroup.FixTag, out var riskLimitGroup))
            {
                RiskLimitGroup.Encode(pointer, current, riskLimitGroup, out current);
            }
            else
            {
                RiskLimitGroup.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
            {
                PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
            }
            else
            {
                PartyDetailExecutingUnit.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            var riskLimitQty = group.GetDouble(RiskLimitQty.FixTag);
            RiskLimitQty.Encode(pointer, current, riskLimitQty, out current);

            var riskLimitType = (byte)group.GetInt(RiskLimitType.FixTag);
            RiskLimitType.Encode(pointer, current, riskLimitType, out current);

            Pad7.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Pre Trade Risk Limits Definition Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = PreTradeRiskLimitsDefinitionRequest.Identifier;

            // --- decode pre trade risk limits definition request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var senderSubId = (int)SenderSubId.Decode(pointer, current, out current);
            message.AppendInt(SenderSubId.FixTag, senderSubId);

            var nettingCoefficient = NettingCoefficient.Decode(pointer, current, out current);
            message.AppendDouble(NettingCoefficient.FixTag, nettingCoefficient);

            var quoteWeightingCoefficient = QuoteWeightingCoefficient.Decode(pointer, current, out current);
            message.AppendDouble(QuoteWeightingCoefficient.FixTag, quoteWeightingCoefficient);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var riskLimitPlatform = RiskLimitPlatform.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitPlatform.FixTag, riskLimitPlatform);

            var noRiskLimitsQty = NoRiskLimitsQty.Decode(pointer, current, out current);
            message.AppendInt(NoRiskLimitsQty.FixTag, noRiskLimitsQty);

            var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

            if (RiskLimitGroup.TryDecode(pointer, current, out var riskLimitGroup, out current))
            {
                message.AppendString(RiskLimitGroup.FixTag, riskLimitGroup);
            }

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad1.Length;

            var riskLimitQty = RiskLimitQty.Decode(pointer, current, out current);
            message.AppendDouble(RiskLimitQty.FixTag, riskLimitQty);

            var riskLimitType = RiskLimitType.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitType.FixTag, riskLimitType);

            current += Pad7.Length;

            return FixErrorCode.None;
        }
    }
}