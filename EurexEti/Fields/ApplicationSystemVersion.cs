using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Application System Version: Optional Fixed Length String Field
    /// </summary>

    public static class ApplicationSystemVersion
    {
        /// <summary>
        ///  Fix Tag for Application System Version
        /// </summary>
        public const ushort FixTag = 1604;

        /// <summary>
        ///  Length of Application System Version in bytes
        /// </summary>
        public const int Length = 30;

        /// <summary>
        ///  Encode Application System Version
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + ApplicationSystemVersion.Length)
            {
                throw new System.Exception("Invalid Length for Application System Version");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Application System Version
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, ApplicationSystemVersion.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = ApplicationSystemVersion.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + ApplicationSystemVersion.Length;
        }

        /// <summary>
        ///  Check available length and set Application System Version to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ApplicationSystemVersion.Length)
            {
                throw new System.Exception("Invalid Length for Application System Version");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Application System Version to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ApplicationSystemVersion.Length;
        }

        /// <summary>
        ///  Set Application System Version to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < ApplicationSystemVersion.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Application System Version
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + ApplicationSystemVersion.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Application System Version
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + ApplicationSystemVersion.Length;
            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Application System Version
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplicationSystemVersion.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Application System Version
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, ApplicationSystemVersion.Length).Trim('\0');
        }
    }
}