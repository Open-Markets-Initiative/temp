using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Instrmt Match Side Id: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class InstrmtMatchSideId
    {
        /// <summary>
        ///  Fix Tag for Instrmt Match Side Id
        /// </summary>
        public const ushort FixTag = 25166;

        /// <summary>
        ///  Length of Instrmt Match Side Id in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Instrmt Match Side Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + InstrmtMatchSideId.Length)
            {
                throw new System.Exception("Invalid Length for Instrmt Match Side Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Instrmt Match Side Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + InstrmtMatchSideId.Length;
        }

        /// <summary>
        ///  Encode Instrmt Match Side Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Instrmt Match Side Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + InstrmtMatchSideId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Instrmt Match Side Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + InstrmtMatchSideId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Instrmt Match Side Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}