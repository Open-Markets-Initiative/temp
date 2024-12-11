using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Hedge Type: Enum
    /// </summary>

    public static class HedgeType
    {
        /// <summary>
        ///  Duration Hedge
        /// </summary>
        public const byte DurationHedge = 0;

        /// <summary>
        ///  Nominal Hedge
        /// </summary>
        public const byte NominalHedge = 1;

        /// <summary>
        ///  Price Factor Hedge
        /// </summary>
        public const byte PriceFactorHedge = 2;

        /// <summary>
        ///  Fix Tag for Hedge Type
        /// </summary>
        public const ushort FixTag = 29008;

        /// <summary>
        ///  Length of Hedge Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Hedge Type
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Hedge Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + HedgeType.Length)
            {
                throw new System.Exception("Invalid Length for Hedge Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Hedge Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + HedgeType.Length;
        }

        /// <summary>
        ///  Check available length and set Hedge Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + HedgeType.Length)
            {
                throw new System.Exception("Invalid Length for Hedge Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Hedge Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + HedgeType.Length;
        }

        /// <summary>
        ///  Set Hedge Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Hedge Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + HedgeType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Hedge Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Hedge Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + HedgeType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Hedge Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}