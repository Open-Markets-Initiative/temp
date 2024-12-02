using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Trade Platform: Enum
    /// </summary>

    public sealed class TradePlatform
    {
        /// <summary>
        ///  Off-Book
        /// </summary>
        public const byte OffBook = 0;

        /// <summary>
        ///  On-Book
        /// </summary>
        public const byte OnBook = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradePlatformMaximumValue = 1;

        /// <summary>
        ///  
        /// </summary>
        public const byte TradePlatformMinimumValue = 0;

        /// <summary>
        ///  Length of Trade Platform in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Trade Platform
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + TradePlatform.Length)
            {
                throw new System.Exception("Invalid Length for Trade Platform");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Trade Platform
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + TradePlatform.Length;
        }

        /// <summary>
        ///  TryDecode Trade Platform
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + TradePlatform.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Trade Platform
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + TradePlatform.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Trade Platform
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}