using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Maturity Month Year: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class MaturityMonthYear
    {
        /// <summary>
        ///  Fix Tag for Maturity Month Year
        /// </summary>
        public const ushort FixTag = 200;

        /// <summary>
        ///  Length of Maturity Month Year in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Maturity Month Year
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Maturity Month Year
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + MaturityMonthYear.Length)
            {
                throw new System.Exception("Invalid Length for Maturity Month Year");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + MaturityMonthYear.Length;
        }

        /// <summary>
        ///  Encode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Maturity Month Year to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MaturityMonthYear.Length)
            {
                throw new System.Exception("Invalid Length for Maturity Month Year");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Maturity Month Year to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MaturityMonthYear.Length;
        }

        /// <summary>
        ///  Set Maturity Month Year to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Maturity Month Year
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + MaturityMonthYear.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Maturity Month Year
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MaturityMonthYear.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Maturity Month Year
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}