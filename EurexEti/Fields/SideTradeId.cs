using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Trade Id: Optional 4 Byte Fixed Width Integer
    /// </summary>

    public static class SideTradeId
    {
        /// <summary>
        ///  Fix Tag for Side Trade Id
        /// </summary>
        public const ushort FixTag = 1506;

        /// <summary>
        ///  Length of Side Trade Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Null value for Side Trade Id
        /// </summary>
        public const uint NoValue = 0xFFFFFFFF;

        /// <summary>
        ///  Encode Side Trade Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + SideTradeId.Length)
            {
                throw new System.Exception("Invalid Length for Side Trade Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Side Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SideTradeId.Length;
        }

        /// <summary>
        ///  Encode Side Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  Check available length and set Side Trade Id to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SideTradeId.Length)
            {
                throw new System.Exception("Invalid Length for Side Trade Id");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Side Trade Id to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SideTradeId.Length;
        }

        /// <summary>
        ///  Set Side Trade Id to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Side Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SideTradeId.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Side Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Side Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SideTradeId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Side Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}