using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Not Affected Orders Grp Comp Message Methods
    /// </summary>

    public static partial class NotAffectedOrdersGrpComp
    {
        /// <summary>
        ///  Fix Tag for Not Affected Orders Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39119;

        /// <summary>
        ///  Encode Not Affected Orders Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup notAffectedOrdersGrpComp, out int current)
        {
            current = offset;

            foreach (var group in notAffectedOrdersGrpComp.sectionList)
            {
                var notAffectedOrderId = group.GetULong(NotAffectedOrderId.FixTag);
                NotAffectedOrderId.Encode(pointer, current, notAffectedOrderId, out current);

                var notAffOrigClOrdId = group.GetULong(NotAffOrigClOrdId.FixTag);
                NotAffOrigClOrdId.Encode(pointer, current, notAffOrigClOrdId, out current);

            }
        }

        /// <summary>
        ///  Decode Not Affected Orders Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noNotAffectedOrders.FixTag, count);

            while (count--)
            {
                var notAffectedOrderId = NotAffectedOrderId.Decode(pointer, current, out current);
                message.AppendULong(NotAffectedOrderId.FixTag, notAffectedOrderId);

                var notAffOrigClOrdId = NotAffOrigClOrdId.Decode(pointer, current, out current);
                message.AppendULong(NotAffOrigClOrdId.FixTag, notAffOrigClOrdId);

            }
        }
    }
}