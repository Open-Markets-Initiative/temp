using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Party Id Entering Firm: Enum
    /// </summary>

    public static class PartyIdEnteringFirm
    {
        /// <summary>
        ///  Participant
        /// </summary>
        public const byte Participant = 1;

        /// <summary>
        ///  Market Supervision
        /// </summary>
        public const byte MarketSupervision = 2;

        /// <summary>
        ///  Fix Tag for Party Id Entering Firm
        /// </summary>
        public const ushort FixTag = 20007;

        /// <summary>
        ///  Length of Party Id Entering Firm in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Null value for Party Id Entering Firm
        /// </summary>
        public const byte NoValue = 0xFF;

        /// <summary>
        ///  Encode Party Id Entering Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + PartyIdEnteringFirm.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Entering Firm");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Party Id Entering Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + PartyIdEnteringFirm.Length;
        }

        /// <summary>
        ///  Check available length and set Party Id Entering Firm to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + PartyIdEnteringFirm.Length)
            {
                throw new System.Exception("Invalid Length for Party Id Entering Firm");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Party Id Entering Firm to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + PartyIdEnteringFirm.Length;
        }

        /// <summary>
        ///  Set Party Id Entering Firm to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Party Id Entering Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + PartyIdEnteringFirm.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Party Id Entering Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Party Id Entering Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + PartyIdEnteringFirm.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Party Id Entering Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}