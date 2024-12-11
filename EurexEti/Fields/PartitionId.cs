using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Partition Id: Optional 2 Byte Fixed Width Integer
    /// </summary>

    public static class PartitionId
    {
        /// <summary>
        ///  Fix Tag for Partition Id
        /// </summary>
        public const ushort FixTag = 5948;

        /// <summary>
        ///  Length of Partition Id in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Null value for Partition Id
        /// </summary>
        public const ushort NoValue = 0xFFFF;

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
        ///  Check available length and set Partition Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartitionId.Length)
            {
                throw new System.Exception("Invalid Length for Partition Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Partition Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartitionId.Length;
        }

        /// <summary>
        ///  Set Partition Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ushort*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Partition Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + PartitionId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Partition Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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