using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Reversal Cancellation Reason: Enum
    /// </summary>

    public sealed class ReversalCancellationReason
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
        ///  TryDecode Reversal Cancellation Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ReversalCancellationReason.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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