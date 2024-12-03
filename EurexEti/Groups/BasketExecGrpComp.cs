using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Basket Exec Grp Comp Message Methods
    /// </summary>

    public partial class BasketExecGrpComp
    {
        /// <summary>
        ///  Length of Basket Exec Grp Comp in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Basket Exec Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode basket exec grp comp ---

            if (!message.TryGetGroup(BasketExecGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(BasketExecGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                var packageId = (uint)group.GetInt(PackageId.FixTag);
                PackageId.Encode(pointer, current, packageId, out current);

                var sideMarketSegmentId = group.GetInt(SideMarketSegmentId.FixTag);
                SideMarketSegmentId.Encode(pointer, current, sideMarketSegmentId, out current);

                var allocId = (uint)group.GetInt(AllocId.FixTag);
                AllocId.Encode(pointer, current, allocId, out current);

                var sideTrdSubTyp = (ushort)group.GetInt(SideTrdSubTyp.FixTag);
                SideTrdSubTyp.Encode(pointer, current, sideTrdSubTyp, out current);

                Pad2.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Basket Exec Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            var packageId = (int)PackageId.Decode(pointer, current, out current);
            message.AppendInt(PackageId.FixTag, packageId);

            var sideMarketSegmentId = SideMarketSegmentId.Decode(pointer, current, out current);
            message.AppendInt(SideMarketSegmentId.FixTag, sideMarketSegmentId);

            var allocId = (int)AllocId.Decode(pointer, current, out current);
            message.AppendInt(AllocId.FixTag, allocId);

            var sideTrdSubTyp = (short)SideTrdSubTyp.Decode(pointer, current, out current);
            message.AppendInt(SideTrdSubTyp.FixTag, sideTrdSubTyp);

            current += Pad2.Length;

        }
    }
}