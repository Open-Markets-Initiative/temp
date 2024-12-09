using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Instrmnt Leg Exec Grp Comp Message Methods
    /// </summary>

    public partial static class InstrmntLegExecGrpComp
    {
        /// <summary>
        ///  Fix Tag for Instrmnt Leg Exec Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39110;

        /// <summary>
        ///  Encode Instrmnt Leg Exec Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int instrmntLegExecGrpComp, out int current)
        {
            current = offset;

            foreach (var group in instrmntLegExecGrpComp.sectionList)
            {
                var legSecurityId = group.GetLong(LegSecurityId.FixTag);
                LegSecurityId.Encode(pointer, current, legSecurityId, out current);

                var legLastPx = group.GetDouble(LegLastPx.FixTag);
                LegLastPx.Encode(pointer, current, legLastPx, out current);

                var legLastQty = group.GetDouble(LegLastQty.FixTag);
                LegLastQty.Encode(pointer, current, legLastQty, out current);

                var legExecId = group.GetInt(LegExecId.FixTag);
                LegExecId.Encode(pointer, current, legExecId, out current);

                var legSide = (byte)group.GetInt(LegSide.FixTag);
                LegSide.Encode(pointer, current, legSide, out current);

                var fillRefId = (byte)group.GetInt(FillRefId.FixTag);
                FillRefId.Encode(pointer, current, fillRefId, out current);

                Pad2.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Instrmnt Leg Exec Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noLegExecs.FixTag, count);

            while (count--)
            {
                var legSecurityId = LegSecurityId.Decode(pointer, current, out current);
                message.AppendLong(LegSecurityId.FixTag, legSecurityId);

                var legLastPx = LegLastPx.Decode(pointer, current, out current);
                message.AppendDouble(LegLastPx.FixTag, legLastPx);

                var legLastQty = LegLastQty.Decode(pointer, current, out current);
                message.AppendDouble(LegLastQty.FixTag, legLastQty);

                var legExecId = LegExecId.Decode(pointer, current, out current);
                message.AppendInt(LegExecId.FixTag, legExecId);

                var legSide = LegSide.Decode(pointer, current, out current);
                message.AppendInt(LegSide.FixTag, legSide);

                var fillRefId = FillRefId.Decode(pointer, current, out current);
                message.AppendInt(FillRefId.FixTag, fillRefId);

                current += Pad2.Length;

            }
        }
    }
}