namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Basket Exec Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketExecGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.BasketExecGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.PackageId.FixTag,
                Eurex.EtiDerivatives.v121.SideMarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v121.AllocId.FixTag,
                Eurex.EtiDerivatives.v121.SideTrdSubTyp.FixTag,
                Eurex.EtiDerivatives.v121.Pad2.FixTag,
            }
        };
    }
}