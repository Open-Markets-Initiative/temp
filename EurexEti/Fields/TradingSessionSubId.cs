using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Trading Session Sub Id: Enum
    /// </summary>

    public sealed class TradingSessionSubId
    {
        /// <summary>
        ///  Opening or opening auction
        /// </summary>
        public const byte Openingauction = 2;

        /// <summary>
        ///  Closing or closing auction
        /// </summary>
        public const byte Closingauction = 4;

        /// <summary>
        ///  Any auction
        /// </summary>
        public const byte AnyAuction = 8;

        /// <summary>
        ///  Fix Tag for Trading Session Sub Id
        /// </summary>
        public const ushort FixTag = 625;

        /// <summary>
        ///  Length of Trading Session Sub Id in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trading Session Sub Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradingSessionSubId.Length)
            {
                throw new System.Exception("Invalid Length for Trading Session Sub Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trading Session Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradingSessionSubId.Length;
        }

        /// <summary>
        ///  TryDecode Trading Session Sub Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradingSessionSubId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trading Session Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradingSessionSubId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trading Session Sub Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}