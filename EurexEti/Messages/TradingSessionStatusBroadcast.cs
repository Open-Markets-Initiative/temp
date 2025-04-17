using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Trading Session Status Broadcast Message Methods
/// </summary>

public static partial class TradingSessionStatusBroadcast
{
    /// <summary>
    ///  Eti Identifier for Trading Session Status Broadcast
    /// </summary>
    public const string Identifier = "10307";

    /// <summary>
    ///  Encode Trading Session Status Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.TradingSessionStatusBroadcast, out current);

        // --- encode trading session status broadcast message ---

        Pad2.Encode(pointer, current, out current);

        if (message.TryGetULong(TrdRegTsTimeOut.FixTag, out var trdRegTsTimeOut))
        {
            TrdRegTsTimeOut.Encode(pointer, current, trdRegTsTimeOut, out current);
        }
        else
        {
            TrdRegTsTimeOut.SetNull(pointer, current, out current);
        }

        if (message.TryGetULong(NotificationIn.FixTag, out var notificationIn))
        {
            NotificationIn.Encode(pointer, current, notificationIn, out current);
        }
        else
        {
            NotificationIn.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        if (message.TryGetInt(ApplSubId.FixTag, out var applSubId))
        {
            ApplSubId.Encode(pointer, current, (uint)applSubId, out current);
        }
        else
        {
            ApplSubId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
        {
            PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
        }
        else
        {
            PartitionId.SetNull(pointer, current, out current);
        }

        var applMsgId = message.GetData(ApplMsgId.FixTag);
        ApplMsgId.Encode(pointer, current, applMsgId, out current);

        if (message.TryGetInt(ApplId.FixTag, out var applId))
        {
            ApplId.Encode(pointer, current, (byte)applId, out current);
        }
        else
        {
            ApplId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
        {
            ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
        }
        else
        {
            ApplResendFlag.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeDate.FixTag, out var tradeDate))
        {
            TradeDate.Encode(pointer, current, (uint)tradeDate, out current);
        }
        else
        {
            TradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradSesEvent.FixTag, out var tradSesEvent))
        {
            TradSesEvent.Encode(pointer, current, (byte)tradSesEvent, out current);
        }
        else
        {
            TradSesEvent.SetNull(pointer, current, out current);
        }

        var refApplLastMsgId = message.GetData(RefApplLastMsgId.FixTag);
        RefApplLastMsgId.Encode(pointer, current, refApplLastMsgId, out current);

        Pad7.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Trading Session Status Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = TradingSessionStatusBroadcast.Identifier;

        // --- decode trading session status broadcast message ---

        current += Pad2.Length;

        if (TrdRegTsTimeOut.TryDecode(pointer, current, out var trdRegTsTimeOut, out current))
        {
            message.AppendULong(TrdRegTsTimeOut.FixTag, trdRegTsTimeOut);
        }

        if (NotificationIn.TryDecode(pointer, current, out var notificationIn, out current))
        {
            message.AppendULong(NotificationIn.FixTag, notificationIn);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
        {
            message.AppendInt(ApplSubId.FixTag, (int)applSubId);
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        var applMsgId = ApplMsgId.Decode(pointer, current, out current);
        message.AppendData(ApplMsgId.FixTag, applMsgId);

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
        {
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad7.Length;

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (TradeDate.TryDecode(pointer, current, out var tradeDate, out current))
        {
            message.AppendInt(TradeDate.FixTag, (int)tradeDate);
        }

        if (TradSesEvent.TryDecode(pointer, current, out var tradSesEvent, out current))
        {
            message.AppendInt(TradSesEvent.FixTag, tradSesEvent);
        }

        var refApplLastMsgId = RefApplLastMsgId.Decode(pointer, current, out current);
        message.AppendData(RefApplLastMsgId.FixTag, refApplLastMsgId);

        current += Pad7.Length;

        return FixErrorCode.None;
    }
}
