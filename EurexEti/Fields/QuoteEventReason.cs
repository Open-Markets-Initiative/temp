using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Event Reason: Enum
    /// </summary>

    public sealed class QuoteEventReason
    {
        /// <summary>
        ///  
        /// </summary>
        public const byte Pendingcancellationexecuted = 14;

        /// <summary>
        ///  
        /// </summary>
        public const byte Invalidprice = 15;

        /// <summary>
        ///  Quote subject to crossing and match prevented
        /// </summary>
        public const byte Crossrejected = 16;

        /// <summary>
        ///  Quote deleted due to Book-or-Cancel quote type
        /// </summary>
        public const byte BookorCancel = 17;

        /// <summary>
        ///  Quote deleted due to passive liquidity protection
        /// </summary>
        public const byte Plp = 18;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteEventReasonMaximumValue = 21;

        /// <summary>
        ///  
        /// </summary>
        public const byte QuoteEventReasonMinimumValue = 14;

        /// <summary>
        ///  Length of Quote Event Reason in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Event Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteEventReason.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Event Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteEventReason.Length;
        }

        /// <summary>
        ///  TryDecode Quote Event Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEventReason.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Event Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEventReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Event Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}