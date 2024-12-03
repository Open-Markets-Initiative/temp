using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Instr Attrib: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoInstrAttrib
    {
        /// <summary>
        ///  Fix Tag for No Instr Attrib
        /// </summary>
        public const ushort FixTag = 870;

        /// <summary>
        ///  Length of No Instr Attrib in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Instr Attrib
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoInstrAttrib.Length)
            {
                throw new System.Exception("Invalid Length for No Instr Attrib");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Instr Attrib
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoInstrAttrib.Length;
        }

        /// <summary>
        ///  Encode No Instr Attrib
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Instr Attrib
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoInstrAttrib.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Instr Attrib
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoInstrAttrib.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Instr Attrib
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}