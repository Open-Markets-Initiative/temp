using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Srqs Quote Snapshot Notification Message Methods
    /// </summary>

    public partial class SrqsQuoteSnapshotNotification
    {
        /// <summary>
        ///  Eti Identifier for Srqs Quote Snapshot Notification
        /// </summary>
        public const string Identifier = "Srqs Quote Snapshot Notification";

        /// <summary>
        ///  Encode Srqs Quote Snapshot Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsQuoteSnapshotNotification, out current);

            // --- encode srqs quote snapshot notification message ---

            var start = current;

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

            var noQuoteEntries = (byte)message.GetInt(NoQuoteEntries.FixTag);
            NoQuoteEntries.Encode(pointer, current, noQuoteEntries, out current);

            var messageEventSource = message.GetToken(MessageEventSource.FixTag);
            MessageEventSource.Encode(pointer, current, messageEventSource, out current);

            Pad6.Encode(pointer, current, out current);

            var transactTime = group.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var expireTime = group.GetULong(ExpireTime.FixTag);
            ExpireTime.Encode(pointer, current, expireTime, out current);

            var quoteId = group.GetULong(QuoteId.FixTag);
            QuoteId.Encode(pointer, current, quoteId, out current);

            var secondaryQuoteId = group.GetULong(SecondaryQuoteId.FixTag);
            SecondaryQuoteId.Encode(pointer, current, secondaryQuoteId, out current);

            var bidPx = group.GetDouble(BidPx.FixTag);
            BidPx.Encode(pointer, current, bidPx, out current);

            var bidSize = group.GetDouble(BidSize.FixTag);
            BidSize.Encode(pointer, current, bidSize, out current);

            var offerPx = group.GetDouble(OfferPx.FixTag);
            OfferPx.Encode(pointer, current, offerPx, out current);

            var offerSize = group.GetDouble(OfferSize.FixTag);
            OfferSize.Encode(pointer, current, offerSize, out current);

            var underlyingPx = group.GetDouble(UnderlyingPx.FixTag);
            UnderlyingPx.Encode(pointer, current, underlyingPx, out current);

            var underlyingDeltaPercentage = group.GetDouble(UnderlyingDeltaPercentage.FixTag);
            UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);

            var quoteRefPrice = group.GetDouble(QuoteRefPrice.FixTag);
            QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);

            var partyIdExecutingTrader = (uint)group.GetInt(PartyIdExecutingTrader.FixTag);
            PartyIdExecutingTrader.Encode(pointer, current, partyIdExecutingTrader, out current);

            var negotiationId = (uint)group.GetInt(NegotiationId.FixTag);
            NegotiationId.Encode(pointer, current, negotiationId, out current);

            var quotingStatus = (byte)group.GetInt(QuotingStatus.FixTag);
            QuotingStatus.Encode(pointer, current, quotingStatus, out current);

            if (group.TryGetString(FirmNegotiationId.FixTag, out var firmNegotiationId))
            {
                FirmNegotiationId.Encode(pointer, current, firmNegotiationId, out current);
            }
            else
            {
                FirmNegotiationId.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
            {
                PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
            }
            else
            {
                PartyExecutingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
            {
                PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
            }
            else
            {
                PartyExecutingTrader.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyEnteringTrader.FixTag, out var partyEnteringTrader))
            {
                PartyEnteringTrader.Encode(pointer, current, partyEnteringTrader, out current);
            }
            else
            {
                PartyEnteringTrader.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Srqs Quote Snapshot Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsQuoteSnapshotNotification.Identifier;

            // --- decode srqs quote snapshot notification message ---

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

            var noQuoteEntries = NoQuoteEntries.Decode(pointer, current, out current);
            message.AppendInt(NoQuoteEntries.FixTag, noQuoteEntries);

            var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
            message.AppendToken(MessageEventSource.FixTag, messageEventSource);

            current += Pad6.Length;

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var expireTime = ExpireTime.Decode(pointer, current, out current);
            message.AppendULong(ExpireTime.FixTag, expireTime);

            var quoteId = QuoteId.Decode(pointer, current, out current);
            message.AppendULong(QuoteId.FixTag, quoteId);

            var secondaryQuoteId = SecondaryQuoteId.Decode(pointer, current, out current);
            message.AppendULong(SecondaryQuoteId.FixTag, secondaryQuoteId);

            var bidPx = BidPx.Decode(pointer, current, out current);
            message.AppendDouble(BidPx.FixTag, bidPx);

            var bidSize = BidSize.Decode(pointer, current, out current);
            message.AppendDouble(BidSize.FixTag, bidSize);

            var offerPx = OfferPx.Decode(pointer, current, out current);
            message.AppendDouble(OfferPx.FixTag, offerPx);

            var offerSize = OfferSize.Decode(pointer, current, out current);
            message.AppendDouble(OfferSize.FixTag, offerSize);

            var underlyingPx = UnderlyingPx.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingPx.FixTag, underlyingPx);

            var underlyingDeltaPercentage = UnderlyingDeltaPercentage.Decode(pointer, current, out current);
            message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);

            var quoteRefPrice = QuoteRefPrice.Decode(pointer, current, out current);
            message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);

            var partyIdExecutingTrader = (int)PartyIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyIdExecutingTrader.FixTag, partyIdExecutingTrader);

            var negotiationId = (int)NegotiationId.Decode(pointer, current, out current);
            message.AppendInt(NegotiationId.FixTag, negotiationId);

            var quotingStatus = QuotingStatus.Decode(pointer, current, out current);
            message.AppendInt(QuotingStatus.FixTag, quotingStatus);

            if (FirmNegotiationId.TryDecode(pointer, current, out var firmNegotiationId, out current))
            {
                message.AppendString(FirmNegotiationId.FixTag, firmNegotiationId);
            }

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
            }

            if (PartyEnteringTrader.TryDecode(pointer, current, out var partyEnteringTrader, out current))
            {
                message.AppendString(PartyEnteringTrader.FixTag, partyEnteringTrader);
            }

            current += Pad2.Length;

            return FixErrorCode.None;
        }
    }
}