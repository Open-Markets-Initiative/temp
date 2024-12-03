using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Party Id Investment Decision Maker: 8 Byte Fixed Width Integer
    /// </summary>

    public sealed class PartyIdInvestmentDecisionMaker
    {
        /// <summary>
        ///  Fix Tag for Party Id Investment Decision Maker
        /// </summary>
        public const ushort FixTag = 20122;

        /// <summary>
        ///  Length of Party Id Investment Decision Maker in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Encode Party Id Investment Decision Maker
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, ulong value, int length, out int current)
        {
            if (length > offset + PartyIdInvestmentDecisionMaker.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Investment Decision Maker");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Investment Decision Maker
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value, out int current)
        {
            Encode(pointer, offset, value);

            current = offset + PartyIdInvestmentDecisionMaker.Length;
        }

        /// <summary>
        ///  Encode Party Id Investment Decision Maker
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, ulong value)
        {
            *(ulong*) (pointer + offset) = value;
        }

        /// <summary>
        ///  TryDecode Party Id Investment Decision Maker
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out ulong value, out int current)
        {
            if (length > offset + PartyIdInvestmentDecisionMaker.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Id Investment Decision Maker
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdInvestmentDecisionMaker.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Investment Decision Maker
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static ulong Decode(byte* pointer, int offset)
        {
            return *(ulong*) (pointer + offset);
        }
    }
}