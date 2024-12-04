using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Order Events: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoOrderEvents
    {
        /// <summary>
        ///  Fix Tag for No Order Events
        /// </summary>
        public const ushort FixTag = 28790;

        /// <summary>
        ///  Length of No Order Events in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Order Events
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoOrderEvents.Length)
            {
                throw new System.Exception("Invalid Length for No Order Events");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Order Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoOrderEvents.Length;
        }

        /// <summary>
        ///  Encode No Order Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Order Events
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoOrderEvents.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Order Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoOrderEvents.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Order Events
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}