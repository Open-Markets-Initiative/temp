namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Basket Exec Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketExecGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.BasketExecGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.PackageId.FixTag,
                Eurex.EtiDerivatives.v130.SideMarketSegmentId.FixTag,
                Eurex.EtiDerivatives.v130.AllocId.FixTag,
                Eurex.EtiDerivatives.v130.SideTrdSubTyp.FixTag,
                Eurex.EtiDerivatives.v130.Pad2.FixTag,
            }
        };
    }
}