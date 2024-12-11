using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Side Alloc Ext Bc Grp Comp Message Methods
    /// </summary>

    public static partial class BasketSideAllocExtBcGrpComp
    {
        /// <summary>
        ///  Fix Tag for Basket Side Alloc Ext Bc Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39103;

        /// <summary>
        ///  Encode Basket Side Alloc Ext Bc Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup basketSideAllocExtBcGrpComp, out int current)
        {
            current = offset;

            foreach (var group in basketSideAllocExtBcGrpComp.sectionList)
            {
                if (group.TryGetDouble(AllocQty.FixTag, out var allocQty))
                {
                    AllocQty.Encode(pointer, current, allocQty, out current);
                }
                else
                {
                    AllocQty.SetNull(pointer, current, out current);
                }

                if (group.TryGetLong(SecurityId.FixTag, out var securityId))
                {
                    SecurityId.Encode(pointer, current, securityId, out current);
                }
                else
                {
                    SecurityId.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(LastPx.FixTag, out var lastPx))
                {
                    LastPx.Encode(pointer, current, lastPx, out current);
                }
                else
                {
                    LastPx.SetNull(pointer, current, out current);
                }

                if (group.TryGetULong(TransBkdTime.FixTag, out var transBkdTime))
                {
                    TransBkdTime.Encode(pointer, current, transBkdTime, out current);
                }
                else
                {
                    TransBkdTime.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(RelatedClosePrice.FixTag, out var relatedClosePrice))
                {
                    RelatedClosePrice.Encode(pointer, current, relatedClosePrice, out current);
                }
                else
                {
                    RelatedClosePrice.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(PackageId.FixTag, out var packageId))
                {
                    PackageId.Encode(pointer, current, (uint)packageId, out current);
                }
                else
                {
                    PackageId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(SideMarketSegmentId.FixTag, out var sideMarketSegmentId))
                {
                    SideMarketSegmentId.Encode(pointer, current, sideMarketSegmentId, out current);
                }
                else
                {
                    SideMarketSegmentId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(AllocId.FixTag, out var allocId))
                {
                    AllocId.Encode(pointer, current, (uint)allocId, out current);
                }
                else
                {
                    AllocId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(SideTrdSubTyp.FixTag, out var sideTrdSubTyp))
                {
                    SideTrdSubTyp.Encode(pointer, current, (ushort)sideTrdSubTyp, out current);
                }
                else
                {
                    SideTrdSubTyp.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(PartySubIdType.FixTag, out var partySubIdType))
                {
                    PartySubIdType.Encode(pointer, current, (ushort)partySubIdType, out current);
                }
                else
                {
                    PartySubIdType.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(Side.FixTag, out var side))
                {
                    Side.Encode(pointer, current, (byte)side, out current);
                }
                else
                {
                    Side.SetNull(pointer, current, out current);
                }

                var positionEffect = group.GetToken(PositionEffect.FixTag);
                PositionEffect.Encode(pointer, current, positionEffect, out current);

                if (group.TryGetInt(EffectOnBasket.FixTag, out var effectOnBasket))
                {
                    EffectOnBasket.Encode(pointer, current, (byte)effectOnBasket, out current);
                }
                else
                {
                    EffectOnBasket.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(TradingCapacity.FixTag, out var tradingCapacity))
                {
                    TradingCapacity.Encode(pointer, current, (byte)tradingCapacity, out current);
                }
                else
                {
                    TradingCapacity.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(TradeAllocStatus.FixTag, out var tradeAllocStatus))
                {
                    TradeAllocStatus.Encode(pointer, current, (byte)tradeAllocStatus, out current);
                }
                else
                {
                    TradeAllocStatus.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(ProductComplex.FixTag, out var productComplex))
                {
                    ProductComplex.Encode(pointer, current, (byte)productComplex, out current);
                }
                else
                {
                    ProductComplex.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(TradePublishIndicator.FixTag, out var tradePublishIndicator))
                {
                    TradePublishIndicator.Encode(pointer, current, (byte)tradePublishIndicator, out current);
                }
                else
                {
                    TradePublishIndicator.SetNull(pointer, current, out current);
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

            }
        }

        /// <summary>
        ///  Decode Basket Side Alloc Ext Bc Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoBasketSideAlloc.FixTag, count);

            while (count-- > 0)
            {
                if (AllocQty.TryDecode(pointer, current, out var allocQty, out current))
                {
                    message.AppendDouble(AllocQty.FixTag, allocQty);
                }

                if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
                {
                    message.AppendLong(SecurityId.FixTag, securityId);
                }

                if (LastPx.TryDecode(pointer, current, out var lastPx, out current))
                {
                    message.AppendDouble(LastPx.FixTag, lastPx);
                }

                if (TransBkdTime.TryDecode(pointer, current, out var transBkdTime, out current))
                {
                    message.AppendULong(TransBkdTime.FixTag, transBkdTime);
                }

                if (RelatedClosePrice.TryDecode(pointer, current, out var relatedClosePrice, out current))
                {
                    message.AppendDouble(RelatedClosePrice.FixTag, relatedClosePrice);
                }

                if (PackageId.TryDecode(pointer, current, out var packageId, out current))
                {
                    message.AppendInt(PackageId.FixTag, (int)packageId);
                }

                if (SideMarketSegmentId.TryDecode(pointer, current, out var sideMarketSegmentId, out current))
                {
                    message.AppendInt(SideMarketSegmentId.FixTag, sideMarketSegmentId);
                }

                if (AllocId.TryDecode(pointer, current, out var allocId, out current))
                {
                    message.AppendInt(AllocId.FixTag, (int)allocId);
                }

                if (SideTrdSubTyp.TryDecode(pointer, current, out var sideTrdSubTyp, out current))
                {
                    message.AppendInt(SideTrdSubTyp.FixTag, (short)sideTrdSubTyp);
                }

                if (PartySubIdType.TryDecode(pointer, current, out var partySubIdType, out current))
                {
                    message.AppendInt(PartySubIdType.FixTag, (short)partySubIdType);
                }

                if (Side.TryDecode(pointer, current, out var side, out current))
                {
                    message.AppendInt(Side.FixTag, side);
                }

                var positionEffect = PositionEffect.Decode(pointer, current, out current);
                message.AppendToken(PositionEffect.FixTag, positionEffect);

                if (EffectOnBasket.TryDecode(pointer, current, out var effectOnBasket, out current))
                {
                    message.AppendInt(EffectOnBasket.FixTag, effectOnBasket);
                }

                if (TradingCapacity.TryDecode(pointer, current, out var tradingCapacity, out current))
                {
                    message.AppendInt(TradingCapacity.FixTag, tradingCapacity);
                }

                if (TradeAllocStatus.TryDecode(pointer, current, out var tradeAllocStatus, out current))
                {
                    message.AppendInt(TradeAllocStatus.FixTag, tradeAllocStatus);
                }

                if (ProductComplex.TryDecode(pointer, current, out var productComplex, out current))
                {
                    message.AppendInt(ProductComplex.FixTag, productComplex);
                }

                if (TradePublishIndicator.TryDecode(pointer, current, out var tradePublishIndicator, out current))
                {
                    message.AppendInt(TradePublishIndicator.FixTag, tradePublishIndicator);
                }

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

            }
        }
    }
}