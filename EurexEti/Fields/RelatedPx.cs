using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Related Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class RelatedPx
    {
        /// <summary>
        ///  Fix Tag for Related Px
        /// </summary>
        public const ushort FixTag = 28908;

        /// <summary>
        ///  Length of Related Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Related Px
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Related Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + RelatedPx.Length)
            {
                throw new System.Exception("Invalid Length for Related Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Related Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + RelatedPx.Length;
        }

        /// <summary>
        ///  TryDecode Related Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + RelatedPx.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Related Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RelatedPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Related Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}