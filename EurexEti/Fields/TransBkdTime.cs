using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trans Bkd Time: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class TransBkdTime
    {
        /// <summary>
        ///  Fix Tag for Trans Bkd Time
        /// </summary>
        public const ushort FixTag = 483;

        /// <summary>
        ///  Length of Trans Bkd Time in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Trans Bkd Time
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

        /// <summary>
        ///  Encode Trans Bkd Time
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + TransBkdTime.Length)
            {
                throw new System.Exception("Invalid Length for Trans Bkd Time");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trans Bkd Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + TransBkdTime.Length;
        }

        /// <summary>
        ///  Encode Trans Bkd Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Trans Bkd Time to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + TransBkdTime.Length)
            {
                throw new System.Exception("Invalid Length for Trans Bkd Time");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Trans Bkd Time to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + TransBkdTime.Length;
        }

        /// <summary>
        ///  Set Trans Bkd Time to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Trans Bkd Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + TransBkdTime.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Trans Bkd Time
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Trans Bkd Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TransBkdTime.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trans Bkd Time
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}