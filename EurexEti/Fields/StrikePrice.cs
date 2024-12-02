using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Strike Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class StrikePrice
    {
        /// <summary>
        ///  Length of Strike Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Strike Price
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Strike Price
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + StrikePrice.Length)
            {
                throw new System.Exception("Invalid Length for Strike Price");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + StrikePrice.Length;
        }

        /// <summary>
        ///  TryDecode Strike Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + StrikePrice.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + StrikePrice.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Strike Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}