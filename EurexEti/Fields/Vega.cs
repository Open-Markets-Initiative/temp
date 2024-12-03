using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Vega: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class Vega
    {
        /// <summary>
        ///  Fix Tag for Vega
        /// </summary>
        public const ushort FixTag = 7968;

        /// <summary>
        ///  Length of Vega in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Vega
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Vega
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + Vega.Length)
            {
                throw new System.Exception("Invalid Length for Vega");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Vega
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + Vega.Length;
        }

        /// <summary>
        ///  TryDecode Vega
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + Vega.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Vega
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Vega.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Vega
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}