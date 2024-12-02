using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Transaction Delay Indicator: Enum
    /// </summary>

    public sealed class TransactionDelayIndicator
    {
        /// <summary>
        ///  Transaction not delayed
        /// </summary>
        public const byte Notdelayed = 0;

        /// <summary>
        ///  Transaction delayed
        /// </summary>
        public const byte Delayed = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte TransactionDelayIndicatorMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte TransactionDelayIndicatorMinimumValue = 0;

        /// <summary>
        ///  Length of Transaction Delay Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Transaction Delay Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TransactionDelayIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Transaction Delay Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Transaction Delay Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TransactionDelayIndicator.Length;
        }

        /// <summary>
        ///  TryDecode Transaction Delay Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TransactionDelayIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Transaction Delay Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TransactionDelayIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Transaction Delay Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}