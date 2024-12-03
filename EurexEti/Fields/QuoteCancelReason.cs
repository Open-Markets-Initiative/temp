using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Quote Cancel Reason: Enum
    /// </summary>

    public sealed class QuoteCancelReason
    {
        /// <summary>
        ///  Expired
        /// </summary>
        public const byte Expired = 5;

        /// <summary>
        ///  Fix Tag for Quote Cancel Reason
        /// </summary>
        public const ushort FixTag = 28747;

        /// <summary>
        ///  Length of Quote Cancel Reason in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Cancel Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteCancelReason.Length)
            {
                throw new System.Exception("Invalid Length for Quote Cancel Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Cancel Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteCancelReason.Length;
        }

        /// <summary>
        ///  TryDecode Quote Cancel Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteCancelReason.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Cancel Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteCancelReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Cancel Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}