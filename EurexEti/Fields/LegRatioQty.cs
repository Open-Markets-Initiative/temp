using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Leg Ratio Qty: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class LegRatioQty
    {
        /// <summary>
        ///  Length of Leg Ratio Qty in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Leg Ratio Qty
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + LegRatioQty.Length)
            {
                throw new System.Exception("Invalid Length for Leg Ratio Qty");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + LegRatioQty.Length;
        }

        /// <summary>
        ///  Encode Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Leg Ratio Qty
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + LegRatioQty.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + LegRatioQty.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Leg Ratio Qty
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}