using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Partition Id: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class PartitionId
    {
        /// <summary>
        ///  Length of Partition Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Partition Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + PartitionId.Length)
            {
                throw new System.Exception("Invalid Length for Partition Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Partition Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PartitionId.Length;
        }

        /// <summary>
        ///  Encode Partition Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Partition Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + PartitionId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Partition Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartitionId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Partition Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}