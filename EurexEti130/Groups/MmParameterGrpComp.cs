using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Mm Parameter Grp Comp Message Methods
/// </summary>

public static partial class MmParameterGrpComp
{
    /// <summary>
    ///  Fix Tag for Mm Parameter Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39116;

    /// <summary>
    ///  Encode Mm Parameter Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup mmParameterGrpComp, out int current)
    {
        current = offset;

        foreach (var group in mmParameterGrpComp.sectionList)
        {
            if (group.TryGetLong(ExposureDuration.FixTag, out var exposureDuration))
            {
                ExposureDuration.Encode(pointer, current, exposureDuration, out current);
            }
            else
            {
                ExposureDuration.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(CumQty.FixTag, out var cumQty))
            {
                CumQty.Encode(pointer, current, cumQty, out current);
            }
            else
            {
                CumQty.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(Delta.FixTag, out var delta))
            {
                Delta.Encode(pointer, current, delta, out current);
            }
            else
            {
                Delta.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(Vega.FixTag, out var vega))
            {
                Vega.Encode(pointer, current, vega, out current);
            }
            else
            {
                Vega.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(PctCount.FixTag, out var pctCount))
            {
                PctCount.Encode(pointer, current, pctCount, out current);
            }
            else
            {
                PctCount.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(TargetPartyIdSessionId.FixTag, out var targetPartyIdSessionId))
            {
                TargetPartyIdSessionId.Encode(pointer, current, (uint)targetPartyIdSessionId, out current);
            }
            else
            {
                TargetPartyIdSessionId.SetNull(pointer, current, out current);
            }

            if (group.TryGetInt(MmRiskLimitActionType.FixTag, out var mmRiskLimitActionType))
            {
                MmRiskLimitActionType.Encode(pointer, current, (byte)mmRiskLimitActionType, out current);
            }
            else
            {
                MmRiskLimitActionType.SetNull(pointer, current, out current);
            }

            Pad7.Encode(pointer, current, out current);

        }
    }

    /// <summary>
    ///  Decode Mm Parameter Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoMmParameters.FixTag, count);

        while (count-- > 0)
        {
            if (ExposureDuration.TryDecode(pointer, current, out var exposureDuration, out current))
            {
                message.AppendLong(ExposureDuration.FixTag, exposureDuration);
            }

            if (CumQty.TryDecode(pointer, current, out var cumQty, out current))
            {
                message.AppendDouble(CumQty.FixTag, cumQty);
            }

            if (Delta.TryDecode(pointer, current, out var delta, out current))
            {
                message.AppendDouble(Delta.FixTag, delta);
            }

            if (Vega.TryDecode(pointer, current, out var vega, out current))
            {
                message.AppendDouble(Vega.FixTag, vega);
            }

            if (PctCount.TryDecode(pointer, current, out var pctCount, out current))
            {
                message.AppendInt(PctCount.FixTag, pctCount);
            }

            if (TargetPartyIdSessionId.TryDecode(pointer, current, out var targetPartyIdSessionId, out current))
            {
                message.AppendInt(TargetPartyIdSessionId.FixTag, (int)targetPartyIdSessionId);
            }

            if (MmRiskLimitActionType.TryDecode(pointer, current, out var mmRiskLimitActionType, out current))
            {
                message.AppendInt(MmRiskLimitActionType.FixTag, mmRiskLimitActionType);
            }

            current += Pad7.Length;

        }
    }
}
