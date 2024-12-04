using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Username: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class Username
    {
        /// <summary>
        ///  Fix Tag for Username
        /// </summary>
        public const ushort FixTag = 553;

        /// <summary>
        ///  Length of Username in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Username
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + Username.Length)
            {
                throw new System.Exception("Invalid Length for Username");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Username
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + Username.Length;
        }

        /// <summary>
        ///  Encode Username
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Username
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + Username.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Username
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Username.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Username
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}