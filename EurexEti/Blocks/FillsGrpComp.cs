namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Fills Grp Comp
        /// </summary>
        public static readonly FixComponentBlock FillsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.FillsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.FillPx.FixTag,
                Eurex.EtiDerivatives.v121.FillQty.FixTag,
                Eurex.EtiDerivatives.v121.FillMatchId.FixTag,
                Eurex.EtiDerivatives.v121.FillExecId.FixTag,
                Eurex.EtiDerivatives.v121.FillLiquidityInd.FixTag,
                Eurex.EtiDerivatives.v121.Pad7.FixTag,
            }
        };
    }
}