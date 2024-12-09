using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Mm Parameters: Runtime Count Field
    /// </summary>

    public static class NoMmParameters
    {
        /// <summary>
        ///  Fix Tag for No Mm Parameters
        /// </summary>
        public const ushort FixTag = 28705;

        /// <summary>
        ///  Length of No Mm Parameters in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Mm Parameters
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoMmParameters.Length)
            {
                throw new System.Exception("Invalid Length for No Mm Parameters");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Mm Parameters
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoMmParameters.Length;
        }

        /// <summary>
        ///  Encode No Mm Parameters
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set No Mm Parameters to 0
        /// </summary>
        public unsafe static void Zero(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + NoMmParameters.Length)
            {
                throw new System.Exception("Invalid Length for No Mm Parameters");
            }

            Zero(pointer, offset, out current);
        }

        /// <summary>
        ///  Set No Mm Parameters to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset, out int current)
        {
            Zero(pointer, offset);

            current = offset + NoMmParameters.Length;
        }

        /// <summary>
        ///  Set No Mm Parameters to 0
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Zero(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = 0;
        }

        /// <summary>
        ///  TryDecode No Mm Parameters
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoMmParameters.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode No Mm Parameters
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value > 0;
        }

        /// <summary>
        ///  Decode No Mm Parameters
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoMmParameters.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Mm Parameters
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}