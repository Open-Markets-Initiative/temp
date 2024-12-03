using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Leg Ord Grp Comp Message Methods
    /// </summary>

    public partial class LegOrdGrpComp
    {
        /// <summary>
        ///  Length of Leg Ord Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Leg Ord Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode leg ord grp comp ---

            if (!message.TryGetGroup(LegOrdGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(LegOrdGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

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