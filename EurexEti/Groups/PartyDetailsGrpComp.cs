using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Details Grp Comp Message Methods
    /// </summary>

    public partial class PartyDetailsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Party Details Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39126;

        /// <summary>
        ///  Length of Party Details Grp Comp in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Party Details Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode party details grp comp ---

            if (!message.TryGetGroup(PartyDetailsGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(PartyDetailsGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var partyDetailIdExecutingTrader = (uint)group.GetInt(PartyDetailIdExecutingTrader.FixTag);
                PartyDetailIdExecutingTrader.Encode(pointer, current, partyDetailIdExecutingTrader, out current);

                if (group.TryGetString(PartyDetailExecutingTrader.FixTag, out var partyDetailExecutingTrader))
                {
                    PartyDetailExecutingTrader.Encode(pointer, current, partyDetailExecutingTrader, out current);
                }
                else
                {
                    PartyDetailExecutingTrader.SetNull(pointer, current, out current);
                }

                var partyDetailRoleQualifier = (byte)group.GetInt(PartyDetailRoleQualifier.FixTag);
                PartyDetailRoleQualifier.Encode(pointer, current, partyDetailRoleQualifier, out current);

                var partyDetailStatus = (byte)group.GetInt(PartyDetailStatus.FixTag);
                PartyDetailStatus.Encode(pointer, current, partyDetailStatus, out current);

                if (group.TryGetString(PartyDetailDeskId.FixTag, out var partyDetailDeskId))
                {
                    PartyDetailDeskId.Encode(pointer, current, partyDetailDeskId, out current);
                }
                else
                {
                    PartyDetailDeskId.SetNull(pointer, current, out current);
                }

                Pad1.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Party Details Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            PartyDetailsGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}