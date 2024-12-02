using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Multileg Price Model: Enum
    /// </summary>

    public sealed class MultilegPriceModel
    {
        /// <summary>
        ///  leg level prices provided by system
        /// </summary>
        public const byte Standard = 0;

        /// <summary>
        ///  leg level prices provided by user
        /// </summary>
        public const byte UserDefined = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte MultilegPriceModelMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte MultilegPriceModelMinimumValue = 0;

        /// <summary>
        ///  Length of Multileg Price Model in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Multileg Price Model
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MultilegPriceModel.Length)
            {
                throw new System.Exception("Invalid Length for Multileg Price Model");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Multileg Price Model
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MultilegPriceModel.Length;
        }

        /// <summary>
        ///  TryDecode Multileg Price Model
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MultilegPriceModel.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Multileg Price Model
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MultilegPriceModel.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Multileg Price Model
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}