namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Cross Request Ack Side Grp Comp
        /// </summary>
        public static readonly FixComponentBlock CrossRequestAckSideGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.CrossRequestAckSideGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.OrderId.FixTag,
                Eurex.EtiDerivatives.v130.InputSource.FixTag,
                Eurex.EtiDerivatives.v130.Side.FixTag,
                Eurex.EtiDerivatives.v130.Pad6.FixTag,
            }
        };
    }
}