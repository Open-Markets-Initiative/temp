namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Trd Instrmnt Leg Grp Comp
        /// </summary>
        public static readonly FixComponentBlock TrdInstrmntLegGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.TrdInstrmntLegGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v130.LegPrice.FixTag,
                Eurex.EtiDerivatives.v130.LegQty.FixTag,
            }
        };
    }
}