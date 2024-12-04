using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Headline: Optional Fixed Length String Field
    /// </summary>

    public sealed class Headline
    {
        /// <summary>
        ///  Fix Tag for Headline
        /// </summary>
        public const ushort FixTag = 148;

        /// <summary>
        ///  Length of Headline in bytes
        /// </summary>
        public const int Length = 256;

        /// <summary>
        ///  Encode Headline
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + Headline.Length)
            {
                throw new System.Exception("Invalid Length for Headline");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Headline
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, Headline.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = Headline.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + Headline.Length;
        }

        /// <summary>
        ///  Check available length and set Headline to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + Headline.Length)
            {
                throw new System.Exception("Invalid Length for Headline");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Headline to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + Headline.Length;
        }

        /// <summary>
        ///  Set Headline to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < Headline.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Headline
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + Headline.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Headline
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Headline
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Headline.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Headline
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, Headline.Length).Trim('\0');
        }
    }
}