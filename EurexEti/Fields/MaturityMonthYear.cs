using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Maturity Month Year: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class MaturityMonthYear
    {
        /// <summary>
        ///  Fix Tag for Maturity Month Year
        /// </summary>
        public const ushort FixTag = 200;

        /// <summary>
        ///  Length of Maturity Month Year in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Maturity Month Year
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + MaturityMonthYear.Length)
            {
                throw new System.Exception("Invalid Length for Maturity Month Year");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MaturityMonthYear.Length;
        }

        /// <summary>
        ///  Encode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Maturity Month Year
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MaturityMonthYear.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MaturityMonthYear.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}