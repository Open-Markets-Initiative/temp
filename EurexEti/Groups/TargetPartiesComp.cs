using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Target Parties Comp Message Methods
    /// </summary>

    public partial class TargetPartiesComp
    {
        /// <summary>
        ///  Fix Tag for Target Parties Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39142;

        /// <summary>
        ///  Length of Target Parties Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Target Parties Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode target parties comp ---

            if (!message.TryGetGroup(TargetPartiesComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(TargetPartiesComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var targetPartyIdExecutingTrader = (uint)group.GetInt(TargetPartyIdExecutingTrader.FixTag);
                TargetPartyIdExecutingTrader.Encode(pointer, current, targetPartyIdExecutingTrader, out current);

                var sideDisclosureInstruction = (byte)group.GetInt(SideDisclosureInstruction.FixTag);
                SideDisclosureInstruction.Encode(pointer, current, sideDisclosureInstruction, out current);

                var priceDisclosureInstruction = (byte)group.GetInt(PriceDisclosureInstruction.FixTag);
                PriceDisclosureInstruction.Encode(pointer, current, priceDisclosureInstruction, out current);

                var leavesQtyDisclosureInstruction = (byte)group.GetInt(LeavesQtyDisclosureInstruction.FixTag);
                LeavesQtyDisclosureInstruction.Encode(pointer, current, leavesQtyDisclosureInstruction, out current);

                var lastPxDisclosureInstruction = (byte)group.GetInt(LastPxDisclosureInstruction.FixTag);
                LastPxDisclosureInstruction.Encode(pointer, current, lastPxDisclosureInstruction, out current);

                var lastQtyDisclosureInstruction = (byte)group.GetInt(LastQtyDisclosureInstruction.FixTag);
                LastQtyDisclosureInstruction.Encode(pointer, current, lastQtyDisclosureInstruction, out current);

                var freeText5DisclosureInstruction = (byte)group.GetInt(FreeText5DisclosureInstruction.FixTag);
                FreeText5DisclosureInstruction.Encode(pointer, current, freeText5DisclosureInstruction, out current);

                var partyOrderOriginationDisclosureInstruction = (byte)group.GetInt(PartyOrderOriginationDisclosureInstruction.FixTag);
                PartyOrderOriginationDisclosureInstruction.Encode(pointer, current, partyOrderOriginationDisclosureInstruction, out current);

                var quoteInstruction = (byte)group.GetInt(QuoteInstruction.FixTag);
                QuoteInstruction.Encode(pointer, current, quoteInstruction, out current);

                var chargeIdDisclosureInstruction = (byte)group.GetInt(ChargeIdDisclosureInstruction.FixTag);
                ChargeIdDisclosureInstruction.Encode(pointer, current, chargeIdDisclosureInstruction, out current);

                if (group.TryGetString(TargetPartyExecutingFirm.FixTag, out var targetPartyExecutingFirm))
                {
                    TargetPartyExecutingFirm.Encode(pointer, current, targetPartyExecutingFirm, out current);
                }
                else
                {
                    TargetPartyExecutingFirm.SetNull(pointer, current, out current);
                }

                if (group.TryGetString(TargetPartyExecutingTrader.FixTag, out var targetPartyExecutingTrader))
                {
                    TargetPartyExecutingTrader.Encode(pointer, current, targetPartyExecutingTrader, out current);
                }
                else
                {
                    TargetPartyExecutingTrader.SetNull(pointer, current, out current);
                }

                var partyDetailStatus = (byte)group.GetInt(PartyDetailStatus.FixTag);
                PartyDetailStatus.Encode(pointer, current, partyDetailStatus, out current);

                var partyDetailStatusInformation = (byte)group.GetInt(PartyDetailStatusInformation.FixTag);
                PartyDetailStatusInformation.Encode(pointer, current, partyDetailStatusInformation, out current);

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Target Parties Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            TargetPartiesComp.Decode(ref message, pointer, current, out current);

        }
    }
}