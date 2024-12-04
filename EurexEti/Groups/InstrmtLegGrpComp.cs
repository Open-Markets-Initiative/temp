using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Instrmt Leg Grp Comp Message Methods
    /// </summary>

    public partial class InstrmtLegGrpComp
    {
        /// <summary>
        ///  Fix Tag for Instrmt Leg Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39111;

        /// <summary>
        ///  Length of Instrmt Leg Grp Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Instrmt Leg Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode instrmt leg grp comp ---

            if (!message.TryGetGroup(InstrmtLegGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(InstrmtLegGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var legSecurityId = group.GetLong(LegSecurityId.FixTag);
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);

                var legPrice = group.GetDouble(LegPrice.FixTag);
                LegPrice.Encode(pointer, current, legPrice, out current);

                var legSymbol = group.GetInt(LegSymbol.FixTag);
                LegSymbol.Encode(pointer, current, legSymbol, out current);

                var legRatioQty = (uint)group.GetInt(LegRatioQty.FixTag);
                LegRatioQty.Encode(pointer, current, legRatioQty, out current);

                var legSide = (byte)group.GetInt(LegSide.FixTag);
                LegSide.Encode(pointer, current, legSide, out current);

                var legSecurityType = (byte)group.GetInt(LegSecurityType.FixTag);
                LegSecurityType.Encode(pointer, current, legSecurityType, out current);

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Instrmt Leg Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            InstrmtLegGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}