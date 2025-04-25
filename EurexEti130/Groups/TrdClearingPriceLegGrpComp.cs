using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Trd Clearing Price Leg Grp Comp Message Methods
/// </summary>

public static partial class TrdClearingPriceLegGrpComp
{
    /// <summary>
    ///  Fix Tag for Trd Clearing Price Leg Grp Comp (Generated)
    /// </summary>
    public const ushort FixTag = 39147;

    /// <summary>
    ///  Encode Trd Clearing Price Leg Grp Comp
    /// </summary>
    public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup trdClearingPriceLegGrpComp, out int current)
    {
        current = offset;

        foreach (var group in trdClearingPriceLegGrpComp.sectionList)
        {
            if (group.TryGetLong(LegSecurityId.FixTag, out var legSecurityId))
            {
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);
            }
            else
            {
                LegSecurityId.SetNull(pointer, current, out current);
            }

            if (group.TryGetDouble(LegClearingTradePrice.FixTag, out var legClearingTradePrice))
            {
                LegClearingTradePrice.Encode(pointer, current, legClearingTradePrice, out current);
            }
            else
            {
                LegClearingTradePrice.SetNull(pointer, current, out current);
            }

        }
    }

    /// <summary>
    ///  Decode Trd Clearing Price Leg Grp Comp
    /// </summary>
    public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
    {
        current = offset;

        if (count < 1)
        {
            return;
        }

        message.AppendInt(NoLegClearingPrices.FixTag, count);

        while (count-- > 0)
        {
            if (LegSecurityId.TryDecode(pointer, current, out var legSecurityId, out current))
            {
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);
            }

            if (LegClearingTradePrice.TryDecode(pointer, current, out var legClearingTradePrice, out current))
            {
                message.AppendDouble(LegClearingTradePrice.FixTag, legClearingTradePrice);
            }

        }
    }
}
