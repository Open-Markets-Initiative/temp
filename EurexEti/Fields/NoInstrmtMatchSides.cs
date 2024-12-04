using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Instrmt Match Sides: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoInstrmtMatchSides
    {
        /// <summary>
        ///  Fix Tag for No Instrmt Match Sides
        /// </summary>
        public const ushort FixTag = 1889;

        /// <summary>
        ///  Length of No Instrmt Match Sides in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Instrmt Match Sides
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoInstrmtMatchSides.Length)
            {
                throw new System.Exception("Invalid Length for No Instrmt Match Sides");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoInstrmtMatchSides.Length;
        }

        /// <summary>
        ///  Encode No Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Instrmt Match Sides
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoInstrmtMatchSides.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoInstrmtMatchSides.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}