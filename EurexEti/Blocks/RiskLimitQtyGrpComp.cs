namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Risk Limit Qty Grp Comp
        /// </summary>
        public static readonly FixComponentBlock RiskLimitQtyGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.RiskLimitQtyGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.RiskLimitQty.FixTag,
                Eurex.EtiDerivatives.v121.RiskLimitType.FixTag,
                Eurex.EtiDerivatives.v121.Pad7.FixTag,
            }
        };
    }
}