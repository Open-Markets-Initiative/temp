using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Type: Enum
    /// </summary>

    public sealed class CrossType
    {
        /// <summary>
        ///  Immediate-or-cancel-cross
        /// </summary>
        public const byte CrossIoc = 2;

        /// <summary>
        ///  One sided cross - unfilled quantity remains active after crossing. Only applicable for CrossRequestType(28771) = 1(Cross Announcement)
        /// </summary>
        public const byte Crossoneside = 3;

        /// <summary>
        ///  Fix Tag for Cross Type
        /// </summary>
        public const ushort FixTag = 549;

        /// <summary>
        ///  Length of Cross Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Cross Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + CrossType.Length)
            {
                throw new System.Exception("Invalid Length for Cross Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Cross Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + CrossType.Length;
        }

        /// <summary>
        ///  TryDecode Cross Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + CrossType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Cross Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + CrossType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Cross Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}