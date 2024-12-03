using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Expire Time: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ExpireTime
    {
        /// <summary>
        ///  Fix Tag for Expire Time
        /// </summary>
        public const ushort FixTag = 126;

        /// <summary>
        ///  Length of Expire Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Expire Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ExpireTime.Length)
            {
                throw new System.Exception("Invalid Length for Expire Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Expire Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ExpireTime.Length;
        }

        /// <summary>
        ///  Encode Expire Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Expire Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ExpireTime.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Expire Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ExpireTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Expire Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}