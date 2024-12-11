using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Related Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
    /// </summary>

    public static class RelatedPx
    {
        /// <summary>
        ///  Fix Tag for Related Px
        /// </summary>
        public const ushort FixTag = 28908;

        /// <summary>
        ///  Length of Related Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Related Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Null value for Related Px
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

        /// <summary>
        ///  Encode Related Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + RelatedPx.Length)
            {
                throw new System.Exception("Invalid Length for Related Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Related Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + RelatedPx.Length;
        }

        /// <summary>
        ///  Check available length and set Related Px to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RelatedPx.Length)
            {
                throw new System.Exception("Invalid Length for Related Px");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Related Px to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RelatedPx.Length;
        }

        /// <summary>
        ///  Set Related Px to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Related Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + RelatedPx.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Related Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(long*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + RelatedPx.Length;

            return result;
        }

        /// <summary>
        ///  Decode Related Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RelatedPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Related Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}