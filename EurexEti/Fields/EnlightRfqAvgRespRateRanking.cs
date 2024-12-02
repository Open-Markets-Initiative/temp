using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Enlight Rfq Avg Resp Rate Ranking: Enum
    /// </summary>

    public sealed class EnlightRfqAvgRespRateRanking
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
        public const byte EnlightRfqAvgRespRateRankingMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte EnlightRfqAvgRespRateRankingMinimumValue = 1;

        /// <summary>
        ///  Length of Enlight Rfq Avg Resp Rate Ranking in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Enlight Rfq Avg Resp Rate Ranking
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + EnlightRfqAvgRespRateRanking.Length)
            {
                throw new System.Exception("Invalid Length for Enlight Rfq Avg Resp Rate Ranking");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Enlight Rfq Avg Resp Rate Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + EnlightRfqAvgRespRateRanking.Length;
        }

        /// <summary>
        ///  TryDecode Enlight Rfq Avg Resp Rate Ranking
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + EnlightRfqAvgRespRateRanking.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Enlight Rfq Avg Resp Rate Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EnlightRfqAvgRespRateRanking.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Enlight Rfq Avg Resp Rate Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}