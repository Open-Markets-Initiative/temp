using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Risk Limit Open Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class RiskLimitOpenQty
    {
        /// <summary>
        ///  Fix Tag for Risk Limit Open Qty
        /// </summary>
        public const ushort FixTag = 28779;

        /// <summary>
        ///  Length of Risk Limit Open Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Risk Limit Open Qty
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Risk Limit Open Qty
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + RiskLimitOpenQty.Length)
            {
                throw new System.Exception("Invalid Length for Risk Limit Open Qty");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Risk Limit Open Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + RiskLimitOpenQty.Length;
        }

        /// <summary>
        ///  TryDecode Risk Limit Open Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + RiskLimitOpenQty.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Risk Limit Open Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RiskLimitOpenQty.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Risk Limit Open Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}