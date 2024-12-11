using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Related Symbol: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class RelatedSymbol
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
        ///  Null value for Related Symbol
        /// </summary>
        public const int NoValue = 0x80000000;

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
        ///  Check available length and set Related Symbol to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RelatedSymbol.Length)
            {
                throw new System.Exception("Invalid Length for Related Symbol");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Related Symbol to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RelatedSymbol.Length;
        }

        /// <summary>
        ///  Set Related Symbol to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(int*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Related Symbol
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + RelatedSymbol.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Related Symbol
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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