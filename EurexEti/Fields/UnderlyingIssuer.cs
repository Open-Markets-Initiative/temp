using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Underlying Issuer: Optional Fixed Length String Field
    /// </summary>

    public static class UnderlyingIssuer
    {
        /// <summary>
        ///  Fix Tag for Underlying Issuer
        /// </summary>
        public const ushort FixTag = 306;

        /// <summary>
        ///  Length of Underlying Issuer in bytes
        /// </summary>
        public const int Length = 30;

        /// <summary>
        ///  Encode Underlying Issuer
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + UnderlyingIssuer.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Issuer");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Underlying Issuer
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, UnderlyingIssuer.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = UnderlyingIssuer.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + UnderlyingIssuer.Length;
        }

        /// <summary>
        ///  Check available length and set Underlying Issuer to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + UnderlyingIssuer.Length)
            {
                throw new System.Exception("Invalid Length for Underlying Issuer");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Underlying Issuer to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + UnderlyingIssuer.Length;
        }

        /// <summary>
        ///  Set Underlying Issuer to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < UnderlyingIssuer.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Underlying Issuer
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + UnderlyingIssuer.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Underlying Issuer
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            current = offset + UnderlyingIssuer.Length;
            value = string.Empty;

            if (*(pointer + offset) == 0)
            {
                return false;
            }

            value = Decode(pointer, offset);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Underlying Issuer
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + UnderlyingIssuer.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Underlying Issuer
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, UnderlyingIssuer.Length).Trim('\0');
        }
    }
}