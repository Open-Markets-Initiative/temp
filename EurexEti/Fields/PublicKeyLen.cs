using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Public Key Len: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class PublicKeyLen
    {
        /// <summary>
        ///  Fix Tag for Public Key Len
        /// </summary>
        public const ushort FixTag = 25242;

        /// <summary>
        ///  Length of Public Key Len in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Public Key Len
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + PublicKeyLen.Length)
            {
                throw new System.Exception("Invalid Length for Public Key Len");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Public Key Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PublicKeyLen.Length;
        }

        /// <summary>
        ///  Encode Public Key Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Public Key Len
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + PublicKeyLen.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Public Key Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PublicKeyLen.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Public Key Len
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}