using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  T 7 Entry Service Trade Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class T7EntryServiceTradeDate
    {
        /// <summary>
        ///  Length of T 7 Entry Service Trade Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode T 7 Entry Service Trade Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + T7EntryServiceTradeDate.Length)
            {
                throw new System.Exception("Invalid Length for T 7 Entry Service Trade Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode T 7 Entry Service Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + T7EntryServiceTradeDate.Length;
        }

        /// <summary>
        ///  Encode T 7 Entry Service Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode T 7 Entry Service Trade Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + T7EntryServiceTradeDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode T 7 Entry Service Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + T7EntryServiceTradeDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode T 7 Entry Service Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}