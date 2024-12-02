using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Margin Based Risk Limit Long: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class MarginBasedRiskLimitLong
    {
        /// <summary>
        ///  Length of Margin Based Risk Limit Long in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Margin Based Risk Limit Long
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Margin Based Risk Limit Long
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + MarginBasedRiskLimitLong.Length)
            {
                throw new System.Exception("Invalid Length for Margin Based Risk Limit Long");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Margin Based Risk Limit Long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + MarginBasedRiskLimitLong.Length;
        }

        /// <summary>
        ///  TryDecode Margin Based Risk Limit Long
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + MarginBasedRiskLimitLong.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Margin Based Risk Limit Long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MarginBasedRiskLimitLong.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Margin Based Risk Limit Long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}