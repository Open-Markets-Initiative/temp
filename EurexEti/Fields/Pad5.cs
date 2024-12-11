using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Pad 5: Fixed Length Padding
    /// </summary>

    public static class Pad5
    {
        /// <summary>
        ///  Fix Tag for Pad 5
        /// </summary>
        public const ushort FixTag = 39050;

        /// <summary>
        ///  Length of Pad 5 in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Encode Pad 5
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, out int current)
        {
            var position = pointer + offset;

            for (var i = 0; i < Pad5.Length; i++)
            {
                *(position++) = 0;
            }

            current = offset + Pad5.Length;
        }

        /// <summary>
        ///  TryDecode Pad 5
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + Pad5.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Pad 5
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Pad5.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Pad 5
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[Pad5.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < Pad5.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}