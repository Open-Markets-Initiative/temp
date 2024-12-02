namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Instrmt Match Side Grp Comp
        /// </summary>
        public static readonly FixComponentBlock InstrmtMatchSideGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.InstrmtMatchSideGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.SecurityId.FixTag,
                Eurex.EtiDerivatives.v121.LastPx.FixTag,
                Eurex.EtiDerivatives.v121.TransBkdTime.FixTag,
                Eurex.EtiDerivatives.v121.RelatedClosePrice.FixTag,
                Eurex.EtiDerivatives.v121.ClearingTradePrice.FixTag,
                Eurex.EtiDerivatives.v121.PackageId.FixTag,
                Eurex.EtiDerivatives.v121.SideMarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v121.SideTrdSubTyp.FixTag,
                Eurex.EtiDerivatives.v121.ProductComplex.FixTag,
                Eurex.EtiDerivatives.v121.TradePublishIndicator.FixTag,
                Eurex.EtiDerivatives.v121.InstrmtMatchSideId.FixTag,
                Eurex.EtiDerivatives.v121.EffectOnBasket.FixTag,
                Eurex.EtiDerivatives.v121.TradeReportText.FixTag,
                Eurex.EtiDerivatives.v121.Pad6.FixTag,
            }
        };
    }
}