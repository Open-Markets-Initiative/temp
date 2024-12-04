using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Fill Liquidity Ind: Enum
    /// </summary>

    public sealed class FillLiquidityInd
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
        ///  Triggered Stop Order
        /// </summary>
        public const byte TriggeredStopOrder = 5;

        /// <summary>
        ///  Triggered OCO Order
        /// </summary>
        public const byte TriggeredOcoOrder = 6;

        /// <summary>
        ///  Triggered Market Order
        /// </summary>
        public const byte TriggeredMarketOrder = 7;

        /// <summary>
        ///  Fix Tag for Fill Liquidity Ind
        /// </summary>
        public const ushort FixTag = 1443;

        /// <summary>
        ///  Length of Fill Liquidity Ind in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Fill Liquidity Ind
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + FillLiquidityInd.Length)
            {
                throw new System.Exception("Invalid Length for Fill Liquidity Ind");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Fill Liquidity Ind
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + FillLiquidityInd.Length;
        }

        /// <summary>
        ///  TryDecode Fill Liquidity Ind
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + FillLiquidityInd.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Fill Liquidity Ind
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + FillLiquidityInd.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Fill Liquidity Ind
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}