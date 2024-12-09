using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No New Basket Instrmt Match Sides: Runtime Count Field
    /// </summary>

    public static class NoNewBasketInstrmtMatchSides
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
        ///  Check available length and set No New Basket Instrmt Match Sides to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoNewBasketInstrmtMatchSides.Length)
            {
                throw new System.Exception("Invalid Length for No New Basket Instrmt Match Sides");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No New Basket Instrmt Match Sides to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoNewBasketInstrmtMatchSides.Length;
        }

        /// <summary>
        ///  Set No New Basket Instrmt Match Sides to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No New Basket Instrmt Match Sides
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoNewBasketInstrmtMatchSides.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No New Basket Instrmt Match Sides
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
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