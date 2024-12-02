using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Appl Seq Trade Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class ApplSeqTradeDate
    {
        /// <summary>
        ///  Length of Appl Seq Trade Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Appl Seq Trade Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + ApplSeqTradeDate.Length)
            {
                throw new System.Exception("Invalid Length for Appl Seq Trade Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Appl Seq Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ApplSeqTradeDate.Length;
        }

        /// <summary>
        ///  Encode Appl Seq Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Appl Seq Trade Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + ApplSeqTradeDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Appl Seq Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ApplSeqTradeDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Appl Seq Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}