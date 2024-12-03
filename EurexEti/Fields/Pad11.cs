using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Pad 11: Fixed Length Padding
    /// </summary>

    public sealed class Pad11
    {
        /// <summary>
        ///  Fix Tag for Pad 11
        /// </summary>
        public const ushort FixTag = 39001;

        /// <summary>
        ///  Length of Pad 11 in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Pad 11
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, out int current)
        {
            var position = pointer + offset;

            for (var i = 0; i < Pad11.Length; i++)
            {
                *(position++) = 0;
            }

            current = offset + Pad11.Length;
        }

        /// <summary>
        ///  TryDecode Pad 11
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + Pad11.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Pad 11
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Pad11.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Pad 11
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[Pad11.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < Pad11.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}