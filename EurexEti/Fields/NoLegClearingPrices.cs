using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Leg Clearing Prices: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoLegClearingPrices
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
        ///  TryDecode No Leg Clearing Prices
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoLegClearingPrices.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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