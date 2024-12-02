using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Instrmnt Leg Exec Grp Comp Message Methods
    /// </summary>

    public partial class InstrmntLegExecGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, InstrmntLegExecGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode instrmnt leg exec grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode instrmnt leg exec grp comp group ---

            message.AppendInt(InstrmntLegExecGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
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