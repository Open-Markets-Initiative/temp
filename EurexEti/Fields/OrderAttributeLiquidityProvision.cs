using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Attribute Liquidity Provision: Enum
    /// </summary>

    public static class OrderAttributeLiquidityProvision
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
        ///  Check available length and set Order Attribute Liquidity Provision to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + OrderAttributeLiquidityProvision.Length)
            {
                throw new System.Exception("Invalid Length for Order Attribute Liquidity Provision");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Order Attribute Liquidity Provision to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + OrderAttributeLiquidityProvision.Length;
        }

        /// <summary>
        ///  Set Order Attribute Liquidity Provision to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Order Attribute Liquidity Provision
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OrderAttributeLiquidityProvision.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Order Attribute Liquidity Provision
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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