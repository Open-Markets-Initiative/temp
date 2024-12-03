using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Side Trd Sub Typ: Enum
    /// </summary>

    public sealed class SideTrdSubTyp
    {
        /// <summary>
        ///  Block Trade
        /// </summary>
        public const ushort BlockTrade = 2001;

        /// <summary>
        ///  Trade at Market
        /// </summary>
        public const ushort TradeatMarket = 2004;

        /// <summary>
        ///  Fix Tag for Side Trd Sub Typ
        /// </summary>
        public const ushort FixTag = 1008;

        /// <summary>
        ///  Length of Side Trd Sub Typ in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Encode Side Trd Sub Typ
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ushort value, int length, out int current)
        {
            if (length > offset + SideTrdSubTyp.Length)
            {
                throw new System.Exception("Invalid Length for Side Trd Sub Typ");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Side Trd Sub Typ
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ushort value, out int current)
        {
            *(ushort*) (pointer + offset) = value;

            current = offset + SideTrdSubTyp.Length;
        }

        /// <summary>
        ///  TryDecode Side Trd Sub Typ
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + SideTrdSubTyp.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Side Trd Sub Typ
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SideTrdSubTyp.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Side Trd Sub Typ
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ushort Decode(byte* pointer, int offset)
        {
            return *(ushort*) (pointer + offset);
        }
    }
}