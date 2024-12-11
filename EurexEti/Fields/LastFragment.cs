using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Last Fragment: Enum
    /// </summary>

    public static class LastFragment
    {
        /// <summary>
        ///  Not Last Message
        /// </summary>
        public const byte NotLastMessage = 0;

        /// <summary>
        ///  Last Message
        /// </summary>
        public const byte LastMessage = 1;

        /// <summary>
        ///  Fix Tag for Last Fragment
        /// </summary>
        public const ushort FixTag = 893;

        /// <summary>
        ///  Length of Last Fragment in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Last Fragment
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Last Fragment
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + LastFragment.Length)
            {
                throw new System.Exception("Invalid Length for Last Fragment");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Last Fragment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + LastFragment.Length;
        }

        /// <summary>
        ///  Check available length and set Last Fragment to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + LastFragment.Length)
            {
                throw new System.Exception("Invalid Length for Last Fragment");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Last Fragment to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + LastFragment.Length;
        }

        /// <summary>
        ///  Set Last Fragment to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Last Fragment
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + LastFragment.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Last Fragment
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Last Fragment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LastFragment.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Last Fragment
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}