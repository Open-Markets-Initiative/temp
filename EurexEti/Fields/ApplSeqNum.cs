using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Appl Seq Num: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class ApplSeqNum
    {
        /// <summary>
        ///  Fix Tag for Appl Seq Num
        /// </summary>
        public const ushort FixTag = 1181;

        /// <summary>
        ///  Length of Appl Seq Num in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Appl Seq Num
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

        /// <summary>
        ///  Encode Appl Seq Num
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ApplSeqNum.Length)
            {
                throw new System.Exception("Invalid Length for Appl Seq Num");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ApplSeqNum.Length;
        }

        /// <summary>
        ///  Encode Appl Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Appl Seq Num to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ApplSeqNum.Length)
            {
                throw new System.Exception("Invalid Length for Appl Seq Num");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Appl Seq Num to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ApplSeqNum.Length;
        }

        /// <summary>
        ///  Set Appl Seq Num to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Appl Seq Num
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ApplSeqNum.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Appl Seq Num
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Appl Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplSeqNum.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}