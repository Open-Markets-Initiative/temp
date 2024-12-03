using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Events: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoEvents
    {
        /// <summary>
        ///  Fix Tag for No Events
        /// </summary>
        public const ushort FixTag = 864;

        /// <summary>
        ///  Length of No Events in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Events
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoEvents.Length)
            {
                throw new System.Exception("Invalid Length for No Events");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoEvents.Length;
        }

        /// <summary>
        ///  Encode No Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Events
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoEvents.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoEvents.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}