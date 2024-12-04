namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Quot Req Legs Grp Comp
        /// </summary>
        public static readonly FixComponentBlock QuotReqLegsGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.QuotReqLegsGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.LegSecurityId.FixTag,
                Eurex.EtiDerivatives.v130.LegRatioQty.FixTag,
                Eurex.EtiDerivatives.v130.LegSymbol.FixTag,
                Eurex.EtiDerivatives.v130.LegSecurityType.FixTag,
                Eurex.EtiDerivatives.v130.LegSide.FixTag,
                Eurex.EtiDerivatives.v130.Pad6.FixTag,
            }
        };
    }
}