using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Underlying Effective Delta Percentage: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public static class UnderlyingEffectiveDeltaPercentage
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
        public const ulong Factor = 10000;

        /// <summary>
        ///  Null value for Underlying Effective Delta Percentage
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

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
        ///  Check available length and set Underlying Effective Delta Percentage to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + UnderlyingEffectiveDeltaPercentage.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Effective Delta Percentage");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Underlying Effective Delta Percentage to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + UnderlyingEffectiveDeltaPercentage.Length;
        }

        /// <summary>
        ///  Set Underlying Effective Delta Percentage to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Underlying Effective Delta Percentage
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + UnderlyingEffectiveDeltaPercentage.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Underlying Effective Delta Percentage
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(ulong*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + UnderlyingEffectiveDeltaPercentage.Length;

            return result;
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