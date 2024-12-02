using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trade Request Result: Enum
    /// </summary>

    public sealed class TradeRequestResult
    {
        /// <summary>
        ///  Deal cancellation pending
        /// </summary>
        public const byte Cancelpending = 100;

        /// <summary>
        ///  Deal cancellation declined
        /// </summary>
        public const byte Canceldeclined = 101;

        /// <summary>
        ///  Deal cancellation approved
        /// </summary>
        public const byte Cancelapproved = 102;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradeRequestResultMaximumValue = 102;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradeRequestResultMinimumValue = 100;

        /// <summary>
        ///  Length of Trade Request Result in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trade Request Result
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradeRequestResult.Length)
            {
                throw new System.Exception("Invalid Length for Trade Request Result");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Request Result
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradeRequestResult.Length;
        }

        /// <summary>
        ///  TryDecode Trade Request Result
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradeRequestResult.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade Request Result
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeRequestResult.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Request Result
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}