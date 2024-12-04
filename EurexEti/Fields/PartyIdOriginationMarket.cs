using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Origination Market: Enum
    /// </summary>

    public sealed class PartyIdOriginationMarket
    {
        /// <summary>
        ///  Korea Exchange
        /// </summary>
        public const byte Xkfe = 1;

        /// <summary>
        ///  Fix Tag for Party Id Origination Market
        /// </summary>
        public const ushort FixTag = 20099;

        /// <summary>
        ///  Length of Party Id Origination Market in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Party Id Origination Market
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PartyIdOriginationMarket.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Origination Market");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Origination Market
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PartyIdOriginationMarket.Length;
        }

        /// <summary>
        ///  TryDecode Party Id Origination Market
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyIdOriginationMarket.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Id Origination Market
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdOriginationMarket.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Origination Market
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}