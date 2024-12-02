using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Event Liquidity Ind: Enum
    /// </summary>

    public sealed class QuoteEventLiquidityInd
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
        ///  
        /// </summary>
        public const byte QuoteEventLiquidityIndMaximumValue = 4;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteEventLiquidityIndMinimumValue = 1;

        /// <summary>
        ///  Length of Quote Event Liquidity Ind in bytes
        /// </summary>
        public const int Length = 1;

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
        ///  TryDecode Quote Event Liquidity Ind
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEventLiquidityInd.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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