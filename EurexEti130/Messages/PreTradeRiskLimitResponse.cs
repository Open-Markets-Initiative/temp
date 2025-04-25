using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Pre Trade Risk Limit Response Message Methods
/// </summary>

public static partial class PreTradeRiskLimitResponse
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

        if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
        {
            RequestTime.Encode(pointer, current, requestTime, out current);
        }
        else
        {
            RequestTime.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeIn.FixTag, out var trdRegTsTimeIn))
        {
            TrdRegTsTimeIn.Encode(pointer, current, trdRegTsTimeIn, out current);
        }
        else
        {
            TrdRegTsTimeIn.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
        {
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
        }
        else
        {
            TrdRegTsTimeOut.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(ResponseIn.FixTag, out var responseIn))
        {
            ResponseIn.Encode(pointer, current, responseIn, out current);
        }
        else
        {
            ResponseIn.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        if (message.TryGetULong(RiskLimitReportId.FixTag, out var riskLimitReportId))
        {
            RiskLimitReportId.Encode(pointer, current, riskLimitReportId, out current);
        }
        else
        {
            RiskLimitReportId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

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

        if (message.TryGetInt(PartyDetailStatus.FixTag, out var partyDetailStatus))
        {
            PartyDetailStatus.Encode(pointer, current, (byte)partyDetailStatus, out current);
        }
        else
        {
            PartyDetailStatus.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(RiskLimitPlatform.FixTag, out var riskLimitPlatform))
        {
            RiskLimitPlatform.Encode(pointer, current, (byte)riskLimitPlatform, out current);
        }
        else
        {
            RiskLimitPlatform.SetNull(pointer, current, out current);
        }

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
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = PreTradeRiskLimitResponse.Identifier;

        // --- decode pre trade risk limit response message ---

        current += Pad2.Length;

        if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
        {
            message.AppendULong(RequestTime.FixTag, requestTime);
        }

        if (TrdRegTsTimeIn.TryDecode(pointer, current, out var trdRegTsTimeIn, out current))
        {
            message.AppendULong(TrdRegTsTimeIn.FixTag, trdRegTsTimeIn);
        }

        if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
        {
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
        }

        if (ResponseIn.TryDecode(pointer, current, out var responseIn, out current))
        {
            message.AppendULong(ResponseIn.FixTag, responseIn);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad3.Length;

        if (RiskLimitReportId.TryDecode(pointer, current, out var riskLimitReportId, out current))
        {
            message.AppendULong(RiskLimitReportId.FixTag, riskLimitReportId);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        var noRiskLimits = (int)NoRiskLimits.Decode(pointer, current, out current);

        if (PartyDetailStatus.TryDecode(pointer, current, out var partyDetailStatus, out current))
        {
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);
        }

        if (RiskLimitPlatform.TryDecode(pointer, current, out var riskLimitPlatform, out current))
        {
            message.AppendInt(RiskLimitPlatform.FixTag, riskLimitPlatform);
        }

        if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
        {
            message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
        }

        current += Pad4.Length;

        RiskLimitsRptGrpComp.Decode(ref message, pointer, current, noRiskLimits, out current);

        return FixErrorCode.None;
    }
}
