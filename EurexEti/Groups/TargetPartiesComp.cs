using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Target Parties Comp Message Methods
    /// </summary>

    public partial static class TargetPartiesComp
    {
        /// <summary>
        ///  Fix Tag for Target Parties Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39146;

        /// <summary>
        ///  Encode Target Parties Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int targetPartiesComp, out int current)
        {
            current = offset;

            foreach (var group in targetPartiesComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noTargetPartyIDs.FixTag, count);

            while (count--)
            {
                var targetPartyIdExecutingTrader = (int)TargetPartyIdExecutingTrader.Decode(pointer, current, out current);
                message.AppendInt(TargetPartyIdExecutingTrader.FixTag, targetPartyIdExecutingTrader);

                var sideDisclosureInstruction = SideDisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(SideDisclosureInstruction.FixTag, sideDisclosureInstruction);

                var priceDisclosureInstruction = PriceDisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(PriceDisclosureInstruction.FixTag, priceDisclosureInstruction);

                var leavesQtyDisclosureInstruction = LeavesQtyDisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(LeavesQtyDisclosureInstruction.FixTag, leavesQtyDisclosureInstruction);

                var lastPxDisclosureInstruction = LastPxDisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(LastPxDisclosureInstruction.FixTag, lastPxDisclosureInstruction);

                var lastQtyDisclosureInstruction = LastQtyDisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(LastQtyDisclosureInstruction.FixTag, lastQtyDisclosureInstruction);

                var freeText5DisclosureInstruction = FreeText5DisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(FreeText5DisclosureInstruction.FixTag, freeText5DisclosureInstruction);

                var partyOrderOriginationDisclosureInstruction = PartyOrderOriginationDisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(PartyOrderOriginationDisclosureInstruction.FixTag, partyOrderOriginationDisclosureInstruction);

                var quoteInstruction = QuoteInstruction.Decode(pointer, current, out current);
                message.AppendInt(QuoteInstruction.FixTag, quoteInstruction);

                var chargeIdDisclosureInstruction = ChargeIdDisclosureInstruction.Decode(pointer, current, out current);
                message.AppendInt(ChargeIdDisclosureInstruction.FixTag, chargeIdDisclosureInstruction);

                if (TargetPartyExecutingFirm.TryDecode(pointer, current, out var targetPartyExecutingFirm, out current))
                {
                    message.AppendString(TargetPartyExecutingFirm.FixTag, targetPartyExecutingFirm);
                }

                if (TargetPartyExecutingTrader.TryDecode(pointer, current, out var targetPartyExecutingTrader, out current))
                {
                    message.AppendString(TargetPartyExecutingTrader.FixTag, targetPartyExecutingTrader);
                }

                var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
                message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

                var partyDetailStatusInformation = PartyDetailStatusInformation.Decode(pointer, current, out current);
                message.AppendInt(PartyDetailStatusInformation.FixTag, partyDetailStatusInformation);

                current += Pad6.Length;

            }
        }
    }
}