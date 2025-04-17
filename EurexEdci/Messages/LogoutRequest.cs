using SRFixBase;

namespace Eurex.Edci.v131;

/// <summary>
///  Logout Request Message Methods
/// </summary>

public static partial class LogoutRequest
{
    /// <summary>
    ///  Edci Identifier for Logout Request
    /// </summary>
    public const string Identifier = "10002";

    /// <summary>
    ///  Encode Logout Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.LogoutRequest, out current);

        // --- encode logout request message ---

        Pad2.Encode(pointer, current, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        Pad4.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Logout Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = LogoutRequest.Identifier;

        // --- decode logout request message ---

        current += Pad2.Length;

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        current += Pad4.Length;

        return FixErrorCode.None;
    }
}
