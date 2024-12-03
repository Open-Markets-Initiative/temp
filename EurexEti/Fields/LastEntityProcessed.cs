using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Last Entity Processed: Fixed Length Data Field
    /// </summary>

    public sealed class LastEntityProcessed
    {
        /// <summary>
        ///  Fix Tag for Last Entity Processed
        /// </summary>
        public const ushort FixTag = 25035;

        /// <summary>
        ///  Length of Last Entity Processed in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Last Entity Processed
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte[] value, int length, out int current)
        {
            if (length > offset + LastEntityProcessed.Length)
            {
                throw new System.Exception("Invalid Length for Last Entity Processed");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Last Entity Processed
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte[] value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, LastEntityProcessed.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = value[i];
            }

            end = LastEntityProcessed.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + LastEntityProcessed.Length;
        }

        /// <summary>
        ///  TryDecode Last Entity Processed
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + LastEntityProcessed.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Last Entity Processed
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LastEntityProcessed.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Last Entity Processed
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[LastEntityProcessed.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < LastEntityProcessed.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}