using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Cl Ord Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ClOrdId
    {
        /// <summary>
        ///  Length of Cl Ord Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Cl Ord Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ClOrdId.Length)
            {
                throw new System.Exception("Invalid Length for Cl Ord Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ClOrdId.Length;
        }

        /// <summary>
        ///  Encode Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Cl Ord Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ClOrdId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ClOrdId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}