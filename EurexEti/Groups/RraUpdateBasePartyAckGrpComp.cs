using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Rra Update Base Party Ack Grp Comp Message Methods
    /// </summary>

    public partial class RraUpdateBasePartyAckGrpComp
    {
        /// <summary>
        ///  Length of Rra Update Base Party Ack Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Rra Update Base Party Ack Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode rra update base party ack grp comp ---

            if (!message.TryGetGroup(RraUpdateBasePartyAckGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(RraUpdateBasePartyAckGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

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