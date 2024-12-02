using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Exposure Duration: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class ExposureDuration
    {
        /// <summary>
        ///  Length of Exposure Duration in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Exposure Duration
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
        {
            if (length > offset + ExposureDuration.Length)
            {
                throw new System.Exception("Invalid Length for Exposure Duration");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Exposure Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + ExposureDuration.Length;
        }

        /// <summary>
        ///  Encode Exposure Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value)
        {
            *(long*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Exposure Duration
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
        {
            if (length > offset + ExposureDuration.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Exposure Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ExposureDuration.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Exposure Duration
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset)
        {
            return *(long*) (pointer + offset);
        }
    }
}