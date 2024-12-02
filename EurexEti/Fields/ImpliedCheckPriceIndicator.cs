using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Implied Check Price Indicator: Enum
    /// </summary>

    public sealed class ImpliedCheckPriceIndicator
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
        ///  
        /// </summary>
        public const byte ImpliedCheckPriceIndicatorMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte ImpliedCheckPriceIndicatorMinimumValue = 0;

        /// <summary>
        ///  Length of Implied Check Price Indicator in bytes
        /// </summary>
        public const int Length = 1;

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
        ///  TryDecode Implied Check Price Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ImpliedCheckPriceIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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