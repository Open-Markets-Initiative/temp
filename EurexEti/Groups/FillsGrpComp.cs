using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Fills Grp Comp Message Methods
    /// </summary>

    public partial class FillsGrpComp
    {
        /// <summary>
        ///  Length of Fills Grp Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Fills Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, FillsGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode fills grp comp ---

            if (!message.TryGetGroup(FillsGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(FillsGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode fills grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode fills grp comp group ---

            message.AppendInt(FillsGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
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