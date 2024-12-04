namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Quote Event Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteEventGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.QuoteEventGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.SecurityId.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventPx.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventQty.FixTag,
                Eurex.EtiDerivatives.v130.QuoteMsgId.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventMatchId.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventExecId.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventType.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventSide.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventLiquidityInd.FixTag,
                Eurex.EtiDerivatives.v130.QuoteEventReason.FixTag,
                Eurex.EtiDerivatives.v130.Pad4.FixTag,
            }
        };
    }
}