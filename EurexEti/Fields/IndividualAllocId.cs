using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Individual Alloc Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class IndividualAllocId
    {
        /// <summary>
        ///  Fix Tag for Individual Alloc Id
        /// </summary>
        public const ushort FixTag = 467;

        /// <summary>
        ///  Length of Individual Alloc Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Individual Alloc Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Individual Alloc Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + IndividualAllocId.Length)
            {
                throw new System.Exception("Invalid Length for Individual Alloc Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Individual Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + IndividualAllocId.Length;
        }

        /// <summary>
        ///  Encode Individual Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Individual Alloc Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + IndividualAllocId.Length)
            {
                throw new System.Exception("Invalid Length for Individual Alloc Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Individual Alloc Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + IndividualAllocId.Length;
        }

        /// <summary>
        ///  Set Individual Alloc Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Individual Alloc Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + IndividualAllocId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Individual Alloc Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Individual Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + IndividualAllocId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Individual Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}