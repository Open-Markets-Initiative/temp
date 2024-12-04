using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Underlying Stip Grp Comp Message Methods
    /// </summary>

    public partial class UnderlyingStipGrpComp
    {
        /// <summary>
        ///  Fix Tag for Underlying Stip Grp Comp (Generated)
        /// </summary>
        public const ushort FixTag = 39149;

        /// <summary>
        ///  Length of Underlying Stip Grp Comp in bytes
        /// </summary>
        public const int Length = 40;

        /// <summary>
        ///  Encode Underlying Stip Grp Comp
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, byte numInGroup, out int current)
        {
            current = offset;

            // --- encode underlying stip grp comp ---

            if (!message.TryGetGroup(UnderlyingStipGrpComp.FixTag, out var groups))
            {
                throw SessionReject.MissingRepeatingGroup(UnderlyingStipGrpComp.FixTag, message);
            }

            foreach (var group in groups.sectionList)
            {
                if (group.TryGetString(UnderlyingStipValue.FixTag, out var underlyingStipValue))
                {
                    UnderlyingStipValue.Encode(pointer, current, underlyingStipValue, out current);
                }
                else
                {
                    UnderlyingStipValue.SetNull(pointer, current, out current);
                }

                if (group.TryGetToken(UnderlyingStipType.FixTag, out var underlyingStipType))
                {
                    UnderlyingStipType.Encode(pointer, current, underlyingStipType, out current);
                }
                else
                {
                    UnderlyingStipType.SetNull(pointer, current, out current);
                }

                Pad1.Encode(pointer, current, out current);

            }
        }

        /// <summary>
        ///  Decode Underlying Stip Grp Comp
        /// </summary>
        public static unsafe void Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            // --- TODO ---

            UnderlyingStipGrpComp.Decode(ref message, pointer, current, out current);

        }
    }
}