using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Exec Grp Comp Message Methods
    /// </summary>

    public partial class BasketExecGrpComp
    {
        /// <summary>
        ///  Fix Tag for Basket Exec Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39101;

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

            BasketExecGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}