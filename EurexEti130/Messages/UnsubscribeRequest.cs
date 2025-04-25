using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Unsubscribe Request Message Methods
/// </summary>

public static partial class UnsubscribeRequest
{
    /// <summary>
    ///  Eti Identifier for Unsubscribe Request
    /// </summary>
    public const string Identifier = "10006";

    /// <summary>
    ///  Encode Unsubscribe Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.UnsubscribeRequest, out current);

        // --- encode unsubscribe request message ---

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

        if (message.TryGetInt(RefApplSubId.FixTag, out var refApplSubId))
        {
            RefApplSubId.Encode(pointer, current, (uint)refApplSubId, out current);
        }
        else
        {
            RefApplSubId.SetNull(pointer, current, out current);
        }

        Pad4.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Unsubscribe Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = UnsubscribeRequest.Identifier;

        // --- decode unsubscribe request message ---

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

        if (RefApplSubId.TryDecode(pointer, current, out var refApplSubId, out current))
        {
            message.AppendInt(RefApplSubId.FixTag, (int)refApplSubId);
        }

        current += Pad4.Length;

        return FixErrorCode.None;
    }
}
