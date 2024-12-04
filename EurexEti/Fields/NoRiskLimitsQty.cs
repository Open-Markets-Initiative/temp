using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  No Risk Limits Qty: 1 Byte Fixed Width Integer
    /// </summary>

    public sealed class NoRiskLimitsQty
    {
        /// <summary>
        ///  Fix Tag for No Risk Limits Qty
        /// </summary>
        public const ushort FixTag = 31669;

        /// <summary>
        ///  Length of No Risk Limits Qty in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode No Risk Limits Qty
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + NoRiskLimitsQty.Length)
            {
                throw new System.Exception("Invalid Length for No Risk Limits Qty");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode No Risk Limits Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + NoRiskLimitsQty.Length;
        }

        /// <summary>
        ///  Encode No Risk Limits Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value)
        {
            *(byte*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode No Risk Limits Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + NoRiskLimitsQty.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode No Risk Limits Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + NoRiskLimitsQty.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode No Risk Limits Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}