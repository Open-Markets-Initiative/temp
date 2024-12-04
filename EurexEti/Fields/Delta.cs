using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Delta: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class Delta
    {
        /// <summary>
        ///  Fix Tag for Delta
        /// </summary>
        public const ushort FixTag = 7966;

        /// <summary>
        ///  Length of Delta in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Delta
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Delta
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + Delta.Length)
            {
                throw new System.Exception("Invalid Length for Delta");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + Delta.Length;
        }

        /// <summary>
        ///  TryDecode Delta
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + Delta.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Delta.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Delta
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}