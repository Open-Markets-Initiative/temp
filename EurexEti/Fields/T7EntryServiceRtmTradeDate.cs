using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  T 7 Entry Service Rtm Trade Date: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class T7EntryServiceRtmTradeDate
    {
        /// <summary>
        ///  Fix Tag for T 7 Entry Service Rtm Trade Date
        /// </summary>
        public const ushort FixTag = 25049;

        /// <summary>
        ///  Length of T 7 Entry Service Rtm Trade Date in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode T 7 Entry Service Rtm Trade Date
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + T7EntryServiceRtmTradeDate.Length)
            {
                throw new System.Exception("Invalid Length for T 7 Entry Service Rtm Trade Date");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode T 7 Entry Service Rtm Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + T7EntryServiceRtmTradeDate.Length;
        }

        /// <summary>
        ///  Encode T 7 Entry Service Rtm Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode T 7 Entry Service Rtm Trade Date
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + T7EntryServiceRtmTradeDate.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode T 7 Entry Service Rtm Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + T7EntryServiceRtmTradeDate.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode T 7 Entry Service Rtm Trade Date
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}