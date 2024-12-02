using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trd Type: Enum
    /// </summary>

    public sealed class TrdType
    {
        /// <summary>
        ///  Block Trade
        /// </summary>
        public const ushort BlockTrade = 1;

        /// <summary>
        ///  Exchange for Swap
        /// </summary>
        public const ushort ExchangeforSwap = 12;

        /// <summary>
        ///  Vola Trade
        /// </summary>
        public const ushort VolaTrade = 1000;

        /// <summary>
        ///  EFP-Fin Trade
        /// </summary>
        public const ushort EfpFinTrade = 1001;

        /// <summary>
        ///  EFP-Index Futures Trade
        /// </summary>
        public const ushort EfpIndexFuturesTrade = 1002;

        /// <summary>
        ///  Trade at Market
        /// </summary>
        public const ushort TradeatMarket = 1004;

        /// <summary>
        ///  Eurex/Xetra Enlight triggered trade
        /// </summary>
        public const ushort Enlight = 1006;

        /// <summary>
        ///  QTPIP BLOCK TRADE
        /// </summary>
        public const ushort Blockqtpip = 1007;

        /// <summary>
        ///  Basket of Equity Total Return Futures
        /// </summary>
        public const ushort Btrf = 1010;

        /// <summary>
        ///  Equity Bespoke Baskets
        /// </summary>
        public const ushort Ebb = 1011;

        /// <summary>
        ///  Delta Neutral Trade at Market
        /// </summary>
        public const ushort DeltaNeutralTradeatMarket = 1017;

        /// <summary>
        ///  
        /// </summary>
        public const ushort TrdTypeMaximumValue = 1017;

        /// <summary>
        ///  
        /// </summary>
        public const ushort TrdTypeMinimumValue = 1;

        /// <summary>
        ///  Length of Trd Type in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Trd Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + TrdType.Length)
            {
                throw new System.Exception("Invalid Length for Trd Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trd Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            *(ushort*) (pointer + offset) = value;

            current = offset + TrdType.Length;
        }

        /// <summary>
        ///  TryDecode Trd Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + TrdType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trd Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TrdType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trd Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}