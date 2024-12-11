using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Event Liquidity Ind: Enum
    /// </summary>

    public static class QuoteEventLiquidityInd
    {
        /// <summary>
        ///  Added Liquidity
        /// </summary>
        public const byte AddedLiquidity = 1;

        /// <summary>
        ///  Removed Liquidity
        /// </summary>
        public const byte RemovedLiquidity = 2;

        /// <summary>
        ///  Auction
        /// </summary>
        public const byte Auction = 4;

        /// <summary>
        ///  Fix Tag for Quote Event Liquidity Ind
        /// </summary>
        public const ushort FixTag = 28641;

        /// <summary>
        ///  Length of Quote Event Liquidity Ind in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Quote Event Liquidity Ind
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Quote Event Liquidity Ind
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteEventLiquidityInd.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Liquidity Ind");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Event Liquidity Ind
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteEventLiquidityInd.Length;
        }

        /// <summary>
        ///  Check available length and set Quote Event Liquidity Ind to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuoteEventLiquidityInd.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Liquidity Ind");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quote Event Liquidity Ind to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuoteEventLiquidityInd.Length;
        }

        /// <summary>
        ///  Set Quote Event Liquidity Ind to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quote Event Liquidity Ind
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEventLiquidityInd.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quote Event Liquidity Ind
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Quote Event Liquidity Ind
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEventLiquidityInd.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Event Liquidity Ind
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}