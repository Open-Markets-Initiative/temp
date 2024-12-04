using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Transfer Reason: Enum
    /// </summary>

    public sealed class TransferReason
    {
        /// <summary>
        ///  Owner
        /// </summary>
        public const byte Owner = 1;

        /// <summary>
        ///  Clearer
        /// </summary>
        public const byte Clearer = 2;

        /// <summary>
        ///  Fix Tag for Transfer Reason
        /// </summary>
        public const ushort FixTag = 830;

        /// <summary>
        ///  Length of Transfer Reason in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Transfer Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TransferReason.Length)
            {
                throw new System.Exception("Invalid Length for Transfer Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Transfer Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TransferReason.Length;
        }

        /// <summary>
        ///  TryDecode Transfer Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TransferReason.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Transfer Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TransferReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Transfer Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}