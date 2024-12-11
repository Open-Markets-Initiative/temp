using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Delete Reason: Enum
    /// </summary>

    public static class DeleteReason
    {
        /// <summary>
        ///  Deletion via the TES Delete Request
        /// </summary>
        public const byte Nospecialreason = 100;

        /// <summary>
        ///  Automatic deletion due to TES Activity State Change
        /// </summary>
        public const byte TasChange = 101;

        /// <summary>
        ///  Automatic deletion due to instrument expiration
        /// </summary>
        public const byte IntradayExpiration = 102;

        /// <summary>
        ///  Deletion caused by Clearing/Risk stop
        /// </summary>
        public const byte RiskEvent = 103;

        /// <summary>
        ///  Deletion caused by Trading stop
        /// </summary>
        public const byte StopTrading = 104;

        /// <summary>
        ///  Deletion of Instrument
        /// </summary>
        public const byte InstrumentDeletion = 105;

        /// <summary>
        ///  Suspension of Instrument
        /// </summary>
        public const byte InstrumentSuspension = 106;

        /// <summary>
        ///  Deletion caused by a pre-trade risk event
        /// </summary>
        public const byte PreTradeRiskEvent = 107;

        /// <summary>
        ///  Basket amendment cancelled
        /// </summary>
        public const byte AmendmentReset = 108;

        /// <summary>
        ///  Amendment cancelled by user action
        /// </summary>
        public const byte AmendmentUserCancelled = 109;

        /// <summary>
        ///  Fix Tag for Delete Reason
        /// </summary>
        public const ushort FixTag = 285;

        /// <summary>
        ///  Length of Delete Reason in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Delete Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + DeleteReason.Length)
            {
                throw new System.Exception("Invalid Length for Delete Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Delete Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + DeleteReason.Length;
        }

        /// <summary>
        ///  Check available length and set Delete Reason to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + DeleteReason.Length)
            {
                throw new System.Exception("Invalid Length for Delete Reason");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Delete Reason to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + DeleteReason.Length;
        }

        /// <summary>
        ///  Set Delete Reason to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(byte*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Delete Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + DeleteReason.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Delete Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out byte value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Delete Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + DeleteReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Delete Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}