using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Pre Trade Risk Limit Response Message Methods
    /// </summary>

    public partial class PreTradeRiskLimitResponse
    {
        /// <summary>
        ///  Eti Identifier for Pre Trade Risk Limit Response
        /// </summary>
        public const string Identifier = "Pre Trade Risk Limit Response";

        /// <summary>
        ///  Encode Pre Trade Risk Limit Response Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.PreTradeRiskLimitResponse, out current);

            // --- encode pre trade risk limit response message ---

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.GetInt(MsgSeqNum.FixTag);
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad3.Encode(pointer, current, out current);

            var riskLimitReportId = message.GetULong(RiskLimitReportId.FixTag);
            RiskLimitReportId.Encode(pointer, current, riskLimitReportId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var noRiskLimits = (byte)message.GetInt(NoRiskLimits.FixTag);
            NoRiskLimits.Encode(pointer, current, noRiskLimits, out current);

            var partyDetailStatus = (byte)message.GetInt(PartyDetailStatus.FixTag);
            PartyDetailStatus.Encode(pointer, current, partyDetailStatus, out current);

            var riskLimitPlatform = (byte)message.GetInt(RiskLimitPlatform.FixTag);
            RiskLimitPlatform.Encode(pointer, current, riskLimitPlatform, out current);

            if (message.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
            {
                PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
            }
            else
            {
                PartyDetailExecutingUnit.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            var riskLimitQty = group.GetDouble(RiskLimitQty.FixTag);
            RiskLimitQty.Encode(pointer, current, riskLimitQty, out current);

            var riskLimitOpenQty = group.GetDouble(RiskLimitOpenQty.FixTag);
            RiskLimitOpenQty.Encode(pointer, current, riskLimitOpenQty, out current);

            var riskLimitNetPositionQty = group.GetDouble(RiskLimitNetPositionQty.FixTag);
            RiskLimitNetPositionQty.Encode(pointer, current, riskLimitNetPositionQty, out current);

            var nettingCoefficient = group.GetDouble(NettingCoefficient.FixTag);
            NettingCoefficient.Encode(pointer, current, nettingCoefficient, out current);

            var quoteWeightingCoefficient = group.GetDouble(QuoteWeightingCoefficient.FixTag);
            QuoteWeightingCoefficient.Encode(pointer, current, quoteWeightingCoefficient, out current);

            var activationDate = (uint)group.GetInt(ActivationDate.FixTag);
            ActivationDate.Encode(pointer, current, activationDate, out current);

            var riskLimitType = (byte)group.GetInt(RiskLimitType.FixTag);
            RiskLimitType.Encode(pointer, current, riskLimitType, out current);

            var riskLimitRequestingPartyRole = (byte)group.GetInt(RiskLimitRequestingPartyRole.FixTag);
            RiskLimitRequestingPartyRole.Encode(pointer, current, riskLimitRequestingPartyRole, out current);

            var riskLimitViolationIndicator = (byte)group.GetInt(RiskLimitViolationIndicator.FixTag);
            RiskLimitViolationIndicator.Encode(pointer, current, riskLimitViolationIndicator, out current);

            if (group.TryGetString(RiskLimitGroup.FixTag, out var riskLimitGroup))
            {
                RiskLimitGroup.Encode(pointer, current, riskLimitGroup, out current);
            }
            else
            {
                RiskLimitGroup.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Pre Trade Risk Limit Response Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = PreTradeRiskLimitResponse.Identifier;

            // --- decode pre trade risk limit response message ---

            current += Pad2.Length;

            var requestTime = RequestTime.Decode(pointer, current, out current);
            message.AppendULong(RequestTime.FixTag, requestTime);

            var trdRegTsTimeIn = TrdRegTsTimeIn.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);

            var trdRegTsTimeOut = TrdRegTsTimeOut.Decode(pointer, current, out current);
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);

            var responseIn = ResponseIn.Decode(pointer, current, out current);
            message.AppendULong(ResponseIn.FixTag, responseIn);

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var msgSeqNum = (int)MsgSeqNum.Decode(pointer, current, out current);
            message.AppendInt(MsgSeqNum.FixTag, msgSeqNum);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad3.Length;

            var riskLimitReportId = RiskLimitReportId.Decode(pointer, current, out current);
            message.AppendULong(RiskLimitReportId.FixTag, riskLimitReportId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var noRiskLimits = NoRiskLimits.Decode(pointer, current, out current);
            message.AppendInt(NoRiskLimits.FixTag, noRiskLimits);

            var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

            var riskLimitPlatform = RiskLimitPlatform.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitPlatform.FixTag, riskLimitPlatform);

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad4.Length;

            var riskLimitQty = RiskLimitQty.Decode(pointer, current, out current);
            message.AppendDouble(RiskLimitQty.FixTag, riskLimitQty);

            var riskLimitOpenQty = RiskLimitOpenQty.Decode(pointer, current, out current);
            message.AppendDouble(RiskLimitOpenQty.FixTag, riskLimitOpenQty);

            var riskLimitNetPositionQty = RiskLimitNetPositionQty.Decode(pointer, current, out current);
            message.AppendDouble(RiskLimitNetPositionQty.FixTag, riskLimitNetPositionQty);

            var nettingCoefficient = NettingCoefficient.Decode(pointer, current, out current);
            message.AppendDouble(NettingCoefficient.FixTag, nettingCoefficient);

            var quoteWeightingCoefficient = QuoteWeightingCoefficient.Decode(pointer, current, out current);
            message.AppendDouble(QuoteWeightingCoefficient.FixTag, quoteWeightingCoefficient);

            var activationDate = (int)ActivationDate.Decode(pointer, current, out current);
            message.AppendInt(ActivationDate.FixTag, activationDate);

            var riskLimitType = RiskLimitType.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitType.FixTag, riskLimitType);

            var riskLimitRequestingPartyRole = RiskLimitRequestingPartyRole.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitRequestingPartyRole.FixTag, riskLimitRequestingPartyRole);

            var riskLimitViolationIndicator = RiskLimitViolationIndicator.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitViolationIndicator.FixTag, riskLimitViolationIndicator);

            if (RiskLimitGroup.TryDecode(pointer, current, out var riskLimitGroup, out current))
            {
                message.AppendString(RiskLimitGroup.FixTag, riskLimitGroup);
            }

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}