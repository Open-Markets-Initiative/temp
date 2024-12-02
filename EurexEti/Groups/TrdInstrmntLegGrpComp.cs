using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trd Instrmnt Leg Grp Comp Message Methods
    /// </summary>

    public partial class TrdInstrmntLegGrpComp
    {
        /// <summary>
        ///  Length of Trd Instrmnt Leg Grp Comp in bytes
        /// </summary>
        public const int Length = 24;

        /// <summary>
        ///  Encode Trd Instrmnt Leg Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, TrdInstrmntLegGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode trd instrmnt leg grp comp ---

            if (!message.TryGetGroup(TrdInstrmntLegGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(TrdInstrmntLegGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var legSecurityId = group.GetLong(LegSecurityId.FixTag);
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);

                var legPrice = group.GetDouble(LegPrice.FixTag);
                LegPrice.Encode(pointer, current, legPrice, out current);

                var legQty = group.GetDouble(LegQty.FixTag);
                LegQty.Encode(pointer, current, legQty, out current);

            }
        }

        /// <summary>
        ///  Decode Trd Instrmnt Leg Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode trd instrmnt leg grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode trd instrmnt leg grp comp group ---

            message.AppendInt(TrdInstrmntLegGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);

                var legPrice = LegPrice.Decode(pointer, current, out current);
                message.AppendDouble(LegPrice.FixTag, legPrice);

                var legQty = LegQty.Decode(pointer, current, out current);
                message.AppendDouble(LegQty.FixTag, legQty);

            }
        }
    }
}