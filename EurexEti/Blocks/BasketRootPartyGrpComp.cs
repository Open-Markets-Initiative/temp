namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Basket Root Party Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketRootPartyGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.BasketRootPartyGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.RootPartySubIdType.FixTag,
                Eurex.EtiDerivatives.v121.RootPartyContraFirm.FixTag,
                Eurex.EtiDerivatives.v121.RootPartyContraTrader.FixTag,
                Eurex.EtiDerivatives.v121.BasketSideTradeReportId.FixTag,
                Eurex.EtiDerivatives.v121.Pad7.FixTag,
            }
        };
    }
}