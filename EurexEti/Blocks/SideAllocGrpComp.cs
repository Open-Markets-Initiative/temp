namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Side Alloc Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SideAllocGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SideAllocGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.AllocQty.FixTag,
                Eurex.EtiDerivatives.v121.IndividualAllocId.FixTag,
                Eurex.EtiDerivatives.v121.TesEnrichmentRuleId.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
            }
        };
    }
}