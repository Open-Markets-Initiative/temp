using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Alloc Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class AllocId
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
        ///  Null value for Alloc Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

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
        ///  Check available length and set Alloc Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + AllocId.Length)
            {
                throw new System.Exception("Invalid Length for Alloc Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Alloc Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + AllocId.Length;
        }

        /// <summary>
        ///  Set Alloc Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Alloc Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + AllocId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Alloc Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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