using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trade Alloc Status: Enum
    /// </summary>

    public sealed class TradeAllocStatus
    {
        /// <summary>
        ///  Pending
        /// </summary>
        public const byte Pending = 1;

        /// <summary>
        ///  Approved
        /// </summary>
        public const byte Approved = 2;

        /// <summary>
        ///  Auto Approved
        /// </summary>
        public const byte AutoApproved = 3;

        /// <summary>
        ///  Uploaded
        /// </summary>
        public const byte Uploaded = 4;

        /// <summary>
        ///  Canceled
        /// </summary>
        public const byte Canceled = 5;

        /// <summary>
        ///  Pending Reversal
        /// </summary>
        public const byte PendingReversal = 7;

        /// <summary>
        ///  Side Approved Reversal
        /// </summary>
        public const byte ApprovedReversal = 8;

        /// <summary>
        ///  Reversed
        /// </summary>
        public const byte Reversed = 9;

        /// <summary>
        ///  Cancelled Reversal
        /// </summary>
        public const byte CancelledReversal = 10;

        /// <summary>
        ///  Fix Tag for Trade Alloc Status
        /// </summary>
        public const ushort FixTag = 1840;

        /// <summary>
        ///  Length of Trade Alloc Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trade Alloc Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradeAllocStatus.Length)
            {
                throw new System.Exception("Invalid Length for Trade Alloc Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Alloc Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradeAllocStatus.Length;
        }

        /// <summary>
        ///  TryDecode Trade Alloc Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradeAllocStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade Alloc Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeAllocStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Alloc Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}