using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Implied Market Indicator: Enum
    /// </summary>

    public sealed class ImpliedMarketIndicator
    {
        /// <summary>
        ///  Not implied
        /// </summary>
        public const byte Notimplied = 0;

        /// <summary>
        ///  Both Implied-in and Implied-out
        /// </summary>
        public const byte Impliedinout = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte ImpliedMarketIndicatorMaximumValue = 3;

        /// <summary>
        ///  
        /// </summary>
        public const byte ImpliedMarketIndicatorMinimumValue = 0;

        /// <summary>
        ///  Length of Implied Market Indicator in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Implied Market Indicator
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ImpliedMarketIndicator.Length)
            {
                throw new System.Exception("Invalid Length for Implied Market Indicator");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Implied Market Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ImpliedMarketIndicator.Length;
        }

        /// <summary>
        ///  TryDecode Implied Market Indicator
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ImpliedMarketIndicator.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Implied Market Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ImpliedMarketIndicator.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Implied Market Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}