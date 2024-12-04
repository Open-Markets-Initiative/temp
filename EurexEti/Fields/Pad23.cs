using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Pad 23: Fixed Length Padding
    /// </summary>

    public sealed class Pad23
    {
        /// <summary>
        ///  Fix Tag for Pad 23
        /// </summary>
        public const ushort FixTag = 39023;

        /// <summary>
        ///  Length of Pad 23 in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Pad 23
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, out int current)
        {
            var position = pointer + offset;

            for (var i = 0; i < Pad23.Length; i++)
            {
                *(position++) = 0;
            }

            current = offset + Pad23.Length;
        }

        /// <summary>
        ///  TryDecode Pad 23
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + Pad23.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Pad 23
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Pad23.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Pad 23
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[Pad23.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < Pad23.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}