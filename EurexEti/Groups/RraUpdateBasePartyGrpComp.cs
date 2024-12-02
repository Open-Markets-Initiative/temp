using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Rra Update Base Party Grp Comp Message Methods
    /// </summary>

    public partial class RraUpdateBasePartyGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, RraUpdateBasePartyGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode rra update base party grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode rra update base party grp comp group ---

            message.AppendInt(RraUpdateBasePartyGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var remainingRiskAllowanceBaseLong = RemainingRiskAllowanceBaseLong.Decode(pointer, current, out current);
                message.AppendDouble(RemainingRiskAllowanceBaseLong.FixTag, remainingRiskAllowanceBaseLong);

                var remainingRiskAllowanceBaseShort = RemainingRiskAllowanceBaseShort.Decode(pointer, current, out current);
                message.AppendDouble(RemainingRiskAllowanceBaseShort.FixTag, remainingRiskAllowanceBaseShort);

                var riskLimitId = (int)RiskLimitId.Decode(pointer, current, out current);
                message.AppendInt(RiskLimitId.FixTag, riskLimitId);

                if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
                {
                    message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
                }

                current += Pad7.Length;

            }
        }
    }
}