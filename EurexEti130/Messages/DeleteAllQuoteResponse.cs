using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Delete All Quote Response Message Methods
/// </summary>

public static partial class DeleteAllQuoteResponse
{
    /// <summary>
    ///  Eti Identifier for Delete All Quote Response
    /// </summary>
    public const string Identifier = "10409";

    /// <summary>
    ///  Encode Delete All Quote Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.DeleteAllQuoteResponse, out current);

        // --- encode delete all quote response message ---

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

        if (message.TryGetULong(MassActionReportId.FixTag, out var massActionReportId))
        {
            MassActionReportId.Encode(pointer, current, massActionReportId, out current);
        }
        else
        {
            MassActionReportId.SetNull(pointer, current, out current);
        }

        var isNotAffectedSecuritiesGrpComp = message.TryGetGroup(NoNotAffectedSecurities.FixTag, out var notAffectedSecuritiesGrpComp) && notAffectedSecuritiesGrpComp.sectionList.Count > 0;
        if (isNotAffectedSecuritiesGrpComp)
        {
            var noNotAffectedSecurities = (ushort)notAffectedSecuritiesGrpComp.sectionList.Count;
            NoNotAffectedSecurities.Encode(pointer, current, noNotAffectedSecurities, out current);
        }
        else
        {
            NoNotAffectedSecurities.Zero(pointer, current, out current);
        }

        Pad6.Encode(pointer, current, out current);

        if (isNotAffectedSecuritiesGrpComp)
        {
            NotAffectedSecuritiesGrpComp.Encode(pointer, current, notAffectedSecuritiesGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Delete All Quote Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = DeleteAllQuoteResponse.Identifier;

        // --- decode delete all quote response message ---

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

        if (MassActionReportId.TryDecode(pointer, current, out var massActionReportId, out current))
        {
            message.AppendULong(MassActionReportId.FixTag, massActionReportId);
        }

        var noNotAffectedSecurities = (int)NoNotAffectedSecurities.Decode(pointer, current, out current);

        current += Pad6.Length;

        NotAffectedSecuritiesGrpComp.Decode(ref message, pointer, current, noNotAffectedSecurities, out current);

        return FixErrorCode.None;
    }
}
