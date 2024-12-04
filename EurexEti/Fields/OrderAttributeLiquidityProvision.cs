using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Attribute Liquidity Provision: Enum
    /// </summary>

    public sealed class OrderAttributeLiquidityProvision
    {
        /// <summary>
        ///  Liquidity provision
        /// </summary>
        public const byte Y = 1;

        /// <summary>
        ///  No liquidity provision
        /// </summary>
        public const byte N = 0;

        /// <summary>
        ///  Fix Tag for Order Attribute Liquidity Provision
        /// </summary>
        public const ushort FixTag = 23002;

        /// <summary>
        ///  Length of Order Attribute Liquidity Provision in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Order Attribute Liquidity Provision
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OrderAttributeLiquidityProvision.Length)
            {
                throw new System.Exception("Invalid Length for Order Attribute Liquidity Provision");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Attribute Liquidity Provision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OrderAttributeLiquidityProvision.Length;
        }

        /// <summary>
        ///  TryDecode Order Attribute Liquidity Provision
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OrderAttributeLiquidityProvision.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Attribute Liquidity Provision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderAttributeLiquidityProvision.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Attribute Liquidity Provision
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}