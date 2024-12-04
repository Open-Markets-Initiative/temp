using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Root Party Id Investment Decision Maker Qualifier: Enum
    /// </summary>

    public sealed class RootPartyIdInvestmentDecisionMakerQualifier
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
        ///  Fix Tag for Root Party Id Investment Decision Maker Qualifier
        /// </summary>
        public const ushort FixTag = 21622;

        /// <summary>
        ///  Length of Root Party Id Investment Decision Maker Qualifier in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Root Party Id Investment Decision Maker Qualifier
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + RootPartyIdInvestmentDecisionMakerQualifier.Length)
            {
                throw new System.Exception("Invalid Length for Root Party Id Investment Decision Maker Qualifier");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Root Party Id Investment Decision Maker Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + RootPartyIdInvestmentDecisionMakerQualifier.Length;
        }

        /// <summary>
        ///  TryDecode Root Party Id Investment Decision Maker Qualifier
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RootPartyIdInvestmentDecisionMakerQualifier.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Root Party Id Investment Decision Maker Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RootPartyIdInvestmentDecisionMakerQualifier.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Root Party Id Investment Decision Maker Qualifier
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}