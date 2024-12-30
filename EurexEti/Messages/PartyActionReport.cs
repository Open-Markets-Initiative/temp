using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Action Report Message Methods
    /// </summary>

    public static partial class PartyActionReport
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

            if (message.TryGetInt(RequestingPartyIdExecutingTrader.FixTag, out var requestingPartyIdExecutingTrader))
            {
                RequestingPartyIdExecutingTrader.Encode(pointer, current, (uint)requestingPartyIdExecutingTrader, out current);
            }
            else
            {
                RequestingPartyIdExecutingTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdExecutingUnit.FixTag, out var partyIdExecutingUnit))
            {
                PartyIdExecutingUnit.Encode(pointer, current, (uint)partyIdExecutingUnit, out current);
            }
            else
            {
                PartyIdExecutingUnit.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdExecutingTrader.FixTag, out var partyIdExecutingTrader))
            {
                PartyIdExecutingTrader.Encode(pointer, current, (uint)partyIdExecutingTrader, out current);
            }
            else
            {
                PartyIdExecutingTrader.SetNull(pointer, current, out current);
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

            if (message.TryGetInt(PartyActionType.FixTag, out var partyActionType))
            {
                PartyActionType.Encode(pointer, current, (byte)partyActionType, out current);
            }
            else
            {
                PartyActionType.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(RequestingPartyIdEnteringFirm.FixTag, out var requestingPartyIdEnteringFirm))
            {
                RequestingPartyIdEnteringFirm.Encode(pointer, current, (byte)requestingPartyIdEnteringFirm, out current);
            }
            else
            {
                RequestingPartyIdEnteringFirm.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Party Action Report Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = PartyActionReport.Identifier;

            // --- decode party action report message ---

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

            if (RequestingPartyIdExecutingTrader.TryDecode(pointer, current, out var requestingPartyIdExecutingTrader, out current))
            {
                message.AppendInt(RequestingPartyIdExecutingTrader.FixTag, (int)requestingPartyIdExecutingTrader);
            }

            if (PartyIdExecutingUnit.TryDecode(pointer, current, out var partyIdExecutingUnit, out current))
            {
                message.AppendInt(PartyIdExecutingUnit.FixTag, (int)partyIdExecutingUnit);
            }

            if (PartyIdExecutingTrader.TryDecode(pointer, current, out var partyIdExecutingTrader, out current))
            {
                message.AppendInt(PartyIdExecutingTrader.FixTag, (int)partyIdExecutingTrader);
            }

            if (RequestingPartyIdExecutingSystem.TryDecode(pointer, current, out var requestingPartyIdExecutingSystem, out current))
            {
                message.AppendInt(RequestingPartyIdExecutingSystem.FixTag, (int)requestingPartyIdExecutingSystem);
            }

            if (MarketId.TryDecode(pointer, current, out var marketId, out current))
            {
                message.AppendInt(MarketId.FixTag, (short)marketId);
            }

            if (PartyActionType.TryDecode(pointer, current, out var partyActionType, out current))
            {
                message.AppendInt(PartyActionType.FixTag, partyActionType);
            }

            if (RequestingPartyIdEnteringFirm.TryDecode(pointer, current, out var requestingPartyIdEnteringFirm, out current))
            {
                message.AppendInt(RequestingPartyIdEnteringFirm.FixTag, requestingPartyIdEnteringFirm);
            }

            return FixErrorCode.None;
        }
    }
}