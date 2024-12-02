using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trade Publish Indicator: Enum
    /// </summary>

    public sealed class TradePublishIndicator
    {
        /// <summary>
        ///  Do not publish trade
        /// </summary>
        public const byte DoNotPublishTrade = 0;

        /// <summary>
        ///  Publish trade
        /// </summary>
        public const byte PublishTrade = 1;

        /// <summary>
        ///  Deferred publication to market
        /// </summary>
        public const byte DeferredPublication = 2;

        /// <summary>
        ///  Published to market
        /// </summary>
        public const byte Published = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradePublishIndicatorMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradePublishIndicatorMinimumValue = 0;

        /// <summary>
        ///  Length of Trade Publish Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trade Publish Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradePublishIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Trade Publish Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Publish Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradePublishIndicator.Length;
        }

        /// <summary>
        ///  TryDecode Trade Publish Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradePublishIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade Publish Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradePublishIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Publish Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}