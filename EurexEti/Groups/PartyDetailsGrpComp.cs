using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Details Grp Comp Message Methods
    /// </summary>

    public static partial class PartyDetailsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Party Details Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39126;

        /// <summary>
        ///  Encode Party Details Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup partyDetailsGrpComp, out int current)
        {
            current = offset;

            foreach (var group in partyDetailsGrpComp.sectionList)
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
}