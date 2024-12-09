using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Not Affected Securities Grp Comp Message Methods
    /// </summary>

    public static partial class NotAffectedSecuritiesGrpComp
    {
        /// <summary>
        ///  Fix Tag for Not Affected Securities Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39120;

        /// <summary>
        ///  Encode Not Affected Securities Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup notAffectedSecuritiesGrpComp, out int current)
        {
            current = offset;

            foreach (var group in notAffectedSecuritiesGrpComp.sectionList)
            {
                var notAffectedSecurityId = group.GetULong(NotAffectedSecurityId.FixTag);
                NotAffectedSecurityId.Encode(pointer, current, notAffectedSecurityId, out current);

            }
        }

        /// <summary>
        ///  Decode Not Affected Securities Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(NoNotAffectedSecurities.FixTag, count);

            while (count-- > 0)
            {
                var notAffectedSecurityId = NotAffectedSecurityId.Decode(pointer, current, out current);
                message.AppendULong(NotAffectedSecurityId.FixTag, notAffectedSecurityId);

            }
        }
    }
}