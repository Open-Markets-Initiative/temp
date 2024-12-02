using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Latest Public Key Seq No: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class LatestPublicKeySeqNo
    {
        /// <summary>
        ///  Length of Latest Public Key Seq No in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Latest Public Key Seq No
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + LatestPublicKeySeqNo.Length)
            {
                throw new System.Exception("Invalid Length for Latest Public Key Seq No");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Latest Public Key Seq No
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + LatestPublicKeySeqNo.Length;
        }

        /// <summary>
        ///  Encode Latest Public Key Seq No
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Latest Public Key Seq No
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + LatestPublicKeySeqNo.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Latest Public Key Seq No
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LatestPublicKeySeqNo.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Latest Public Key Seq No
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}