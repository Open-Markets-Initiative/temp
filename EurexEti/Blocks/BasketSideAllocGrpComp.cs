namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Basket Side Alloc Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketSideAllocGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.BasketSideAllocGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.AllocQty.FixTag,
                Eurex.EtiDerivatives.v130.IndividualAllocId.FixTag,
                Eurex.EtiDerivatives.v130.PartySubIdType.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.InstrmtMatchSideId.FixTag,
                Eurex.EtiDerivatives.v130.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.Pad4.FixTag,
            }
        };
    }
}