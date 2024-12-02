using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Individual Alloc Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class IndividualAllocId
    {
        /// <summary>
        ///  Length of Individual Alloc Id in bytes
        /// </summary>
        public const int Length = 4;

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
        ///  TryDecode Individual Alloc Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + IndividualAllocId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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