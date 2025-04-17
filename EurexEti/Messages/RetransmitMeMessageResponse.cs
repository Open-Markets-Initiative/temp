using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Retransmit Me Message Response Message Methods
/// </summary>

public static partial class RetransmitMeMessageResponse
{
    /// <summary>
    ///  Eti Identifier for Retransmit Me Message Response
    /// </summary>
    public const string Identifier = "10027";

    /// <summary>
    ///  Encode Retransmit Me Message Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.RetransmitMeMessageResponse, out current);

        // --- encode retransmit me message response message ---

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

        if (message.TryGetInt(ApplTotalMessageCount.FixTag, out var applTotalMessageCount))
        {
            ApplTotalMessageCount.Encode(pointer, current, (ushort)applTotalMessageCount, out current);
        }
        else
        {
            ApplTotalMessageCount.SetNull(pointer, current, out current);
        }

        var applEndMsgId = message.GetData(ApplEndMsgId.FixTag);
        ApplEndMsgId.Encode(pointer, current, applEndMsgId, out current);

        var refApplLastMsgId = message.GetData(RefApplLastMsgId.FixTag);
        RefApplLastMsgId.Encode(pointer, current, refApplLastMsgId, out current);

        Pad6.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Retransmit Me Message Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = RetransmitMeMessageResponse.Identifier;

        // --- decode retransmit me message response message ---

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

        if (ApplTotalMessageCount.TryDecode(pointer, current, out var applTotalMessageCount, out current))
        {
            message.AppendInt(ApplTotalMessageCount.FixTag, (short)applTotalMessageCount);
        }

        var applEndMsgId = ApplEndMsgId.Decode(pointer, current, out current);
        message.AppendData(ApplEndMsgId.FixTag, applEndMsgId);

        var refApplLastMsgId = RefApplLastMsgId.Decode(pointer, current, out current);
        message.AppendData(RefApplLastMsgId.FixTag, refApplLastMsgId);

        current += Pad6.Length;

        return FixErrorCode.None;
    }
}
