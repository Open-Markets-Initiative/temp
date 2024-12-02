using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Match Type: Enum
    /// </summary>

    public sealed class MatchType
    {
        /// <summary>
        ///  Confirmed Trade Report (reporting from recognized markets)
        /// </summary>
        public const byte ConfirmedTradeReport = 3;

        /// <summary>
        ///  Auto-match incoming order
        /// </summary>
        public const byte Automatchincoming = 4;

        /// <summary>
        ///  Cross Auction
        /// </summary>
        public const byte CrossAuction = 5;

        /// <summary>
        ///  Call Auction
        /// </summary>
        public const byte CallAuction = 7;

        /// <summary>
        ///  Auto match resting order
        /// </summary>
        public const byte Automatchresting = 11;

        /// <summary>
        ///  Liquidity Improvement Cross
        /// </summary>
        public const byte LiquidityImprovementCross = 13;

        /// <summary>
        ///  
        /// </summary>
        public const byte MatchTypeMaximumValue = 15;

        /// <summary>
        ///  
        /// </summary>
        public const byte MatchTypeMinimumValue = 0;

        /// <summary>
        ///  Length of Match Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Match Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MatchType.Length)
            {
                throw new System.Exception("Invalid Length for Match Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Match Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MatchType.Length;
        }

        /// <summary>
        ///  TryDecode Match Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MatchType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Match Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MatchType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Match Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}