using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leg Security Type: Enum
    /// </summary>

    public static class LegSecurityType
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
        ///  Check available length and set Leg Security Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + LegSecurityType.Length)
            {
                throw new System.Exception("Invalid Length for Leg Security Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Leg Security Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + LegSecurityType.Length;
        }

        /// <summary>
        ///  Set Leg Security Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Leg Security Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + LegSecurityType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Leg Security Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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