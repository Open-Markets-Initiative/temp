using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Qty Grp Comp Message Methods
    /// </summary>

    public partial static class RiskLimitQtyGrpComp
    {
        /// <summary>
        ///  Fix Tag for Risk Limit Qty Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39132;

        /// <summary>
        ///  Encode Risk Limit Qty Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int riskLimitQtyGrpComp, out int current)
        {
            current = offset;

            foreach (var group in riskLimitQtyGrpComp.sectionList)
            {
                var riskLimitQty = group.GetDouble(RiskLimitQty.FixTag);
                RiskLimitQty.Encode(pointer, current, riskLimitQty, out current);

                var riskLimitType = (byte)group.GetInt(RiskLimitType.FixTag);
                RiskLimitType.Encode(pointer, current, riskLimitType, out current);

                Pad7.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Risk Limit Qty Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noRiskLimitsQty.FixTag, count);

            while (count--)
            {
                var riskLimitQty = RiskLimitQty.Decode(pointer, current, out current);
                message.AppendDouble(RiskLimitQty.FixTag, riskLimitQty);

                var riskLimitType = RiskLimitType.Decode(pointer, current, out current);
                message.AppendInt(RiskLimitType.FixTag, riskLimitType);

                current += Pad7.Length;

            }
        }
    }
}