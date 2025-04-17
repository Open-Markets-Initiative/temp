using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Target Parties Comp Message Methods
/// </summary>

public static partial class TargetPartiesComp
{
    /// <summary>
    ///  Fix Tag for Target Parties Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39146;

    /// <summary>
    ///  Encode Target Parties Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup targetPartiesComp, out int current)
    {
        current = offset;

        foreach (var group in targetPartiesComp.sectionList)
        {
            if (group.TryGetInt(TargetPartyIdExecutingTrader.FixTag, out var targetPartyIdExecutingTrader))
            {
                TargetPartyIdExecutingTrader.Encode(pointer, current, (uint)targetPartyIdExecutingTrader, out current);
            }
            else
            {
                TargetPartyIdExecutingTrader.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(SideDisclosureInstruction.FixTag, out var sideDisclosureInstruction))
            {
                SideDisclosureInstruction.Encode(pointer, current, (byte)sideDisclosureInstruction, out current);
            }
            else
            {
                SideDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PriceDisclosureInstruction.FixTag, out var priceDisclosureInstruction))
            {
                PriceDisclosureInstruction.Encode(pointer, current, (byte)priceDisclosureInstruction, out current);
            }
            else
            {
                PriceDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LeavesQtyDisclosureInstruction.FixTag, out var leavesQtyDisclosureInstruction))
            {
                LeavesQtyDisclosureInstruction.Encode(pointer, current, (byte)leavesQtyDisclosureInstruction, out current);
            }
            else
            {
                LeavesQtyDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LastPxDisclosureInstruction.FixTag, out var lastPxDisclosureInstruction))
            {
                LastPxDisclosureInstruction.Encode(pointer, current, (byte)lastPxDisclosureInstruction, out current);
            }
            else
            {
                LastPxDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(LastQtyDisclosureInstruction.FixTag, out var lastQtyDisclosureInstruction))
            {
                LastQtyDisclosureInstruction.Encode(pointer, current, (byte)lastQtyDisclosureInstruction, out current);
            }
            else
            {
                LastQtyDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(FreeText5DisclosureInstruction.FixTag, out var freeText5DisclosureInstruction))
            {
                FreeText5DisclosureInstruction.Encode(pointer, current, (byte)freeText5DisclosureInstruction, out current);
            }
            else
            {
                FreeText5DisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PartyOrderOriginationDisclosureInstruction.FixTag, out var partyOrderOriginationDisclosureInstruction))
            {
                PartyOrderOriginationDisclosureInstruction.Encode(pointer, current, (byte)partyOrderOriginationDisclosureInstruction, out current);
            }
            else
            {
                PartyOrderOriginationDisclosureInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(QuoteInstruction.FixTag, out var quoteInstruction))
            {
                QuoteInstruction.Encode(pointer, current, (byte)quoteInstruction, out current);
            }
            else
            {
                QuoteInstruction.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(ChargeIdDisclosureInstruction.FixTag, out var chargeIdDisclosureInstruction))
            {
                ChargeIdDisclosureInstruction.Encode(pointer, current, (byte)chargeIdDisclosureInstruction, out current);
            }
            else
            {
                ChargeIdDisclosureInstruction.SetNull(pointer, current, out current);
            }

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

            if (group.TryGetInt(PartyDetailStatus.FixTag, out var partyDetailStatus))
            {
                PartyDetailStatus.Encode(pointer, current, (byte)partyDetailStatus, out current);
            }
            else
            {
                PartyDetailStatus.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PartyDetailStatusInformation.FixTag, out var partyDetailStatusInformation))
            {
                PartyDetailStatusInformation.Encode(pointer, current, (byte)partyDetailStatusInformation, out current);
            }
            else
            {
                PartyDetailStatusInformation.SetNull(pointer, current, out current);
            }

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

        message.AppendInt(NoTargetPartyIDs.FixTag, count);

        while (count-- > 0)
        {
            if (TargetPartyIdExecutingTrader.TryDecode(pointer, current, out var targetPartyIdExecutingTrader, out current))
            {
                message.AppendInt(TargetPartyIdExecutingTrader.FixTag, (int)targetPartyIdExecutingTrader);
            }

            if (SideDisclosureInstruction.TryDecode(pointer, current, out var sideDisclosureInstruction, out current))
            {
                message.AppendInt(SideDisclosureInstruction.FixTag, sideDisclosureInstruction);
            }

            if (PriceDisclosureInstruction.TryDecode(pointer, current, out var priceDisclosureInstruction, out current))
            {
                message.AppendInt(PriceDisclosureInstruction.FixTag, priceDisclosureInstruction);
            }

            if (LeavesQtyDisclosureInstruction.TryDecode(pointer, current, out var leavesQtyDisclosureInstruction, out current))
            {
                message.AppendInt(LeavesQtyDisclosureInstruction.FixTag, leavesQtyDisclosureInstruction);
            }

            if (LastPxDisclosureInstruction.TryDecode(pointer, current, out var lastPxDisclosureInstruction, out current))
            {
                message.AppendInt(LastPxDisclosureInstruction.FixTag, lastPxDisclosureInstruction);
            }

            if (LastQtyDisclosureInstruction.TryDecode(pointer, current, out var lastQtyDisclosureInstruction, out current))
            {
                message.AppendInt(LastQtyDisclosureInstruction.FixTag, lastQtyDisclosureInstruction);
            }

            if (FreeText5DisclosureInstruction.TryDecode(pointer, current, out var freeText5DisclosureInstruction, out current))
            {
                message.AppendInt(FreeText5DisclosureInstruction.FixTag, freeText5DisclosureInstruction);
            }

            if (PartyOrderOriginationDisclosureInstruction.TryDecode(pointer, current, out var partyOrderOriginationDisclosureInstruction, out current))
            {
                message.AppendInt(PartyOrderOriginationDisclosureInstruction.FixTag, partyOrderOriginationDisclosureInstruction);
            }

            if (QuoteInstruction.TryDecode(pointer, current, out var quoteInstruction, out current))
            {
                message.AppendInt(QuoteInstruction.FixTag, quoteInstruction);
            }

            if (ChargeIdDisclosureInstruction.TryDecode(pointer, current, out var chargeIdDisclosureInstruction, out current))
            {
                message.AppendInt(ChargeIdDisclosureInstruction.FixTag, chargeIdDisclosureInstruction);
            }

            if (TargetPartyExecutingFirm.TryDecode(pointer, current, out var targetPartyExecutingFirm, out current))
            {
                message.AppendString(TargetPartyExecutingFirm.FixTag, targetPartyExecutingFirm);
            }

            if (TargetPartyExecutingTrader.TryDecode(pointer, current, out var targetPartyExecutingTrader, out current))
            {
                message.AppendString(TargetPartyExecutingTrader.FixTag, targetPartyExecutingTrader);
            }

            if (PartyDetailStatus.TryDecode(pointer, current, out var partyDetailStatus, out current))
            {
                message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);
            }

            if (PartyDetailStatusInformation.TryDecode(pointer, current, out var partyDetailStatusInformation, out current))
            {
                message.AppendInt(PartyDetailStatusInformation.FixTag, partyDetailStatusInformation);
            }

            current += Pad6.Length;

        }
    }
}
