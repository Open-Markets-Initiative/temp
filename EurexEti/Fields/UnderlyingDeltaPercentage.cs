using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Underlying Delta Percentage: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class UnderlyingDeltaPercentage
    {
        /// <summary>
        ///  Fix Tag for Underlying Delta Percentage
        /// </summary>
        public const ushort FixTag = 25149;

        /// <summary>
        ///  Length of Underlying Delta Percentage in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Underlying Delta Percentage
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Underlying Delta Percentage
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + UnderlyingDeltaPercentage.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Delta Percentage");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Underlying Delta Percentage
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + UnderlyingDeltaPercentage.Length;
        }

        /// <summary>
        ///  TryDecode Underlying Delta Percentage
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + UnderlyingDeltaPercentage.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Underlying Delta Percentage
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UnderlyingDeltaPercentage.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Underlying Delta Percentage
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}