using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Order Events: Runtime Count Field
    /// </summary>

    public static class NoOrderEvents
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
        ///  Check available length and set No Order Events to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoOrderEvents.Length)
            {
                throw new System.Exception("Invalid Length for No Order Events");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No Order Events to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoOrderEvents.Length;
        }

        /// <summary>
        ///  Set No Order Events to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No Order Events
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoOrderEvents.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No Order Events
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
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