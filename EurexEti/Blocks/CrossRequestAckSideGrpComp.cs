namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Cross Request Ack Side Grp Comp
        /// </summary>
        public static readonly FixComponentBlock CrossRequestAckSideGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.CrossRequestAckSideGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.OrderId.FixTag,
                Eurex.EtiDerivatives.v121.InputSource.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.Pad6.FixTag,
            }
        };
    }
}