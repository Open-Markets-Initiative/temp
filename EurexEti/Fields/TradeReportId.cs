using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade Report Id: Optional Fixed Length String Field
    /// </summary>

    public static class TradeReportId
    {
        /// <summary>
        ///  Fix Tag for Trade Report Id
        /// </summary>
        public const ushort FixTag = 571;

        /// <summary>
        ///  Length of Trade Report Id in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Encode Trade Report Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + TradeReportId.Length)
            {
                throw new System.Exception("Invalid Length for Trade Report Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Report Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, TradeReportId.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = TradeReportId.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + TradeReportId.Length;
        }

        /// <summary>
        ///  Check available length and set Trade Report Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TradeReportId.Length)
            {
                throw new System.Exception("Invalid Length for Trade Report Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trade Report Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TradeReportId.Length;
        }

        /// <summary>
        ///  Set Trade Report Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < TradeReportId.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Trade Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + TradeReportId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trade Report Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + TradeReportId.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Trade Report Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeReportId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Report Id
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, TradeReportId.Length).Trim('\0');
        }
    }
}