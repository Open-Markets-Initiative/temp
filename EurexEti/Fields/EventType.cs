using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Event Type: Enum
    /// </summary>

    public static class EventType
    {
        /// <summary>
        ///  Swap Start Date
        /// </summary>
        public const byte SwapStartDate = 8;

        /// <summary>
        ///  Swap End Date
        /// </summary>
        public const byte SwapEndDate = 9;

        /// <summary>
        ///  Fix Tag for Event Type
        /// </summary>
        public const ushort FixTag = 865;

        /// <summary>
        ///  Length of Event Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Event Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + EventType.Length)
            {
                throw new System.Exception("Invalid Length for Event Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Event Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + EventType.Length;
        }

        /// <summary>
        ///  Check available length and set Event Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + EventType.Length)
            {
                throw new System.Exception("Invalid Length for Event Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Event Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + EventType.Length;
        }

        /// <summary>
        ///  Set Event Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Event Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + EventType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Event Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Event Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EventType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Event Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}