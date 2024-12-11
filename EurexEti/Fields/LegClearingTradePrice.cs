using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Leg Clearing Trade Price: 8 Byte Fixed Width Nullable Integer with 8 Decimal Place Precision
    /// </summary>

    public static class LegClearingTradePrice
    {
        /// <summary>
        ///  Fix Tag for Leg Clearing Trade Price
        /// </summary>
        public const ushort FixTag = 31596;

        /// <summary>
        ///  Length of Leg Clearing Trade Price in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Leg Clearing Trade Price
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Null value for Leg Clearing Trade Price
        /// </summary>
        public const ulong NoValue = 0x8000000000000000;

        /// <summary>
        ///  Encode Leg Clearing Trade Price
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + LegClearingTradePrice.Length)
            {
                throw new System.Exception("Invalid Length for Leg Clearing Trade Price");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Clearing Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + LegClearingTradePrice.Length;
        }

        /// <summary>
        ///  Check available length and set Leg Clearing Trade Price to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + LegClearingTradePrice.Length)
            {
                throw new System.Exception("Invalid Length for Leg Clearing Trade Price");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Leg Clearing Trade Price to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + LegClearingTradePrice.Length;
        }

        /// <summary>
        ///  Set Leg Clearing Trade Price to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ulong*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Leg Clearing Trade Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + LegClearingTradePrice.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Leg Clearing Trade Price
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out double value, out int current)
        {
            var raw = *(long*)(pointer + offset);

            var result = raw != NoValue;

            value = raw / (double)Factor;

            current = offset + LegClearingTradePrice.Length;

            return result;
        }

        /// <summary>
        ///  Decode Leg Clearing Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegClearingTradePrice.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Clearing Trade Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}