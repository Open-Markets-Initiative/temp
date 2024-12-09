using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Rra Update Base Party Grp Comp Message Methods
    /// </summary>

    public partial static class RraUpdateBasePartyGrpComp
    {
        /// <summary>
        ///  Fix Tag for Rra Update Base Party Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39135;

        /// <summary>
        ///  Encode Rra Update Base Party Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int rraUpdateBasePartyGrpComp, out int current)
        {
            current = offset;

            foreach (var group in rraUpdateBasePartyGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noPartyRiskLimits.FixTag, count);

            while (count--)
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