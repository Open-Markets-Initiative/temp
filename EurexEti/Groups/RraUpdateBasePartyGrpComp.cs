using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Rra Update Base Party Grp Comp Message Methods
    /// </summary>

    public partial class RraUpdateBasePartyGrpComp
    {
        /// <summary>
        ///  Fix Tag for Rra Update Base Party Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39135;

        /// <summary>
        ///  Length of Rra Update Base Party Grp Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Rra Update Base Party Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode rra update base party grp comp ---

            if (!message.TryGetGroup(RraUpdateBasePartyGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(RraUpdateBasePartyGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var remainingRiskAllowanceBaseLong = group.GetDouble(RemainingRiskAllowanceBaseLong.FixTag);
                RemainingRiskAllowanceBaseLong.Encode(pointer, current, remainingRiskAllowanceBaseLong, out current);

                var remainingRiskAllowanceBaseShort = group.GetDouble(RemainingRiskAllowanceBaseShort.FixTag);
                RemainingRiskAllowanceBaseShort.Encode(pointer, current, remainingRiskAllowanceBaseShort, out current);

                var riskLimitId = (uint)group.GetInt(RiskLimitId.FixTag);
                RiskLimitId.Encode(pointer, current, riskLimitId, out current);

                if (group.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
                {
                    PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
                }
                else
                {
                    PartyDetailExecutingUnit.SetNull(pointer, current, out current);
                }

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Rra Update Base Party Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            RraUpdateBasePartyGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}