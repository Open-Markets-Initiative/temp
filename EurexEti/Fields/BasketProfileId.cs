using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Basket Profile Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class BasketProfileId
    {
        /// <summary>
        ///  Length of Basket Profile Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Basket Profile Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + BasketProfileId.Length)
            {
                throw new System.Exception("Invalid Length for Basket Profile Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + BasketProfileId.Length;
        }

        /// <summary>
        ///  Encode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Basket Profile Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + BasketProfileId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + BasketProfileId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Basket Profile Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}