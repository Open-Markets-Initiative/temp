using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Remaining Risk Allowance Base Long: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class RemainingRiskAllowanceBaseLong
    {
        /// <summary>
        ///  Length of Remaining Risk Allowance Base Long in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Remaining Risk Allowance Base Long
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Remaining Risk Allowance Base Long
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + RemainingRiskAllowanceBaseLong.Length)
            {
                throw new System.Exception("Invalid Length for Remaining Risk Allowance Base Long");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Remaining Risk Allowance Base Long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + RemainingRiskAllowanceBaseLong.Length;
        }

        /// <summary>
        ///  TryDecode Remaining Risk Allowance Base Long
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + RemainingRiskAllowanceBaseLong.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Remaining Risk Allowance Base Long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RemainingRiskAllowanceBaseLong.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Remaining Risk Allowance Base Long
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}