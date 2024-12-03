using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Req Id: Optional Fixed Length String Field
    /// </summary>

    public sealed class QuoteReqId
    {
        /// <summary>
        ///  Fix Tag for Quote Req Id
        /// </summary>
        public const ushort FixTag = 131;

        /// <summary>
        ///  Length of Quote Req Id in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Encode Quote Req Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + QuoteReqId.Length)
            {
                throw new System.Exception("Invalid Length for Quote Req Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Req Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, QuoteReqId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = QuoteReqId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + QuoteReqId.Length;
        }

        /// <summary>
        ///  Check available length and set Quote Req Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuoteReqId.Length)
            {
                throw new System.Exception("Invalid Length for Quote Req Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quote Req Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuoteReqId.Length;
        }

        /// <summary>
        ///  Set Quote Req Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < QuoteReqId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Quote Req Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + QuoteReqId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quote Req Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Quote Req Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteReqId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Req Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, QuoteReqId.Length).Trim('\0');
        }
    }
}