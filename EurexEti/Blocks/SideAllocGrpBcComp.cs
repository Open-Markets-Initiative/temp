namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Side Alloc Grp Bc Comp
        /// </summary>
        public static readonly FixComponentBlock SideAllocGrpBcComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SideAllocGrpBcComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.AllocQty.FixTag,
                Eurex.EtiDerivatives.v121.ReversalApprovalTime.FixTag,
                Eurex.EtiDerivatives.v121.IndividualAllocId.FixTag,
                Eurex.EtiDerivatives.v121.TesEnrichmentRuleId.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v121.Pad3.FixTag,
            }
        };
    }
}