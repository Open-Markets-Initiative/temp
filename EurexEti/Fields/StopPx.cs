using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Stop Px: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public sealed class StopPx
    {
        /// <summary>
        ///  Length of Stop Px in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Stop Px
        /// </summary>
        public const int Factor = 100000000;

        /// <summary>
        ///  Encode Stop Px
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + StopPx.Length)
            {
                throw new System.Exception("Invalid Length for Stop Px");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Stop Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + StopPx.Length;
        }

        /// <summary>
        ///  TryDecode Stop Px
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + StopPx.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Stop Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + StopPx.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Stop Px
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}