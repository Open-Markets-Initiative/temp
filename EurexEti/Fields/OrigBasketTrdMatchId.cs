using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Orig Basket Trd Match Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class OrigBasketTrdMatchId
    {
        /// <summary>
        ///  Fix Tag for Orig Basket Trd Match Id
        /// </summary>
        public const ushort FixTag = 25248;

        /// <summary>
        ///  Length of Orig Basket Trd Match Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Orig Basket Trd Match Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + OrigBasketTrdMatchId.Length)
            {
                throw new System.Exception("Invalid Length for Orig Basket Trd Match Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Orig Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + OrigBasketTrdMatchId.Length;
        }

        /// <summary>
        ///  Encode Orig Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Orig Basket Trd Match Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + OrigBasketTrdMatchId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Orig Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrigBasketTrdMatchId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Orig Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}