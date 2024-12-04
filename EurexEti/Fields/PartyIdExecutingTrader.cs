using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Executing Trader: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class PartyIdExecutingTrader
    {
        /// <summary>
        ///  Fix Tag for Party Id Executing Trader
        /// </summary>
        public const ushort FixTag = 20012;

        /// <summary>
        ///  Length of Party Id Executing Trader in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Party Id Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + PartyIdExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Executing Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PartyIdExecutingTrader.Length;
        }

        /// <summary>
        ///  Encode Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Party Id Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + PartyIdExecutingTrader.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdExecutingTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}