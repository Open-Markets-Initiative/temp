using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Request Type: Enum
    /// </summary>

    public sealed class CrossRequestType
    {
        /// <summary>
        ///  Cross Announcement
        /// </summary>
        public const byte Cross = 1;

        /// <summary>
        ///  Liquidity Improvement Cross
        /// </summary>
        public const byte Clip = 2;

        /// <summary>
        ///  Fix Tag for Cross Request Type
        /// </summary>
        public const ushort FixTag = 28771;

        /// <summary>
        ///  Length of Cross Request Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Cross Request Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + CrossRequestType.Length)
            {
                throw new System.Exception("Invalid Length for Cross Request Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cross Request Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + CrossRequestType.Length;
        }

        /// <summary>
        ///  TryDecode Cross Request Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + CrossRequestType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Cross Request Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CrossRequestType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cross Request Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}