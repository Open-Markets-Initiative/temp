using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Secondary Trade Id: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class SecondaryTradeId
    {
        /// <summary>
        ///  Length of Secondary Trade Id in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Secondary Trade Id
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + SecondaryTradeId.Length)
            {
                throw new System.Exception("Invalid Length for Secondary Trade Id");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Secondary Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + SecondaryTradeId.Length;
        }

        /// <summary>
        ///  Encode Secondary Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Secondary Trade Id
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SecondaryTradeId.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Secondary Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SecondaryTradeId.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Secondary Trade Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}