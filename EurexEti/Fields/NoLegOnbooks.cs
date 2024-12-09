using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Leg Onbooks: Runtime Count Field
    /// </summary>

    public static class NoLegOnbooks
    {
        /// <summary>
        ///  Fix Tag for No Leg Onbooks
        /// </summary>
        public const ushort FixTag = 28555;

        /// <summary>
        ///  Length of No Leg Onbooks in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Leg Onbooks
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoLegOnbooks.Length)
            {
                throw new System.Exception("Invalid Length for No Leg Onbooks");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Leg Onbooks
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoLegOnbooks.Length;
        }

        /// <summary>
        ///  Encode No Leg Onbooks
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set No Leg Onbooks to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoLegOnbooks.Length)
            {
                throw new System.Exception("Invalid Length for No Leg Onbooks");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No Leg Onbooks to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoLegOnbooks.Length;
        }

        /// <summary>
        ///  Set No Leg Onbooks to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No Leg Onbooks
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoLegOnbooks.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No Leg Onbooks
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
        }

        /// <summary>
        ///  Decode No Leg Onbooks
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoLegOnbooks.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Leg Onbooks
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}