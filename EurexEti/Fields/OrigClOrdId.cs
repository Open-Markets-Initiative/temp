using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Orig Cl Ord Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class OrigClOrdId
    {
        /// <summary>
        ///  Fix Tag for Orig Cl Ord Id
        /// </summary>
        public const ushort FixTag = 41;

        /// <summary>
        ///  Length of Orig Cl Ord Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Orig Cl Ord Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + OrigClOrdId.Length)
            {
                throw new System.Exception("Invalid Length for Orig Cl Ord Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + OrigClOrdId.Length;
        }

        /// <summary>
        ///  Encode Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Orig Cl Ord Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + OrigClOrdId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrigClOrdId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Orig Cl Ord Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}