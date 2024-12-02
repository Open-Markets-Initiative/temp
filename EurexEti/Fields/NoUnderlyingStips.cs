using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Underlying Stips: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoUnderlyingStips
    {
        /// <summary>
        ///  Length of No Underlying Stips in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Underlying Stips
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoUnderlyingStips.Length)
            {
                throw new System.Exception("Invalid Length for No Underlying Stips");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Underlying Stips
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoUnderlyingStips.Length;
        }

        /// <summary>
        ///  Encode No Underlying Stips
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Underlying Stips
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoUnderlyingStips.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Underlying Stips
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoUnderlyingStips.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Underlying Stips
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}