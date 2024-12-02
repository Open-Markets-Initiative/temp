namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Basket Side Alloc Ext Bc Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketSideAllocExtBcGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.BasketSideAllocExtBcGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.AllocQty.FixTag,
                Eurex.EtiDerivatives.v121.SecurityId.FixTag,
                Eurex.EtiDerivatives.v121.LastPx.FixTag,
                Eurex.EtiDerivatives.v121.TransBkdTime.FixTag,
                Eurex.EtiDerivatives.v121.RelatedClosePrice.FixTag,
                Eurex.EtiDerivatives.v121.PackageId.FixTag,
                Eurex.EtiDerivatives.v121.SideMarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v121.AllocId.FixTag,
                Eurex.EtiDerivatives.v121.SideTrdSubTyp.FixTag,
                Eurex.EtiDerivatives.v121.PartySubIdType.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.PositionEffect.FixTag,
                Eurex.EtiDerivatives.v121.EffectOnBasket.FixTag,
                Eurex.EtiDerivatives.v121.TradingCapacity.FixTag,
                Eurex.EtiDerivatives.v121.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v121.ProductComplex.FixTag,
                Eurex.EtiDerivatives.v121.TradePublishIndicator.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.Account.FixTag,
                Eurex.EtiDerivatives.v121.FreeText1.FixTag,
                Eurex.EtiDerivatives.v121.FreeText2.FixTag,
                Eurex.EtiDerivatives.v121.FreeText3.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdTakeUpTradingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdOrderOriginationFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdBeneficiary.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdPositionAccount.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdLocationId.FixTag,
                Eurex.EtiDerivatives.v121.CustOrderHandlingInst.FixTag,
                Eurex.EtiDerivatives.v121.ComplianceText.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
            }
        };
    }
}