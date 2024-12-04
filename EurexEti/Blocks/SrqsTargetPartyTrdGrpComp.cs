namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Srqs Target Party Trd Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsTargetPartyTrdGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SrqsTargetPartyTrdGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.SideLastQty.FixTag,
                Eurex.EtiDerivatives.v130.QuoteId.FixTag,
                Eurex.EtiDerivatives.v130.TargetPartyIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.TargetPartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v130.TargetPartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.TargetPartyEnteringTrader.FixTag,
                Eurex.EtiDerivatives.v130.Pad3.FixTag,
            }
        };
    }
}