using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Maximum Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class MaximumPrice
    {
        /// <summary>
        ///  Fix Tag for Maximum Price
        /// </summary>
        public const ushort FixTag = 28773;

        /// <summary>
        ///  Length of Maximum Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Maximum Price
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Maximum Price
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + MaximumPrice.Length)
            {
                throw new System.Exception("Invalid Length for Maximum Price");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Maximum Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + MaximumPrice.Length;
        }

        /// <summary>
        ///  TryDecode Maximum Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + MaximumPrice.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Maximum Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MaximumPrice.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Maximum Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}