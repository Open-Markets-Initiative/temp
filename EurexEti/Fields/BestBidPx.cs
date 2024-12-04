using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Best Bid Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class BestBidPx
    {
        /// <summary>
        ///  Fix Tag for Best Bid Px
        /// </summary>
        public const ushort FixTag = 25132;

        /// <summary>
        ///  Length of Best Bid Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Best Bid Px
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Best Bid Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + BestBidPx.Length)
            {
                throw new System.Exception("Invalid Length for Best Bid Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Best Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + BestBidPx.Length;
        }

        /// <summary>
        ///  TryDecode Best Bid Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + BestBidPx.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Best Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BestBidPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Best Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}