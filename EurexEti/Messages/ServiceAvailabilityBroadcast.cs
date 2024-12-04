using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Service Availability Broadcast Message Methods
    /// </summary>

    public partial class ServiceAvailabilityBroadcast
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

            var sendingTime = message.sendTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad2.Encode(pointer, current, out current);

            var matchingEngineTradeDate = (uint)message.GetInt(MatchingEngineTradeDate.FixTag);
            MatchingEngineTradeDate.Encode(pointer, current, matchingEngineTradeDate, out current);

            var tradeManagerTradeDate = (uint)message.GetInt(TradeManagerTradeDate.FixTag);
            TradeManagerTradeDate.Encode(pointer, current, tradeManagerTradeDate, out current);

            var applSeqTradeDate = (uint)message.GetInt(ApplSeqTradeDate.FixTag);
            ApplSeqTradeDate.Encode(pointer, current, applSeqTradeDate, out current);

            var t7EntryServiceTradeDate = (uint)message.GetInt(T7EntryServiceTradeDate.FixTag);
            T7EntryServiceTradeDate.Encode(pointer, current, t7EntryServiceTradeDate, out current);

            var t7EntryServiceRtmTradeDate = (uint)message.GetInt(T7EntryServiceRtmTradeDate.FixTag);
            T7EntryServiceRtmTradeDate.Encode(pointer, current, t7EntryServiceRtmTradeDate, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var matchingEngineStatus = (byte)message.GetInt(MatchingEngineStatus.FixTag);
            MatchingEngineStatus.Encode(pointer, current, matchingEngineStatus, out current);

            var tradeManagerStatus = (byte)message.GetInt(TradeManagerStatus.FixTag);
            TradeManagerStatus.Encode(pointer, current, tradeManagerStatus, out current);

            var applSeqStatus = (byte)message.GetInt(ApplSeqStatus.FixTag);
            ApplSeqStatus.Encode(pointer, current, applSeqStatus, out current);

            var t7EntryServiceStatus = (byte)message.GetInt(T7EntryServiceStatus.FixTag);
            T7EntryServiceStatus.Encode(pointer, current, t7EntryServiceStatus, out current);

            var t7EntryServiceRtmStatus = (byte)message.GetInt(T7EntryServiceRtmStatus.FixTag);
            T7EntryServiceRtmStatus.Encode(pointer, current, t7EntryServiceRtmStatus, out current);

            Pad5.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Service Availability Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ServiceAvailabilityBroadcast.Identifier;

            // --- decode service availability broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new DateTime((long)sendingTime);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad2.Length;

            var matchingEngineTradeDate = (int)MatchingEngineTradeDate.Decode(pointer, current, out current);
            message.AppendInt(MatchingEngineTradeDate.FixTag, matchingEngineTradeDate);

            var tradeManagerTradeDate = (int)TradeManagerTradeDate.Decode(pointer, current, out current);
            message.AppendInt(TradeManagerTradeDate.FixTag, tradeManagerTradeDate);

            var applSeqTradeDate = (int)ApplSeqTradeDate.Decode(pointer, current, out current);
            message.AppendInt(ApplSeqTradeDate.FixTag, applSeqTradeDate);

            var t7EntryServiceTradeDate = (int)T7EntryServiceTradeDate.Decode(pointer, current, out current);
            message.AppendInt(T7EntryServiceTradeDate.FixTag, t7EntryServiceTradeDate);

            var t7EntryServiceRtmTradeDate = (int)T7EntryServiceRtmTradeDate.Decode(pointer, current, out current);
            message.AppendInt(T7EntryServiceRtmTradeDate.FixTag, t7EntryServiceRtmTradeDate);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var matchingEngineStatus = MatchingEngineStatus.Decode(pointer, current, out current);
            message.AppendInt(MatchingEngineStatus.FixTag, matchingEngineStatus);

            var tradeManagerStatus = TradeManagerStatus.Decode(pointer, current, out current);
            message.AppendInt(TradeManagerStatus.FixTag, tradeManagerStatus);

            var applSeqStatus = ApplSeqStatus.Decode(pointer, current, out current);
            message.AppendInt(ApplSeqStatus.FixTag, applSeqStatus);

            var t7EntryServiceStatus = T7EntryServiceStatus.Decode(pointer, current, out current);
            message.AppendInt(T7EntryServiceStatus.FixTag, t7EntryServiceStatus);

            var t7EntryServiceRtmStatus = T7EntryServiceRtmStatus.Decode(pointer, current, out current);
            message.AppendInt(T7EntryServiceRtmStatus.FixTag, t7EntryServiceRtmStatus);

            current += Pad5.Length;

            return FixErrorCode.None;
        }
    }
}