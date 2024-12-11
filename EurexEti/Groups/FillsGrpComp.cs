using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Fills Grp Comp Message Methods
    /// </summary>

    public static partial class FillsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Fills Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39109;

        /// <summary>
        ///  Encode Fills Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup fillsGrpComp, out int current)
        {
            current = offset;

            foreach (var group in fillsGrpComp.sectionList)
            {
                if (group.TryGetDouble(FillPx.FixTag, out var fillPx))
                {
                    FillPx.Encode(pointer, current, fillPx, out current);
                }
                else
                {
                    FillPx.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(FillQty.FixTag, out var fillQty))
                {
                    FillQty.Encode(pointer, current, fillQty, out current);
                }
                else
                {
                    FillQty.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(FillMatchId.FixTag, out var fillMatchId))
                {
                    FillMatchId.Encode(pointer, current, (uint)fillMatchId, out current);
                }
                else
                {
                    FillMatchId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(FillExecId.FixTag, out var fillExecId))
                {
                    FillExecId.Encode(pointer, current, fillExecId, out current);
                }
                else
                {
                    FillExecId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(FillLiquidityInd.FixTag, out var fillLiquidityInd))
                {
                    FillLiquidityInd.Encode(pointer, current, (byte)fillLiquidityInd, out current);
                }
                else
                {
                    FillLiquidityInd.SetNull(pointer, current, out current);
                }

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

            message.AppendInt(NoFills.FixTag, count);

            while (count-- > 0)
            {
                if (FillPx.TryDecode(pointer, current, out var fillPx, out current))
                {
                    message.AppendDouble(FillPx.FixTag, fillPx);
                }

                if (FillQty.TryDecode(pointer, current, out var fillQty, out current))
                {
                    message.AppendDouble(FillQty.FixTag, fillQty);
                }

                if (FillMatchId.TryDecode(pointer, current, out var fillMatchId, out current))
                {
                    message.AppendInt(FillMatchId.FixTag, (int)fillMatchId);
                }

                if (FillExecId.TryDecode(pointer, current, out var fillExecId, out current))
                {
                    message.AppendInt(FillExecId.FixTag, fillExecId);
                }

                if (FillLiquidityInd.TryDecode(pointer, current, out var fillLiquidityInd, out current))
                {
                    message.AppendInt(FillLiquidityInd.FixTag, fillLiquidityInd);
                }

                current += Pad7.Length;

            }
        }
    }
}