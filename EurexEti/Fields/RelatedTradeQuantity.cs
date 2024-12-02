using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Related Trade Quantity: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class RelatedTradeQuantity
    {
        /// <summary>
        ///  Length of Related Trade Quantity in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Related Trade Quantity
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Related Trade Quantity
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + RelatedTradeQuantity.Length)
            {
                throw new System.Exception("Invalid Length for Related Trade Quantity");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Related Trade Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + RelatedTradeQuantity.Length;
        }

        /// <summary>
        ///  TryDecode Related Trade Quantity
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + RelatedTradeQuantity.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Related Trade Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RelatedTradeQuantity.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Related Trade Quantity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}