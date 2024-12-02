using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Related Close Price: 8 Byte Fixed Width Integer with 6 Decimal Place Precision
    /// </summary>

    public sealed class RelatedClosePrice
    {
        /// <summary>
        ///  Length of Related Close Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Related Close Price
        /// </summary>
        public const int Factor = 1000000;

        /// <summary>
        ///  Encode Related Close Price
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + RelatedClosePrice.Length)
            {
                throw new System.Exception("Invalid Length for Related Close Price");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Related Close Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + RelatedClosePrice.Length;
        }

        /// <summary>
        ///  TryDecode Related Close Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + RelatedClosePrice.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Related Close Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RelatedClosePrice.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Related Close Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}