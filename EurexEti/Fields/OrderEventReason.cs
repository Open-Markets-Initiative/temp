using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Event Reason: Enum
    /// </summary>

    public sealed class OrderEventReason
    {
        /// <summary>
        ///  SMP event
        /// </summary>
        public const byte Smp = 100;

        /// <summary>
        ///  Fix Tag for Order Event Reason
        /// </summary>
        public const ushort FixTag = 1798;

        /// <summary>
        ///  Length of Order Event Reason in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Order Event Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OrderEventReason.Length)
            {
                throw new System.Exception("Invalid Length for Order Event Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Event Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OrderEventReason.Length;
        }

        /// <summary>
        ///  TryDecode Order Event Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OrderEventReason.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Event Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderEventReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Event Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}