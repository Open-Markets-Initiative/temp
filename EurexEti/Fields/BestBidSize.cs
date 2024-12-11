using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Best Bid Size: 8 Byte Fixed Width Nullable Integer with 4 Decimal Place Precision
    /// </summary>

    public static class BestBidSize
    {
        /// <summary>
        ///  Fix Tag for Best Bid Size
        /// </summary>
        public const ushort FixTag = 25134;

        /// <summary>
        ///  Length of Best Bid Size in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Best Bid Size
        /// </summary>
        public const ulong Factor = 10000;

        /// <summary>
        ///  Null value for Best Bid Size
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

        /// <summary>
        ///  Encode Best Bid Size
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + BestBidSize.Length)
            {
                throw new System.Exception("Invalid Length for Best Bid Size");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Best Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + BestBidSize.Length;
        }

        /// <summary>
        ///  Check available length and set Best Bid Size to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + BestBidSize.Length)
            {
                throw new System.Exception("Invalid Length for Best Bid Size");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Best Bid Size to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + BestBidSize.Length;
        }

        /// <summary>
        ///  Set Best Bid Size to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Best Bid Size
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + BestBidSize.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Best Bid Size
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(ulong*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + BestBidSize.Length;

            return result;
        }

        /// <summary>
        ///  Decode Best Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BestBidSize.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Best Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}