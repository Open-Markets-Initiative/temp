using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limits Rpt Grp Comp Message Methods
    /// </summary>

    public static partial class RiskLimitsRptGrpComp
    {
        /// <summary>
        ///  Fix Tag for Risk Limits Rpt Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39133;

        /// <summary>
        ///  Encode Risk Limits Rpt Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup riskLimitsRptGrpComp, out int current)
        {
            current = offset;

            foreach (var group in riskLimitsRptGrpComp.sectionList)
            {
                var riskLimitQty = group.GetDouble(RiskLimitQty.FixTag);
                RiskLimitQty.Encode(pointer, current, riskLimitQty, out current);

                var riskLimitOpenQty = group.GetDouble(RiskLimitOpenQty.FixTag);
                RiskLimitOpenQty.Encode(pointer, current, riskLimitOpenQty, out current);

                var riskLimitNetPositionQty = group.GetDouble(RiskLimitNetPositionQty.FixTag);
                RiskLimitNetPositionQty.Encode(pointer, current, riskLimitNetPositionQty, out current);

                var nettingCoefficient = group.GetDouble(NettingCoefficient.FixTag);
                NettingCoefficient.Encode(pointer, current, nettingCoefficient, out current);

                var quoteWeightingCoefficient = group.GetDouble(QuoteWeightingCoefficient.FixTag);
                QuoteWeightingCoefficient.Encode(pointer, current, quoteWeightingCoefficient, out current);

                var activationDate = (uint)group.GetInt(ActivationDate.FixTag);
                ActivationDate.Encode(pointer, current, activationDate, out current);

                var riskLimitType = (byte)group.GetInt(RiskLimitType.FixTag);
                RiskLimitType.Encode(pointer, current, riskLimitType, out current);

                var riskLimitRequestingPartyRole = (byte)group.GetInt(RiskLimitRequestingPartyRole.FixTag);
                RiskLimitRequestingPartyRole.Encode(pointer, current, riskLimitRequestingPartyRole, out current);

                var riskLimitViolationIndicator = (byte)group.GetInt(RiskLimitViolationIndicator.FixTag);
                RiskLimitViolationIndicator.Encode(pointer, current, riskLimitViolationIndicator, out current);

                if (group.TryGetString(RiskLimitGroup.FixTag, out var riskLimitGroup))
                {
                    RiskLimitGroup.Encode(pointer, current, riskLimitGroup, out current);
                }
                else
                {
                    RiskLimitGroup.SetNull(pointer, current, out current);
                }

                Pad6.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Risk Limits Rpt Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noRiskLimits.FixTag, count);

            while (count--)
            {
                var riskLimitQty = RiskLimitQty.Decode(pointer, current, out current);
                message.AppendDouble(RiskLimitQty.FixTag, riskLimitQty);

                var riskLimitOpenQty = RiskLimitOpenQty.Decode(pointer, current, out current);
                message.AppendDouble(RiskLimitOpenQty.FixTag, riskLimitOpenQty);

                var riskLimitNetPositionQty = RiskLimitNetPositionQty.Decode(pointer, current, out current);
                message.AppendDouble(RiskLimitNetPositionQty.FixTag, riskLimitNetPositionQty);

                var nettingCoefficient = NettingCoefficient.Decode(pointer, current, out current);
                message.AppendDouble(NettingCoefficient.FixTag, nettingCoefficient);

                var quoteWeightingCoefficient = QuoteWeightingCoefficient.Decode(pointer, current, out current);
                message.AppendDouble(QuoteWeightingCoefficient.FixTag, quoteWeightingCoefficient);

                var activationDate = (int)ActivationDate.Decode(pointer, current, out current);
                message.AppendInt(ActivationDate.FixTag, activationDate);

                var riskLimitType = RiskLimitType.Decode(pointer, current, out current);
                message.AppendInt(RiskLimitType.FixTag, riskLimitType);

                var riskLimitRequestingPartyRole = RiskLimitRequestingPartyRole.Decode(pointer, current, out current);
                message.AppendInt(RiskLimitRequestingPartyRole.FixTag, riskLimitRequestingPartyRole);

                var riskLimitViolationIndicator = RiskLimitViolationIndicator.Decode(pointer, current, out current);
                message.AppendInt(RiskLimitViolationIndicator.FixTag, riskLimitViolationIndicator);

                if (RiskLimitGroup.TryDecode(pointer, current, out var riskLimitGroup, out current))
                {
                    message.AppendString(RiskLimitGroup.FixTag, riskLimitGroup);
                }

                current += Pad6.Length;

            }
        }
    }
}