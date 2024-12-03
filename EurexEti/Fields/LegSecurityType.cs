using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Leg Security Type: Enum
    /// </summary>

    public sealed class LegSecurityType
    {
        /// <summary>
        ///  Multileg Instrument
        /// </summary>
        public const byte MultilegInstrument = 1;

        /// <summary>
        ///  Underlying Leg
        /// </summary>
        public const byte UnderlyingLeg = 2;

        /// <summary>
        ///  Fix Tag for Leg Security Type
        /// </summary>
        public const ushort FixTag = 609;

        /// <summary>
        ///  Length of Leg Security Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Leg Security Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + LegSecurityType.Length)
            {
                throw new System.Exception("Invalid Length for Leg Security Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Security Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + LegSecurityType.Length;
        }

        /// <summary>
        ///  TryDecode Leg Security Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + LegSecurityType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Security Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegSecurityType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Security Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}