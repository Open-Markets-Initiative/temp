using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Last Fragment: Enum
    /// </summary>

    public sealed class LastFragment
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
        ///  TryDecode Last Fragment
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + LastFragment.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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