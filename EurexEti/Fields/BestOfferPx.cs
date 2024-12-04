using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Best Offer Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class BestOfferPx
    {
        /// <summary>
        ///  Fix Tag for Best Offer Px
        /// </summary>
        public const ushort FixTag = 25133;

        /// <summary>
        ///  Length of Best Offer Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Best Offer Px
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Best Offer Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + BestOfferPx.Length)
            {
                throw new System.Exception("Invalid Length for Best Offer Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Best Offer Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + BestOfferPx.Length;
        }

        /// <summary>
        ///  TryDecode Best Offer Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + BestOfferPx.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Best Offer Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BestOfferPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Best Offer Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}