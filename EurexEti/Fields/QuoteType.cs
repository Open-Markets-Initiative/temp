using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Type: Enum
    /// </summary>

    public sealed class QuoteType
    {
        /// <summary>
        ///  Indicative (for Continuous Auction Issuer trading model and Eurex/Xetra EnLight only)
        /// </summary>
        public const byte Indicative = 0;

        /// <summary>
        ///  Tradeable
        /// </summary>
        public const byte Tradeable = 1;

        /// <summary>
        ///  Tradeable(BOC)
        /// </summary>
        public const byte TradeableBoc = 100;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteTypeMaximumValue = 104;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteTypeMinimumValue = 0;

        /// <summary>
        ///  Length of Quote Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteType.Length)
            {
                throw new System.Exception("Invalid Length for Quote Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteType.Length;
        }

        /// <summary>
        ///  TryDecode Quote Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}