using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Alloc Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class AllocId
    {
        /// <summary>
        ///  Fix Tag for Alloc Id
        /// </summary>
        public const ushort FixTag = 70;

        /// <summary>
        ///  Length of Alloc Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Alloc Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + AllocId.Length)
            {
                throw new System.Exception("Invalid Length for Alloc Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + AllocId.Length;
        }

        /// <summary>
        ///  Encode Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Alloc Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + AllocId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + AllocId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Alloc Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}