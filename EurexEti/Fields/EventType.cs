using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Event Type: Enum
    /// </summary>

    public sealed class EventType
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
        ///  TryDecode Event Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + EventType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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