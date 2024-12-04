using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Side Trade Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class SideTradeId
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
        ///  TryDecode Side Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SideTradeId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
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