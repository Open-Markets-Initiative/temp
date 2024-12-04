namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Risk Limit Qty Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RiskLimitQtyGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.RiskLimitQtyGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.RiskLimitQty.FixTag,
                Eurex.EtiDerivatives.v130.RiskLimitType.FixTag,
                Eurex.EtiDerivatives.v130.Pad7.FixTag,
            }
        };
    }
}