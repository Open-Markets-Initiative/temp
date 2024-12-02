namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Srqs Quote Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsQuoteGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.SrqsQuoteGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.QuoteId.FixTag,
            }
        };
    }
}