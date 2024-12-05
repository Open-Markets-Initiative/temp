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
        public unsafe static void Encode(byte* pointer, int offset, string value, out int current)
        {
            if (length > offset + value.Length)
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
            DataLength.Encode(pointer, offset, (ushort)value.Length, out current);

            for (var i = 0; i < value.Length; i++)
            {
                *(position++) = value[i];
            }

            current = offset + value.Length;
        }

        /// <summary>
        ///  TryDecode Public Key
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, int size, out string value, out int current)
        {
            if (size > 0 && length > offset + size)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = string.Empty;

            current = offset;

            return false;
        }
    }
}