using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Underlying Price Stip Value: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class UnderlyingPriceStipValue
    {
        /// <summary>
        ///  Length of Underlying Price Stip Value in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Underlying Price Stip Value
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Underlying Price Stip Value
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + UnderlyingPriceStipValue.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Price Stip Value");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Underlying Price Stip Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + UnderlyingPriceStipValue.Length;
        }

        /// <summary>
        ///  TryDecode Underlying Price Stip Value
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + UnderlyingPriceStipValue.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Underlying Price Stip Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UnderlyingPriceStipValue.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Underlying Price Stip Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}