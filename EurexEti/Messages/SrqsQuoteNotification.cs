using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Quote Notification Message Methods
    /// </summary>

    public static partial class SrqsQuoteNotification
    {
        /// <summary>
        ///  Eti Identifier for Srqs Quote Notification
        /// </summary>
        public const string Identifier = "10707";

        /// <summary>
        ///  Encode Srqs Quote Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsQuoteNotification, out current);

            // --- encode srqs quote notification message ---

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

            if (message.TryGetULong(QuoteId.FixTag, out var quoteId))
            {
                QuoteId.Encode(pointer, current, quoteId, out current);
            }
            else
            {
                QuoteId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(SecondaryQuoteId.FixTag, out var secondaryQuoteId))
            {
                SecondaryQuoteId.Encode(pointer, current, secondaryQuoteId, out current);
            }
            else
            {
                SecondaryQuoteId.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(BidPx.FixTag, out var bidPx))
            {
                BidPx.Encode(pointer, current, bidPx, out current);
            }
            else
            {
                BidPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(BidSize.FixTag, out var bidSize))
            {
                BidSize.Encode(pointer, current, bidSize, out current);
            }
            else
            {
                BidSize.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OfferPx.FixTag, out var offerPx))
            {
                OfferPx.Encode(pointer, current, offerPx, out current);
            }
            else
            {
                OfferPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OfferSize.FixTag, out var offerSize))
            {
                OfferSize.Encode(pointer, current, offerSize, out current);
            }
            else
            {
                OfferSize.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(UnderlyingDeltaPercentage.FixTag, out var underlyingDeltaPercentage))
            {
                UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);
            }
            else
            {
                UnderlyingDeltaPercentage.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(QuoteRefPrice.FixTag, out var quoteRefPrice))
            {
                QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);
            }
            else
            {
                QuoteRefPrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ExpireTime.FixTag, out var expireTime))
            {
                ExpireTime.Encode(pointer, current, expireTime, out current);
            }
            else
            {
                ExpireTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(NegotiationId.FixTag, out var negotiationId))
            {
                NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
            }
            else
            {
                NegotiationId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(QuotingStatus.FixTag, out var quotingStatus))
            {
                QuotingStatus.Encode(pointer, current, (byte)quotingStatus, out current);
            }
            else
            {
                QuotingStatus.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
            {
                TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
            }
            else
            {
                TradingCapacity.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(QuoteCancelReason.FixTag, out var quoteCancelReason))
            {
                QuoteCancelReason.Encode(pointer, current, (byte)quoteCancelReason, out current);
            }
            else
            {
                QuoteCancelReason.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

            if (message.TryGetInt(PartyIdExecutingTrader.FixTag, out var partyIdExecutingTrader))
            {
                PartyIdExecutingTrader.Encode(pointer, current, (uint)partyIdExecutingTrader, out current);
            }
            else
            {
                PartyIdExecutingTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyExecutingFirm.FixTag, out var partyExecutingFirm))
            {
                PartyExecutingFirm.Encode(pointer, current, partyExecutingFirm, out current);
            }
            else
            {
                PartyExecutingFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyExecutingTrader.FixTag, out var partyExecutingTrader))
            {
                PartyExecutingTrader.Encode(pointer, current, partyExecutingTrader, out current);
            }
            else
            {
                PartyExecutingTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyEnteringTrader.FixTag, out var partyEnteringTrader))
            {
                PartyEnteringTrader.Encode(pointer, current, partyEnteringTrader, out current);
            }
            else
            {
                PartyEnteringTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(QuoteReqId.FixTag, out var quoteReqId))
            {
                QuoteReqId.Encode(pointer, current, quoteReqId, out current);
            }
            else
            {
                QuoteReqId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FreeText1.FixTag, out var freeText1))
            {
                FreeText1.Encode(pointer, current, freeText1, out current);
            }
            else
            {
                FreeText1.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FreeText2.FixTag, out var freeText2))
            {
                FreeText2.Encode(pointer, current, freeText2, out current);
            }
            else
            {
                FreeText2.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FreeText3.FixTag, out var freeText3))
            {
                FreeText3.Encode(pointer, current, freeText3, out current);
            }
            else
            {
                FreeText3.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(FreeText5.FixTag, out var freeText5))
            {
                FreeText5.Encode(pointer, current, freeText5, out current);
            }
            else
            {
                FreeText5.SetNull(pointer, current, out current);
            }

            var positionEffect = message.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            if (message.TryGetString(Account.FixTag, out var account))
            {
                Account.Encode(pointer, current, account, out current);
            }
            else
            {
                Account.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
            {
                PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
            }
            else
            {
                PartyIdBeneficiary.SetNull(pointer, current, out current);
            }

            var custOrderHandlingInst = message.GetToken(CustOrderHandlingInst.FixTag);
            CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

            if (message.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
            {
                PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
            }
            else
            {
                PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
            {
                PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
            }
            else
            {
                PartyIdPositionAccount.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyIdLocationId.FixTag, out var partyIdLocationId))
            {
                PartyIdLocationId.Encode(pointer, current, partyIdLocationId, out current);
            }
            else
            {
                PartyIdLocationId.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
            {
                PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
            }
            else
            {
                PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Quote Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsQuoteNotification.Identifier;

            // --- decode srqs quote notification message ---

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

            if (QuoteId.TryDecode(pointer, current, out var quoteId, out current))
            {
                message.AppendULong(QuoteId.FixTag, quoteId);
            }

            if (SecondaryQuoteId.TryDecode(pointer, current, out var secondaryQuoteId, out current))
            {
                message.AppendULong(SecondaryQuoteId.FixTag, secondaryQuoteId);
            }

            if (BidPx.TryDecode(pointer, current, out var bidPx, out current))
            {
                message.AppendDouble(BidPx.FixTag, bidPx);
            }

            if (BidSize.TryDecode(pointer, current, out var bidSize, out current))
            {
                message.AppendDouble(BidSize.FixTag, bidSize);
            }

            if (OfferPx.TryDecode(pointer, current, out var offerPx, out current))
            {
                message.AppendDouble(OfferPx.FixTag, offerPx);
            }

            if (OfferSize.TryDecode(pointer, current, out var offerSize, out current))
            {
                message.AppendDouble(OfferSize.FixTag, offerSize);
            }

            if (UnderlyingDeltaPercentage.TryDecode(pointer, current, out var underlyingDeltaPercentage, out current))
            {
                message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);
            }

            if (QuoteRefPrice.TryDecode(pointer, current, out var quoteRefPrice, out current))
            {
                message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);
            }

            if (ExpireTime.TryDecode(pointer, current, out var expireTime, out current))
            {
                message.AppendULong(ExpireTime.FixTag, expireTime);
            }

            if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
            {
                message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
            }

            if (QuotingStatus.TryDecode(pointer, current, out var quotingStatus, out current))
            {
                message.AppendInt(QuotingStatus.FixTag, quotingStatus);
            }

            if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
            {
                message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
            }

            if (QuoteCancelReason.TryDecode(pointer, current, out var quoteCancelReason, out current))
            {
                message.AppendInt(QuoteCancelReason.FixTag, quoteCancelReason);
            }

            current += Pad1.Length;

            if (PartyIdExecutingTrader.TryDecode(pointer, current, out var partyIdExecutingTrader, out current))
            {
                message.AppendInt(PartyIdExecutingTrader.FixTag, (int)partyIdExecutingTrader);
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

            if (QuoteReqId.TryDecode(pointer, current, out var quoteReqId, out current))
            {
                message.AppendString(QuoteReqId.FixTag, quoteReqId);
            }

            if (FreeText1.TryDecode(pointer, current, out var freeText1, out current))
            {
                message.AppendString(FreeText1.FixTag, freeText1);
            }

            if (FreeText2.TryDecode(pointer, current, out var freeText2, out current))
            {
                message.AppendString(FreeText2.FixTag, freeText2);
            }

            if (FreeText3.TryDecode(pointer, current, out var freeText3, out current))
            {
                message.AppendString(FreeText3.FixTag, freeText3);
            }

            if (FreeText5.TryDecode(pointer, current, out var freeText5, out current))
            {
                message.AppendString(FreeText5.FixTag, freeText5);
            }

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
            }

            if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
            {
                message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
            }

            var custOrderHandlingInst = CustOrderHandlingInst.Decode(pointer, current, out current);
            message.AppendToken(CustOrderHandlingInst.FixTag, custOrderHandlingInst);

            if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
            {
                message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
            }

            if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
            {
                message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
            }

            if (PartyIdLocationId.TryDecode(pointer, current, out var partyIdLocationId, out current))
            {
                message.AppendString(PartyIdLocationId.FixTag, partyIdLocationId);
            }

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
            {
                message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
            }

            return FixErrorCode.None;
        }
    }
}