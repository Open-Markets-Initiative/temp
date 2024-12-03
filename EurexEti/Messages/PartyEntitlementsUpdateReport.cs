using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Entitlements Update Report Message Methods
    /// </summary>

    public partial class PartyEntitlementsUpdateReport
    {
        /// <summary>
        ///  Eti Identifier for Party Entitlements Update Report
        /// </summary>
        public const string Identifier = "Party Entitlements Update Report";

        /// <summary>
        ///  Encode Party Entitlements Update Report Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.PartyEntitlementsUpdateReport, out current);

            // --- encode party entitlements update report message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
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

            var listUpdateAction = message.GetToken(ListUpdateAction.FixTag);
            ListUpdateAction.Encode(pointer, current, listUpdateAction, out current);

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

            var partyDetailStatus = (byte)message.GetInt(PartyDetailStatus.FixTag);
            PartyDetailStatus.Encode(pointer, current, partyDetailStatus, out current);

            Pad6.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Party Entitlements Update Report Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = PartyEntitlementsUpdateReport.Identifier;

            // --- decode party entitlements update report message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

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

            var listUpdateAction = ListUpdateAction.Decode(pointer, current, out current);
            message.AppendToken(ListUpdateAction.FixTag, listUpdateAction);

            if (RequestingPartyEnteringFirm.TryDecode(pointer, current, out var requestingPartyEnteringFirm, out current))
            {
                message.AppendString(RequestingPartyEnteringFirm.FixTag, requestingPartyEnteringFirm);
            }

            if (RequestingPartyClearingFirm.TryDecode(pointer, current, out var requestingPartyClearingFirm, out current))
            {
                message.AppendString(RequestingPartyClearingFirm.FixTag, requestingPartyClearingFirm);
            }

            var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

            current += Pad6.Length;

            return FixErrorCode.None;
        }
    }
}