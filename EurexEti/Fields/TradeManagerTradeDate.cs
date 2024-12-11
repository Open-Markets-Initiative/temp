using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade Manager Trade Date: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class TradeManagerTradeDate
    {
        /// <summary>
        ///  Fix Tag for Trade Manager Trade Date
        /// </summary>
        public const ushort FixTag = 25031;

        /// <summary>
        ///  Length of Trade Manager Trade Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Trade Manager Trade Date
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Trade Manager Trade Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + TradeManagerTradeDate.Length)
            {
                throw new System.Exception("Invalid Length for Trade Manager Trade Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Manager Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TradeManagerTradeDate.Length;
        }

        /// <summary>
        ///  Encode Trade Manager Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Trade Manager Trade Date to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TradeManagerTradeDate.Length)
            {
                throw new System.Exception("Invalid Length for Trade Manager Trade Date");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trade Manager Trade Date to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TradeManagerTradeDate.Length;
        }

        /// <summary>
        ///  Set Trade Manager Trade Date to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Trade Manager Trade Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + TradeManagerTradeDate.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trade Manager Trade Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Trade Manager Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeManagerTradeDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Manager Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}