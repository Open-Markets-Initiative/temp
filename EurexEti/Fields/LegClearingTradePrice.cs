using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Leg Clearing Trade Price: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class LegClearingTradePrice
    {
        /// <summary>
        ///  Length of Leg Clearing Trade Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Leg Clearing Trade Price
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Leg Clearing Trade Price
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + LegClearingTradePrice.Length)
            {
                throw new System.Exception("Invalid Length for Leg Clearing Trade Price");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Clearing Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + LegClearingTradePrice.Length;
        }

        /// <summary>
        ///  TryDecode Leg Clearing Trade Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + LegClearingTradePrice.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Clearing Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegClearingTradePrice.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Clearing Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}