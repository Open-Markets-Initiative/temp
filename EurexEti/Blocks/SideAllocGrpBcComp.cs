namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Side Alloc Grp Bc Comp
        /// </summary>
        public static readonly FixComponentBlock SideAllocGrpBcComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SideAllocGrpBcComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.AllocQty.FixTag,
                Eurex.EtiDerivatives.v130.ReversalApprovalTime.FixTag,
                Eurex.EtiDerivatives.v130.IndividualAllocId.FixTag,
                Eurex.EtiDerivatives.v130.TesEnrichmentRuleId.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v130.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.TradeAllocStatus.FixTag,
                Eurex.EtiDerivatives.v130.Pad3.FixTag,
            }
        };
    }
}