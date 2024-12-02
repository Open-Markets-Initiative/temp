using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Pad 1: Fixed Length Padding
    /// </summary>

    public sealed class Pad1
    {
        /// <summary>
        ///  Length of Pad 1 in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Pad 1
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, out int current)
        {
            var position = pointer + offset;

            for (var i = 0; i < {Declaration}.Length; i++)
            {
                *(position++) = 0;
            }

            current = offset + Pad1.Length;
        }

        /// <summary>
        ///  TryDecode Pad 1
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + Pad1.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Pad 1
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Pad1.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Pad 1
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[Pad1.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < Pad1.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}