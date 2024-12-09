using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
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
                var legSecurityId = group.GetLong(LegSecurityId.FixTag);
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);

                var legClearingTradePrice = group.GetDouble(LegClearingTradePrice.FixTag);
                LegClearingTradePrice.Encode(pointer, current, legClearingTradePrice, out current);

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

            message.AppendInt(noLegClearingPrices.FixTag, count);

            while (count--)
            {
                var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);

                var legClearingTradePrice = LegClearingTradePrice.Decode(pointer, current, out current);
                message.AppendDouble(LegClearingTradePrice.FixTag, legClearingTradePrice);

            }
        }
    }
}