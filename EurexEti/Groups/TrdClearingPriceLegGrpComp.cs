using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trd Clearing Price Leg Grp Comp Message Methods
    /// </summary>

    public partial class TrdClearingPriceLegGrpComp
    {
        /// <summary>
        ///  Fix Tag for Trd Clearing Price Leg Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39147;

        /// <summary>
        ///  Length of Trd Clearing Price Leg Grp Comp in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Trd Clearing Price Leg Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode trd clearing price leg grp comp ---

            if (!message.TryGetGroup(TrdClearingPriceLegGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(TrdClearingPriceLegGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            TrdClearingPriceLegGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}