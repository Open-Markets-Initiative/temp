using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limits Rpt Grp Comp Message Methods
    /// </summary>

    public partial class RiskLimitsRptGrpComp
    {
        /// <summary>
        ///  Fix Tag for Risk Limits Rpt Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39133;

        /// <summary>
        ///  Length of Risk Limits Rpt Grp Comp in bytes
        /// </summary>
        public const int Length = 56;

        /// <summary>
        ///  Encode Risk Limits Rpt Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode risk limits rpt grp comp ---

            if (!message.TryGetGroup(RiskLimitsRptGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(RiskLimitsRptGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            RiskLimitsRptGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}