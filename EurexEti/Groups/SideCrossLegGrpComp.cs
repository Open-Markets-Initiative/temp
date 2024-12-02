using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Side Cross Leg Grp Comp Message Methods
    /// </summary>

    public partial class SideCrossLegGrpComp
    {
        /// <summary>
        ///  Length of Side Cross Leg Grp Comp in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Side Cross Leg Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode group header ---

            BlockLength.Encode(pointer, current, SideCrossLegGrpComp.Length, out current);

            NumInGroup.Encode(pointer, current, numInGroup, out current);

            if (numInGroup == 0) { return; }

            // --- encode side cross leg grp comp ---

            if (!message.TryGetGroup(SideCrossLegGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(SideCrossLegGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
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
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- decode side cross leg grp comp ---

            var blockLength = BlockLength.Decode(pointer, current, out current);

            var numInGroup = (int)NumInGroup.Decode(pointer, current, out current);

            if (numInGroup == 0) { return; }

            // --- decode side cross leg grp comp group ---

            message.AppendInt(SideCrossLegGrpComp.FixTag, numInGroup);

            for (var i = 0; i < numInGroup; i++)
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