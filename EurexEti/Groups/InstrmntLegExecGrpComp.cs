using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Instrmnt Leg Exec Grp Comp Message Methods
    /// </summary>

    public partial class InstrmntLegExecGrpComp
    {
        /// <summary>
        ///  Fix Tag for Instrmnt Leg Exec Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39110;

        /// <summary>
        ///  Length of Instrmnt Leg Exec Grp Comp in bytes
        /// </summary>
        public const int Length = 32;

        /// <summary>
        ///  Encode Instrmnt Leg Exec Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode instrmnt leg exec grp comp ---

            if (!message.TryGetGroup(InstrmntLegExecGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(InstrmntLegExecGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            InstrmntLegExecGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}