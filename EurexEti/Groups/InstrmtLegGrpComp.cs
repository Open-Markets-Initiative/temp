using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Instrmt Leg Grp Comp Message Methods
    /// </summary>

    public static partial class InstrmtLegGrpComp
    {
        /// <summary>
        ///  Fix Tag for Instrmt Leg Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39111;

        /// <summary>
        ///  Encode Instrmt Leg Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup instrmtLegGrpComp, out int current)
        {
            current = offset;

            foreach (var group in instrmtLegGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoLegOnbooks.FixTag, count);

            while (count-- > 0)
            {
                var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);

                var legPrice = LegPrice.Decode(pointer, current, out current);
                message.AppendDouble(LegPrice.FixTag, legPrice);

                var legSymbol = LegSymbol.Decode(pointer, current, out current);
                message.AppendInt(LegSymbol.FixTag, legSymbol);

                var legRatioQty = (int)LegRatioQty.Decode(pointer, current, out current);
                message.AppendInt(LegRatioQty.FixTag, legRatioQty);

                var legSide = LegSide.Decode(pointer, current, out current);
                message.AppendInt(LegSide.FixTag, legSide);

                var legSecurityType = LegSecurityType.Decode(pointer, current, out current);
                message.AppendInt(LegSecurityType.FixTag, legSecurityType);

                current += Pad6.Length;

            }
        }
    }
}