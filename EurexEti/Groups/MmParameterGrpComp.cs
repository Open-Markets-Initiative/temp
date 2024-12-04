using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mm Parameter Grp Comp Message Methods
    /// </summary>

    public partial class MmParameterGrpComp
    {
        /// <summary>
        ///  Fix Tag for Mm Parameter Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39116;

        /// <summary>
        ///  Length of Mm Parameter Grp Comp in bytes
        /// </summary>
        public const int Length = 48;

        /// <summary>
        ///  Encode Mm Parameter Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

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

                var mmRiskLimitActionType = (byte)group.GetInt(MmRiskLimitActionType.FixTag);
                MmRiskLimitActionType.Encode(pointer, current, mmRiskLimitActionType, out current);

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Mm Parameter Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            MmParameterGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}