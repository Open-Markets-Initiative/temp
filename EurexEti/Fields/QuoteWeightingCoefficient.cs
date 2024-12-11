using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Weighting Coefficient: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public static class QuoteWeightingCoefficient
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
        public const ulong Factor = 10000;

        /// <summary>
        ///  Null value for Quote Weighting Coefficient
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

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
        ///  Check available length and set Quote Weighting Coefficient to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuoteWeightingCoefficient.Length)
            {
                throw new System.Exception("Invalid Length for Quote Weighting Coefficient");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quote Weighting Coefficient to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuoteWeightingCoefficient.Length;
        }

        /// <summary>
        ///  Set Quote Weighting Coefficient to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quote Weighting Coefficient
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + QuoteWeightingCoefficient.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quote Weighting Coefficient
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(long*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + QuoteWeightingCoefficient.Length;

            return result;
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