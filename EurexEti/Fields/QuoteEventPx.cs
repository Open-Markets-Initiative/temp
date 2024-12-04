using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Event Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class QuoteEventPx
    {
        /// <summary>
        ///  Fix Tag for Quote Event Px
        /// </summary>
        public const ushort FixTag = 28553;

        /// <summary>
        ///  Length of Quote Event Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Quote Event Px
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Quote Event Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + QuoteEventPx.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + QuoteEventPx.Length;
        }

        /// <summary>
        ///  TryDecode Quote Event Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + QuoteEventPx.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEventPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}