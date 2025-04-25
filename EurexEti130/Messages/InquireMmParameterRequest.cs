using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Inquire Mm Parameter Request Message Methods
/// </summary>

public static partial class InquireMmParameterRequest
{
    /// <summary>
    ///  Eti Identifier for Inquire Mm Parameter Request
    /// </summary>
    public const string Identifier = "10305";

    /// <summary>
    ///  Encode Inquire Mm Parameter Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.InquireMmParameterRequest, out current);

        // --- encode inquire mm parameter request message ---

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

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TargetPartyIdSessionId.FixTag, out var targetPartyIdSessionId))
        {
            TargetPartyIdSessionId.Encode(pointer, current, (uint)targetPartyIdSessionId, out current);
        }
        else
        {
            TargetPartyIdSessionId.SetNull(pointer, current, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Inquire Mm Parameter Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = InquireMmParameterRequest.Identifier;

        // --- decode inquire mm parameter request message ---

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

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (TargetPartyIdSessionId.TryDecode(pointer, current, out var targetPartyIdSessionId, out current))
        {
            message.AppendInt(TargetPartyIdSessionId.FixTag, (int)targetPartyIdSessionId);
        }

        return FixErrorCode.None;
    }
}
