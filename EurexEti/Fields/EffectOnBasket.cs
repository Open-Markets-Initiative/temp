using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Effect On Basket: Enum
    /// </summary>

    public sealed class EffectOnBasket
    {
        /// <summary>
        ///  Add volume
        /// </summary>
        public const byte AddVolume = 1;

        /// <summary>
        ///  Remove volume
        /// </summary>
        public const byte RemoveVolume = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte EffectOnBasketMaximumValue = 2;

        /// <summary>
        ///  
        /// </summary>
        public const byte EffectOnBasketMinimumValue = 1;

        /// <summary>
        ///  Length of Effect On Basket in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Effect On Basket
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + EffectOnBasket.Length)
            {
                throw new System.Exception("Invalid Length for Effect On Basket");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Effect On Basket
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + EffectOnBasket.Length;
        }

        /// <summary>
        ///  TryDecode Effect On Basket
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + EffectOnBasket.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Effect On Basket
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + EffectOnBasket.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Effect On Basket
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}