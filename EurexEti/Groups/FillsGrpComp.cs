using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Fills Grp Comp Message Methods
    /// </summary>

    public partial class FillsGrpComp
    {
        /// <summary>
        ///  Fix Tag for Fills Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39109;

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

            // --- TODO ---

            FillsGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}