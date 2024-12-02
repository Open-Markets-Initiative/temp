using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trade Manager Status: Enum
    /// </summary>

    public sealed class TradeManagerStatus
    {
        /// <summary>
        ///  Unavailable
        /// </summary>
        public const byte Unavailable = 0;

        /// <summary>
        ///  Available
        /// </summary>
        public const byte Available = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradeManagerStatusMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradeManagerStatusMinimumValue = 0;

        /// <summary>
        ///  Length of Trade Manager Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trade Manager Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradeManagerStatus.Length)
            {
                throw new System.Exception("Invalid Length for Trade Manager Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Manager Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradeManagerStatus.Length;
        }

        /// <summary>
        ///  TryDecode Trade Manager Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradeManagerStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade Manager Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradeManagerStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Manager Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}