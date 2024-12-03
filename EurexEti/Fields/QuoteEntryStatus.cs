using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Entry Status: Enum
    /// </summary>

    public sealed class QuoteEntryStatus
    {
        /// <summary>
        ///  Accepted with warning
        /// </summary>
        public const byte Accepted = 0;

        /// <summary>
        ///  Rejected
        /// </summary>
        public const byte Rejected = 5;

        /// <summary>
        ///  Removed from Market
        /// </summary>
        public const byte RemovedandRejected = 6;

        /// <summary>
        ///  Pending
        /// </summary>
        public const byte Pending = 10;

        /// <summary>
        ///  Fix Tag for Quote Entry Status
        /// </summary>
        public const ushort FixTag = 1167;

        /// <summary>
        ///  Length of Quote Entry Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Entry Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteEntryStatus.Length)
            {
                throw new System.Exception("Invalid Length for Quote Entry Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Entry Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteEntryStatus.Length;
        }

        /// <summary>
        ///  TryDecode Quote Entry Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteEntryStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Entry Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteEntryStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Entry Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}