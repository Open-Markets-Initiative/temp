using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Maturity Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class MaturityDate
    {
        /// <summary>
        ///  Fix Tag for Maturity Date
        /// </summary>
        public const ushort FixTag = 541;

        /// <summary>
        ///  Length of Maturity Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Maturity Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + MaturityDate.Length)
            {
                throw new System.Exception("Invalid Length for Maturity Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MaturityDate.Length;
        }

        /// <summary>
        ///  Encode Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Maturity Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MaturityDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MaturityDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Maturity Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}