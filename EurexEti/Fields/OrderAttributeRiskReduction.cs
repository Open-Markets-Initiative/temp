using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Order Attribute Risk Reduction: Enum
    /// </summary>

    public sealed class OrderAttributeRiskReduction
    {
        /// <summary>
        ///  Risk reduction
        /// </summary>
        public const byte Y = 1;

        /// <summary>
        ///  No risk reduction
        /// </summary>
        public const byte N = 0;

        /// <summary>
        ///  Fix Tag for Order Attribute Risk Reduction
        /// </summary>
        public const ushort FixTag = 23003;

        /// <summary>
        ///  Length of Order Attribute Risk Reduction in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Order Attribute Risk Reduction
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + OrderAttributeRiskReduction.Length)
            {
                throw new System.Exception("Invalid Length for Order Attribute Risk Reduction");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Attribute Risk Reduction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + OrderAttributeRiskReduction.Length;
        }

        /// <summary>
        ///  TryDecode Order Attribute Risk Reduction
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + OrderAttributeRiskReduction.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Attribute Risk Reduction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderAttributeRiskReduction.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Attribute Risk Reduction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}