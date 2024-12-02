namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Trd Instrmnt Leg Grp Comp
        /// </summary>
        public static readonly FixComponentBlock TrdInstrmntLegGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.TrdInstrmntLegGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v121.LegPrice.FixTag,
                Eurex.EtiDerivatives.v121.LegQty.FixTag,
            }
        };
    }
}