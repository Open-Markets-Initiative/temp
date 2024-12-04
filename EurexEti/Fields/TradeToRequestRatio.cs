using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade To Request Ratio: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class TradeToRequestRatio
    {
        /// <summary>
        ///  Fix Tag for Trade To Request Ratio
        /// </summary>
        public const ushort FixTag = 25184;

        /// <summary>
        ///  Length of Trade To Request Ratio in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Trade To Request Ratio
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Trade To Request Ratio
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + TradeToRequestRatio.Length)
            {
                throw new System.Exception("Invalid Length for Trade To Request Ratio");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade To Request Ratio
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + TradeToRequestRatio.Length;
        }

        /// <summary>
        ///  TryDecode Trade To Request Ratio
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + TradeToRequestRatio.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade To Request Ratio
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeToRequestRatio.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade To Request Ratio
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}