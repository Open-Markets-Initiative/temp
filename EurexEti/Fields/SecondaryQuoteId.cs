using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Secondary Quote Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class SecondaryQuoteId
    {
        /// <summary>
        ///  Fix Tag for Secondary Quote Id
        /// </summary>
        public const ushort FixTag = 1751;

        /// <summary>
        ///  Length of Secondary Quote Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Secondary Quote Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + SecondaryQuoteId.Length)
            {
                throw new System.Exception("Invalid Length for Secondary Quote Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SecondaryQuoteId.Length;
        }

        /// <summary>
        ///  Encode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Secondary Quote Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + SecondaryQuoteId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SecondaryQuoteId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Secondary Quote Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}