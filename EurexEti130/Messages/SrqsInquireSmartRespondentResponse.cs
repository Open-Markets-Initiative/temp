using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Srqs Inquire Smart Respondent Response Message Methods
/// </summary>

public static partial class SrqsInquireSmartRespondentResponse
{
    /// <summary>
    ///  Eti Identifier for Srqs Inquire Smart Respondent Response
    /// </summary>
    public const string Identifier = "10719";

    /// <summary>
    ///  Encode Srqs Inquire Smart Respondent Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.SrqsInquireSmartRespondentResponse, out current);

        // --- encode srqs inquire smart respondent response message ---

        Pad2.Encode(pointer, current, out current);

        if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
        {
            RequestTime.Encode(pointer, current, requestTime, out current);
        }
        else
        {
            RequestTime.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        Pad4.Encode(pointer, current, out current);

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        var isSmartPartyDetailGrpComp = message.TryGetGroup(NoPartyDetails.FixTag, out var smartPartyDetailGrpComp) && smartPartyDetailGrpComp.sectionList.Count > 0;
        if (isSmartPartyDetailGrpComp)
        {
            var noPartyDetails = (ushort)smartPartyDetailGrpComp.sectionList.Count;
            NoPartyDetails.Encode(pointer, current, noPartyDetails, out current);
        }
        else
        {
            NoPartyDetails.Zero(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

        if (isSmartPartyDetailGrpComp)
        {
            SmartPartyDetailGrpComp.Encode(pointer, current, smartPartyDetailGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Srqs Inquire Smart Respondent Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SrqsInquireSmartRespondentResponse.Identifier;

        // --- decode srqs inquire smart respondent response message ---

        current += Pad2.Length;

        if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
        {
            message.AppendULong(RequestTime.FixTag, requestTime);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        current += Pad4.Length;

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        var noPartyDetails = (int)NoPartyDetails.Decode(pointer, current, out current);

        current += Pad2.Length;

        SmartPartyDetailGrpComp.Decode(ref message, pointer, current, noPartyDetails, out current);

        return FixErrorCode.None;
    }
}
