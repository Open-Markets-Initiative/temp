namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Affected Order Requests Grp Comp
        /// </summary>
        public static readonly FixComponentBlock AffectedOrderRequestsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.AffectedOrderRequestsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.AffectedOrderRequestId.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
            }
        };
    }
}