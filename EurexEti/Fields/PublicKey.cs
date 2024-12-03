using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Public Key: Optional Fixed Length String Field
    /// </summary>

    public sealed class PublicKey
    {
        /// <summary>
        ///  Fix Tag for Public Key
        /// </summary>
        public const ushort FixTag = 25233;

        /// <summary>
        ///  Length of Public Key in bytes
        /// </summary>
        public const int Length = 814;

        /// <summary>
        ///  Encode Public Key
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, int length, out int current)
        {
            if (length > offset + PublicKey.Length)
            {
                throw new System.Exception("Invalid Length for Public Key");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Public Key
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            var position = pointer + offset;

            var end = Math.Min(value.Length, PublicKey.Length);

            for (var i = 0; i < end; i++)
            {
                *(position++) = (byte)value[i];
            }

            end = PublicKey.Length - end;

            for(var i = 0; i < end; i++)
            {
                *(position++) = 0;
            }

            current = offset + PublicKey.Length;
        }

        /// <summary>
        ///  Check available length and set Public Key to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PublicKey.Length)
            {
                throw new System.Exception("Invalid Length for Public Key");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Public Key to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PublicKey.Length;
        }

        /// <summary>
        ///  Set Public Key to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            var position = pointer + offset;

            for (var i = 0; i < PublicKey.Length; i++)
            {
                *(position++) = 0;
            }
        }

        /// <summary>
        ///  TryDecode Public Key
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out string value, out int current)
        {
            if (length > offset + PublicKey.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Public Key
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out string value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return !string.IsNullOrEmpty(value);
        }

        /// <summary>
        ///  Decode Public Key
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PublicKey.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Public Key
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset)
        {
            return new string ((sbyte*)pointer, offset, PublicKey.Length).Trim('\0');
        }
    }
}