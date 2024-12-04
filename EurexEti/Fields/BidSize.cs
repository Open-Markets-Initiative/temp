using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Bid Size: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class BidSize
    {
        /// <summary>
        ///  Fix Tag for Bid Size
        /// </summary>
        public const ushort FixTag = 134;

        /// <summary>
        ///  Length of Bid Size in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Bid Size
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Bid Size
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + BidSize.Length)
            {
                throw new System.Exception("Invalid Length for Bid Size");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + BidSize.Length;
        }

        /// <summary>
        ///  TryDecode Bid Size
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + BidSize.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BidSize.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Bid Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}