using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Cross Type: Enum
    /// </summary>

    public static class CrossType
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
        ///  Check available length and set Cross Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + CrossType.Length)
            {
                throw new System.Exception("Invalid Length for Cross Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Cross Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + CrossType.Length;
        }

        /// <summary>
        ///  Set Cross Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Cross Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + CrossType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Cross Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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