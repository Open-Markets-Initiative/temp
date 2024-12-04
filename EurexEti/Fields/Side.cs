using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side: Enum
    /// </summary>

    public sealed class Side
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
        ///  Fix Tag for Side
        /// </summary>
        public const ushort FixTag = 54;

        /// <summary>
        ///  Length of Side in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Side
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + Side.Length)
            {
                throw new System.Exception("Invalid Length for Side");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + Side.Length;
        }

        /// <summary>
        ///  TryDecode Side
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + Side.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + Side.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}