using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Enrichment Rules Grp Comp Message Methods
    /// </summary>

    public partial class EnrichmentRulesGrpComp
    {
        /// <summary>
        ///  Fix Tag for Enrichment Rules Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39108;

        /// <summary>
        ///  Length of Enrichment Rules Grp Comp in bytes
        /// </summary>
        public const int Length = 64;

        /// <summary>
        ///  Encode Enrichment Rules Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode enrichment rules grp comp ---

            if (!message.TryGetGroup(EnrichmentRulesGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(EnrichmentRulesGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var enrichmentRuleId = (ushort)group.GetInt(EnrichmentRuleId.FixTag);
                EnrichmentRuleId.Encode(pointer, current, enrichmentRuleId, out current);

                var partyIdOriginationMarket = (byte)group.GetInt(PartyIdOriginationMarket.FixTag);
                PartyIdOriginationMarket.Encode(pointer, current, partyIdOriginationMarket, out current);

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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            EnrichmentRulesGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}