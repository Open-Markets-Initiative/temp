using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leg Security Id: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class LegSecurityId
    {
        /// <summary>
        ///  Fix Tag for Leg Security Id
        /// </summary>
        public const ushort FixTag = 602;

        /// <summary>
        ///  Length of Leg Security Id in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Leg Security Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, long value, int length, out int current)
        {
            if (length > offset + LegSecurityId.Length)
            {
                throw new System.Exception("Invalid Length for Leg Security Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + LegSecurityId.Length;
        }

        /// <summary>
        ///  Encode Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, long value)
        {
            *(long*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Leg Security Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out long value, out int current)
        {
            if (length > offset + LegSecurityId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegSecurityId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static long Decode(byte* pointer, int offset)
        {
            return *(long*) (pointer + offset);
        }
    }
}