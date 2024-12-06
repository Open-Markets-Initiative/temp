using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Action Report Message Methods
    /// </summary>

    public partial class PartyActionReport
    {
        /// <summary>
        ///  Eti Identifier for Party Action Report
        /// </summary>
        public const string Identifier = "10042";

        /// <summary>
        ///  Encode Party Action Report Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.PartyActionReport, out current);

            // --- encode party action report message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
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

            var requestingPartyIdExecutingTrader = (uint)message.GetInt(RequestingPartyIdExecutingTrader.FixTag);
            RequestingPartyIdExecutingTrader.Encode(pointer, current, requestingPartyIdExecutingTrader, out current);

            var partyIdExecutingUnit = (uint)message.GetInt(PartyIdExecutingUnit.FixTag);
            PartyIdExecutingUnit.Encode(pointer, current, partyIdExecutingUnit, out current);

            var partyIdExecutingTrader = (uint)message.GetInt(PartyIdExecutingTrader.FixTag);
            PartyIdExecutingTrader.Encode(pointer, current, partyIdExecutingTrader, out current);

            var requestingPartyIdExecutingSystem = (uint)message.GetInt(RequestingPartyIdExecutingSystem.FixTag);
            RequestingPartyIdExecutingSystem.Encode(pointer, current, requestingPartyIdExecutingSystem, out current);

            var marketId = (ushort)message.GetInt(MarketId.FixTag);
            MarketId.Encode(pointer, current, marketId, out current);

            var partyActionType = (byte)message.GetInt(PartyActionType.FixTag);
            PartyActionType.Encode(pointer, current, partyActionType, out current);

            var requestingPartyIdEnteringFirm = (byte)message.GetInt(RequestingPartyIdEnteringFirm.FixTag);
            RequestingPartyIdEnteringFirm.Encode(pointer, current, requestingPartyIdEnteringFirm, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Party Action Report Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = PartyActionReport.Identifier;

            // --- decode party action report message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.sendingTime = new System.DateTime((long)sendingTime);

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

            var requestingPartyIdExecutingTrader = (int)RequestingPartyIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(RequestingPartyIdExecutingTrader.FixTag, requestingPartyIdExecutingTrader);

            var partyIdExecutingUnit = (int)PartyIdExecutingUnit.Decode(pointer, current, out current);
            message.AppendInt(PartyIdExecutingUnit.FixTag, partyIdExecutingUnit);

            var partyIdExecutingTrader = (int)PartyIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyIdExecutingTrader.FixTag, partyIdExecutingTrader);

            var requestingPartyIdExecutingSystem = (int)RequestingPartyIdExecutingSystem.Decode(pointer, current, out current);
            message.AppendInt(RequestingPartyIdExecutingSystem.FixTag, requestingPartyIdExecutingSystem);

            var marketId = (short)MarketId.Decode(pointer, current, out current);
            message.AppendInt(MarketId.FixTag, marketId);

            var partyActionType = PartyActionType.Decode(pointer, current, out current);
            message.AppendInt(PartyActionType.FixTag, partyActionType);

            var requestingPartyIdEnteringFirm = RequestingPartyIdEnteringFirm.Decode(pointer, current, out current);
            message.AppendInt(RequestingPartyIdEnteringFirm.FixTag, requestingPartyIdEnteringFirm);

            return FixErrorCode.None;
        }
    }
}