using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Risk Limit Qty Grp Comp Message Methods
/// </summary>

public static partial class RiskLimitQtyGrpComp
{
    /// <summary>
    ///  Fix Tag for Risk Limit Qty Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39132;

    /// <summary>
    ///  Encode Risk Limit Qty Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup riskLimitQtyGrpComp, out int current)
    {
        current = offset;

        foreach (var group in riskLimitQtyGrpComp.sectionList)
        {
            if (group.TryGetDouble(RiskLimitQty.FixTag, out var riskLimitQty))
            {
                RiskLimitQty.Encode(pointer, current, riskLimitQty, out current);
            }
            else
            {
                RiskLimitQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(RiskLimitType.FixTag, out var riskLimitType))
            {
                RiskLimitType.Encode(pointer, current, (byte)riskLimitType, out current);
            }
            else
            {
                RiskLimitType.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Risk Limit Qty Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoRiskLimitsQty.FixTag, count);

        while (count-- > 0)
        {
            if (RiskLimitQty.TryDecode(pointer, current, out var riskLimitQty, out current))
            {
                message.AppendDouble(RiskLimitQty.FixTag, riskLimitQty);
            }

            if (RiskLimitType.TryDecode(pointer, current, out var riskLimitType, out current))
            {
                message.AppendInt(RiskLimitType.FixTag, riskLimitType);
            }

            current += Pad7.Length;

        }
    }
}
