using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mm Parameter Grp Comp Message Methods
    /// </summary>

    public static partial class MmParameterGrpComp
    {
        /// <summary>
        ///  Fix Tag for Mm Parameter Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39116;

        /// <summary>
        ///  Encode Mm Parameter Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup mmParameterGrpComp, out int current)
        {
            current = offset;

            foreach (var group in mmParameterGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noMmParameters.FixTag, count);

            while (count--)
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

                var mmRiskLimitActionType = MmRiskLimitActionType.Decode(pointer, current, out current);
                message.AppendInt(MmRiskLimitActionType.FixTag, mmRiskLimitActionType);

                current += Pad7.Length;

            }
        }
    }
}