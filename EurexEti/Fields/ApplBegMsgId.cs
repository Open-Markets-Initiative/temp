using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Appl Beg Msg Id: Fixed Length Data Field
    /// </summary>

    public sealed class ApplBegMsgId
    {
        /// <summary>
        ///  Fix Tag for Appl Beg Msg Id
        /// </summary>
        public const ushort FixTag = 28718;

        /// <summary>
        ///  Length of Appl Beg Msg Id in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Encode Appl Beg Msg Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte[] value, int length, out int current)
        {
            if (length > offset + ApplBegMsgId.Length)
            {
                throw new System.Exception("Invalid Length for Appl Beg Msg Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Beg Msg Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte[] value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, ApplBegMsgId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = value[i];
            }

            end = ApplBegMsgId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + ApplBegMsgId.Length;
        }

        /// <summary>
        ///  TryDecode Appl Beg Msg Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte[] value, out int current)
        {
            if (length > offset + ApplBegMsgId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = null;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Beg Msg Id
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplBegMsgId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Beg Msg Id
        /// </summary>
        public unsafe static byte[] Decode(byte* pointer, int offset)
        {
            var buffer = new byte[ApplBegMsgId.Length];

            byte* position = pointer + offset;

            for (var i = 0; i < ApplBegMsgId.Length; i++)
            {
                buffer[i] = *(position++);
            }

            return buffer;
        }
    }
}