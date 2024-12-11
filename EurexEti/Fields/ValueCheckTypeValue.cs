using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Value Check Type Value: Enum
    /// </summary>

    public static class ValueCheckTypeValue
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
        ///  Null value for Value Check Type Value
        /// </summary>
        public const byte NoValue = 0xFF;

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
        ///  Check available length and set Value Check Type Value to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ValueCheckTypeValue.Length)
            {
                throw new System.Exception("Invalid Length for Value Check Type Value");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Value Check Type Value to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ValueCheckTypeValue.Length;
        }

        /// <summary>
        ///  Set Value Check Type Value to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Value Check Type Value
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ValueCheckTypeValue.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Value Check Type Value
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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