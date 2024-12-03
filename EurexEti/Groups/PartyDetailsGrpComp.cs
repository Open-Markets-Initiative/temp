using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Details Grp Comp Message Methods
    /// </summary>

    public partial class PartyDetailsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Party Details Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39122;

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

            var partyDetailIdExecutingTrader = (int)PartyDetailIdExecutingTrader.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailIdExecutingTrader.FixTag, partyDetailIdExecutingTrader);

            if (PartyDetailExecutingTrader.TryDecode(pointer, current, out var partyDetailExecutingTrader, out current))
            {
                message.AppendString(PartyDetailExecutingTrader.FixTag, partyDetailExecutingTrader);
            }

            var partyDetailRoleQualifier = PartyDetailRoleQualifier.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailRoleQualifier.FixTag, partyDetailRoleQualifier);

            var partyDetailStatus = PartyDetailStatus.Decode(pointer, current, out current);
            message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);

            if (PartyDetailDeskId.TryDecode(pointer, current, out var partyDetailDeskId, out current))
            {
                message.AppendString(PartyDetailDeskId.FixTag, partyDetailDeskId);
            }

            current += Pad1.Length;

        }
    }
}