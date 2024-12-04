namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Quote Leg Exec Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteLegExecGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.QuoteLegExecGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v130.LegLastPx.FixTag,
                Eurex.EtiDerivatives.v130.LegLastQty.FixTag,
                Eurex.EtiDerivatives.v130.LegExecId.FixTag,
                Eurex.EtiDerivatives.v130.LegSide.FixTag,
                Eurex.EtiDerivatives.v130.NoQuoteEventsIndex.FixTag,
                Eurex.EtiDerivatives.v130.Pad2.FixTag,
            }
        };
    }
}