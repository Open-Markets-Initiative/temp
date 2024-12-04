using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Quote Size Type: Enum
    /// </summary>

    public sealed class QuoteSizeType
    {
        /// <summary>
        ///  Total Size (Quote Modification)
        /// </summary>
        public const byte TotalSize = 1;

        /// <summary>
        ///  Open Size(Quote Entry)
        /// </summary>
        public const byte OpenSize = 2;

        /// <summary>
        ///  Fix Tag for Quote Size Type
        /// </summary>
        public const ushort FixTag = 28723;

        /// <summary>
        ///  Length of Quote Size Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Quote Size Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + QuoteSizeType.Length)
            {
                throw new System.Exception("Invalid Length for Quote Size Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Quote Size Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + QuoteSizeType.Length;
        }

        /// <summary>
        ///  TryDecode Quote Size Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + QuoteSizeType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Quote Size Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + QuoteSizeType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Quote Size Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}