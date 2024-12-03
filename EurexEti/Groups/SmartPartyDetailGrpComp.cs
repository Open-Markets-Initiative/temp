using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Smart Party Detail Grp Comp Message Methods
    /// </summary>

    public partial class SmartPartyDetailGrpComp
    {
        /// <summary>
        ///  Fix Tag for Smart Party Detail Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39137;

        /// <summary>
        ///  Length of Smart Party Detail Grp Comp in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Smart Party Detail Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode smart party detail grp comp ---

            if (!message.TryGetGroup(SmartPartyDetailGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SmartPartyDetailGrpComp.FixTag, message);
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

                if (group.TryGetString(PartyDetailExecutingTrader.FixTag, out var partyDetailExecutingTrader))
                {
                    PartyDetailExecutingTrader.Encode(pointer, current, partyDetailExecutingTrader, out current);
                }
                else
                {
                    PartyDetailExecutingTrader.SetNull(pointer, current, out current);
                }

                Pad5.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Smart Party Detail Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            if (PartyDetailExecutingTrader.TryDecode(pointer, current, out var partyDetailExecutingTrader, out current))
            {
                message.AppendString(PartyDetailExecutingTrader.FixTag, partyDetailExecutingTrader);
            }

            current += Pad5.Length;

        }
    }
}