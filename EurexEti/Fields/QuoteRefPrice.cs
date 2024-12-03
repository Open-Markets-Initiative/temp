using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Ref Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class QuoteRefPrice
    {
        /// <summary>
        ///  Fix Tag for Quote Ref Price
        /// </summary>
        public const ushort FixTag = 28759;

        /// <summary>
        ///  Length of Quote Ref Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Quote Ref Price
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Quote Ref Price
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + QuoteRefPrice.Length)
            {
                throw new System.Exception("Invalid Length for Quote Ref Price");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Ref Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + QuoteRefPrice.Length;
        }

        /// <summary>
        ///  TryDecode Quote Ref Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + QuoteRefPrice.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Ref Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteRefPrice.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Ref Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}