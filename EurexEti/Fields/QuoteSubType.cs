using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Sub Type: Enum
    /// </summary>

    public sealed class QuoteSubType
    {
        /// <summary>
        ///  Working Delta
        /// </summary>
        public const byte WorkingDelta = 1;

        /// <summary>
        ///  Basis Trade
        /// </summary>
        public const byte BasisTrade = 2;

        /// <summary>
        ///  Regular LDS Negotiation
        /// </summary>
        public const byte Regular = 3;

        /// <summary>
        ///  Negotiate the underlying outside the exchange
        /// </summary>
        public const byte NegotiateUnderlyingOutsideExchange = 4;

        /// <summary>
        ///  Option Volatility Strategy with fixed Underlying price and delta
        /// </summary>
        public const byte VolaStrategyFix = 5;

        /// <summary>
        ///  Option Volatility Strategy - Underlying price is negotiated on exchange
        /// </summary>
        public const byte VolaStrategyNegotiateUnderlying = 6;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteSubTypeMaximumValue = 6;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteSubTypeMinimumValue = 1;

        /// <summary>
        ///  Length of Quote Sub Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Sub Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteSubType.Length)
            {
                throw new System.Exception("Invalid Length for Quote Sub Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteSubType.Length;
        }

        /// <summary>
        ///  TryDecode Quote Sub Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteSubType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteSubType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Sub Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}