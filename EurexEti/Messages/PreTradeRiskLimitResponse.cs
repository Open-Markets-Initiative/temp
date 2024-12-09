using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Pre Trade Risk Limit Response Message Methods
    /// </summary>

    public partial class PreTradeRiskLimitResponse
    {
        /// <summary>
        ///  Eti Identifier for Pre Trade Risk Limit Response
        /// </summary>
        public const string Identifier = "10313";

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

            Pad2.Encode(pointer, current, out current);

            var requestTime = message.GetULong(RequestTime.FixTag);
            RequestTime.Encode(pointer, current, requestTime, out current);

            var trdRegTsTimeIn = message.GetULong(TrdRegTsTimeIn.FixTag);
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);

            var trdRegTsTimeOut = message.GetULong(TrdRegTsTimeOut.FixTag);
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);

            var responseIn = message.GetULong(ResponseIn.FixTag);
            ResponseIn.Encode(pointer, current, responseIn, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad3.Encode(pointer, current, out current);

            var riskLimitReportId = message.GetULong(RiskLimitReportId.FixTag);
            RiskLimitReportId.Encode(pointer, current, riskLimitReportId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var isRiskLimitsRptGrpComp = message.TryGetGroup(NoRiskLimits.FixTag, out var riskLimitsRptGrpComp) && riskLimitsRptGrpComp.sectionList.Count > 0;
            if (isRiskLimitsRptGrpComp)
            {
                var noRiskLimits = (byte)riskLimitsRptGrpComp.sectionList.Count;
                NoRiskLimits.Encode(pointer, current, noRiskLimits, out current);
            }
            else
            {
                NoRiskLimits.Zero(pointer, current, out current);
            }

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

            if (isRiskLimitsRptGrpComp)
            {
                RiskLimitsRptGrpComp.Encode(pointer, current, riskLimitsRptGrpComp, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
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
            message.sendingTime = new System.DateTime((long)sendingTime);

            var msgSeqNum = MsgSeqNum.Decode(pointer, current, out current);
            message.msgSeqNum = (int)msgSeqNum;

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad3.Length;

            var riskLimitReportId = RiskLimitReportId.Decode(pointer, current, out current);
            message.AppendULong(RiskLimitReportId.FixTag, riskLimitReportId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var noRiskLimits = (int)NoRiskLimits.Decode(pointer, current, out current);

            var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

            var riskLimitPlatform = RiskLimitPlatform.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitPlatform.FixTag, riskLimitPlatform);

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad4.Length;

            RiskLimitsRptGrpComp.Decode(ref message, pointer, current, noRiskLimits, out current);

            return FixErrorCode.None;
        }
    }
}