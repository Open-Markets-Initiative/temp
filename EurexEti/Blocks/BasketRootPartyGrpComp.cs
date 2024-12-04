namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Basket Root Party Grp Comp
        /// </summary>
        public static readonly FixComponentBlock BasketRootPartyGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.BasketRootPartyGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.RootPartySubIdType.FixTag,
                Eurex.EtiDerivatives.v130.RootPartyContraFirm.FixTag,
                Eurex.EtiDerivatives.v130.RootPartyContraTrader.FixTag,
                Eurex.EtiDerivatives.v130.BasketSideTradeReportId.FixTag,
                Eurex.EtiDerivatives.v130.Pad7.FixTag,
            }
        };
    }
}