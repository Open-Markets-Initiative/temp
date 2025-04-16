using SRFixBase;

namespace Eurex.Edci.v130;

/// <summary>
///  Logon Response Message Methods
/// </summary>

public static partial class LogonResponse
{
    /// <summary>
    ///  Edci Identifier for Logon Response
    /// </summary>
    public const string Identifier = "10001";

    /// <summary>
    ///  Encode Logon Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.LogonResponse, out current);

        // --- encode logon response message ---

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

        if (message.TryGetInt(HeartBtInt.FixTag, out var heartBtInt))
        {
            HeartBtInt.Encode(pointer, current, (uint)heartBtInt, out current);
        }
        else
        {
            HeartBtInt.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(SessionInstanceId.FixTag, out var sessionInstanceId))
        {
            SessionInstanceId.Encode(pointer, current, (uint)sessionInstanceId, out current);
        }
        else
        {
            SessionInstanceId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketId.FixTag, out var marketId))
        {
            MarketId.Encode(pointer, current, (ushort)marketId, out current);
        }
        else
        {
            MarketId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradSesMode.FixTag, out var tradSesMode))
        {
            TradSesMode.Encode(pointer, current, (byte)tradSesMode, out current);
        }
        else
        {
            TradSesMode.SetNull(pointer, current, out current);
        }

        if (message.TryGetString(DefaultCstmApplVerId.FixTag, out var defaultCstmApplVerId))
        {
            DefaultCstmApplVerId.Encode(pointer, current, defaultCstmApplVerId, out current);
        }
        else
        {
            DefaultCstmApplVerId.SetNull(pointer, current, out current);
        }

        if (message.TryGetToken(DefaultCstmApplVerSubId.FixTag, out var defaultCstmApplVerSubId))
        {
            DefaultCstmApplVerSubId.Encode(pointer, current, defaultCstmApplVerSubId, out current);
        }
        else
        {
            DefaultCstmApplVerSubId.SetNull(pointer, current, out current);
        }

        Pad2.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Logon Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = LogonResponse.Identifier;

        // --- decode logon response message ---

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

        if (HeartBtInt.TryDecode(pointer, current, out var heartBtInt, out current))
        {
            message.AppendInt(HeartBtInt.FixTag, (int)heartBtInt);
        }

        if (SessionInstanceId.TryDecode(pointer, current, out var sessionInstanceId, out current))
        {
            message.AppendInt(SessionInstanceId.FixTag, (int)sessionInstanceId);
        }

        if (MarketId.TryDecode(pointer, current, out var marketId, out current))
        {
            message.AppendInt(MarketId.FixTag, (short)marketId);
        }

        if (TradSesMode.TryDecode(pointer, current, out var tradSesMode, out current))
        {
            message.AppendInt(TradSesMode.FixTag, tradSesMode);
        }

        if (DefaultCstmApplVerId.TryDecode(pointer, current, out var defaultCstmApplVerId, out current))
        {
            message.AppendString(DefaultCstmApplVerId.FixTag, defaultCstmApplVerId);
        }

        if (DefaultCstmApplVerSubId.TryDecode(pointer, current, out var defaultCstmApplVerSubId, out current))
        {
            message.AppendToken(DefaultCstmApplVerSubId.FixTag, defaultCstmApplVerSubId);
        }

        current += Pad2.Length;

        return FixErrorCode.None;
    }
}
