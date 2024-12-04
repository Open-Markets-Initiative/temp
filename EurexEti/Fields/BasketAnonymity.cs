using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Basket Anonymity: Enum
    /// </summary>

    public sealed class BasketAnonymity
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
        ///  Fix Tag for Basket Anonymity
        /// </summary>
        public const ushort FixTag = 31091;

        /// <summary>
        ///  Length of Basket Anonymity in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Basket Anonymity
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + BasketAnonymity.Length)
            {
                throw new System.Exception("Invalid Length for Basket Anonymity");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Basket Anonymity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + BasketAnonymity.Length;
        }

        /// <summary>
        ///  TryDecode Basket Anonymity
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + BasketAnonymity.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Basket Anonymity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BasketAnonymity.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Basket Anonymity
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}