using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Srqs Enter Quote Request Message Methods
    /// </summary>

    public static partial class SrqsEnterQuoteRequest
    {
        /// <summary>
        ///  Eti Identifier for Srqs Enter Quote Request
        /// </summary>
        public const string Identifier = "10702";

        /// <summary>
        ///  Encode Srqs Enter Quote Request Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.SrqsEnterQuoteRequest, out current);

            // --- encode srqs enter quote request message ---

            if (message.TryGetString(NetworkMsgId.FixTag, out var networkMsgId))
            {
                NetworkMsgId.Encode(pointer, current, networkMsgId, out current);
            }
            else
            {
                NetworkMsgId.SetNull(pointer, current, out current);
            }

            Pad2.Encode(pointer, current, out current);

            var msgSeqNum = (uint)message.msgSeqNum;
            MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

            var senderSubId = uint.Parse(message.senderSubID);
            SenderSubId.Encode(pointer, current, senderSubId, out current);

            if (message.TryGetDouble(BidPx.FixTag, out var bidPx))
            {
                BidPx.Encode(pointer, current, bidPx, out current);
            }
            else
            {
                BidPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OfferPx.FixTag, out var offerPx))
            {
                OfferPx.Encode(pointer, current, offerPx, out current);
            }
            else
            {
                OfferPx.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(UnderlyingDeltaPercentage.FixTag, out var underlyingDeltaPercentage))
            {
                UnderlyingDeltaPercentage.Encode(pointer, current, underlyingDeltaPercentage, out current);
            }
            else
            {
                UnderlyingDeltaPercentage.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(BidSize.FixTag, out var bidSize))
            {
                BidSize.Encode(pointer, current, bidSize, out current);
            }
            else
            {
                BidSize.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(OfferSize.FixTag, out var offerSize))
            {
                OfferSize.Encode(pointer, current, offerSize, out current);
            }
            else
            {
                OfferSize.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(PartyIdClientId.FixTag, out var partyIdClientId))
            {
                PartyIdClientId.Encode(pointer, current, partyIdClientId, out current);
            }
            else
            {
                PartyIdClientId.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(PartyIdInvestmentDecisionMaker.FixTag, out var partyIdInvestmentDecisionMaker))
            {
                PartyIdInvestmentDecisionMaker.Encode(pointer, current, partyIdInvestmentDecisionMaker, out current);
            }
            else
            {
                PartyIdInvestmentDecisionMaker.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ExecutingTrader.FixTag, out var executingTrader))
            {
                ExecutingTrader.Encode(pointer, current, executingTrader, out current);
            }
            else
            {
                ExecutingTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetDouble(QuoteRefPrice.FixTag, out var quoteRefPrice))
            {
                QuoteRefPrice.Encode(pointer, current, quoteRefPrice, out current);
            }
            else
            {
                QuoteRefPrice.SetNull(pointer, current, out current);
            }

            if (message.TryGetULong(ValidUntilTime.FixTag, out var validUntilTime))
            {
                ValidUntilTime.Encode(pointer, current, validUntilTime, out current);
            }
            else
            {
                ValidUntilTime.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(MarketSegmentId.FixTag, out var marketSegmentId))
            {
                MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);
            }
            else
            {
                MarketSegmentId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(NegotiationId.FixTag, out var negotiationId))
            {
                NegotiationId.Encode(pointer, current, (uint)negotiationId, out current);
            }
            else
            {
                NegotiationId.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(OrderAttributeLiquidityProvision.FixTag, out var orderAttributeLiquidityProvision))
            {
                OrderAttributeLiquidityProvision.Encode(pointer, current, (byte)orderAttributeLiquidityProvision, out current);
            }
            else
            {
                OrderAttributeLiquidityProvision.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ExecutingTraderQualifier.FixTag, out var executingTraderQualifier))
            {
                ExecutingTraderQualifier.Encode(pointer, current, (byte)executingTraderQualifier, out current);
            }
            else
            {
                ExecutingTraderQualifier.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, out var partyIdInvestmentDecisionMakerQualifier))
            {
                PartyIdInvestmentDecisionMakerQualifier.Encode(pointer, current, (byte)partyIdInvestmentDecisionMakerQualifier, out current);
            }
            else
            {
                PartyIdInvestmentDecisionMakerQualifier.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
            {
                TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
            }
            else
            {
                TradingCapacity.SetNull(pointer, current, out current);
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

            Pad2.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Srqs Enter Quote Request Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = SrqsEnterQuoteRequest.Identifier;

            // --- decode srqs enter quote request message ---

            if (NetworkMsgId.TryDecode(pointer, current, out var networkMsgId, out current))
            {
                message.AppendString(NetworkMsgId.FixTag, networkMsgId);
            }

            current += Pad2.Length;

            if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
            {
                message.msgSeqNum = (int)msgSeqNum;
            }

            if (SenderSubId.TryDecode(pointer, current, out var senderSubId, out current))
            {
                message.senderSubID = senderSubId.ToString();
            }

            if (BidPx.TryDecode(pointer, current, out var bidPx, out current))
            {
                message.AppendDouble(BidPx.FixTag, bidPx);
            }

            if (OfferPx.TryDecode(pointer, current, out var offerPx, out current))
            {
                message.AppendDouble(OfferPx.FixTag, offerPx);
            }

            if (UnderlyingDeltaPercentage.TryDecode(pointer, current, out var underlyingDeltaPercentage, out current))
            {
                message.AppendDouble(UnderlyingDeltaPercentage.FixTag, underlyingDeltaPercentage);
            }

            if (BidSize.TryDecode(pointer, current, out var bidSize, out current))
            {
                message.AppendDouble(BidSize.FixTag, bidSize);
            }

            if (OfferSize.TryDecode(pointer, current, out var offerSize, out current))
            {
                message.AppendDouble(OfferSize.FixTag, offerSize);
            }

            if (PartyIdClientId.TryDecode(pointer, current, out var partyIdClientId, out current))
            {
                message.AppendULong(PartyIdClientId.FixTag, partyIdClientId);
            }

            if (PartyIdInvestmentDecisionMaker.TryDecode(pointer, current, out var partyIdInvestmentDecisionMaker, out current))
            {
                message.AppendULong(PartyIdInvestmentDecisionMaker.FixTag, partyIdInvestmentDecisionMaker);
            }

            if (ExecutingTrader.TryDecode(pointer, current, out var executingTrader, out current))
            {
                message.AppendULong(ExecutingTrader.FixTag, executingTrader);
            }

            if (QuoteRefPrice.TryDecode(pointer, current, out var quoteRefPrice, out current))
            {
                message.AppendDouble(QuoteRefPrice.FixTag, quoteRefPrice);
            }

            if (ValidUntilTime.TryDecode(pointer, current, out var validUntilTime, out current))
            {
                message.AppendULong(ValidUntilTime.FixTag, validUntilTime);
            }

            if (MarketSegmentId.TryDecode(pointer, current, out var marketSegmentId, out current))
            {
                message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);
            }

            if (NegotiationId.TryDecode(pointer, current, out var negotiationId, out current))
            {
                message.AppendInt(NegotiationId.FixTag, (int)negotiationId);
            }

            if (OrderAttributeLiquidityProvision.TryDecode(pointer, current, out var orderAttributeLiquidityProvision, out current))
            {
                message.AppendInt(OrderAttributeLiquidityProvision.FixTag, orderAttributeLiquidityProvision);
            }

            if (ExecutingTraderQualifier.TryDecode(pointer, current, out var executingTraderQualifier, out current))
            {
                message.AppendInt(ExecutingTraderQualifier.FixTag, executingTraderQualifier);
            }

            if (PartyIdInvestmentDecisionMakerQualifier.TryDecode(pointer, current, out var partyIdInvestmentDecisionMakerQualifier, out current))
            {
                message.AppendInt(PartyIdInvestmentDecisionMakerQualifier.FixTag, partyIdInvestmentDecisionMakerQualifier);
            }

            if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
            {
                message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
            }

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
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

            current += Pad2.Length;

            return FixErrorCode.None;
        }
    }
}