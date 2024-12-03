using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Bid Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class BidPx
    {
        /// <summary>
        ///  Fix Tag for Bid Px
        /// </summary>
        public const ushort FixTag = 132;

        /// <summary>
        ///  Length of Bid Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Bid Px
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Bid Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + BidPx.Length)
            {
                throw new System.Exception("Invalid Length for Bid Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + BidPx.Length;
        }

        /// <summary>
        ///  TryDecode Bid Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + BidPx.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BidPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Bid Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}