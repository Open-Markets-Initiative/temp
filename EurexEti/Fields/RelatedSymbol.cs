using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Related Symbol: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class RelatedSymbol
    {
        /// <summary>
        ///  Fix Tag for Related Symbol
        /// </summary>
        public const ushort FixTag = 1649;

        /// <summary>
        ///  Length of Related Symbol in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Related Symbol
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + RelatedSymbol.Length)
            {
                throw new System.Exception("Invalid Length for Related Symbol");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Related Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RelatedSymbol.Length;
        }

        /// <summary>
        ///  Encode Related Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Related Symbol
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + RelatedSymbol.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Related Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RelatedSymbol.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Related Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}