using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trade To Quote Ratio Ranking: Enum
    /// </summary>

    public sealed class TradeToQuoteRatioRanking
    {
        /// <summary>
        ///  Low
        /// </summary>
        public const byte Low = 1;

        /// <summary>
        ///  Medium
        /// </summary>
        public const byte Medium = 2;

        /// <summary>
        ///  High
        /// </summary>
        public const byte High = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradeToQuoteRatioRankingMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradeToQuoteRatioRankingMinimumValue = 1;

        /// <summary>
        ///  Length of Trade To Quote Ratio Ranking in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trade To Quote Ratio Ranking
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradeToQuoteRatioRanking.Length)
            {
                throw new System.Exception("Invalid Length for Trade To Quote Ratio Ranking");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade To Quote Ratio Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradeToQuoteRatioRanking.Length;
        }

        /// <summary>
        ///  TryDecode Trade To Quote Ratio Ranking
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradeToQuoteRatioRanking.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade To Quote Ratio Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeToQuoteRatioRanking.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade To Quote Ratio Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}