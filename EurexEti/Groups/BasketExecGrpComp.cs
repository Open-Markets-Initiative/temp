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
                if (group.TryGetInt(PackageId.FixTag, out var packageId))
                {
                    PackageId.Encode(pointer, current, (uint)packageId, out current);
                }
                else
                {
                    PackageId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(SideMarketSegmentId.FixTag, out var sideMarketSegmentId))
                {
                    SideMarketSegmentId.Encode(pointer, current, sideMarketSegmentId, out current);
                }
                else
                {
                    SideMarketSegmentId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(AllocId.FixTag, out var allocId))
                {
                    AllocId.Encode(pointer, current, (uint)allocId, out current);
                }
                else
                {
                    AllocId.SetNull(pointer, current, out current);
                }

                if (group.TryGetInt(SideTrdSubTyp.FixTag, out var sideTrdSubTyp))
                {
                    SideTrdSubTyp.Encode(pointer, current, (ushort)sideTrdSubTyp, out current);
                }
                else
                {
                    SideTrdSubTyp.SetNull(pointer, current, out current);
                }

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

            message.AppendInt(NoInstrmtMatchSides.FixTag, count);

            while (count-- > 0)
            {
                if (PackageId.TryDecode(pointer, current, out var packageId, out current))
                {
                    message.AppendInt(PackageId.FixTag, (int)packageId);
                }

                if (SideMarketSegmentId.TryDecode(pointer, current, out var sideMarketSegmentId, out current))
                {
                    message.AppendInt(SideMarketSegmentId.FixTag, sideMarketSegmentId);
                }

                if (AllocId.TryDecode(pointer, current, out var allocId, out current))
                {
                    message.AppendInt(AllocId.FixTag, (int)allocId);
                }

                if (SideTrdSubTyp.TryDecode(pointer, current, out var sideTrdSubTyp, out current))
                {
                    message.AppendInt(SideTrdSubTyp.FixTag, (short)sideTrdSubTyp);
                }

                current += Pad2.Length;

            }
        }
    }
}