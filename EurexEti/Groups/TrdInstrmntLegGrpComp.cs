using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trd Instrmnt Leg Grp Comp Message Methods
    /// </summary>

    public partial static class TrdInstrmntLegGrpComp
    {
        /// <summary>
        ///  Fix Tag for Trd Instrmnt Leg Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39148;

        /// <summary>
        ///  Encode Trd Instrmnt Leg Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int trdInstrmntLegGrpComp, out int current)
        {
            current = offset;

            foreach (var group in trdInstrmntLegGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noLegs.FixTag, count);

            while (count--)
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