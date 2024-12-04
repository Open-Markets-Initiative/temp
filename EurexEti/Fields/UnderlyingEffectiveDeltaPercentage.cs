using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Underlying Effective Delta Percentage: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class UnderlyingEffectiveDeltaPercentage
    {
        /// <summary>
        ///  Fix Tag for Underlying Effective Delta Percentage
        /// </summary>
        public const ushort FixTag = 25151;

        /// <summary>
        ///  Length of Underlying Effective Delta Percentage in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Underlying Effective Delta Percentage
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Underlying Effective Delta Percentage
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + UnderlyingEffectiveDeltaPercentage.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Effective Delta Percentage");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Underlying Effective Delta Percentage
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + UnderlyingEffectiveDeltaPercentage.Length;
        }

        /// <summary>
        ///  TryDecode Underlying Effective Delta Percentage
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + UnderlyingEffectiveDeltaPercentage.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Underlying Effective Delta Percentage
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UnderlyingEffectiveDeltaPercentage.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Underlying Effective Delta Percentage
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}