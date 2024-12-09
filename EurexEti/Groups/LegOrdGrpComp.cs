using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leg Ord Grp Comp Message Methods
    /// </summary>

    public static partial class LegOrdGrpComp
    {
        /// <summary>
        ///  Fix Tag for Leg Ord Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39115;

        /// <summary>
        ///  Encode Leg Ord Grp Comp
        /// </summary>
        public static unsafe void Encode(byte* pointer, int offset, FixRepeatGroup legOrdGrpComp, out int current)
        {
            current = offset;

            foreach (var group in legOrdGrpComp.sectionList)
            {
                if (group.TryGetString(LegAccount.FixTag, out var legAccount))
                {
                    LegAccount.Encode(pointer, current, legAccount, out current);
                }
                else
                {
                    LegAccount.SetNull(pointer, current, out current);
                }

                var legPositionEffect = group.GetToken(LegPositionEffect.FixTag);
                LegPositionEffect.Encode(pointer, current, legPositionEffect, out current);

                Pad5.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Leg Ord Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noLegOnbooks.FixTag, count);

            while (count--)
            {
                if (LegAccount.TryDecode(pointer, current, out var legAccount, out current))
                {
                    message.AppendString(LegAccount.FixTag, legAccount);
                }

                var legPositionEffect = LegPositionEffect.Decode(pointer, current, out current);
                message.AppendToken(LegPositionEffect.FixTag, legPositionEffect);

                current += Pad5.Length;

            }
        }
    }
}