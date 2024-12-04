using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Event Side: Enum
    /// </summary>

    public sealed class QuoteEventSide
    {
        /// <summary>
        ///  Buy
        /// </summary>
        public const byte Buy = 1;

        /// <summary>
        ///  Sell
        /// </summary>
        public const byte Sell = 2;

        /// <summary>
        ///  Fix Tag for Quote Event Side
        /// </summary>
        public const ushort FixTag = 28581;

        /// <summary>
        ///  Length of Quote Event Side in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Event Side
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteEventSide.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Side");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Event Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteEventSide.Length;
        }

        /// <summary>
        ///  TryDecode Quote Event Side
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEventSide.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Event Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEventSide.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Event Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}