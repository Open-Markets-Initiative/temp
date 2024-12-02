using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Risk Limit Qty Grp Comp Message Methods
    /// </summary>

    public partial class RiskLimitQtyGrpComp
    {
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

            // --- encode group header ---

            BlockLength.Encode(pointer, current, RiskLimitQtyGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

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

            // --- decode risk limit qty grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode risk limit qty grp comp group ---

            message.AppendInt(RiskLimitQtyGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
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