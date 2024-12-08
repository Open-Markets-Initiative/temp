using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Best Offer Size: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class BestOfferSize
    {
        /// <summary>
        ///  Fix Tag for Best Offer Size
        /// </summary>
        public const ushort FixTag = 25135;

        /// <summary>
        ///  Length of Best Offer Size in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Best Offer Size
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Best Offer Size
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + BestOfferSize.Length)
            {
                throw new System.Exception("Invalid Length for Best Offer Size");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Best Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + BestOfferSize.Length;
        }

        /// <summary>
        ///  TryDecode Best Offer Size
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + BestOfferSize.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Best Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BestOfferSize.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Best Offer Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}