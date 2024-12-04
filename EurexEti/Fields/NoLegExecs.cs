using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Leg Execs: 2 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoLegExecs
    {
        /// <summary>
        ///  Fix Tag for No Leg Execs
        /// </summary>
        public const ushort FixTag = 30555;

        /// <summary>
        ///  Length of No Leg Execs in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode No Leg Execs
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + NoLegExecs.Length)
            {
                throw new System.Exception("Invalid Length for No Leg Execs");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Leg Execs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoLegExecs.Length;
        }

        /// <summary>
        ///  Encode No Leg Execs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value)
        {
            *(ushort*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Leg Execs
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + NoLegExecs.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Leg Execs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoLegExecs.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Leg Execs
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}