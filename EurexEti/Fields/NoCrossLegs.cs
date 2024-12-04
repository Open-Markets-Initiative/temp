using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Cross Legs: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoCrossLegs
    {
        /// <summary>
        ///  Fix Tag for No Cross Legs
        /// </summary>
        public const ushort FixTag = 1829;

        /// <summary>
        ///  Length of No Cross Legs in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Cross Legs
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoCrossLegs.Length)
            {
                throw new System.Exception("Invalid Length for No Cross Legs");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Cross Legs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoCrossLegs.Length;
        }

        /// <summary>
        ///  Encode No Cross Legs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Cross Legs
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoCrossLegs.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Cross Legs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoCrossLegs.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Cross Legs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}