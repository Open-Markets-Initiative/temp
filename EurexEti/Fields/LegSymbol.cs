using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leg Symbol: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class LegSymbol
    {
        /// <summary>
        ///  Fix Tag for Leg Symbol
        /// </summary>
        public const ushort FixTag = 600;

        /// <summary>
        ///  Length of Leg Symbol in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Leg Symbol
        /// </summary>
        public const int NoValue = 0x80000000;

        /// <summary>
        ///  Encode Leg Symbol
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, int value, int length, out int current)
        {
            if (length > offset + LegSymbol.Length)
            {
                throw new System.Exception("Invalid Length for Leg Symbol");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + LegSymbol.Length;
        }

        /// <summary>
        ///  Encode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, int value)
        {
            *(int*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Leg Symbol to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + LegSymbol.Length)
            {
                throw new System.Exception("Invalid Length for Leg Symbol");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Leg Symbol to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + LegSymbol.Length;
        }

        /// <summary>
        ///  Set Leg Symbol to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(int*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Leg Symbol
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out int value, out int current)
        {
            if (length > offset + LegSymbol.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Leg Symbol
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out int value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegSymbol.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Symbol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static int Decode(byte* pointer, int offset)
        {
            return *(int*) (pointer + offset);
        }
    }
}