using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Side: Enum
    /// </summary>

    public sealed class OrderSide
    {
        /// <summary>
        ///  Buy
        /// </summary>
        public const byte Buy = 1;

        /// <summary>
        ///  Sell
        /// </summary>
        public const byte Sell = 2;

        /// <summary>
        ///  Fix Tag for Order Side
        /// </summary>
        public const ushort FixTag = 28586;

        /// <summary>
        ///  Length of Order Side in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Order Side
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OrderSide.Length)
            {
                throw new System.Exception("Invalid Length for Order Side");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OrderSide.Length;
        }

        /// <summary>
        ///  TryDecode Order Side
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OrderSide.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderSide.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}