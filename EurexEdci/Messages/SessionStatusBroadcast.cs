using SRFixBase;

namespace Eurex.Edci.v130;

/// <summary>
///  Session Status Broadcast Message Methods
/// </summary>

public static partial class SessionStatusBroadcast
{
    /// <summary>
    ///  Eti Identifier for Session Status Broadcast
    /// </summary>
    public const string Identifier = "10903";

    /// <summary>
    ///  Encode Session Status Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.SessionStatusBroadcast, out current);

        // --- encode session status broadcast message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        if (message.TryGetInt(PartyIdExecutingUnit.FixTag, out var partyIdExecutingUnit))
        {
            PartyIdExecutingUnit.Encode(pointer, current, (uint)partyIdExecutingUnit, out current);
        }
        else
        {
            PartyIdExecutingUnit.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
        {
            PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
        }
        else
        {
            PartitionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplId.FixTag, out var applId))
        {
            ApplId.Encode(pointer, current, (byte)applId, out current);
        }
        else
        {
            ApplId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(LastFragment.FixTag, out var lastFragment))
        {
            LastFragment.Encode(pointer, current, (byte)lastFragment, out current);
        }
        else
        {
            LastFragment.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeDate.FixTag, out var tradeDate))
        {
            TradeDate.Encode(pointer, current, (uint)tradeDate, out current);
        }
        else
        {
            TradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
        {
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
        }
        else
        {
            MarketSegmentId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradSesEvent.FixTag, out var tradSesEvent))
        {
            TradSesEvent.Encode(pointer, current, (byte)tradSesEvent, out current);
        }
        else
        {
            TradSesEvent.SetNull(pointer, current, out current);
        }

        Pad7.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Session Status Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SessionStatusBroadcast.Identifier;

        // --- decode session status broadcast message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (PartyIdExecutingUnit.TryDecode(pointer, current, out var partyIdExecutingUnit, out current))
        {
            message.AppendInt(PartyIdExecutingUnit.FixTag, (int)partyIdExecutingUnit);
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        if (TradeDate.TryDecode(pointer, current, out var tradeDate, out current))
        {
            message.AppendInt(TradeDate.FixTag, (int)tradeDate);
        }

        if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
        {
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
        }

        if (TradSesEvent.TryDecode(pointer, current, out var tradSesEvent, out current))
        {
            message.AppendInt(TradSesEvent.FixTag, tradSesEvent);
        }

        current += Pad7.Length;

        return FixErrorCode.None;
    }
}
