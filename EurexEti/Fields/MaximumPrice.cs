using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Maximum Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
    /// </summary>

    public static class MaximumPrice
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
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Null value for Maximum Price
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

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
        ///  Check available length and set Maximum Price to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MaximumPrice.Length)
            {
                throw new System.Exception("Invalid Length for Maximum Price");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Maximum Price to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MaximumPrice.Length;
        }

        /// <summary>
        ///  Set Maximum Price to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Maximum Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + MaximumPrice.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Maximum Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(long*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + MaximumPrice.Length;

            return result;
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