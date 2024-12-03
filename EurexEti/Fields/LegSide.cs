using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Leg Side: Enum
    /// </summary>

    public sealed class LegSide
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
        ///  Fix Tag for Leg Side
        /// </summary>
        public const ushort FixTag = 624;

        /// <summary>
        ///  Length of Leg Side in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Leg Side
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + LegSide.Length)
            {
                throw new System.Exception("Invalid Length for Leg Side");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + LegSide.Length;
        }

        /// <summary>
        ///  TryDecode Leg Side
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + LegSide.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegSide.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Side
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}