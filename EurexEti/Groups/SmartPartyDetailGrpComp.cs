using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Smart Party Detail Grp Comp Message Methods
    /// </summary>

    public static partial class SmartPartyDetailGrpComp
    {
        /// <summary>
        ///  Fix Tag for Smart Party Detail Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39141;

        /// <summary>
        ///  Encode Smart Party Detail Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup smartPartyDetailGrpComp, out int current)
        {
            current = offset;

            foreach (var group in smartPartyDetailGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoPartyDetails.FixTag, count);

            while (count-- > 0)
            {
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
}