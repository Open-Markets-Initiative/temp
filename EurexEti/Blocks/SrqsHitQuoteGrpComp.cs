namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Srqs Hit Quote Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsHitQuoteGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SrqsHitQuoteGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.OrderQty.FixTag,
                Eurex.EtiDerivatives.v130.QuoteId.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.Pad7.FixTag,
            }
        };
    }
}