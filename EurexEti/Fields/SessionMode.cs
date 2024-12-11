using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Session Mode: Enum
    /// </summary>

    public static class SessionMode
    {
        /// <summary>
        ///  ETI HF
        /// </summary>
        public const byte Etihf = 1;

        /// <summary>
        ///  ETI LF
        /// </summary>
        public const byte Etilf = 2;

        /// <summary>
        ///  GUI
        /// </summary>
        public const byte Gui = 3;

        /// <summary>
        ///  FIX LF
        /// </summary>
        public const byte Fixlf = 4;

        /// <summary>
        ///  Fix Tag for Session Mode
        /// </summary>
        public const ushort FixTag = 28730;

        /// <summary>
        ///  Length of Session Mode in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Session Mode
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Session Mode
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SessionMode.Length)
            {
                throw new System.Exception("Invalid Length for Session Mode");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Session Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SessionMode.Length;
        }

        /// <summary>
        ///  Check available length and set Session Mode to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SessionMode.Length)
            {
                throw new System.Exception("Invalid Length for Session Mode");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Session Mode to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SessionMode.Length;
        }

        /// <summary>
        ///  Set Session Mode to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Session Mode
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SessionMode.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Session Mode
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Session Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SessionMode.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Session Mode
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}