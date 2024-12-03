using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Heart Bt Int: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class HeartBtInt
    {
        /// <summary>
        ///  Fix Tag for Heart Bt Int
        /// </summary>
        public const ushort FixTag = 108;

        /// <summary>
        ///  Length of Heart Bt Int in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Heart Bt Int
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + HeartBtInt.Length)
            {
                throw new System.Exception("Invalid Length for Heart Bt Int");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Heart Bt Int
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + HeartBtInt.Length;
        }

        /// <summary>
        ///  Encode Heart Bt Int
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Heart Bt Int
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + HeartBtInt.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Heart Bt Int
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + HeartBtInt.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Heart Bt Int
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}