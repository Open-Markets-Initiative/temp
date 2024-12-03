using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Basket Approve Broadcast Message Methods
    /// </summary>

    public partial class BasketApproveBroadcast
    {
        /// <summary>
        ///  Eti Identifier for Basket Approve Broadcast
        /// </summary>
        public const string Identifier = "Basket Approve Broadcast";

        /// <summary>
        ///  Encode Basket Approve Broadcast Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.BasketApproveBroadcast, out current);

            // --- encode basket approve broadcast message ---

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

            var basketTrdMatchId = message.GetULong(BasketTrdMatchId.FixTag);
            BasketTrdMatchId.Encode(pointer, current, basketTrdMatchId, out current);

            var transactTime = message.GetULong(TransactTime.FixTag);
            TransactTime.Encode(pointer, current, transactTime, out current);

            var basketExecId = (uint)message.GetInt(BasketExecId.FixTag);
            BasketExecId.Encode(pointer, current, basketExecId, out current);

            var marketSegmentId = message.GetInt(MarketSegmentId.FixTag);
            MarketSegmentId.Encode(pointer, current, marketSegmentId, out current);

            var basketProfileId = (uint)message.GetInt(BasketProfileId.FixTag);
            BasketProfileId.Encode(pointer, current, basketProfileId, out current);

            var trdType = (ushort)message.GetInt(TrdType.FixTag);
            TrdType.Encode(pointer, current, trdType, out current);

            var noBasketSideAlloc = (ushort)message.GetInt(NoBasketSideAlloc.FixTag);
            NoBasketSideAlloc.Encode(pointer, current, noBasketSideAlloc, out current);

            var tradeReportType = (byte)message.GetInt(TradeReportType.FixTag);
            TradeReportType.Encode(pointer, current, tradeReportType, out current);

            var basketTradeReportType = (byte)message.GetInt(BasketTradeReportType.FixTag);
            BasketTradeReportType.Encode(pointer, current, basketTradeReportType, out current);

            var messageEventSource = message.GetToken(MessageEventSource.FixTag);
            MessageEventSource.Encode(pointer, current, messageEventSource, out current);

            var noBasketRootPartyGrps = (byte)message.GetInt(NoBasketRootPartyGrps.FixTag);
            NoBasketRootPartyGrps.Encode(pointer, current, noBasketRootPartyGrps, out current);

            var partyIdEnteringFirm = (byte)message.GetInt(PartyIdEnteringFirm.FixTag);
            PartyIdEnteringFirm.Encode(pointer, current, partyIdEnteringFirm, out current);

            if (message.TryGetString(PartyEnteringTrader.FixTag, out var partyEnteringTrader))
            {
                PartyEnteringTrader.Encode(pointer, current, partyEnteringTrader, out current);
            }
            else
            {
                PartyEnteringTrader.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(BasketTradeReportText.FixTag, out var basketTradeReportText))
            {
                BasketTradeReportText.Encode(pointer, current, basketTradeReportText, out current);
            }
            else
            {
                BasketTradeReportText.SetNull(pointer, current, out current);
            }

            if (message.TryGetString(TradeReportId.FixTag, out var tradeReportId))
            {
                TradeReportId.Encode(pointer, current, tradeReportId, out current);
            }
            else
            {
                TradeReportId.SetNull(pointer, current, out current);
            }

            Pad5.Encode(pointer, current, out current);

            var rootPartySubIdType = (ushort)group.GetInt(RootPartySubIdType.FixTag);
            RootPartySubIdType.Encode(pointer, current, rootPartySubIdType, out current);

            if (group.TryGetString(RootPartyContraFirm.FixTag, out var rootPartyContraFirm))
            {
                RootPartyContraFirm.Encode(pointer, current, rootPartyContraFirm, out current);
            }
            else
            {
                RootPartyContraFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(RootPartyContraTrader.FixTag, out var rootPartyContraTrader))
            {
                RootPartyContraTrader.Encode(pointer, current, rootPartyContraTrader, out current);
            }
            else
            {
                RootPartyContraTrader.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(BasketSideTradeReportId.FixTag, out var basketSideTradeReportId))
            {
                BasketSideTradeReportId.Encode(pointer, current, basketSideTradeReportId, out current);
            }
            else
            {
                BasketSideTradeReportId.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

            var allocQty = group.GetDouble(AllocQty.FixTag);
            AllocQty.Encode(pointer, current, allocQty, out current);

            var securityId = group.GetLong(SecurityId.FixTag);
            SecurityId.Encode(pointer, current, securityId, out current);

            var lastPx = group.GetDouble(LastPx.FixTag);
            LastPx.Encode(pointer, current, lastPx, out current);

            var transBkdTime = group.GetULong(TransBkdTime.FixTag);
            TransBkdTime.Encode(pointer, current, transBkdTime, out current);

            var relatedClosePrice = group.GetDouble(RelatedClosePrice.FixTag);
            RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);

            var packageId = (uint)group.GetInt(PackageId.FixTag);
            PackageId.Encode(pointer, current, packageId, out current);

            var sideMarketSegmentId = group.GetInt(SideMarketSegmentId.FixTag);
            SideMarketSegmentId.Encode(pointer, current, sideMarketSegmentId, out current);

            var allocId = (uint)group.GetInt(AllocId.FixTag);
            AllocId.Encode(pointer, current, allocId, out current);

            var sideTrdSubTyp = (ushort)group.GetInt(SideTrdSubTyp.FixTag);
            SideTrdSubTyp.Encode(pointer, current, sideTrdSubTyp, out current);

            var partySubIdType = (ushort)group.GetInt(PartySubIdType.FixTag);
            PartySubIdType.Encode(pointer, current, partySubIdType, out current);

            var side = (byte)group.GetInt(Side.FixTag);
            Side.Encode(pointer, current, side, out current);

            var positionEffect = group.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            var effectOnBasket = (byte)group.GetInt(EffectOnBasket.FixTag);
            EffectOnBasket.Encode(pointer, current, effectOnBasket, out current);

            var tradingCapacity = (byte)group.GetInt(TradingCapacity.FixTag);
            TradingCapacity.Encode(pointer, current, tradingCapacity, out current);

            var tradeAllocStatus = (byte)group.GetInt(TradeAllocStatus.FixTag);
            TradeAllocStatus.Encode(pointer, current, tradeAllocStatus, out current);

            var productComplex = (byte)group.GetInt(ProductComplex.FixTag);
            ProductComplex.Encode(pointer, current, productComplex, out current);

            var tradePublishIndicator = (byte)group.GetInt(TradePublishIndicator.FixTag);
            TradePublishIndicator.Encode(pointer, current, tradePublishIndicator, out current);

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

            if (group.TryGetString(Account.FixTag, out var account))
            {
                Account.Encode(pointer, current, account, out current);
            }
            else
            {
                Account.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText1.FixTag, out var freeText1))
            {
                FreeText1.Encode(pointer, current, freeText1, out current);
            }
            else
            {
                FreeText1.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText2.FixTag, out var freeText2))
            {
                FreeText2.Encode(pointer, current, freeText2, out current);
            }
            else
            {
                FreeText2.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText3.FixTag, out var freeText3))
            {
                FreeText3.Encode(pointer, current, freeText3, out current);
            }
            else
            {
                FreeText3.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
            {
                PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
            }
            else
            {
                PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
            {
                PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
            }
            else
            {
                PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
            {
                PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
            }
            else
            {
                PartyIdBeneficiary.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdPositionAccount.FixTag, out var partyIdPositionAccount))
            {
                PartyIdPositionAccount.Encode(pointer, current, partyIdPositionAccount, out current);
            }
            else
            {
                PartyIdPositionAccount.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdLocationId.FixTag, out var partyIdLocationId))
            {
                PartyIdLocationId.Encode(pointer, current, partyIdLocationId, out current);
            }
            else
            {
                PartyIdLocationId.SetNull(pointer, current, out current);
            }

            var custOrderHandlingInst = group.GetToken(CustOrderHandlingInst.FixTag);
            CustOrderHandlingInst.Encode(pointer, current, custOrderHandlingInst, out current);

            if (group.TryGetString(ComplianceText.FixTag, out var complianceText))
            {
                ComplianceText.Encode(pointer, current, complianceText, out current);
            }
            else
            {
                ComplianceText.SetNull(pointer, current, out current);
            }

            Pad4.Encode(pointer, current, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Basket Approve Broadcast Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = BasketApproveBroadcast.Identifier;

            // --- decode basket approve broadcast message ---

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

            var basketTrdMatchId = BasketTrdMatchId.Decode(pointer, current, out current);
            message.AppendULong(BasketTrdMatchId.FixTag, basketTrdMatchId);

            var transactTime = TransactTime.Decode(pointer, current, out current);
            message.AppendULong(TransactTime.FixTag, transactTime);

            var basketExecId = (int)BasketExecId.Decode(pointer, current, out current);
            message.AppendInt(BasketExecId.FixTag, basketExecId);

            var marketSegmentId = MarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(MarketSegmentId.FixTag, marketSegmentId);

            var basketProfileId = (int)BasketProfileId.Decode(pointer, current, out current);
            message.AppendInt(BasketProfileId.FixTag, basketProfileId);

            var trdType = (short)TrdType.Decode(pointer, current, out current);
            message.AppendInt(TrdType.FixTag, trdType);

            var noBasketSideAlloc = (short)NoBasketSideAlloc.Decode(pointer, current, out current);
            message.AppendInt(NoBasketSideAlloc.FixTag, noBasketSideAlloc);

            var tradeReportType = TradeReportType.Decode(pointer, current, out current);
            message.AppendInt(TradeReportType.FixTag, tradeReportType);

            var basketTradeReportType = BasketTradeReportType.Decode(pointer, current, out current);
            message.AppendInt(BasketTradeReportType.FixTag, basketTradeReportType);

            var messageEventSource = MessageEventSource.Decode(pointer, current, out current);
            message.AppendToken(MessageEventSource.FixTag, messageEventSource);

            var noBasketRootPartyGrps = NoBasketRootPartyGrps.Decode(pointer, current, out current);
            message.AppendInt(NoBasketRootPartyGrps.FixTag, noBasketRootPartyGrps);

            var partyIdEnteringFirm = PartyIdEnteringFirm.Decode(pointer, current, out current);
            message.AppendInt(PartyIdEnteringFirm.FixTag, partyIdEnteringFirm);

            if (PartyEnteringTrader.TryDecode(pointer, current, out var partyEnteringTrader, out current))
            {
                message.AppendString(PartyEnteringTrader.FixTag, partyEnteringTrader);
            }

            if (BasketTradeReportText.TryDecode(pointer, current, out var basketTradeReportText, out current))
            {
                message.AppendString(BasketTradeReportText.FixTag, basketTradeReportText);
            }

            if (TradeReportId.TryDecode(pointer, current, out var tradeReportId, out current))
            {
                message.AppendString(TradeReportId.FixTag, tradeReportId);
            }

            current += Pad5.Length;

            var rootPartySubIdType = (short)RootPartySubIdType.Decode(pointer, current, out current);
            message.AppendInt(RootPartySubIdType.FixTag, rootPartySubIdType);

            if (RootPartyContraFirm.TryDecode(pointer, current, out var rootPartyContraFirm, out current))
            {
                message.AppendString(RootPartyContraFirm.FixTag, rootPartyContraFirm);
            }

            if (RootPartyContraTrader.TryDecode(pointer, current, out var rootPartyContraTrader, out current))
            {
                message.AppendString(RootPartyContraTrader.FixTag, rootPartyContraTrader);
            }

            if (BasketSideTradeReportId.TryDecode(pointer, current, out var basketSideTradeReportId, out current))
            {
                message.AppendString(BasketSideTradeReportId.FixTag, basketSideTradeReportId);
            }

            current += Pad7.Length;

            var allocQty = AllocQty.Decode(pointer, current, out current);
            message.AppendDouble(AllocQty.FixTag, allocQty);

            var securityId = SecurityId.Decode(pointer, current, out current);
            message.AppendLong(SecurityId.FixTag, securityId);

            var lastPx = LastPx.Decode(pointer, current, out current);
            message.AppendDouble(LastPx.FixTag, lastPx);

            var transBkdTime = TransBkdTime.Decode(pointer, current, out current);
            message.AppendULong(TransBkdTime.FixTag, transBkdTime);

            var relatedClosePrice = RelatedClosePrice.Decode(pointer, current, out current);
            message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);

            var packageId = (int)PackageId.Decode(pointer, current, out current);
            message.AppendInt(PackageId.FixTag, packageId);

            var sideMarketSegmentId = SideMarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(SideMarketSegmentId.FixTag, sideMarketSegmentId);

            var allocId = (int)AllocId.Decode(pointer, current, out current);
            message.AppendInt(AllocId.FixTag, allocId);

            var sideTrdSubTyp = (short)SideTrdSubTyp.Decode(pointer, current, out current);
            message.AppendInt(SideTrdSubTyp.FixTag, sideTrdSubTyp);

            var partySubIdType = (short)PartySubIdType.Decode(pointer, current, out current);
            message.AppendInt(PartySubIdType.FixTag, partySubIdType);

            var side = Side.Decode(pointer, current, out current);
            message.AppendInt(Side.FixTag, side);

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            var effectOnBasket = EffectOnBasket.Decode(pointer, current, out current);
            message.AppendInt(EffectOnBasket.FixTag, effectOnBasket);

            var tradingCapacity = TradingCapacity.Decode(pointer, current, out current);
            message.AppendInt(TradingCapacity.FixTag, tradingCapacity);

            var tradeAllocStatus = TradeAllocStatus.Decode(pointer, current, out current);
            message.AppendInt(TradeAllocStatus.FixTag, tradeAllocStatus);

            var productComplex = ProductComplex.Decode(pointer, current, out current);
            message.AppendInt(ProductComplex.FixTag, productComplex);

            var tradePublishIndicator = TradePublishIndicator.Decode(pointer, current, out current);
            message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);

            if (PartyExecutingFirm.TryDecode(pointer, current, out var partyExecutingFirm, out current))
            {
                message.AppendString(PartyExecutingFirm.FixTag, partyExecutingFirm);
            }

            if (PartyExecutingTrader.TryDecode(pointer, current, out var partyExecutingTrader, out current))
            {
                message.AppendString(PartyExecutingTrader.FixTag, partyExecutingTrader);
            }

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
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

            if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
            {
                message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
            }

            if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
            {
                message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
            }

            if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
            {
                message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
            }

            if (PartyIdPositionAccount.TryDecode(pointer, current, out var partyIdPositionAccount, out current))
            {
                message.AppendString(PartyIdPositionAccount.FixTag, partyIdPositionAccount);
            }

            if (PartyIdLocationId.TryDecode(pointer, current, out var partyIdLocationId, out current))
            {
                message.AppendString(PartyIdLocationId.FixTag, partyIdLocationId);
            }

            var custOrderHandlingInst = CustOrderHandlingInst.Decode(pointer, current, out current);
            message.AppendToken(CustOrderHandlingInst.FixTag, custOrderHandlingInst);

            if (ComplianceText.TryDecode(pointer, current, out var complianceText, out current))
            {
                message.AppendString(ComplianceText.FixTag, complianceText);
            }

            current += Pad4.Length;

            return FixErrorCode.None;
        }
    }
}