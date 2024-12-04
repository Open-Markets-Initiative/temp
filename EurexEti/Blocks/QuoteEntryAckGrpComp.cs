namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Quote Entry Ack Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteEntryAckGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.QuoteEntryAckGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.SecurityId.FixTag,
                Eurex.EtiDerivatives.v130.CxlSize.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEntryRejectReason.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEntryStatus.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.Pad2.FixTag,
            }
        };
    }
}