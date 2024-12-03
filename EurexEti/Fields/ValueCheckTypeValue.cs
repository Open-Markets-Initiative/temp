using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Value Check Type Value: Enum
    /// </summary>

    public sealed class ValueCheckTypeValue
    {
        /// <summary>
        ///  Do not check
        /// </summary>
        public const byte Donotcheck = 0;

        /// <summary>
        ///  Check
        /// </summary>
        public const byte Check = 1;

        /// <summary>
        ///  Fix Tag for Value Check Type Value
        /// </summary>
        public const ushort FixTag = 25126;

        /// <summary>
        ///  Length of Value Check Type Value in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Value Check Type Value
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ValueCheckTypeValue.Length)
            {
                throw new System.Exception("Invalid Length for Value Check Type Value");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Value Check Type Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ValueCheckTypeValue.Length;
        }

        /// <summary>
        ///  TryDecode Value Check Type Value
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ValueCheckTypeValue.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Value Check Type Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ValueCheckTypeValue.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Value Check Type Value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}