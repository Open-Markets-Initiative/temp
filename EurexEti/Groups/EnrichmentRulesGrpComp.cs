using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Enrichment Rules Grp Comp Message Methods
/// </summary>

public static partial class EnrichmentRulesGrpComp
{
    /// <summary>
    ///  Fix Tag for Enrichment Rules Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39108;

    /// <summary>
    ///  Encode Enrichment Rules Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup enrichmentRulesGrpComp, out int current)
    {
        current = offset;

        foreach (var group in enrichmentRulesGrpComp.sectionList)
        {
            if (group.TryGetInt(EnrichmentRuleId.FixTag, out var enrichmentRuleId))
            {
                EnrichmentRuleId.Encode(pointer, current, (ushort)enrichmentRuleId, out current);
            }
            else
            {
                EnrichmentRuleId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PartyIdOriginationMarket.FixTag, out var partyIdOriginationMarket))
            {
                PartyIdOriginationMarket.Encode(pointer, current, (byte)partyIdOriginationMarket, out current);
            }
            else
            {
                PartyIdOriginationMarket.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(Account.FixTag, out var account))
            {
                Account.Encode(pointer, current, account, out current);
            }
            else
            {
                Account.SetNull(pointer, current, out current);
            }

            var positionEffect = group.GetToken(PositionEffect.FixTag);
            PositionEffect.Encode(pointer, current, positionEffect, out current);

            if (group.TryGetString(PartyIdTakeUpTradingFirm.FixTag, out var partyIdTakeUpTradingFirm))
            {
                PartyIdTakeUpTradingFirm.Encode(pointer, current, partyIdTakeUpTradingFirm, out current);
            }
            else
            {
                PartyIdTakeUpTradingFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdOrderOriginationFirm.FixTag, out var partyIdOrderOriginationFirm))
            {
                PartyIdOrderOriginationFirm.Encode(pointer, current, partyIdOrderOriginationFirm, out current);
            }
            else
            {
                PartyIdOrderOriginationFirm.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyIdBeneficiary.FixTag, out var partyIdBeneficiary))
            {
                PartyIdBeneficiary.Encode(pointer, current, partyIdBeneficiary, out current);
            }
            else
            {
                PartyIdBeneficiary.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText1.FixTag, out var freeText1))
            {
                FreeText1.Encode(pointer, current, freeText1, out current);
            }
            else
            {
                FreeText1.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText2.FixTag, out var freeText2))
            {
                FreeText2.Encode(pointer, current, freeText2, out current);
            }
            else
            {
                FreeText2.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(FreeText3.FixTag, out var freeText3))
            {
                FreeText3.Encode(pointer, current, freeText3, out current);
            }
            else
            {
                FreeText3.SetNull(pointer, current, out current);
            }

            Pad1.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Enrichment Rules Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoEnrichmentRules.FixTag, count);

        while (count-- > 0)
        {
            if (EnrichmentRuleId.TryDecode(pointer, current, out var enrichmentRuleId, out current))
            {
                message.AppendInt(EnrichmentRuleId.FixTag, (short)enrichmentRuleId);
            }

            if (PartyIdOriginationMarket.TryDecode(pointer, current, out var partyIdOriginationMarket, out current))
            {
                message.AppendInt(PartyIdOriginationMarket.FixTag, partyIdOriginationMarket);
            }

            if (Account.TryDecode(pointer, current, out var account, out current))
            {
                message.AppendString(Account.FixTag, account);
            }

            var positionEffect = PositionEffect.Decode(pointer, current, out current);
            message.AppendToken(PositionEffect.FixTag, positionEffect);

            if (PartyIdTakeUpTradingFirm.TryDecode(pointer, current, out var partyIdTakeUpTradingFirm, out current))
            {
                message.AppendString(PartyIdTakeUpTradingFirm.FixTag, partyIdTakeUpTradingFirm);
            }

            if (PartyIdOrderOriginationFirm.TryDecode(pointer, current, out var partyIdOrderOriginationFirm, out current))
            {
                message.AppendString(PartyIdOrderOriginationFirm.FixTag, partyIdOrderOriginationFirm);
            }

            if (PartyIdBeneficiary.TryDecode(pointer, current, out var partyIdBeneficiary, out current))
            {
                message.AppendString(PartyIdBeneficiary.FixTag, partyIdBeneficiary);
            }

            if (FreeText1.TryDecode(pointer, current, out var freeText1, out current))
            {
                message.AppendString(FreeText1.FixTag, freeText1);
            }

            if (FreeText2.TryDecode(pointer, current, out var freeText2, out current))
            {
                message.AppendString(FreeText2.FixTag, freeText2);
            }

            if (FreeText3.TryDecode(pointer, current, out var freeText3, out current))
            {
                message.AppendString(FreeText3.FixTag, freeText3);
            }

            current += Pad1.Length;

        }
    }
}
