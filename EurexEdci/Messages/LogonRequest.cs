using SRFixBase;

namespace Eurex.Edci.v131;

/// <summary>
///  Logon Request Message Methods
/// </summary>

public static partial class LogonRequest
{
    /// <summary>
    ///  Edci Identifier for Logon Request
    /// </summary>
    public const string Identifier = "10000";

    /// <summary>
    ///  Encode Logon Request Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.LogonRequest, out current);

        // --- encode logon request message ---

        Pad2.Encode(pointer, current, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        Pad4.Encode(pointer, current, out current);

        if (message.TryGetInt(HeartBtInt.FixTag, out var heartBtInt))
        {
            HeartBtInt.Encode(pointer, current, (uint)heartBtInt, out current);
        }
        else
        {
            HeartBtInt.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartyIdSessionId.FixTag, out var partyIdSessionId))
        {
            PartyIdSessionId.Encode(pointer, current, (uint)partyIdSessionId, out current);
        }
        else
        {
            PartyIdSessionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(DefaultCstmApplVerId.FixTag, out var defaultCstmApplVerId))
        {
            DefaultCstmApplVerId.Encode(pointer, current, defaultCstmApplVerId, out current);
        }
        else
        {
            DefaultCstmApplVerId.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(Password.FixTag, out var password))
        {
            Password.Encode(pointer, current, password, out current);
        }
        else
        {
            Password.SetNull(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Logon Request Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = LogonRequest.Identifier;

        // --- decode logon request message ---

        current += Pad2.Length;

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        current += Pad4.Length;

        if (HeartBtInt.TryDecode(pointer, current, out var heartBtInt, out current))
        {
            message.AppendInt(HeartBtInt.FixTag, (int)heartBtInt);
        }

        if (PartyIdSessionId.TryDecode(pointer, current, out var partyIdSessionId, out current))
        {
            message.AppendInt(PartyIdSessionId.FixTag, (int)partyIdSessionId);
        }

        if (DefaultCstmApplVerId.TryDecode(pointer, current, out var defaultCstmApplVerId, out current))
        {
            message.AppendString(DefaultCstmApplVerId.FixTag, defaultCstmApplVerId);
        }

        if (Password.TryDecode(pointer, current, out var password, out current))
        {
            message.AppendString(Password.FixTag, password);
        }

        current += Pad2.Length;

        return FixErrorCode.None;
    }
}
