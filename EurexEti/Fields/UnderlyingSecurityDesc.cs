using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Underlying Security Desc: Optional Fixed Length Space Filled String Field
    /// </summary>

    public static class UnderlyingSecurityDesc
    {
        /// <summary>
        ///  Fix Tag for Underlying Security Desc
        /// </summary>
        public const ushort FixTag = 307;

        /// <summary>
        ///  Length of Underlying Security Desc in bytes
        /// </summary>
        public const int Length = 30;

        /// <summary>
        ///  Encode Underlying Security Desc
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + UnderlyingSecurityDesc.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Security Desc");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Underlying Security Desc
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, UnderlyingSecurityDesc.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = UnderlyingSecurityDesc.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = (byte)' ';
            }

            current = offset + UnderlyingSecurityDesc.Length;
        }

        /// <summary>
        ///  Check available length and set Underlying Security Desc to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + UnderlyingSecurityDesc.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Security Desc");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Underlying Security Desc to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + UnderlyingSecurityDesc.Length;
        }

        /// <summary>
        ///  Set Underlying Security Desc to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < UnderlyingSecurityDesc.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Underlying Security Desc
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + UnderlyingSecurityDesc.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Underlying Security Desc
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + UnderlyingSecurityDesc.Length;

            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Underlying Security Desc
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UnderlyingSecurityDesc.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Underlying Security Desc
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, UnderlyingSecurityDesc.Length).Trim();
        }
    }
}