namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Basket Side Alloc Ext Bc Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketSideAllocExtBcGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.BasketSideAllocExtBcGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.AllocQty.FixTag,
                Eurex.EtiDerivatives.v130.SecurityId.FixTag,
                Eurex.EtiDerivatives.v130.LastPx.FixTag,
                Eurex.EtiDerivatives.v130.TransBkdTime.FixTag,
                Eurex.EtiDerivatives.v130.RelatedClosePrice.FixTag,
                Eurex.EtiDerivatives.v130.PackageId.FixTag,
                Eurex.EtiDerivatives.v130.SideMarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v130.AllocId.FixTag,
                Eurex.EtiDerivatives.v130.SideTrdSubTyp.FixTag,
                Eurex.EtiDerivatives.v130.PartySubIdType.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.PositionEffect.FixTag,
                Eurex.EtiDerivatives.v130.EffectOnBasket.FixTag,
                Eurex.EtiDerivatives.v130.TradingCapacity.FixTag,
                Eurex.EtiDerivatives.v130.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v130.ProductComplex.FixTag,
                Eurex.EtiDerivatives.v130.TradePublishIndicator.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.Account.FixTag,
                Eurex.EtiDerivatives.v130.FreeText1.FixTag,
                Eurex.EtiDerivatives.v130.FreeText2.FixTag,
                Eurex.EtiDerivatives.v130.FreeText3.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdTakeUpTradingFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdOrderOriginationFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdBeneficiary.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdPositionAccount.FixTag,
                Eurex.EtiDerivatives.v130.PartyIdLocationId.FixTag,
                Eurex.EtiDerivatives.v130.CustOrderHandlingInst.FixTag,
                Eurex.EtiDerivatives.v130.ComplianceText.FixTag,
                Eurex.EtiDerivatives.v130.Pad4.FixTag,
            }
        };
    }
}