using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trd Instrmnt Leg Grp Comp Message Methods
    /// </summary>

    public partial class TrdInstrmntLegGrpComp
    {
        /// <summary>
        ///  Fix Tag for Trd Instrmnt Leg Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39144;

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

            // --- TODO ---

            TrdInstrmntLegGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}