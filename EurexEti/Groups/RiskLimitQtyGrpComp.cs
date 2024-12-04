using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Risk Limit Qty Grp Comp Message Methods
    /// </summary>

    public partial class RiskLimitQtyGrpComp
    {
        /// <summary>
        ///  Fix Tag for Risk Limit Qty Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39132;

        /// <summary>
        ///  Length of Risk Limit Qty Grp Comp in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Risk Limit Qty Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode risk limit qty grp comp ---

            if (!message.TryGetGroup(RiskLimitQtyGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(RiskLimitQtyGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            RiskLimitQtyGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}