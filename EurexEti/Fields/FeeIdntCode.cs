using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Fee Idnt Code: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class FeeIdntCode
    {
        /// <summary>
        ///  Fix Tag for Fee Idnt Code
        /// </summary>
        public const ushort FixTag = 32999;

        /// <summary>
        ///  Length of Fee Idnt Code in bytes
        /// </summary>
        public const int Length = 15;

        /// <summary>
        ///  Encode Fee Idnt Code
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + FeeIdntCode.Length)
            {
                throw new System.Exception("Invalid Length for Fee Idnt Code");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Fee Idnt Code
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, FeeIdntCode.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = FeeIdntCode.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + FeeIdntCode.Length;
        }

        /// <summary>
        ///  Check available length and set Fee Idnt Code to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + FeeIdntCode.Length)
            {
                throw new System.Exception("Invalid Length for Fee Idnt Code");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Fee Idnt Code to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + FeeIdntCode.Length;
        }

        /// <summary>
        ///  Set Fee Idnt Code to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < FeeIdntCode.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Fee Idnt Code
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + FeeIdntCode.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Fee Idnt Code
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + FeeIdntCode.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Fee Idnt Code
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + FeeIdntCode.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Fee Idnt Code
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, FeeIdntCode.Length).Trim();
        }
    }
}