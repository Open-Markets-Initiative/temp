using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Root Party Id Executing Trader: 4 Byte Fixed Width Integer
    /// </summary>

    public sealed class RootPartyIdExecutingTrader
    {
        /// <summary>
        ///  Length of Root Party Id Executing Trader in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Root Party Id Executing Trader
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + RootPartyIdExecutingTrader.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Id Executing Trader");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Root Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + RootPartyIdExecutingTrader.Length;
        }

        /// <summary>
        ///  Encode Root Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value)
        {
            *(uint*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Root Party Id Executing Trader
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + RootPartyIdExecutingTrader.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Root Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RootPartyIdExecutingTrader.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Root Party Id Executing Trader
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}