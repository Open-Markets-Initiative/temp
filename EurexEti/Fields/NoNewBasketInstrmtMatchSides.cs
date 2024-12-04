using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No New Basket Instrmt Match Sides: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoNewBasketInstrmtMatchSides
    {
        /// <summary>
        ///  Fix Tag for No New Basket Instrmt Match Sides
        /// </summary>
        public const ushort FixTag = 25251;

        /// <summary>
        ///  Length of No New Basket Instrmt Match Sides in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No New Basket Instrmt Match Sides
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoNewBasketInstrmtMatchSides.Length)
            {
                throw new System.Exception("Invalid Length for No New Basket Instrmt Match Sides");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No New Basket Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoNewBasketInstrmtMatchSides.Length;
        }

        /// <summary>
        ///  Encode No New Basket Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No New Basket Instrmt Match Sides
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoNewBasketInstrmtMatchSides.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No New Basket Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoNewBasketInstrmtMatchSides.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No New Basket Instrmt Match Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}