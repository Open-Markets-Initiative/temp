using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Number Of Securities: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class NumberOfSecurities
    {
        /// <summary>
        ///  Length of Number Of Securities in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Number Of Securities
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + NumberOfSecurities.Length)
            {
                throw new System.Exception("Invalid Length for Number Of Securities");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Number Of Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NumberOfSecurities.Length;
        }

        /// <summary>
        ///  Encode Number Of Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Number Of Securities
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + NumberOfSecurities.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Number Of Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NumberOfSecurities.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Number Of Securities
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}