using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Product Complex: Enum
    /// </summary>

    public sealed class ProductComplex
    {
        /// <summary>
        ///  Simple instrument
        /// </summary>
        public const byte Simpleinstrument = 1;

        /// <summary>
        ///  Standard Option Strategy
        /// </summary>
        public const byte Standardoptionstrategy = 2;

        /// <summary>
        ///  Non-Standard Option Strategy
        /// </summary>
        public const byte Nonstandardoptionstrategy = 3;

        /// <summary>
        ///  Volatility Strategy
        /// </summary>
        public const byte Volatilitystrategy = 4;

        /// <summary>
        ///  Futures Spread
        /// </summary>
        public const byte FuturesSpread = 5;

        /// <summary>
        ///  Inter-Product Spread
        /// </summary>
        public const byte Interproductspread = 6;

        /// <summary>
        ///  Standard Future Strategy
        /// </summary>
        public const byte Standardfuturestrategy = 7;

        /// <summary>
        ///  Pack and Bundle
        /// </summary>
        public const byte Packandbundle = 8;

        /// <summary>
        ///  Strip
        /// </summary>
        public const byte Strip = 9;

        /// <summary>
        ///  Flexible Simple Instrument
        /// </summary>
        public const byte Flexiblesimpleinstrument = 10;

        /// <summary>
        ///  Commodity Strip
        /// </summary>
        public const byte Commoditystrip = 11;

        /// <summary>
        ///  Scaled Simple Instrument
        /// </summary>
        public const byte Scaledsimpleinstrument = 12;

        /// <summary>
        ///  Non-Standard Volatility Strategy
        /// </summary>
        public const byte Nonstandardvolatilitystrategy = 13;

        /// <summary>
        ///  Fix Tag for Product Complex
        /// </summary>
        public const ushort FixTag = 1227;

        /// <summary>
        ///  Length of Product Complex in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Product Complex
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + ProductComplex.Length)
            {
                throw new System.Exception("Invalid Length for Product Complex");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Product Complex
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + ProductComplex.Length;
        }

        /// <summary>
        ///  TryDecode Product Complex
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + ProductComplex.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Product Complex
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + ProductComplex.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Product Complex
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}