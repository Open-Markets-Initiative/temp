using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leaves Qty: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public static class LeavesQty
    {
        /// <summary>
        ///  Fix Tag for Leaves Qty
        /// </summary>
        public const ushort FixTag = 151;

        /// <summary>
        ///  Length of Leaves Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Leaves Qty
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Null value for Leaves Qty
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

        /// <summary>
        ///  Encode Leaves Qty
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + LeavesQty.Length)
            {
                throw new System.Exception("Invalid Length for Leaves Qty");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leaves Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + LeavesQty.Length;
        }

        /// <summary>
        ///  Check available length and set Leaves Qty to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + LeavesQty.Length)
            {
                throw new System.Exception("Invalid Length for Leaves Qty");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Leaves Qty to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + LeavesQty.Length;
        }

        /// <summary>
        ///  Set Leaves Qty to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Leaves Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + LeavesQty.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Leaves Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(long*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + LeavesQty.Length;

            return result;
        }

        /// <summary>
        ///  Decode Leaves Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LeavesQty.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leaves Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}