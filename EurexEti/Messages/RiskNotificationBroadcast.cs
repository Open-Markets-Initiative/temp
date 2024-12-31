using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Notification Broadcast Message Methods
    /// </summary>

    public static partial class RiskNotificationBroadcast
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

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            if (message.TryGetULong(ApplSeqNum.FixTag, out var applSeqNum))
            {
                ApplSeqNum.Encode(pointer, current, applSeqNum, out current);
            }
            else
            {
                ApplSeqNum.SetNull(pointer, current, out current);
            }

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

            if (message.TryGetInt(ApplResendFlag.FixTag, out var applResendFlag))
            {
                ApplResendFlag.Encode(pointer, current, (byte)applResendFlag, out current);
            }
            else
            {
                ApplResendFlag.SetNull(pointer, current, out current);
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

            Pad7.Encode(pointer, current, out current);

            if (message.TryGetULong(TransactTime.FixTag, out var transactTime))
            {
                TransactTime.Encode(pointer, current, transactTime, out current);
            }
            else
            {
                TransactTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradeDate.FixTag, out var tradeDate))
            {
                TradeDate.Encode(pointer, current, (uint)tradeDate, out current);
            }
            else
            {
                TradeDate.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyDetailIdExecutingUnit.FixTag, out var partyDetailIdExecutingUnit))
            {
                PartyDetailIdExecutingUnit.Encode(pointer, current, (uint)partyDetailIdExecutingUnit, out current);
            }
            else
            {
                PartyDetailIdExecutingUnit.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RequestingPartyIdExecutingSystem.FixTag, out var requestingPartyIdExecutingSystem))
            {
                RequestingPartyIdExecutingSystem.Encode(pointer, current, (uint)requestingPartyIdExecutingSystem, out current);
            }
            else
            {
                RequestingPartyIdExecutingSystem.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketId.FixTag, out var marketId))
            {
                MarketId.Encode(pointer, current, (ushort)marketId, out current);
            }
            else
            {
                MarketId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(InventoryCheckType.FixTag, out var inventoryCheckType))
            {
                InventoryCheckType.Encode(pointer, current, (byte)inventoryCheckType, out current);
            }
            else
            {
                InventoryCheckType.SetNull(pointer, current, out current);
            }

            var listUpdateAction = message.GetToken(ListUpdateAction.FixTag);
            ListUpdateAction.Encode(pointer, current, listUpdateAction, out current);

            if (message.TryGetInt(RiskLimitAction.FixTag, out var riskLimitAction))
            {
                RiskLimitAction.Encode(pointer, current, (byte)riskLimitAction, out current);
            }
            else
            {
                RiskLimitAction.SetNull(pointer, current, out current);
            }

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
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
        {
            message.Reset();

            message.msgType = RiskNotificationBroadcast.Identifier;

            // --- decode risk notification broadcast message ---

            current += Pad2.Length;

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ApplSeqNum.TryDecode(pointer, current, out var applSeqNum, out current))
            {
                message.AppendULong(ApplSeqNum.FixTag, applSeqNum);
            }

            if (ApplSubId.TryDecode(pointer, current, out var applSubId, out current))
            {
                message.AppendInt(ApplSubId.FixTag, (int)applSubId);
            }

            if (PartitionId.TryDecode(pointer, current, out var partitionId, out current))
            {
                message.AppendInt(PartitionId.FixTag, (short)partitionId);
            }

            if (ApplResendFlag.TryDecode(pointer, current, out var applResendFlag, out current))
            {
                message.AppendInt(ApplResendFlag.FixTag, applResendFlag);
            }

            if (ApplId.TryDecode(pointer, current, out var applId, out current))
            {
                message.AppendInt(ApplId.FixTag, applId);
            }

            if (LastFragment.TryDecode(pointer, current, out var lastFragment, out current))
            {
                message.AppendInt(LastFragment.FixTag, lastFragment);
            }

            current += Pad7.Length;

            if (TransactTime.TryDecode(pointer, current, out var transactTime, out current))
            {
                message.AppendULong(TransactTime.FixTag, transactTime);
            }

            if (TradeDate.TryDecode(pointer, current, out var tradeDate, out current))
            {
                message.AppendInt(TradeDate.FixTag, (int)tradeDate);
            }

            if (PartyDetailIdExecutingUnit.TryDecode(pointer, current, out var partyDetailIdExecutingUnit, out current))
            {
                message.AppendInt(PartyDetailIdExecutingUnit.FixTag, (int)partyDetailIdExecutingUnit);
            }

            if (RequestingPartyIdExecutingSystem.TryDecode(pointer, current, out var requestingPartyIdExecutingSystem, out current))
            {
                message.AppendInt(RequestingPartyIdExecutingSystem.FixTag, (int)requestingPartyIdExecutingSystem);
            }

            if (MarketId.TryDecode(pointer, current, out var marketId, out current))
            {
                message.AppendInt(MarketId.FixTag, (short)marketId);
            }

            if (InventoryCheckType.TryDecode(pointer, current, out var inventoryCheckType, out current))
            {
                message.AppendInt(InventoryCheckType.FixTag, inventoryCheckType);
            }

            var listUpdateAction = ListUpdateAction.Decode(pointer, current, out current);
            message.AppendToken(ListUpdateAction.FixTag, listUpdateAction);

            if (RiskLimitAction.TryDecode(pointer, current, out var riskLimitAction, out current))
            {
                message.AppendInt(RiskLimitAction.FixTag, riskLimitAction);
            }

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