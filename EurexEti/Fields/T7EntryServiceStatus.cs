using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  T 7 Entry Service Status: Enum
    /// </summary>

    public sealed class T7EntryServiceStatus
    {
        /// <summary>
        ///  Unavailable
        /// </summary>
        public const byte Unavailable = 0;

        /// <summary>
        ///  Available
        /// </summary>
        public const byte Available = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte T7EntryServiceStatusMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte T7EntryServiceStatusMinimumValue = 0;

        /// <summary>
        ///  Length of T 7 Entry Service Status in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode T 7 Entry Service Status
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + T7EntryServiceStatus.Length)
            {
                throw new System.Exception("Invalid Length for T 7 Entry Service Status");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode T 7 Entry Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + T7EntryServiceStatus.Length;
        }

        /// <summary>
        ///  TryDecode T 7 Entry Service Status
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + T7EntryServiceStatus.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode T 7 Entry Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + T7EntryServiceStatus.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode T 7 Entry Service Status
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}