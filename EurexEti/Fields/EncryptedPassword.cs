using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Encrypted Password: Optional Fixed Length String Field
    /// </summary>

    public sealed class EncryptedPassword
    {
        /// <summary>
        ///  Length of Encrypted Password in bytes
        /// </summary>
        public const int Length = 684;

        /// <summary>
        ///  Encode Encrypted Password
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + EncryptedPassword.Length)
            {
                throw new System.Exception("Invalid Length for Encrypted Password");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Encrypted Password
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, EncryptedPassword.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = EncryptedPassword.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + EncryptedPassword.Length;
        }

        /// <summary>
        ///  Check available length and set Encrypted Password to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + EncryptedPassword.Length)
            {
                throw new System.Exception("Invalid Length for Encrypted Password");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Encrypted Password to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + EncryptedPassword.Length;
        }

        /// <summary>
        ///  Set Encrypted Password to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < EncryptedPassword.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Encrypted Password
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + EncryptedPassword.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Encrypted Password
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Encrypted Password
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EncryptedPassword.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Encrypted Password
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, EncryptedPassword.Length).Trim('\0');
        }
    }
}