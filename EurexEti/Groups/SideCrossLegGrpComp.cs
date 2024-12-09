using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Cross Leg Grp Comp Message Methods
    /// </summary>

    public partial static class SideCrossLegGrpComp
    {
        /// <summary>
        ///  Fix Tag for Side Cross Leg Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39140;

        /// <summary>
        ///  Encode Side Cross Leg Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int sideCrossLegGrpComp, out int current)
        {
            current = offset;

            foreach (var group in sideCrossLegGrpComp.sectionList)
            {
                var legInputSource = (byte)group.GetInt(LegInputSource.FixTag);
                LegInputSource.Encode(pointer, current, legInputSource, out current);

                var legPositionEffect = group.GetToken(LegPositionEffect.FixTag);
                LegPositionEffect.Encode(pointer, current, legPositionEffect, out current);

                if (group.TryGetString(LegAccount.FixTag, out var legAccount))
                {
                    LegAccount.Encode(pointer, current, legAccount, out current);
                }
                else
                {
                    LegAccount.SetNull(pointer, current, out current);
                }

                Pad4.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Side Cross Leg Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, int count, out int current)
        {
            current = offset;

            if (count < 1)
            {
                return;
            }

            message.AppendInt(noCrossLegs.FixTag, count);

            while (count--)
            {
                var legInputSource = LegInputSource.Decode(pointer, current, out current);
                message.AppendInt(LegInputSource.FixTag, legInputSource);

                var legPositionEffect = LegPositionEffect.Decode(pointer, current, out current);
                message.AppendToken(LegPositionEffect.FixTag, legPositionEffect);

                if (LegAccount.TryDecode(pointer, current, out var legAccount, out current))
                {
                    message.AppendString(LegAccount.FixTag, legAccount);
                }

                current += Pad4.Length;

            }
        }
    }
}