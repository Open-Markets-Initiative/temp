using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Enlight Rfq Avg Resp Time Ranking: Enum
    /// </summary>

    public sealed class EnlightRfqAvgRespTimeRanking
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
        public const byte EnlightRfqAvgRespTimeRankingMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte EnlightRfqAvgRespTimeRankingMinimumValue = 1;

        /// <summary>
        ///  Length of Enlight Rfq Avg Resp Time Ranking in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Enlight Rfq Avg Resp Time Ranking
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + EnlightRfqAvgRespTimeRanking.Length)
            {
                throw new System.Exception("Invalid Length for Enlight Rfq Avg Resp Time Ranking");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Enlight Rfq Avg Resp Time Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + EnlightRfqAvgRespTimeRanking.Length;
        }

        /// <summary>
        ///  TryDecode Enlight Rfq Avg Resp Time Ranking
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + EnlightRfqAvgRespTimeRanking.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Enlight Rfq Avg Resp Time Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EnlightRfqAvgRespTimeRanking.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Enlight Rfq Avg Resp Time Ranking
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}