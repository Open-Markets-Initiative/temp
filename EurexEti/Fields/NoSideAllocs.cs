using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Side Allocs: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoSideAllocs
    {
        /// <summary>
        ///  Fix Tag for No Side Allocs
        /// </summary>
        public const ushort FixTag = 28709;

        /// <summary>
        ///  Length of No Side Allocs in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Side Allocs
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoSideAllocs.Length)
            {
                throw new System.Exception("Invalid Length for No Side Allocs");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Side Allocs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoSideAllocs.Length;
        }

        /// <summary>
        ///  Encode No Side Allocs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Side Allocs
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoSideAllocs.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Side Allocs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoSideAllocs.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Side Allocs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}