using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Best Bid Size: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class BestBidSize
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
        public const int Factor = 10000;

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
        ///  TryDecode Best Bid Size
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + BestBidSize.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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