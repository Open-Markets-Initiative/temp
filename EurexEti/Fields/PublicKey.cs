using System;
using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Public Key: Runtime Variable Length Ascii String
    /// </summary>

    public static class PublicKey
    {
        /// <summary>
        ///  Fix Tag for Public Key
        /// </summary>
        public const ushort FixTag = 25233;

        /// <summary>
        ///  Encode Public Key
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int length, string value, out int current)
        {
            if (length > offset + size)
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

            for (var i = 0; i < value.Length; i++)
            {
                *(position++) = (byte)value[i];
            }

            current = offset + value.Length;
        }

        /// <summary>
        ///  TryDecode Public Key
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, int size, out string value, out int current)
        {
            if (length > offset + PublicKey.Length)
            {
                return TryDecode(pointer, offset, size, out value, out current);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Public Key
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int size, out string value, out int current)
        {
            if (size > 0)
            {
                value = Decode(pointer, offset, size, out current);

                return !string.IsNullOrEmpty(value);
            }

            value = string.Empty;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Public Key
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, int size, out int current)
        {
            current = offset + size;

            return Decode(pointer, offset, size);
        }

        /// <summary>
        ///  Decode Public Key
        /// </summary>
        public unsafe static string Decode(byte* pointer, int offset, int size)
        {
            return new string ((sbyte*)pointer, offset, size);
        }
    }
}