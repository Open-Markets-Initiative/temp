using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Investment Decision Maker Qualifier: Enum
    /// </summary>

    public sealed class PartyIdInvestmentDecisionMakerQualifier
    {
        /// <summary>
        ///  Algo
        /// </summary>
        public const byte Algo = 22;

        /// <summary>
        ///  Human/Natural person
        /// </summary>
        public const byte Human = 24;

        /// <summary>
        ///  Fix Tag for Party Id Investment Decision Maker Qualifier
        /// </summary>
        public const ushort FixTag = 21222;

        /// <summary>
        ///  Length of Party Id Investment Decision Maker Qualifier in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Party Id Investment Decision Maker Qualifier
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PartyIdInvestmentDecisionMakerQualifier.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Investment Decision Maker Qualifier");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Investment Decision Maker Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PartyIdInvestmentDecisionMakerQualifier.Length;
        }

        /// <summary>
        ///  TryDecode Party Id Investment Decision Maker Qualifier
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyIdInvestmentDecisionMakerQualifier.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Party Id Investment Decision Maker Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdInvestmentDecisionMakerQualifier.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Investment Decision Maker Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}