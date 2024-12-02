namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Basket Side Alloc Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketSideAllocGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.BasketSideAllocGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.AllocQty.FixTag,
                Eurex.EtiDerivatives.v121.IndividualAllocId.FixTag,
                Eurex.EtiDerivatives.v121.PartySubIdType.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.InstrmtMatchSideId.FixTag,
                Eurex.EtiDerivatives.v121.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
            }
        };
    }
}