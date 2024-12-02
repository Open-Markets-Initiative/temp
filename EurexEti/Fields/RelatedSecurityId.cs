using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Related Security Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class RelatedSecurityId
    {
        /// <summary>
        ///  Length of Related Security Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Related Security Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
        {
            if (length > offset + RelatedSecurityId.Length)
            {
                throw new System.Exception("Invalid Length for Related Security Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RelatedSecurityId.Length;
        }

        /// <summary>
        ///  Encode Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value)
        {
            *(long*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Related Security Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
        {
            if (length > offset + RelatedSecurityId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RelatedSecurityId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Related Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset)
        {
            return *(long*) (pointer + offset);
        }
    }
}