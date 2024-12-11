using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Pad 41: Fixed Length Padding
    /// </summary>

    public static class Pad41
    {
        /// <summary>
        ///  Fix Tag for Pad 41
        /// </summary>
        public const ushort FixTag = 39041;

        /// <summary>
        ///  Length of Pad 41 in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Pad 41
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, out int current)
        {
            var position = pointer + offset;

            for (var i = 0; i < Pad41.Length; i++)
            {
                *(position++) = 0;
            }

            current = offset + Pad41.Length;
        }

        /// <summary>
        ///  TryDecode Pad 41
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + Pad41.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Pad 41
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Pad41.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Pad 41
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[Pad41.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < Pad41.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}