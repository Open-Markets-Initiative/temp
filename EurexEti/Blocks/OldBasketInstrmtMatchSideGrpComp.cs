namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Old Basket Instrmt Match Side Grp Comp
        /// </summary>
        public static readonly FixComponentBlock OldBasketInstrmtMatchSideGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.OldBasketInstrmtMatchSideGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.SecurityId.FixTag,
                Eurex.EtiDerivatives.v130.LastPx.FixTag,
                Eurex.EtiDerivatives.v130.TransBkdTime.FixTag,
                Eurex.EtiDerivatives.v130.RelatedClosePrice.FixTag,
                Eurex.EtiDerivatives.v130.ClearingTradePrice.FixTag,
                Eurex.EtiDerivatives.v130.PackageId.FixTag,
                Eurex.EtiDerivatives.v130.SideMarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v130.SideTrdSubTyp.FixTag,
                Eurex.EtiDerivatives.v130.ProductComplex.FixTag,
                Eurex.EtiDerivatives.v130.TradePublishIndicator.FixTag,
                Eurex.EtiDerivatives.v130.InstrmtMatchSideId.FixTag,
                Eurex.EtiDerivatives.v130.EffectOnBasket.FixTag,
                Eurex.EtiDerivatives.v130.TradeReportText.FixTag,
                Eurex.EtiDerivatives.v130.Pad6.FixTag,
            }
        };
    }
}