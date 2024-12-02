using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Reversal Reason Text: Optional Fixed Length String Field
    /// </summary>

    public sealed class ReversalReasonText
    {
        /// <summary>
        ///  Length of Reversal Reason Text in bytes
        /// </summary>
        public const int Length = 132;

        /// <summary>
        ///  Encode Reversal Reason Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + ReversalReasonText.Length)
            {
                throw new System.Exception("Invalid Length for Reversal Reason Text");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Reversal Reason Text
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, ReversalReasonText.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = ReversalReasonText.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + ReversalReasonText.Length;
        }

        /// <summary>
        ///  Check available length and set Reversal Reason Text to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ReversalReasonText.Length)
            {
                throw new System.Exception("Invalid Length for Reversal Reason Text");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Reversal Reason Text to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ReversalReasonText.Length;
        }

        /// <summary>
        ///  Set Reversal Reason Text to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < ReversalReasonText.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Reversal Reason Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + ReversalReasonText.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Reversal Reason Text
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Reversal Reason Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ReversalReasonText.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Reversal Reason Text
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, ReversalReasonText.Length).Trim('\0');
        }
    }
}