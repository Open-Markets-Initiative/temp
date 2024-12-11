using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Ref Appl Last Seq Num: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class RefApplLastSeqNum
    {
        /// <summary>
        ///  Fix Tag for Ref Appl Last Seq Num
        /// </summary>
        public const ushort FixTag = 1357;

        /// <summary>
        ///  Length of Ref Appl Last Seq Num in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Ref Appl Last Seq Num
        /// </summary>
        public const ulong NoValue = 0xFFFFFFFFFFFFFFFF;

        /// <summary>
        ///  Encode Ref Appl Last Seq Num
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + RefApplLastSeqNum.Length)
            {
                throw new System.Exception("Invalid Length for Ref Appl Last Seq Num");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Ref Appl Last Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RefApplLastSeqNum.Length;
        }

        /// <summary>
        ///  Encode Ref Appl Last Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Ref Appl Last Seq Num to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + RefApplLastSeqNum.Length)
            {
                throw new System.Exception("Invalid Length for Ref Appl Last Seq Num");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Ref Appl Last Seq Num to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + RefApplLastSeqNum.Length;
        }

        /// <summary>
        ///  Set Ref Appl Last Seq Num to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Ref Appl Last Seq Num
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + RefApplLastSeqNum.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Ref Appl Last Seq Num
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ulong value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Ref Appl Last Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RefApplLastSeqNum.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Ref Appl Last Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}