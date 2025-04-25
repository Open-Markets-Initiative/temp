using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Rra Update Base Party Grp Comp Message Methods
/// </summary>

public static partial class RraUpdateBasePartyGrpComp
{
    /// <summary>
    ///  Fix Tag for Rra Update Base Party Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39135;

    /// <summary>
    ///  Encode Rra Update Base Party Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup rraUpdateBasePartyGrpComp, out int current)
    {
        current = offset;

        foreach (var group in rraUpdateBasePartyGrpComp.sectionList)
        {
            if (group.TryGetDouble(RemainingRiskAllowanceBaseLong.FixTag, out var remainingRiskAllowanceBaseLong))
            {
                RemainingRiskAllowanceBaseLong.Encode(pointer, current, remainingRiskAllowanceBaseLong, out current);
            }
            else
            {
                RemainingRiskAllowanceBaseLong.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(RemainingRiskAllowanceBaseShort.FixTag, out var remainingRiskAllowanceBaseShort))
            {
                RemainingRiskAllowanceBaseShort.Encode(pointer, current, remainingRiskAllowanceBaseShort, out current);
            }
            else
            {
                RemainingRiskAllowanceBaseShort.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(RiskLimitId.FixTag, out var riskLimitId))
            {
                RiskLimitId.Encode(pointer, current, (uint)riskLimitId, out current);
            }
            else
            {
                RiskLimitId.SetNull(pointer, current, out current);
            }

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

        message.AppendInt(NoPartyRiskLimits.FixTag, count);

        while (count-- > 0)
        {
            if (RemainingRiskAllowanceBaseLong.TryDecode(pointer, current, out var remainingRiskAllowanceBaseLong, out current))
            {
                message.AppendDouble(RemainingRiskAllowanceBaseLong.FixTag, remainingRiskAllowanceBaseLong);
            }

            if (RemainingRiskAllowanceBaseShort.TryDecode(pointer, current, out var remainingRiskAllowanceBaseShort, out current))
            {
                message.AppendDouble(RemainingRiskAllowanceBaseShort.FixTag, remainingRiskAllowanceBaseShort);
            }

            if (RiskLimitId.TryDecode(pointer, current, out var riskLimitId, out current))
            {
                message.AppendInt(RiskLimitId.FixTag, (int)riskLimitId);
            }

            if (PartyDetailExecutingUnit.TryDecode(pointer, current, out var partyDetailExecutingUnit, out current))
            {
                message.AppendString(PartyDetailExecutingUnit.FixTag, partyDetailExecutingUnit);
            }

            current += Pad7.Length;

        }
    }
}
