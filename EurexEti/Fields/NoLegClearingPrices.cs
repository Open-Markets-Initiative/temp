using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Leg Clearing Prices: Runtime Count Field
    /// </summary>

    public static class NoLegClearingPrices
    {
        /// <summary>
        ///  Fix Tag for No Leg Clearing Prices
        /// </summary>
        public const ushort FixTag = 31555;

        /// <summary>
        ///  Length of No Leg Clearing Prices in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Leg Clearing Prices
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoLegClearingPrices.Length)
            {
                throw new System.Exception("Invalid Length for No Leg Clearing Prices");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Leg Clearing Prices
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoLegClearingPrices.Length;
        }

        /// <summary>
        ///  Encode No Leg Clearing Prices
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set No Leg Clearing Prices to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoLegClearingPrices.Length)
            {
                throw new System.Exception("Invalid Length for No Leg Clearing Prices");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No Leg Clearing Prices to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoLegClearingPrices.Length;
        }

        /// <summary>
        ///  Set No Leg Clearing Prices to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No Leg Clearing Prices
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoLegClearingPrices.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No Leg Clearing Prices
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
        }

        /// <summary>
        ///  Decode No Leg Clearing Prices
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoLegClearingPrices.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Leg Clearing Prices
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}