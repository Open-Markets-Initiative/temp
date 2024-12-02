namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Quote Event Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuoteEventGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.QuoteEventGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.SecurityId.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventPx.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventQty.FixTag,
                Eurex.EtiDerivatives.v121.QuoteMsgId.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventMatchId.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventExecId.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventType.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventSide.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventLiquidityInd.FixTag,
                Eurex.EtiDerivatives.v121.QuoteEventReason.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
            }
        };
    }
}