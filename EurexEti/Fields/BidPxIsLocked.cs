using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Bid Px Is Locked: Enum
    /// </summary>

    public sealed class BidPxIsLocked
    {
        /// <summary>
        ///  No
        /// </summary>
        public const byte No = 0;

        /// <summary>
        ///  Yes
        /// </summary>
        public const byte Yes = 1;

        /// <summary>
        ///  Fix Tag for Bid Px Is Locked
        /// </summary>
        public const ushort FixTag = 25206;

        /// <summary>
        ///  Length of Bid Px Is Locked in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Bid Px Is Locked
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + BidPxIsLocked.Length)
            {
                throw new System.Exception("Invalid Length for Bid Px Is Locked");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Bid Px Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + BidPxIsLocked.Length;
        }

        /// <summary>
        ///  TryDecode Bid Px Is Locked
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + BidPxIsLocked.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Bid Px Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BidPxIsLocked.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Bid Px Is Locked
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}