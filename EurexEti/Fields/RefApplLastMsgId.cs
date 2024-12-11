using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Ref Appl Last Msg Id: Fixed Length Data Field
    /// </summary>

    public static class RefApplLastMsgId
    {
        /// <summary>
        ///  Fix Tag for Ref Appl Last Msg Id
        /// </summary>
        public const ushort FixTag = 28722;

        /// <summary>
        ///  Length of Ref Appl Last Msg Id in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Ref Appl Last Msg Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte[] value, int length, out int current)
        {
            if (length > offset + RefApplLastMsgId.Length)
            {
                throw new System.Exception("Invalid Length for Ref Appl Last Msg Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ref Appl Last Msg Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte[] value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, RefApplLastMsgId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = value[i];
            }

            end = RefApplLastMsgId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + RefApplLastMsgId.Length;
        }

        /// <summary>
        ///  TryDecode Ref Appl Last Msg Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + RefApplLastMsgId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Ref Appl Last Msg Id
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RefApplLastMsgId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ref Appl Last Msg Id
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[RefApplLastMsgId.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < RefApplLastMsgId.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}