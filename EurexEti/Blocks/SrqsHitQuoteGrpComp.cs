namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Srqs Hit Quote Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsHitQuoteGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SrqsHitQuoteGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.OrderQty.FixTag,
                Eurex.EtiDerivatives.v121.QuoteId.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.Pad7.FixTag,
            }
        };
    }
}