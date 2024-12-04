namespace SRFixBase
{
    public static partial class FixComponentBlocks
    {
        /// <summary>
        ///  Eurex Derivatives Eti T7 v13 0 Target Parties Comp
        /// </summary>
        public static readonly FixComponentBlock TargetPartiesComp = new FixComponentBlock
        {
            Tag = Eurex.EtiDerivatives.v130.TargetPartiesComp.FixTag,

            Tags = new ushort []
            {
                Eurex.EtiDerivatives.v130.TargetPartyIdExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.SideDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.PriceDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.LeavesQtyDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.LastPxDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.LastQtyDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.FreeText5DisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.PartyOrderOriginationDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.QuoteInstruction.FixTag,
                Eurex.EtiDerivatives.v130.ChargeIdDisclosureInstruction.FixTag,
                Eurex.EtiDerivatives.v130.TargetPartyExecutingFirm.FixTag,
                Eurex.EtiDerivatives.v130.TargetPartyExecutingTrader.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailStatus.FixTag,
                Eurex.EtiDerivatives.v130.PartyDetailStatusInformation.FixTag,
                Eurex.EtiDerivatives.v130.Pad6.FixTag,
            }
        };
    }
}