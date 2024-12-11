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
                if (group.TryGetDouble(RiskLimitQty.FixTag, out var riskLimitQty))
                {
                    RiskLimitQty.Encode(pointer, current, riskLimitQty, out current);
                }
                else
                {
                    RiskLimitQty.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(RiskLimitOpenQty.FixTag, out var riskLimitOpenQty))
                {
                    RiskLimitOpenQty.Encode(pointer, current, riskLimitOpenQty, out current);
                }
                else
                {
                    RiskLimitOpenQty.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(RiskLimitNetPositionQty.FixTag, out var riskLimitNetPositionQty))
                {
                    RiskLimitNetPositionQty.Encode(pointer, current, riskLimitNetPositionQty, out current);
                }
                else
                {
                    RiskLimitNetPositionQty.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(NettingCoefficient.FixTag, out var nettingCoefficient))
                {
                    NettingCoefficient.Encode(pointer, current, nettingCoefficient, out current);
                }
                else
                {
                    NettingCoefficient.SetNull(pointer, current, out current);
                }

                if (group.TryGetDouble(QuoteWeightingCoefficient.FixTag, out var quoteWeightingCoefficient))
                {
                    QuoteWeightingCoefficient.Encode(pointer, current, quoteWeightingCoefficient, out current);
                }
                else
                {
                    QuoteWeightingCoefficient.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(ActivationDate.FixTag, out var activationDate))
                {
                    ActivationDate.Encode(pointer, current, (uint)activationDate, out current);
                }
                else
                {
                    ActivationDate.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(RiskLimitType.FixTag, out var riskLimitType))
                {
                    RiskLimitType.Encode(pointer, current, (byte)riskLimitType, out current);
                }
                else
                {
                    RiskLimitType.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(RiskLimitRequestingPartyRole.FixTag, out var riskLimitRequestingPartyRole))
                {
                    RiskLimitRequestingPartyRole.Encode(pointer, current, (byte)riskLimitRequestingPartyRole, out current);
                }
                else
                {
                    RiskLimitRequestingPartyRole.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(RiskLimitViolationIndicator.FixTag, out var riskLimitViolationIndicator))
                {
                    RiskLimitViolationIndicator.Encode(pointer, current, (byte)riskLimitViolationIndicator, out current);
                }
                else
                {
                    RiskLimitViolationIndicator.SetNull(pointer, current, out current);
                }

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

            message.AppendInt(NoRiskLimits.FixTag, count);

            while (count-- > 0)
            {
                if (RiskLimitQty.TryDecode(pointer, current, out var riskLimitQty, out current))
                {
                    message.AppendDouble(RiskLimitQty.FixTag, riskLimitQty);
                }

                if (RiskLimitOpenQty.TryDecode(pointer, current, out var riskLimitOpenQty, out current))
                {
                    message.AppendDouble(RiskLimitOpenQty.FixTag, riskLimitOpenQty);
                }

                if (RiskLimitNetPositionQty.TryDecode(pointer, current, out var riskLimitNetPositionQty, out current))
                {
                    message.AppendDouble(RiskLimitNetPositionQty.FixTag, riskLimitNetPositionQty);
                }

                if (NettingCoefficient.TryDecode(pointer, current, out var nettingCoefficient, out current))
                {
                    message.AppendDouble(NettingCoefficient.FixTag, nettingCoefficient);
                }

                if (QuoteWeightingCoefficient.TryDecode(pointer, current, out var quoteWeightingCoefficient, out current))
                {
                    message.AppendDouble(QuoteWeightingCoefficient.FixTag, quoteWeightingCoefficient);
                }

                if (ActivationDate.TryDecode(pointer, current, out var activationDate, out current))
                {
                    message.AppendInt(ActivationDate.FixTag, (int)activationDate);
                }

                if (RiskLimitType.TryDecode(pointer, current, out var riskLimitType, out current))
                {
                    message.AppendInt(RiskLimitType.FixTag, riskLimitType);
                }

                if (RiskLimitRequestingPartyRole.TryDecode(pointer, current, out var riskLimitRequestingPartyRole, out current))
                {
                    message.AppendInt(RiskLimitRequestingPartyRole.FixTag, riskLimitRequestingPartyRole);
                }

                if (RiskLimitViolationIndicator.TryDecode(pointer, current, out var riskLimitViolationIndicator, out current))
                {
                    message.AppendInt(RiskLimitViolationIndicator.FixTag, riskLimitViolationIndicator);
                }

                if (RiskLimitGroup.TryDecode(pointer, current, out var riskLimitGroup, out current))
                {
                    message.AppendString(RiskLimitGroup.FixTag, riskLimitGroup);
                }

                current += Pad6.Length;

            }
        }
    }
}