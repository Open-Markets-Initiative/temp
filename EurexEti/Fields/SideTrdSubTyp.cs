using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Trd Sub Typ: Enum
    /// </summary>

    public static class SideTrdSubTyp
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
        ///  Null value for Side Trd Sub Typ
        /// </summary>
        public const ushort NoValue = 0xFFFF;

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
        ///  Check available length and set Side Trd Sub Typ to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SideTrdSubTyp.Length)
            {
                throw new System.Exception("Invalid Length for Side Trd Sub Typ");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Side Trd Sub Typ to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SideTrdSubTyp.Length;
        }

        /// <summary>
        ///  Set Side Trd Sub Typ to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(ushort*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Side Trd Sub Typ
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ushort value, out int current)
        {
            if (length > offset + SideTrdSubTyp.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Side Trd Sub Typ
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out ushort value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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