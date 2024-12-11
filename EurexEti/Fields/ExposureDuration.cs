using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Exposure Duration: Optional 8 Byte Fixed Width Integer
    /// </summary>

    public static class ExposureDuration
    {
        /// <summary>
        ///  Fix Tag for Exposure Duration
        /// </summary>
        public const ushort FixTag = 1629;

        /// <summary>
        ///  Length of Exposure Duration in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Null value for Exposure Duration
        /// </summary>
        public const long NoValue = 0x8000000000000000;

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
        ///  Check available length and set Exposure Duration to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ExposureDuration.Length)
            {
                throw new System.Exception("Invalid Length for Exposure Duration");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Exposure Duration to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ExposureDuration.Length;
        }

        /// <summary>
        ///  Set Exposure Duration to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(long*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Exposure Duration
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
        {
            if (length > offset + ExposureDuration.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Exposure Duration
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out long value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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