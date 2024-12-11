using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Implied Check Price Indicator: Enum
    /// </summary>

    public static class ImpliedCheckPriceIndicator
    {
        /// <summary>
        ///  No
        /// </summary>
        public const byte No = 0;

        /// <summary>
        ///  Yes
        /// </summary>
        public const byte Yes = 1;

        /// <summary>
        ///  Fix Tag for Implied Check Price Indicator
        /// </summary>
        public const ushort FixTag = 25244;

        /// <summary>
        ///  Length of Implied Check Price Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Implied Check Price Indicator
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Implied Check Price Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ImpliedCheckPriceIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Implied Check Price Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Implied Check Price Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ImpliedCheckPriceIndicator.Length;
        }

        /// <summary>
        ///  Check available length and set Implied Check Price Indicator to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + ImpliedCheckPriceIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Implied Check Price Indicator");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Implied Check Price Indicator to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + ImpliedCheckPriceIndicator.Length;
        }

        /// <summary>
        ///  Set Implied Check Price Indicator to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Implied Check Price Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ImpliedCheckPriceIndicator.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Implied Check Price Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Implied Check Price Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ImpliedCheckPriceIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Implied Check Price Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}