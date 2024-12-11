using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Event Px: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
    /// </summary>

    public static class OrderEventPx
    {
        /// <summary>
        ///  Fix Tag for Order Event Px
        /// </summary>
        public const ushort FixTag = 1799;

        /// <summary>
        ///  Length of Order Event Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Order Event Px
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Null value for Order Event Px
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

        /// <summary>
        ///  Encode Order Event Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + OrderEventPx.Length)
            {
                throw new System.Exception("Invalid Length for Order Event Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + OrderEventPx.Length;
        }

        /// <summary>
        ///  Check available length and set Order Event Px to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + OrderEventPx.Length)
            {
                throw new System.Exception("Invalid Length for Order Event Px");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Order Event Px to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + OrderEventPx.Length;
        }

        /// <summary>
        ///  Set Order Event Px to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Order Event Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + OrderEventPx.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Order Event Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(ulong*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + OrderEventPx.Length;

            return result;
        }

        /// <summary>
        ///  Decode Order Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderEventPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}