using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Event Qty: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public static class QuoteEventQty
    {
        /// <summary>
        ///  Fix Tag for Quote Event Qty
        /// </summary>
        public const ushort FixTag = 28542;

        /// <summary>
        ///  Length of Quote Event Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Quote Event Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Null value for Quote Event Qty
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

        /// <summary>
        ///  Encode Quote Event Qty
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + QuoteEventQty.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Qty");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Event Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + QuoteEventQty.Length;
        }

        /// <summary>
        ///  Check available length and set Quote Event Qty to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuoteEventQty.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Qty");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quote Event Qty to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuoteEventQty.Length;
        }

        /// <summary>
        ///  Set Quote Event Qty to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quote Event Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + QuoteEventQty.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quote Event Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(ulong*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + QuoteEventQty.Length;

            return result;
        }

        /// <summary>
        ///  Decode Quote Event Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEventQty.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Event Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}