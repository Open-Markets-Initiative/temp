namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Quote Entry Ack Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteEntryAckGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.QuoteEntryAckGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.SecurityId.FixTag,
                Eurex.EtiDerivatives.v121.CxlSize.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEntryRejectReason.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEntryStatus.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.Pad2.FixTag,
            }
        };
    }
}