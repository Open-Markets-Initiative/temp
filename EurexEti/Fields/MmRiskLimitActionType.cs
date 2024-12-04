using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mm Risk Limit Action Type: Enum
    /// </summary>

    public sealed class MmRiskLimitActionType
    {
        /// <summary>
        ///  Quote inactivate
        /// </summary>
        public const byte QuoteInactivate = 1;

        /// <summary>
        ///  Quote inactivate and delete
        /// </summary>
        public const byte QuoteInactivateAndDelete = 2;

        /// <summary>
        ///  Fix Tag for Mm Risk Limit Action Type
        /// </summary>
        public const ushort FixTag = 25253;

        /// <summary>
        ///  Length of Mm Risk Limit Action Type in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Mm Risk Limit Action Type
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MmRiskLimitActionType.Length)
            {
                throw new System.Exception("Invalid Length for Mm Risk Limit Action Type");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mm Risk Limit Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MmRiskLimitActionType.Length;
        }

        /// <summary>
        ///  TryDecode Mm Risk Limit Action Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MmRiskLimitActionType.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mm Risk Limit Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MmRiskLimitActionType.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mm Risk Limit Action Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}