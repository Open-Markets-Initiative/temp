using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trd Clearing Price Leg Grp Comp Message Methods
    /// </summary>

    public partial class TrdClearingPriceLegGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, TrdClearingPriceLegGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode trd clearing price leg grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode trd clearing price leg grp comp group ---

            message.AppendInt(TrdClearingPriceLegGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);

                var legClearingTradePrice = LegClearingTradePrice.Decode(pointer, current, out current);
                message.AppendDouble(LegClearingTradePrice.FixTag, legClearingTradePrice);

            }
        }
    }
}