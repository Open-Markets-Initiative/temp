namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Affected Order Requests Grp Comp
        /// </summary>
        public static readonly FixComponentBlock AffectedOrderRequestsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.AffectedOrderRequestsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.AffectedOrderRequestId.FixTag,
                Eurex.EtiDerivatives.v130.Pad4.FixTag,
            }
        };
    }
}