using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Order Event Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class OrderEventQty
    {
        /// <summary>
        ///  Fix Tag for Order Event Qty
        /// </summary>
        public const ushort FixTag = 1800;

        /// <summary>
        ///  Length of Order Event Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Order Event Qty
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Order Event Qty
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + OrderEventQty.Length)
            {
                throw new System.Exception("Invalid Length for Order Event Qty");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Order Event Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + OrderEventQty.Length;
        }

        /// <summary>
        ///  TryDecode Order Event Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + OrderEventQty.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Order Event Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + OrderEventQty.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Order Event Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}