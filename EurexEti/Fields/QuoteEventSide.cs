using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Event Side: Enum
    /// </summary>

    public static class QuoteEventSide
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
        ///  Null value for Quote Event Side
        /// </summary>
        public const byte NoValue = 0xFF;

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
        ///  Check available length and set Quote Event Side to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuoteEventSide.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Side");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quote Event Side to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuoteEventSide.Length;
        }

        /// <summary>
        ///  Set Quote Event Side to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quote Event Side
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEventSide.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quote Event Side
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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