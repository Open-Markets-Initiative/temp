using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Fills: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoFills
    {
        /// <summary>
        ///  Fix Tag for No Fills
        /// </summary>
        public const ushort FixTag = 1362;

        /// <summary>
        ///  Length of No Fills in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Fills
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoFills.Length)
            {
                throw new System.Exception("Invalid Length for No Fills");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Fills
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoFills.Length;
        }

        /// <summary>
        ///  Encode No Fills
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Fills
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoFills.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Fills
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoFills.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Fills
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}