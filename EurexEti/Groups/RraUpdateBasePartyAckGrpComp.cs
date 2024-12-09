using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Rra Update Base Party Ack Grp Comp Message Methods
    /// </summary>

    public static partial class RraUpdateBasePartyAckGrpComp
    {
        /// <summary>
        ///  Fix Tag for Rra Update Base Party Ack Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39134;

        /// <summary>
        ///  Encode Rra Update Base Party Ack Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup rraUpdateBasePartyAckGrpComp, out int current)
        {
            current = offset;

            foreach (var group in rraUpdateBasePartyAckGrpComp.sectionList)
            {
                if (group.TryGetString(PartyDetailExecutingUnit.FixTag, out var partyDetailExecutingUnit))
                {
                    PartyDetailExecutingUnit.Encode(pointer, current, partyDetailExecutingUnit, out current);
                }
                else
                {
                    PartyDetailExecutingUnit.SetNull(pointer, current, out current);
                }

                Pad1.Encode(pointer, current, out current);

                var riskLimitResult = (ushort)group.GetInt(RiskLimitResult.FixTag);
                RiskLimitResult.Encode(pointer, current, riskLimitResult, out current);

            }
        }

        /// <summary>
        ///  Decode Rra Update Base Party Ack Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoPartyRiskLimits.FixTag, count);

            while (count-- > 0)
            {
                if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
                {
                    message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
                }

                current += Pad1.Length;

                var riskLimitResult = (short)RiskLimitResult.Decode(pointer, current, out current);
                message.AppendInt(RiskLimitResult.FixTag, riskLimitResult);

            }
        }
    }
}