namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Quote Leg Exec Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteLegExecGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.QuoteLegExecGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v121.LegLastPx.FixTag,
                Eurex.EtiDerivatives.v121.LegLastQty.FixTag,
                Eurex.EtiDerivatives.v121.LegExecId.FixTag,
                Eurex.EtiDerivatives.v121.LegSide.FixTag,
                Eurex.EtiDerivatives.v121.NoQuoteEventsIndex.FixTag,
                Eurex.EtiDerivatives.v121.Pad2.FixTag,
            }
        };
    }
}