namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v12 1 Target Parties Comp
        /// </summary>
        public static readonly FixComponentBlock TargetPartiesComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v121.TargetPartiesComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v121.TargetPartyIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.SideDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.PriceDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.LeavesQtyDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.LastPxDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.LastQtyDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.FreeText5DisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.PartyOrderOriginationDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.QuoteInstruction.FixTag,
                Eurex.EtiDerivatives.v121.ChargeIdDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v121.TargetPartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v121.TargetPartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailStatus.FixTag,
                Eurex.EtiDerivatives.v121.PartyDetailStatusInformation.FixTag,
                Eurex.EtiDerivatives.v121.Pad6.FixTag,
            }
        };
    }
}