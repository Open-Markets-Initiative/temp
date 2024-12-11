using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Is Locked: Enum
    /// </summary>

    public static class SideIsLocked
    {
        /// <summary>
        ///  No
        /// </summary>
        public const byte No = 0;

        /// <summary>
        ///  Yes
        /// </summary>
        public const byte Yes = 1;

        /// <summary>
        ///  Fix Tag for Side Is Locked
        /// </summary>
        public const ushort FixTag = 25208;

        /// <summary>
        ///  Length of Side Is Locked in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Side Is Locked
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Side Is Locked
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + SideIsLocked.Length)
            {
                throw new System.Exception("Invalid Length for Side Is Locked");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Side Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + SideIsLocked.Length;
        }

        /// <summary>
        ///  Check available length and set Side Is Locked to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SideIsLocked.Length)
            {
                throw new System.Exception("Invalid Length for Side Is Locked");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Side Is Locked to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SideIsLocked.Length;
        }

        /// <summary>
        ///  Set Side Is Locked to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Side Is Locked
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SideIsLocked.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Side Is Locked
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Side Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SideIsLocked.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Side Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}