using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  No Leg Onbooks: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoLegOnbooks
    {
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
        ///  TryDecode No Leg Onbooks
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoLegOnbooks.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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