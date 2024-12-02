namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Cross Request Side Grp Comp
        /// </summary>
        public static readonly FixComponentBlock CrossRequestSideGrpComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.CrossRequestSideGrpComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.PartyIdClientId.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdInvestmentDecisionMaker.FixTag,
                Eurex.EtiDerivatives.v121.ExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.MaximumPrice.FixTag,
                Eurex.EtiDerivatives.v121.MatchInstCrossId.FixTag,
                Eurex.EtiDerivatives.v121.InputSource.FixTag,
                Eurex.EtiDerivatives.v121.Side.FixTag,
                Eurex.EtiDerivatives.v121.SelfMatchPreventionInstruction.FixTag,
                Eurex.EtiDerivatives.v121.TradingCapacity.FixTag,
                Eurex.EtiDerivatives.v121.ExecutingTraderQualifier.FixTag,
                Eurex.EtiDerivatives.v121.OrderAttributeLiquidityProvision.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdInvestmentDecisionMakerQualifier.FixTag,
                Eurex.EtiDerivatives.v121.OrderAttributeRiskReduction.FixTag,
                Eurex.EtiDerivatives.v121.OrderOrigination.FixTag,
                Eurex.EtiDerivatives.v121.PositionEffect.FixTag,
                Eurex.EtiDerivatives.v121.CustOrderHandlingInst.FixTag,
                Eurex.EtiDerivatives.v121.Account.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdPositionAccount.FixTag,
                Eurex.EtiDerivatives.v121.FreeText1.FixTag,
                Eurex.EtiDerivatives.v121.FreeText2.FixTag,
                Eurex.EtiDerivatives.v121.FreeText3.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdOrderOriginationFirm.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdBeneficiary.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdTakeUpTradingFirm.FixTag,
                Eurex.EtiDerivatives.v121.SideComplianceText.FixTag,
                Eurex.EtiDerivatives.v121.PartyIdLocationId.FixTag,
                Eurex.EtiDerivatives.v121.PartyEndClientIdentification.FixTag,
                Eurex.EtiDerivatives.v121.Pad4.FixTag,
            }
        };
    }
}