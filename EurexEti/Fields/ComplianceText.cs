using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Compliance Text: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class ComplianceText
    {
        /// <summary>
        ///  Fix Tag for Compliance Text
        /// </summary>
        public const ushort FixTag = 2404;

        /// <summary>
        ///  Length of Compliance Text in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Encode Compliance Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + ComplianceText.Length)
            {
                throw new System.Exception("Invalid Length for Compliance Text");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Compliance Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, ComplianceText.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = ComplianceText.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + ComplianceText.Length;
        }

        /// <summary>
        ///  Check available length and set Compliance Text to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ComplianceText.Length)
            {
                throw new System.Exception("Invalid Length for Compliance Text");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Compliance Text to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ComplianceText.Length;
        }

        /// <summary>
        ///  Set Compliance Text to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < ComplianceText.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Compliance Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + ComplianceText.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Compliance Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + ComplianceText.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Compliance Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ComplianceText.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Compliance Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, ComplianceText.Length).Trim();
        }
    }
}