namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Srqs Quote Grp Comp
        /// </summary>
        public static readonly FixComponentBlock SrqsQuoteGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.SrqsQuoteGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.QuoteId.FixTag,
            }
        };
    }
}