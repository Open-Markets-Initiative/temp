using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trading Capacity: Enum
    /// </summary>

    public sealed class TradingCapacity
    {
        /// <summary>
        ///  Customer (Agency)
        /// </summary>
        public const byte Customer = 1;

        /// <summary>
        ///  Principal (Proprietary)
        /// </summary>
        public const byte Principal = 5;

        /// <summary>
        ///  Market Maker
        /// </summary>
        public const byte MarketMaker = 6;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradingCapacityMaximumValue = 11;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradingCapacityMinimumValue = 1;

        /// <summary>
        ///  Length of Trading Capacity in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trading Capacity
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradingCapacity.Length)
            {
                throw new System.Exception("Invalid Length for Trading Capacity");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trading Capacity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradingCapacity.Length;
        }

        /// <summary>
        ///  TryDecode Trading Capacity
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradingCapacity.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trading Capacity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradingCapacity.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trading Capacity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}