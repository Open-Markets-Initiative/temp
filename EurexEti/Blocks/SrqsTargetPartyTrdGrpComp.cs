namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Srqs Target Party Trd Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsTargetPartyTrdGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SrqsTargetPartyTrdGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.SideLastQty.FixTag,
                Eurex.EtiDerivatives.v121.QuoteId.FixTag,
                Eurex.EtiDerivatives.v121.TargetPartyIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.TargetPartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.TargetPartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.TargetPartyEnteringTrader.FixTag,
                Eurex.EtiDerivatives.v121.Pad3.FixTag,
            }
        };
    }
}