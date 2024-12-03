using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Requesting Party Id Entering Firm: Enum
    /// </summary>

    public sealed class RequestingPartyIdEnteringFirm
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
        ///  Fix Tag for Requesting Party Id Entering Firm
        /// </summary>
        public const ushort FixTag = 20807;

        /// <summary>
        ///  Length of Requesting Party Id Entering Firm in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Requesting Party Id Entering Firm
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + RequestingPartyIdEnteringFirm.Length)
            {
                throw new System.Exception("Invalid Length for Requesting Party Id Entering Firm");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Requesting Party Id Entering Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + RequestingPartyIdEnteringFirm.Length;
        }

        /// <summary>
        ///  TryDecode Requesting Party Id Entering Firm
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + RequestingPartyIdEnteringFirm.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Requesting Party Id Entering Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + RequestingPartyIdEnteringFirm.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Requesting Party Id Entering Firm
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}