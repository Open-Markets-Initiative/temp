namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Order Event Grp Comp
        /// </summary>
        public static readonly FixComponentBlock OrderEventGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.OrderEventGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.OrderEventPx.FixTag,
                Eurex.EtiDerivatives.v121.OrderEventQty.FixTag,
                Eurex.EtiDerivatives.v121.OrderEventMatchId.FixTag,
                Eurex.EtiDerivatives.v121.OrderEventReason.FixTag,
                Eurex.EtiDerivatives.v121.Pad3.FixTag,
            }
        };
    }
}