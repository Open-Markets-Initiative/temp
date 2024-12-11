using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade Publish Indicator: Enum
    /// </summary>

    public static class TradePublishIndicator
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
        ///  Fix Tag for Trade Publish Indicator
        /// </summary>
        public const ushort FixTag = 1390;

        /// <summary>
        ///  Length of Trade Publish Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Trade Publish Indicator
        /// </summary>
        public const byte NoValue = 0xFF;

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
        ///  Check available length and set Trade Publish Indicator to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TradePublishIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Trade Publish Indicator");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trade Publish Indicator to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TradePublishIndicator.Length;
        }

        /// <summary>
        ///  Set Trade Publish Indicator to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Trade Publish Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradePublishIndicator.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trade Publish Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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