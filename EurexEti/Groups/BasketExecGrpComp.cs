using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Exec Grp Comp Message Methods
    /// </summary>

    public static partial class BasketExecGrpComp
    {
        /// <summary>
        ///  Fix Tag for Basket Exec Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39101;

        /// <summary>
        ///  Encode Basket Exec Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup basketExecGrpComp, out int current)
        {
            current = offset;

            foreach (var group in basketExecGrpComp.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noInstrmtMatchSides.FixTag, count);

            while (count--)
            {
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
}