using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Response Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class QuoteResponseId
    {
        /// <summary>
        ///  Fix Tag for Quote Response Id
        /// </summary>
        public const ushort FixTag = 693;

        /// <summary>
        ///  Length of Quote Response Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Quote Response Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + QuoteResponseId.Length)
            {
                throw new System.Exception("Invalid Length for Quote Response Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + QuoteResponseId.Length;
        }

        /// <summary>
        ///  Encode Quote Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Quote Response Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + QuoteResponseId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteResponseId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Response Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}