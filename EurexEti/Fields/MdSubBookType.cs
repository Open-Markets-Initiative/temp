using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Md Sub Book Type: Enum
    /// </summary>

    public sealed class MdSubBookType
    {
        /// <summary>
        ///  Implied
        /// </summary>
        public const byte Implied = 1;

        /// <summary>
        ///  Volume Weighted Average
        /// </summary>
        public const byte VolumeWeightedAverage = 2;

        /// <summary>
        ///  Fix Tag for Md Sub Book Type
        /// </summary>
        public const ushort FixTag = 1173;

        /// <summary>
        ///  Length of Md Sub Book Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Md Sub Book Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MdSubBookType.Length)
            {
                throw new System.Exception("Invalid Length for Md Sub Book Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Md Sub Book Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MdSubBookType.Length;
        }

        /// <summary>
        ///  TryDecode Md Sub Book Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MdSubBookType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Md Sub Book Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MdSubBookType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Md Sub Book Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}