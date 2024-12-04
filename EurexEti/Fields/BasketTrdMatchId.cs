using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Trd Match Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class BasketTrdMatchId
    {
        /// <summary>
        ///  Fix Tag for Basket Trd Match Id
        /// </summary>
        public const ushort FixTag = 25161;

        /// <summary>
        ///  Length of Basket Trd Match Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Basket Trd Match Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + BasketTrdMatchId.Length)
            {
                throw new System.Exception("Invalid Length for Basket Trd Match Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + BasketTrdMatchId.Length;
        }

        /// <summary>
        ///  Encode Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Basket Trd Match Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + BasketTrdMatchId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BasketTrdMatchId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Basket Trd Match Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}