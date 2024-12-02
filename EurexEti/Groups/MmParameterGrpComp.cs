using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mm Parameter Grp Comp Message Methods
    /// </summary>

    public partial class MmParameterGrpComp
    {
        /// <summary>
        ///  Length of Mm Parameter Grp Comp in bytes
        /// </summary>
        public const int Length = 40;

        /// <summary>
        ///  Encode Mm Parameter Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, MmParameterGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode mm parameter grp comp ---

            if (!message.TryGetGroup(MmParameterGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(MmParameterGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var exposureDuration = group.GetLong(ExposureDuration.FixTag);
                ExposureDuration.Encode(pointer, current, exposureDuration, out current);

                var cumQty = group.GetDouble(CumQty.FixTag);
                CumQty.Encode(pointer, current, cumQty, out current);

                var delta = group.GetDouble(Delta.FixTag);
                Delta.Encode(pointer, current, delta, out current);

                var vega = group.GetDouble(Vega.FixTag);
                Vega.Encode(pointer, current, vega, out current);

                var pctCount = group.GetInt(PctCount.FixTag);
                PctCount.Encode(pointer, current, pctCount, out current);

                var targetPartyIdSessionId = (uint)group.GetInt(TargetPartyIdSessionId.FixTag);
                TargetPartyIdSessionId.Encode(pointer, current, targetPartyIdSessionId, out current);

            }
        }

        /// <summary>
        ///  Decode Mm Parameter Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode mm parameter grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode mm parameter grp comp group ---

            message.AppendInt(MmParameterGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
            {
                var exposureDuration = ExposureDuration.Decode(pointer, current, out current);
                message.AppendLong(ExposureDuration.FixTag, exposureDuration);

                var cumQty = CumQty.Decode(pointer, current, out current);
                message.AppendDouble(CumQty.FixTag, cumQty);

                var delta = Delta.Decode(pointer, current, out current);
                message.AppendDouble(Delta.FixTag, delta);

                var vega = Vega.Decode(pointer, current, out current);
                message.AppendDouble(Vega.FixTag, vega);

                var pctCount = PctCount.Decode(pointer, current, out current);
                message.AppendInt(PctCount.FixTag, pctCount);

                var targetPartyIdSessionId = (int)TargetPartyIdSessionId.Decode(pointer, current, out current);
                message.AppendInt(TargetPartyIdSessionId.FixTag, targetPartyIdSessionId);

            }
        }
    }
}