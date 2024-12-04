namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Fills Grp Comp
        /// </summary>
        public static readonly FixComponentBlock FillsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.FillsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.FillPx.FixTag,
                Eurex.EtiDerivatives.v130.FillQty.FixTag,
                Eurex.EtiDerivatives.v130.FillMatchId.FixTag,
                Eurex.EtiDerivatives.v130.FillExecId.FixTag,
                Eurex.EtiDerivatives.v130.FillLiquidityInd.FixTag,
                Eurex.EtiDerivatives.v130.Pad7.FixTag,
            }
        };
    }
}