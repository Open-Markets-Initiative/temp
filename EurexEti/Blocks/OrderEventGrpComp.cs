namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Order Event Grp Comp
        /// </summary>
        public static readonly FixComponentBlock OrderEventGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.OrderEventGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.OrderEventPx.FixTag,
                Eurex.EtiDerivatives.v130.OrderEventQty.FixTag,
                Eurex.EtiDerivatives.v130.OrderEventMatchId.FixTag,
                Eurex.EtiDerivatives.v130.OrderEventReason.FixTag,
                Eurex.EtiDerivatives.v130.Pad3.FixTag,
            }
        };
    }
}