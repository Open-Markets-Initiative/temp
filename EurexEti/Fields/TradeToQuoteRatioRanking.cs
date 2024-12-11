using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trade To Quote Ratio Ranking: Enum
    /// </summary>

    public static class TradeToQuoteRatioRanking
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
        ///  Fix Tag for Trade To Quote Ratio Ranking
        /// </summary>
        public const ushort FixTag = 25179;

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
        ///  Check available length and set Trade To Quote Ratio Ranking to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TradeToQuoteRatioRanking.Length)
            {
                throw new System.Exception("Invalid Length for Trade To Quote Ratio Ranking");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trade To Quote Ratio Ranking to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TradeToQuoteRatioRanking.Length;
        }

        /// <summary>
        ///  Set Trade To Quote Ratio Ranking to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Trade To Quote Ratio Ranking
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradeToQuoteRatioRanking.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trade To Quote Ratio Ranking
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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