using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Weighting Coefficient: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class QuoteWeightingCoefficient
    {
        /// <summary>
        ///  Fix Tag for Quote Weighting Coefficient
        /// </summary>
        public const ushort FixTag = 25210;

        /// <summary>
        ///  Length of Quote Weighting Coefficient in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Quote Weighting Coefficient
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Quote Weighting Coefficient
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + QuoteWeightingCoefficient.Length)
            {
                throw new System.Exception("Invalid Length for Quote Weighting Coefficient");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Weighting Coefficient
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + QuoteWeightingCoefficient.Length;
        }

        /// <summary>
        ///  TryDecode Quote Weighting Coefficient
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + QuoteWeightingCoefficient.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Weighting Coefficient
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteWeightingCoefficient.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Weighting Coefficient
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}