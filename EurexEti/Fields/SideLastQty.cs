using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Side Last Qty: 8 Byte Fixed Width Integer with 4 Decimal Place Precision
    /// </summary>

    public sealed class SideLastQty
    {
        /// <summary>
        ///  Length of Side Last Qty in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Side Last Qty
        /// </summary>
        public const int Factor = 10000;

        /// <summary>
        ///  Encode Side Last Qty
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, double value, int length, out int current)
        {
            if (length > offset + SideLastQty.Length)
            {
                throw new System.Exception("Invalid Length for Side Last Qty");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Side Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, double value, out int current)
        {
            *(ulong*) (pointer + offset) = (ulong)(value * Factor);

            current = offset + SideLastQty.Length;
        }

        /// <summary>
        ///  TryDecode Side Last Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out double value, out int current)
        {
            if (length > offset + SideLastQty.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Side Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SideLastQty.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Side Last Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static double Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset) / (double)Factor;
        }
    }
}