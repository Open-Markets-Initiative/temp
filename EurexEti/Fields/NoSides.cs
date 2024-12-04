using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Sides: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoSides
    {
        /// <summary>
        ///  Fix Tag for No Sides
        /// </summary>
        public const ushort FixTag = 552;

        /// <summary>
        ///  Length of No Sides in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Sides
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoSides.Length)
            {
                throw new System.Exception("Invalid Length for No Sides");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoSides.Length;
        }

        /// <summary>
        ///  Encode No Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Sides
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoSides.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoSides.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Sides
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}