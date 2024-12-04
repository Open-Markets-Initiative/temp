using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Not Aff Orig Cl Ord Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class NotAffOrigClOrdId
    {
        /// <summary>
        ///  Fix Tag for Not Aff Orig Cl Ord Id
        /// </summary>
        public const ushort FixTag = 1372;

        /// <summary>
        ///  Length of Not Aff Orig Cl Ord Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Not Aff Orig Cl Ord Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + NotAffOrigClOrdId.Length)
            {
                throw new System.Exception("Invalid Length for Not Aff Orig Cl Ord Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Not Aff Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NotAffOrigClOrdId.Length;
        }

        /// <summary>
        ///  Encode Not Aff Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Not Aff Orig Cl Ord Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + NotAffOrigClOrdId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Not Aff Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NotAffOrigClOrdId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Not Aff Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}