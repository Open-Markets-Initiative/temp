using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Event Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class OrderEventPx
    {
        /// <summary>
        ///  Fix Tag for Order Event Px
        /// </summary>
        public const ushort FixTag = 1799;

        /// <summary>
        ///  Length of Order Event Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Order Event Px
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Order Event Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + OrderEventPx.Length)
            {
                throw new System.Exception("Invalid Length for Order Event Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + OrderEventPx.Length;
        }

        /// <summary>
        ///  TryDecode Order Event Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + OrderEventPx.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderEventPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Event Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}