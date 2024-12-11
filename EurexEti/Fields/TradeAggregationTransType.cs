using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade Aggregation Trans Type: Enum
    /// </summary>

    public static class TradeAggregationTransType
    {
        /// <summary>
        ///  New
        /// </summary>
        public const byte New = 0;

        /// <summary>
        ///  Fix Tag for Trade Aggregation Trans Type
        /// </summary>
        public const ushort FixTag = 2788;

        /// <summary>
        ///  Length of Trade Aggregation Trans Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trade Aggregation Trans Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradeAggregationTransType.Length)
            {
                throw new System.Exception("Invalid Length for Trade Aggregation Trans Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Aggregation Trans Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradeAggregationTransType.Length;
        }

        /// <summary>
        ///  Check available length and set Trade Aggregation Trans Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TradeAggregationTransType.Length)
            {
                throw new System.Exception("Invalid Length for Trade Aggregation Trans Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trade Aggregation Trans Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TradeAggregationTransType.Length;
        }

        /// <summary>
        ///  Set Trade Aggregation Trans Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Trade Aggregation Trans Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradeAggregationTransType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trade Aggregation Trans Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Trade Aggregation Trans Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeAggregationTransType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Aggregation Trans Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}