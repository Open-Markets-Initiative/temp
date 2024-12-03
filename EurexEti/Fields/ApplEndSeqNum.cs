using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Appl End Seq Num: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ApplEndSeqNum
    {
        /// <summary>
        ///  Fix Tag for Appl End Seq Num
        /// </summary>
        public const ushort FixTag = 1183;

        /// <summary>
        ///  Length of Appl End Seq Num in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Appl End Seq Num
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + ApplEndSeqNum.Length)
            {
                throw new System.Exception("Invalid Length for Appl End Seq Num");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl End Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ApplEndSeqNum.Length;
        }

        /// <summary>
        ///  Encode Appl End Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Appl End Seq Num
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + ApplEndSeqNum.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl End Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplEndSeqNum.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl End Seq Num
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}