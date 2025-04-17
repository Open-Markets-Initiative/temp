using SRFixBase;

namespace Eurex.Edci.v131;

/// <summary>
///  Affected Ord Grp Comp Message Methods
/// </summary>

public static partial class AffectedOrdGrpComp
{
    /// <summary>
    ///  Fix Tag for Affected Ord Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39100;

    /// <summary>
    ///  Encode Affected Ord Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup affectedOrdGrpComp, out int current)
    {
        current = offset;

        foreach (var group in affectedOrdGrpComp.sectionList)
        {
            if (group.TryGetULong(AffectedOrderId.FixTag, out var affectedOrderId))
            {
                AffectedOrderId.Encode(pointer, current, affectedOrderId, out current);
            }
            else
            {
                AffectedOrderId.SetNull(pointer, current, out current);
            }

            if (group.TryGetULong(AffectedClOrdId.FixTag, out var affectedClOrdId))
            {
                AffectedClOrdId.Encode(pointer, current, affectedClOrdId, out current);
            }
            else
            {
                AffectedClOrdId.SetNull(pointer, current, out current);
            }

            if (group.TryGetULong(AffectedOrigClOrdId.FixTag, out var affectedOrigClOrdId))
            {
                AffectedOrigClOrdId.Encode(pointer, current, affectedOrigClOrdId, out current);
            }
            else
            {
                AffectedOrigClOrdId.SetNull(pointer, current, out current);
            }

            if (group.TryGetLong(SecurityId.FixTag, out var securityId))
            {
                SecurityId.Encode(pointer, current, securityId, out current);
            }
            else
            {
                SecurityId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PartyIdSessionId.FixTag, out var partyIdSessionId))
            {
                PartyIdSessionId.Encode(pointer, current, (uint)partyIdSessionId, out current);
            }
            else
            {
                PartyIdSessionId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PartyIdExecutingTrader.FixTag, out var partyIdExecutingTrader))
            {
                PartyIdExecutingTrader.Encode(pointer, current, (uint)partyIdExecutingTrader, out current);
            }
            else
            {
                PartyIdExecutingTrader.SetNull(pointer, current, out current);
            }

            var ordStatus = group.GetToken(OrdStatus.FixTag);
            OrdStatus.Encode(pointer, current, ordStatus, out current);

            var execType = group.GetToken(ExecType.FixTag);
            ExecType.Encode(pointer, current, execType, out current);

            if (group.TryGetString(AffectedFixClOrdId.FixTag, out var affectedFixClOrdId))
            {
                AffectedFixClOrdId.Encode(pointer, current, affectedFixClOrdId, out current);
            }
            else
            {
                AffectedFixClOrdId.SetNull(pointer, current, out current);
            }

            if (group.TryGetString(AffectedFixOrigClOrdId.FixTag, out var affectedFixOrigClOrdId))
            {
                AffectedFixOrigClOrdId.Encode(pointer, current, affectedFixOrigClOrdId, out current);
            }
            else
            {
                AffectedFixOrigClOrdId.SetNull(pointer, current, out current);
            }

            Pad6.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Affected Ord Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoAffectedOrders.FixTag, count);

        while (count-- > 0)
        {
            if (AffectedOrderId.TryDecode(pointer, current, out var affectedOrderId, out current))
            {
                message.AppendULong(AffectedOrderId.FixTag, affectedOrderId);
            }

            if (AffectedClOrdId.TryDecode(pointer, current, out var affectedClOrdId, out current))
            {
                message.AppendULong(AffectedClOrdId.FixTag, affectedClOrdId);
            }

            if (AffectedOrigClOrdId.TryDecode(pointer, current, out var affectedOrigClOrdId, out current))
            {
                message.AppendULong(AffectedOrigClOrdId.FixTag, affectedOrigClOrdId);
            }

            if (SecurityId.TryDecode(pointer, current, out var securityId, out current))
            {
                message.AppendLong(SecurityId.FixTag, securityId);
            }

            if (PartyIdSessionId.TryDecode(pointer, current, out var partyIdSessionId, out current))
            {
                message.AppendInt(PartyIdSessionId.FixTag, (int)partyIdSessionId);
            }

            if (PartyIdExecutingTrader.TryDecode(pointer, current, out var partyIdExecutingTrader, out current))
            {
                message.AppendInt(PartyIdExecutingTrader.FixTag, (int)partyIdExecutingTrader);
            }

            var ordStatus = OrdStatus.Decode(pointer, current, out current);
            message.AppendToken(OrdStatus.FixTag, ordStatus);

            var execType = ExecType.Decode(pointer, current, out current);
            message.AppendToken(ExecType.FixTag, execType);

            if (AffectedFixClOrdId.TryDecode(pointer, current, out var affectedFixClOrdId, out current))
            {
                message.AppendString(AffectedFixClOrdId.FixTag, affectedFixClOrdId);
            }

            if (AffectedFixOrigClOrdId.TryDecode(pointer, current, out var affectedFixOrigClOrdId, out current))
            {
                message.AppendString(AffectedFixOrigClOrdId.FixTag, affectedFixOrigClOrdId);
            }

            current += Pad6.Length;

        }
    }
}
