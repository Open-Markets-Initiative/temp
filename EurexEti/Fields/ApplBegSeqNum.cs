using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Appl Beg Seq Num: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ApplBegSeqNum
    {
        /// <summary>
        ///  Fix Tag for Appl Beg Seq Num
        /// </summary>
        public const ushort FixTag = 1182;

        /// <summary>
        ///  Length of Appl Beg Seq Num in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Appl Beg Seq Num
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ApplBegSeqNum.Length)
            {
                throw new System.Exception("Invalid Length for Appl Beg Seq Num");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Beg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ApplBegSeqNum.Length;
        }

        /// <summary>
        ///  Encode Appl Beg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Appl Beg Seq Num
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ApplBegSeqNum.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Beg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplBegSeqNum.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Beg Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}