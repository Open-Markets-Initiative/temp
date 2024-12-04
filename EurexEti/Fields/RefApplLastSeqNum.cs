using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Ref Appl Last Seq Num: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class RefApplLastSeqNum
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
        ///  TryDecode Ref Appl Last Seq Num
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + RefApplLastSeqNum.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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