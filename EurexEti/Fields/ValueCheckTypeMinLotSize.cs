using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Value Check Type Min Lot Size: Enum
    /// </summary>

    public sealed class ValueCheckTypeMinLotSize
    {
        /// <summary>
        ///  Do not check
        /// </summary>
        public const byte Donotcheck = 0;

        /// <summary>
        ///  Check
        /// </summary>
        public const byte Check = 1;

        /// <summary>
        ///  Fix Tag for Value Check Type Min Lot Size
        /// </summary>
        public const ushort FixTag = 25175;

        /// <summary>
        ///  Length of Value Check Type Min Lot Size in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Value Check Type Min Lot Size
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ValueCheckTypeMinLotSize.Length)
            {
                throw new System.Exception("Invalid Length for Value Check Type Min Lot Size");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Value Check Type Min Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ValueCheckTypeMinLotSize.Length;
        }

        /// <summary>
        ///  TryDecode Value Check Type Min Lot Size
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ValueCheckTypeMinLotSize.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Value Check Type Min Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ValueCheckTypeMinLotSize.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Value Check Type Min Lot Size
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}