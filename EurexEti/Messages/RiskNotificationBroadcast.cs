using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Notification Broadcast Message Methods
    /// </summary>

    public partial class RiskNotificationBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Risk Notification Broadcast
        /// </summary>
        public const string Identifier = "10033";

        /// <summary>
        ///  Encode Risk Notification Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.RiskNotificationBroadcast, out current);

            // --- encode risk notification broadcast message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var applSeqNum = message.GetULong(ApplSeqNum.FixTag);
            ApplSeqNum.Encode(pointer, current, applSeqNum, out current);

            var applSubId = (uint)message.GetInt(ApplSubId.FixTag);
            ApplSubId.Encode(pointer, current, applSubId, out current);

            var partitionId = (ushort)message.GetInt(PartitionId.FixTag);
            PartitionId.Encode(pointer, current, partitionId, out current);

            var applResendFlag = (byte)message.GetInt(ApplResendFlag.FixTag);
            ApplResendFlag.Encode(pointer, current, applResendFlag, out current);

            var applId = (byte)message.GetInt(ApplId.FixTag);
            ApplId.Encode(pointer, current, applId, out current);

            var lastFragment = (byte)message.GetInt(LastFragment.FixTag);
            LastFragment.Encode(pointer, current, lastFragment, out current);

            Pad7.Encode(pointer, current, out current);

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var tradeDate = (uint)message.GetInt(TradeDate.FixTag);
            TradeDate.Encode(pointer, current, tradeDate, out current);

            var partyDetailIdExecutingUnit = (uint)message.GetInt(PartyDetailIdExecutingUnit.FixTag);
            PartyDetailIdExecutingUnit.Encode(pointer, current, partyDetailIdExecutingUnit, out current);

            var requestingPartyIdExecutingSystem = (uint)message.GetInt(RequestingPartyIdExecutingSystem.FixTag);
            RequestingPartyIdExecutingSystem.Encode(pointer, current, requestingPartyIdExecutingSystem, out current);

            var marketId = (ushort)message.GetInt(MarketId.FixTag);
            MarketId.Encode(pointer, current, marketId, out current);

            var inventoryCheckType = (byte)message.GetInt(InventoryCheckType.FixTag);
            InventoryCheckType.Encode(pointer, current, inventoryCheckType, out current);

            var listUpdateAction = message.GetToken(ListUpdateAction.FixTag);
            ListUpdateAction.Encode(pointer, current, listUpdateAction, out current);

            var riskLimitAction = (byte)message.GetInt(RiskLimitAction.FixTag);
            RiskLimitAction.Encode(pointer, current, riskLimitAction, out current);

            if (message.TryGetString(RequestingPartyEnteringFirm.FixTag, out var requestingPartyEnteringFirm))
            {
                RequestingPartyEnteringFirm.Encode(pointer, current, requestingPartyEnteringFirm, out current);
            }
            else
            {
                RequestingPartyEnteringFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(RequestingPartyClearingFirm.FixTag, out var requestingPartyClearingFirm))
            {
                RequestingPartyClearingFirm.Encode(pointer, current, requestingPartyClearingFirm, out current);
            }
            else
            {
                RequestingPartyClearingFirm.SetNull(pointer, current, out current);
            }

            Pad5.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Risk Notification Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = RiskNotificationBroadcast.Identifier;

            // --- decode risk notification broadcast message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new DateTime((long)sendingTime);

            var applSeqNum = ApplSeqNum.Decode(pointer, current, out current);
            message.AppendULong(ApplSeqNum.FixTag, applSeqNum);

            var applSubId = (int)ApplSubId.Decode(pointer, current, out current);
            message.AppendInt(ApplSubId.FixTag, applSubId);

            var partitionId = (short)PartitionId.Decode(pointer, current, out current);
            message.AppendInt(PartitionId.FixTag, partitionId);

            var applResendFlag = ApplResendFlag.Decode(pointer, current, out current);
            message.AppendInt(ApplResendFlag.FixTag, applResendFlag);

            var applId = ApplId.Decode(pointer, current, out current);
            message.AppendInt(ApplId.FixTag, applId);

            var lastFragment = LastFragment.Decode(pointer, current, out current);
            message.AppendInt(LastFragment.FixTag, lastFragment);

            current += Pad7.Length;

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var tradeDate = (int)TradeDate.Decode(pointer, current, out current);
            message.AppendInt(TradeDate.FixTag, tradeDate);

            var partyDetailIdExecutingUnit = (int)PartyDetailIdExecutingUnit.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailIdExecutingUnit.FixTag, partyDetailIdExecutingUnit);

            var requestingPartyIdExecutingSystem = (int)RequestingPartyIdExecutingSystem.Decode(pointer, current, out current);
            message.AppendInt(RequestingPartyIdExecutingSystem.FixTag, requestingPartyIdExecutingSystem);

            var marketId = (short)MarketId.Decode(pointer, current, out current);
            message.AppendInt(MarketId.FixTag, marketId);

            var inventoryCheckType = InventoryCheckType.Decode(pointer, current, out current);
            message.AppendInt(InventoryCheckType.FixTag, inventoryCheckType);

            var listUpdateAction = ListUpdateAction.Decode(pointer, current, out current);
            message.AppendToken(ListUpdateAction.FixTag, listUpdateAction);

            var riskLimitAction = RiskLimitAction.Decode(pointer, current, out current);
            message.AppendInt(RiskLimitAction.FixTag, riskLimitAction);

            if (RequestingPartyEnteringFirm.TryDecode(pointer, current, out var requestingPartyEnteringFirm, out current))
            {
                message.AppendString(RequestingPartyEnteringFirm.FixTag, requestingPartyEnteringFirm);
            }

            if (RequestingPartyClearingFirm.TryDecode(pointer, current, out var requestingPartyClearingFirm, out current))
            {
                message.AppendString(RequestingPartyClearingFirm.FixTag, requestingPartyClearingFirm);
            }

            current += Pad5.Length;

            return FixErrorCode.None;
        }
    }
}