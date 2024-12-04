namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Instrmnt Leg Exec Grp Comp
        /// </summary>
        public static readonly FixComponentBlock InstrmntLegExecGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.InstrmntLegExecGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v130.LegLastPx.FixTag,
                Eurex.EtiDerivatives.v130.LegLastQty.FixTag,
                Eurex.EtiDerivatives.v130.LegExecId.FixTag,
                Eurex.EtiDerivatives.v130.LegSide.FixTag,
                Eurex.EtiDerivatives.v130.FillRefId.FixTag,
                Eurex.EtiDerivatives.v130.Pad2.FixTag,
            }
        };
    }
}