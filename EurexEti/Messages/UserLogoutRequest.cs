using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  User Logout Request Message Methods
/// </summary>

public static partial class UserLogoutRequest
{
    /// <summary>
    ///  Eti Identifier for User Logout Request
    /// </summary>
    public const string Identifier = "10029";

    /// <summary>
    ///  Encode User Logout Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.UserLogoutRequest, out current);

        // --- encode user logout request message ---

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

        if (message.TryGetInt(Username.FixTag, out var username))
        {
            Username.Encode(pointer, current, (uint)username, out current);
        }
        else
        {
            Username.SetNull(pointer, current, out current);
        }

        Pad4.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode User Logout Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = UserLogoutRequest.Identifier;

        // --- decode user logout request message ---

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

        if (Username.TryDecode(pointer, current, out var username, out current))
        {
            message.AppendInt(Username.FixTag, (int)username);
        }

        current += Pad4.Length;

        return FixErrorCode.None;
    }
}
