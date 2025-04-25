using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Inquire Margin Based Risk Limit Response Message Methods
/// </summary>

public static partial class InquireMarginBasedRiskLimitResponse
{
    /// <summary>
    ///  Eti Identifier for Inquire Margin Based Risk Limit Response
    /// </summary>
    public const string Identifier = "10324";

    /// <summary>
    ///  Encode Inquire Margin Based Risk Limit Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.InquireMarginBasedRiskLimitResponse, out current);

        // --- encode inquire margin based risk limit response message ---

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

        if (message.TryGetDouble(MarginBasedRiskLimitLong.FixTag, out var marginBasedRiskLimitLong))
        {
            MarginBasedRiskLimitLong.Encode(pointer, current, marginBasedRiskLimitLong, out current);
        }
        else
        {
            MarginBasedRiskLimitLong.SetNull(pointer, current, out current);
        }

        if (message.TryGetDouble(MarginBasedRiskLimitShort.FixTag, out var marginBasedRiskLimitShort))
        {
            MarginBasedRiskLimitShort.Encode(pointer, current, marginBasedRiskLimitShort, out current);
        }
        else
        {
            MarginBasedRiskLimitShort.SetNull(pointer, current, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Inquire Margin Based Risk Limit Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = InquireMarginBasedRiskLimitResponse.Identifier;

        // --- decode inquire margin based risk limit response message ---

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

        if (MarginBasedRiskLimitLong.TryDecode(pointer, current, out var marginBasedRiskLimitLong, out current))
        {
            message.AppendDouble(MarginBasedRiskLimitLong.FixTag, marginBasedRiskLimitLong);
        }

        if (MarginBasedRiskLimitShort.TryDecode(pointer, current, out var marginBasedRiskLimitShort, out current))
        {
            message.AppendDouble(MarginBasedRiskLimitShort.FixTag, marginBasedRiskLimitShort);
        }

        return FixErrorCode.None;
    }
}
