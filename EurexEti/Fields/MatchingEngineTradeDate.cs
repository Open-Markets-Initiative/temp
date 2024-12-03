using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Matching Engine Trade Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class MatchingEngineTradeDate
    {
        /// <summary>
        ///  Fix Tag for Matching Engine Trade Date
        /// </summary>
        public const ushort FixTag = 25030;

        /// <summary>
        ///  Length of Matching Engine Trade Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Matching Engine Trade Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + MatchingEngineTradeDate.Length)
            {
                throw new System.Exception("Invalid Length for Matching Engine Trade Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Matching Engine Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MatchingEngineTradeDate.Length;
        }

        /// <summary>
        ///  Encode Matching Engine Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Matching Engine Trade Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MatchingEngineTradeDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Matching Engine Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MatchingEngineTradeDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Matching Engine Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}