using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Pre Trade Risk Limits Definition Request Message Methods
    /// </summary>

    public static partial class PreTradeRiskLimitsDefinitionRequest
    {
        /// <summary>
        ///  Eti Identifier for Pre Trade Risk Limits Definition Request
        /// </summary>
        public const string Identifier = "10312";

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

            if (message.TryGetDouble(NettingCoefficient.FixTag, out var nettingCoefficient))
            {
                NettingCoefficient.Encode(pointer, current, nettingCoefficient, out current);
            }
            else
            {
                NettingCoefficient.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(QuoteWeightingCoefficient.FixTag, out var quoteWeightingCoefficient))
            {
                QuoteWeightingCoefficient.Encode(pointer, current, quoteWeightingCoefficient, out current);
            }
            else
            {
                QuoteWeightingCoefficient.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RiskLimitPlatform.FixTag, out var riskLimitPlatform))
            {
                RiskLimitPlatform.Encode(pointer, current, (byte)riskLimitPlatform, out current);
            }
            else
            {
                RiskLimitPlatform.SetNull(pointer, current, out current);
            }

            var isRiskLimitQtyGrpComp = message.TryGetGroup(NoRiskLimitsQty.FixTag, out var riskLimitQtyGrpComp) && riskLimitQtyGrpComp.sectionList.Count > 0;
            if (isRiskLimitQtyGrpComp)
            {
                var noRiskLimitsQty = (byte)riskLimitQtyGrpComp.sectionList.Count;
                NoRiskLimitsQty.Encode(pointer, current, noRiskLimitsQty, out current);
            }
            else
            {
                NoRiskLimitsQty.Zero(pointer, current, out current);
            }

            if (message.TryGetInt(PartyDetailStatus.FixTag, out var partyDetailStatus))
            {
                PartyDetailStatus.Encode(pointer, current, (byte)partyDetailStatus, out current);
            }
            else
            {
                PartyDetailStatus.SetNull(pointer, current, out current);
            }

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

            if (isRiskLimitQtyGrpComp)
            {
                RiskLimitQtyGrpComp.Encode(pointer, current, riskLimitQtyGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (NettingCoefficient.TryDecode(pointer, current, out var nettingCoefficient, out current))
            {
                message.AppendDouble(NettingCoefficient.FixTag, nettingCoefficient);
            }

            if (QuoteWeightingCoefficient.TryDecode(pointer, current, out var quoteWeightingCoefficient, out current))
            {
                message.AppendDouble(QuoteWeightingCoefficient.FixTag, quoteWeightingCoefficient);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (RiskLimitPlatform.TryDecode(pointer, current, out var riskLimitPlatform, out current))
            {
                message.AppendInt(RiskLimitPlatform.FixTag, riskLimitPlatform);
            }

            var noRiskLimitsQty = (int)NoRiskLimitsQty.Decode(pointer, current, out current);

            if (PartyDetailStatus.TryDecode(pointer, current, out var partyDetailStatus, out current))
            {
                message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);
            }

            if (RiskLimitGroup.TryDecode(pointer, current, out var riskLimitGroup, out current))
            {
                message.AppendString(RiskLimitGroup.FixTag, riskLimitGroup);
            }

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad1.Length;

            RiskLimitQtyGrpComp.Decode(ref message, pointer, current, noRiskLimitsQty, out current);

            return FixErrorCode.None;
        }
    }
}