using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Fills Grp Comp Message Methods
    /// </summary>

    public partial static class FillsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Fills Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39109;

        /// <summary>
        ///  Encode Fills Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int fillsGrpComp, out int current)
        {
            current = offset;

            foreach (var group in fillsGrpComp.sectionList)
            {
                var fillPx = group.GetDouble(FillPx.FixTag);
                FillPx.Encode(pointer, current, fillPx, out current);

                var fillQty = group.GetDouble(FillQty.FixTag);
                FillQty.Encode(pointer, current, fillQty, out current);

                var fillMatchId = (uint)group.GetInt(FillMatchId.FixTag);
                FillMatchId.Encode(pointer, current, fillMatchId, out current);

                var fillExecId = group.GetInt(FillExecId.FixTag);
                FillExecId.Encode(pointer, current, fillExecId, out current);

                var fillLiquidityInd = (byte)group.GetInt(FillLiquidityInd.FixTag);
                FillLiquidityInd.Encode(pointer, current, fillLiquidityInd, out current);

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Fills Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noFills.FixTag, count);

            while (count--)
            {
                var fillPx = FillPx.Decode(pointer, current, out current);
                message.AppendDouble(FillPx.FixTag, fillPx);

                var fillQty = FillQty.Decode(pointer, current, out current);
                message.AppendDouble(FillQty.FixTag, fillQty);

                var fillMatchId = (int)FillMatchId.Decode(pointer, current, out current);
                message.AppendInt(FillMatchId.FixTag, fillMatchId);

                var fillExecId = FillExecId.Decode(pointer, current, out current);
                message.AppendInt(FillExecId.FixTag, fillExecId);

                var fillLiquidityInd = FillLiquidityInd.Decode(pointer, current, out current);
                message.AppendInt(FillLiquidityInd.FixTag, fillLiquidityInd);

                current += Pad7.Length;

            }
        }
    }
}