using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Is Locked: Enum
    /// </summary>

    public sealed class SideIsLocked
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
        ///  TryDecode Side Is Locked
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + SideIsLocked.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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