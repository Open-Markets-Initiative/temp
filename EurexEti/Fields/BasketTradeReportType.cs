using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Basket Trade Report Type: Enum
    /// </summary>

    public sealed class BasketTradeReportType
    {
        /// <summary>
        ///  Submit
        /// </summary>
        public const byte Submit = 0;

        /// <summary>
        ///  Addendum
        /// </summary>
        public const byte Addendum = 4;

        /// <summary>
        ///  No/Was (Substitute)
        /// </summary>
        public const byte NoWasSubstitue = 5;

        /// <summary>
        ///  Fix Tag for Basket Trade Report Type
        /// </summary>
        public const ushort FixTag = 25173;

        /// <summary>
        ///  Length of Basket Trade Report Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Basket Trade Report Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + BasketTradeReportType.Length)
            {
                throw new System.Exception("Invalid Length for Basket Trade Report Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Basket Trade Report Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + BasketTradeReportType.Length;
        }

        /// <summary>
        ///  TryDecode Basket Trade Report Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + BasketTradeReportType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Basket Trade Report Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BasketTradeReportType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Basket Trade Report Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}