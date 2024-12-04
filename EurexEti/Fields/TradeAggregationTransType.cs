using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade Aggregation Trans Type: Enum
    /// </summary>

    public sealed class TradeAggregationTransType
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
        ///  TryDecode Trade Aggregation Trans Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradeAggregationTransType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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