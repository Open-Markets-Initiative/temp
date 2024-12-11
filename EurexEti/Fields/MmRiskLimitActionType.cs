using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Mm Risk Limit Action Type: Enum
    /// </summary>

    public static class MmRiskLimitActionType
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
        ///  Check available length and set Mm Risk Limit Action Type to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + MmRiskLimitActionType.Length)
            {
                throw new System.Exception("Invalid Length for Mm Risk Limit Action Type");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Mm Risk Limit Action Type to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + MmRiskLimitActionType.Length;
        }

        /// <summary>
        ///  Set Mm Risk Limit Action Type to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Mm Risk Limit Action Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MmRiskLimitActionType.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Mm Risk Limit Action Type
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
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