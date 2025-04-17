using SRFixBase;

namespace Eurex.Edci.v131;

/// <summary>
///  Logout Response Message Methods
/// </summary>

public static partial class LogoutResponse
{
    /// <summary>
    ///  Edci Identifier for Logout Response
    /// </summary>
    public const string Identifier = "10003";

    /// <summary>
    ///  Encode Logout Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.LogoutResponse, out current);

        // --- encode logout response message ---

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

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        Pad3.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Logout Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = LogoutResponse.Identifier;

        // --- decode logout response message ---

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

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad3.Length;

        return FixErrorCode.None;
    }
}
