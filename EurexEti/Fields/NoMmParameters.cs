using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Mm Parameters: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoMmParameters
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
        ///  TryDecode No Mm Parameters
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoMmParameters.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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