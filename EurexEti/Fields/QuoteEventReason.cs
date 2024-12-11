using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Event Reason: Enum
    /// </summary>

    public static class QuoteEventReason
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
        ///  Fix Tag for Quote Event Reason
        /// </summary>
        public const ushort FixTag = 28733;

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
        ///  Check available length and set Quote Event Reason to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + QuoteEventReason.Length)
            {
                throw new System.Exception("Invalid Length for Quote Event Reason");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Quote Event Reason to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + QuoteEventReason.Length;
        }

        /// <summary>
        ///  Set Quote Event Reason to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Quote Event Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEventReason.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Quote Event Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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