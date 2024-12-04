using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Requesting Party Id Executing Trader: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class RequestingPartyIdExecutingTrader
    {
        /// <summary>
        ///  Fix Tag for Requesting Party Id Executing Trader
        /// </summary>
        public const ushort FixTag = 20812;

        /// <summary>
        ///  Length of Requesting Party Id Executing Trader in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Requesting Party Id Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + RequestingPartyIdExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Id Executing Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Requesting Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RequestingPartyIdExecutingTrader.Length;
        }

        /// <summary>
        ///  Encode Requesting Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Requesting Party Id Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + RequestingPartyIdExecutingTrader.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Requesting Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RequestingPartyIdExecutingTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Requesting Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}