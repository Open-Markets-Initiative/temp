using SRFixBase;

namespace Eurex.Eti.v130;

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
            if (group.TryGetInt(PartyDetailIdExecutingTrader.FixTag, out var partyDetailIdExecutingTrader))
            {
                PartyDetailIdExecutingTrader.Encode(pointer, current, (uint)partyDetailIdExecutingTrader, out current);
            }
            else
            {
                PartyDetailIdExecutingTrader.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(PartyDetailExecutingTrader.FixTag, out var partyDetailExecutingTrader))
            {
                PartyDetailExecutingTrader.Encode(pointer, current, partyDetailExecutingTrader, out current);
            }
            else
            {
                PartyDetailExecutingTrader.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PartyDetailRoleQualifier.FixTag, out var partyDetailRoleQualifier))
            {
                PartyDetailRoleQualifier.Encode(pointer, current, (byte)partyDetailRoleQualifier, out current);
            }
            else
            {
                PartyDetailRoleQualifier.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PartyDetailStatus.FixTag, out var partyDetailStatus))
            {
                PartyDetailStatus.Encode(pointer, current, (byte)partyDetailStatus, out current);
            }
            else
            {
                PartyDetailStatus.SetNull(pointer, current, out current);
            }

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
            if (PartyDetailIdExecutingTrader.TryDecode(pointer, current, out var partyDetailIdExecutingTrader, out current))
            {
                message.AppendInt(PartyDetailIdExecutingTrader.FixTag, (int)partyDetailIdExecutingTrader);
            }

            if (PartyDetailExecutingTrader.TryDecode(pointer, current, out var partyDetailExecutingTrader, out current))
            {
                message.AppendString(PartyDetailExecutingTrader.FixTag, partyDetailExecutingTrader);
            }

            if (PartyDetailRoleQualifier.TryDecode(pointer, current, out var partyDetailRoleQualifier, out current))
            {
                message.AppendInt(PartyDetailRoleQualifier.FixTag, partyDetailRoleQualifier);
            }

            if (PartyDetailStatus.TryDecode(pointer, current, out var partyDetailStatus, out current))
            {
                message.AppendInt(PartyDetailStatus.FixTag, partyDetailStatus);
            }

            if (PartyDetailDeskId.TryDecode(pointer, current, out var partyDetailDeskId, out current))
            {
                message.AppendString(PartyDetailDeskId.FixTag, partyDetailDeskId);
            }

            current += Pad1.Length;

        }
    }
}
