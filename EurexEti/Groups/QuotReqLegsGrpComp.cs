using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quot Req Legs Grp Comp Message Methods
    /// </summary>

    public partial static class QuotReqLegsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Quot Req Legs Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39127;

        /// <summary>
        ///  Encode Quot Req Legs Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int quotReqLegsGrpComp, out int current)
        {
            current = offset;

            foreach (var group in quotReqLegsGrpComp.sectionList)
            {
                var legSecurityId = group.GetLong(LegSecurityId.FixTag);
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);

                var legRatioQty = (uint)group.GetInt(LegRatioQty.FixTag);
                LegRatioQty.Encode(pointer, current, legRatioQty, out current);

                var legSymbol = group.GetInt(LegSymbol.FixTag);
                LegSymbol.Encode(pointer, current, legSymbol, out current);

                var legSecurityType = (byte)group.GetInt(LegSecurityType.FixTag);
                LegSecurityType.Encode(pointer, current, legSecurityType, out current);

                var legSide = (byte)group.GetInt(LegSide.FixTag);
                LegSide.Encode(pointer, current, legSide, out current);

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Quot Req Legs Grp Comp
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

                var legRatioQty = (int)LegRatioQty.Decode(pointer, current, out current);
                message.AppendInt(LegRatioQty.FixTag, legRatioQty);

                var legSymbol = LegSymbol.Decode(pointer, current, out current);
                message.AppendInt(LegSymbol.FixTag, legSymbol);

                var legSecurityType = LegSecurityType.Decode(pointer, current, out current);
                message.AppendInt(LegSecurityType.FixTag, legSecurityType);

                var legSide = LegSide.Decode(pointer, current, out current);
                message.AppendInt(LegSide.FixTag, legSide);

                current += Pad6.Length;

            }
        }
    }
}