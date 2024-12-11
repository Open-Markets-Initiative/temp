using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Reversal Cancellation Reason: Enum
    /// </summary>

    public static class ReversalCancellationReason
    {
        /// <summary>
        ///  TES Activity State Change
        /// </summary>
        public const byte TasChange = 1;

        /// <summary>
        ///  Instrument Expiration
        /// </summary>
        public const byte IntradayExpiration = 2;

        /// <summary>
        ///  Instrument Deletion
        /// </summary>
        public const byte InstrumentDeletion = 3;

        /// <summary>
        ///  Instrument Suspension
        /// </summary>
        public const byte InstrumentSuspension = 4;

        /// <summary>
        ///  Fix Tag for Reversal Cancellation Reason
        /// </summary>
        public const ushort FixTag = 25195;

        /// <summary>
        ///  Length of Reversal Cancellation Reason in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Reversal Cancellation Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ReversalCancellationReason.Length)
            {
                throw new System.Exception("Invalid Length for Reversal Cancellation Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Reversal Cancellation Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ReversalCancellationReason.Length;
        }

        /// <summary>
        ///  Check available length and set Reversal Cancellation Reason to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ReversalCancellationReason.Length)
            {
                throw new System.Exception("Invalid Length for Reversal Cancellation Reason");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Reversal Cancellation Reason to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ReversalCancellationReason.Length;
        }

        /// <summary>
        ///  Set Reversal Cancellation Reason to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Reversal Cancellation Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ReversalCancellationReason.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Reversal Cancellation Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Reversal Cancellation Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ReversalCancellationReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Reversal Cancellation Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}