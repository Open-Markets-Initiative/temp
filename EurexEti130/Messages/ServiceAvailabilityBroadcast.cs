using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Service Availability Broadcast Message Methods
/// </summary>

public static partial class ServiceAvailabilityBroadcast
{
    /// <summary>
    ///  Eti Identifier for Service Availability Broadcast
    /// </summary>
    public const string Identifier = "10030";

    /// <summary>
    ///  Encode Service Availability Broadcast Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.ServiceAvailabilityBroadcast, out current);

        // --- encode service availability broadcast message ---

        Pad2.Encode(pointer, current, out current);

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

        Pad2.Encode(pointer, current, out current);

        if (message.TryGetInt(MatchingEngineTradeDate.FixTag, out var matchingEngineTradeDate))
        {
            MatchingEngineTradeDate.Encode(pointer, current, (uint)matchingEngineTradeDate, out current);
        }
        else
        {
            MatchingEngineTradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeManagerTradeDate.FixTag, out var tradeManagerTradeDate))
        {
            TradeManagerTradeDate.Encode(pointer, current, (uint)tradeManagerTradeDate, out current);
        }
        else
        {
            TradeManagerTradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplSeqTradeDate.FixTag, out var applSeqTradeDate))
        {
            ApplSeqTradeDate.Encode(pointer, current, (uint)applSeqTradeDate, out current);
        }
        else
        {
            ApplSeqTradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(T7EntryServiceTradeDate.FixTag, out var t7EntryServiceTradeDate))
        {
            T7EntryServiceTradeDate.Encode(pointer, current, (uint)t7EntryServiceTradeDate, out current);
        }
        else
        {
            T7EntryServiceTradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(T7EntryServiceRtmTradeDate.FixTag, out var t7EntryServiceRtmTradeDate))
        {
            T7EntryServiceRtmTradeDate.Encode(pointer, current, (uint)t7EntryServiceRtmTradeDate, out current);
        }
        else
        {
            T7EntryServiceRtmTradeDate.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(PartitionId.FixTag, out var partitionId))
        {
            PartitionId.Encode(pointer, current, (ushort)partitionId, out current);
        }
        else
        {
            PartitionId.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(MatchingEngineStatus.FixTag, out var matchingEngineStatus))
        {
            MatchingEngineStatus.Encode(pointer, current, (byte)matchingEngineStatus, out current);
        }
        else
        {
            MatchingEngineStatus.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(TradeManagerStatus.FixTag, out var tradeManagerStatus))
        {
            TradeManagerStatus.Encode(pointer, current, (byte)tradeManagerStatus, out current);
        }
        else
        {
            TradeManagerStatus.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(ApplSeqStatus.FixTag, out var applSeqStatus))
        {
            ApplSeqStatus.Encode(pointer, current, (byte)applSeqStatus, out current);
        }
        else
        {
            ApplSeqStatus.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(T7EntryServiceStatus.FixTag, out var t7EntryServiceStatus))
        {
            T7EntryServiceStatus.Encode(pointer, current, (byte)t7EntryServiceStatus, out current);
        }
        else
        {
            T7EntryServiceStatus.SetNull(pointer, current, out current);
        }

        if (message.TryGetInt(T7EntryServiceRtmStatus.FixTag, out var t7EntryServiceRtmStatus))
        {
            T7EntryServiceRtmStatus.Encode(pointer, current, (byte)t7EntryServiceRtmStatus, out current);
        }
        else
        {
            T7EntryServiceRtmStatus.SetNull(pointer, current, out current);
        }

        Pad5.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Service Availability Broadcast Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = ServiceAvailabilityBroadcast.Identifier;

        // --- decode service availability broadcast message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
        {
            message.AppendInt(ApplSubId.FixTag, (int)applSubId);
        }

        if (ApplId.TryDecode(pointer, current, out var applId, out current))
        {
            message.AppendInt(ApplId.FixTag, applId);
        }

        if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
        {
            message.AppendInt(LastFragment.FixTag, lastFragment);
        }

        current += Pad2.Length;

        if (MatchingEngineTradeDate.TryDecode(pointer, current, out var matchingEngineTradeDate, out current))
        {
            message.AppendInt(MatchingEngineTradeDate.FixTag, (int)matchingEngineTradeDate);
        }

        if (TradeManagerTradeDate.TryDecode(pointer, current, out var tradeManagerTradeDate, out current))
        {
            message.AppendInt(TradeManagerTradeDate.FixTag, (int)tradeManagerTradeDate);
        }

        if (ApplSeqTradeDate.TryDecode(pointer, current, out var applSeqTradeDate, out current))
        {
            message.AppendInt(ApplSeqTradeDate.FixTag, (int)applSeqTradeDate);
        }

        if (T7EntryServiceTradeDate.TryDecode(pointer, current, out var t7EntryServiceTradeDate, out current))
        {
            message.AppendInt(T7EntryServiceTradeDate.FixTag, (int)t7EntryServiceTradeDate);
        }

        if (T7EntryServiceRtmTradeDate.TryDecode(pointer, current, out var t7EntryServiceRtmTradeDate, out current))
        {
            message.AppendInt(T7EntryServiceRtmTradeDate.FixTag, (int)t7EntryServiceRtmTradeDate);
        }

        if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
        {
            message.AppendInt(PartitionId.FixTag, (short)partitionId);
        }

        if (MatchingEngineStatus.TryDecode(pointer, current, out var matchingEngineStatus, out current))
        {
            message.AppendInt(MatchingEngineStatus.FixTag, matchingEngineStatus);
        }

        if (TradeManagerStatus.TryDecode(pointer, current, out var tradeManagerStatus, out current))
        {
            message.AppendInt(TradeManagerStatus.FixTag, tradeManagerStatus);
        }

        if (ApplSeqStatus.TryDecode(pointer, current, out var applSeqStatus, out current))
        {
            message.AppendInt(ApplSeqStatus.FixTag, applSeqStatus);
        }

        if (T7EntryServiceStatus.TryDecode(pointer, current, out var t7EntryServiceStatus, out current))
        {
            message.AppendInt(T7EntryServiceStatus.FixTag, t7EntryServiceStatus);
        }

        if (T7EntryServiceRtmStatus.TryDecode(pointer, current, out var t7EntryServiceRtmStatus, out current))
        {
            message.AppendInt(T7EntryServiceRtmStatus.FixTag, t7EntryServiceRtmStatus);
        }

        current += Pad5.Length;

        return FixErrorCode.None;
    }
}
