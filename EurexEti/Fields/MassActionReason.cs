using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Mass Action Reason: Enum
    /// </summary>

    public sealed class MassActionReason
    {
        /// <summary>
        ///  No special reason
        /// </summary>
        public const byte NoSpecialReason = 0;

        /// <summary>
        ///  Trading was stopped
        /// </summary>
        public const byte StopTrading = 1;

        /// <summary>
        ///  Emergency
        /// </summary>
        public const byte Emergency = 2;

        /// <summary>
        ///  Market Maker Protection
        /// </summary>
        public const byte MarketMakerProtection = 3;

        /// <summary>
        ///  Session loss or logout
        /// </summary>
        public const byte SessionLoss = 6;

        /// <summary>
        ///  Duplicate Session Login
        /// </summary>
        public const byte DuplicateSessionLogin = 7;

        /// <summary>
        ///  Clearing Risk Control
        /// </summary>
        public const byte ClearingRiskControl = 8;

        /// <summary>
        ///  Internal connection loss
        /// </summary>
        public const byte InternalConnectionLoss = 100;

        /// <summary>
        ///  Product State Halt
        /// </summary>
        public const byte ProductStateHalt = 105;

        /// <summary>
        ///  Product State Holiday
        /// </summary>
        public const byte ProductStateHoliday = 106;

        /// <summary>
        ///  Instrument Suspended
        /// </summary>
        public const byte InstrumentSuspended = 107;

        /// <summary>
        ///  Complex Instrument Deletion
        /// </summary>
        public const byte ComplexInstrumentDeletion = 109;

        /// <summary>
        ///  Volatility Interruption
        /// </summary>
        public const byte VolatilityInterruption = 110;

        /// <summary>
        ///  Product temporarily not tradeable
        /// </summary>
        public const byte Producttemporarilynottradeable = 111;

        /// <summary>
        ///  Member has been disabled
        /// </summary>
        public const byte Memberdisable = 117;

        /// <summary>
        ///  Scaled Simple Instrument Deletion
        /// </summary>
        public const byte ScaledSimpleInstrumentDeletion = 121;

        /// <summary>
        ///  Fix Tag for Mass Action Reason
        /// </summary>
        public const ushort FixTag = 28721;

        /// <summary>
        ///  Length of Mass Action Reason in bytes
        /// </summary>
        public const int Length = 1;

        /// <summary>
        ///  Encode Mass Action Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, byte value, int length, out int current)
        {
            if (length > offset + MassActionReason.Length)
            {
                throw new System.Exception("Invalid Length for Mass Action Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Mass Action Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, byte value, out int current)
        {
            *(byte*) (pointer + offset) = value;

            current = offset + MassActionReason.Length;
        }

        /// <summary>
        ///  TryDecode Mass Action Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out byte value, out int current)
        {
            if (length > offset + MassActionReason.Length)
            {
                value = Decode(pointer, offset, out current);

                return true;
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  Decode Mass Action Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset, out int current)
        {
            current = offset + MassActionReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Mass Action Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static byte Decode(byte* pointer, int offset)
        {
            return *(byte*) (pointer + offset);
        }
    }
}