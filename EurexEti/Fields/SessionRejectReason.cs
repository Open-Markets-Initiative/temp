using System.Runtime.CompilerServices;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Session Reject Reason: Enum
    /// </summary>

    public static class SessionRejectReason
    {
        /// <summary>
        ///  Required Tag Missing
        /// </summary>
        public const uint RequiredTagMissing = 1;

        /// <summary>
        ///  Value is incorrect (out of range) for this tag
        /// </summary>
        public const uint Valueisincorrect = 5;

        /// <summary>
        ///  Decryption problem
        /// </summary>
        public const uint Decryptionproblem = 7;

        /// <summary>
        ///  Invalid TemplateID
        /// </summary>
        public const uint InvalidMsgId = 11;

        /// <summary>
        ///  Incorrect NumInGroup count for repeating group
        /// </summary>
        public const uint IncorrectNumInGroupcount = 16;

        /// <summary>
        ///  Other
        /// </summary>
        public const uint Other = 99;

        /// <summary>
        ///  Throttle limit exceeded
        /// </summary>
        public const uint ThrottleLimitExceeded = 100;

        /// <summary>
        ///  Stale request was not forwarded to T7
        /// </summary>
        public const uint ExposureLimitExceeded = 101;

        /// <summary>
        ///  Service temporarily not available
        /// </summary>
        public const uint ServiceTemporarilyNotAvailable = 102;

        /// <summary>
        ///  Service not available
        /// </summary>
        public const uint ServiceNotAvailable = 103;

        /// <summary>
        ///  Error converting response or broadcast
        /// </summary>
        public const uint Outboundconversionerror = 105;

        /// <summary>
        ///  Heartbeat violation error
        /// </summary>
        public const uint HeartbeatViolation = 152;

        /// <summary>
        ///  Internal technical error
        /// </summary>
        public const uint Internaltechnicalerror = 200;

        /// <summary>
        ///  Validation Error
        /// </summary>
        public const uint ValidationError = 210;

        /// <summary>
        ///  User already logged in
        /// </summary>
        public const uint UserAlreadyLoggedIn = 211;

        /// <summary>
        ///  Gateway is standby
        /// </summary>
        public const uint GatewayIsStandby = 216;

        /// <summary>
        ///  Session login limit (per time interval) reached
        /// </summary>
        public const uint SessionLoginLimitReached = 217;

        /// <summary>
        ///  User Entitlement Data time out
        /// </summary>
        public const uint UserEntitlementDataTimeout = 223;

        /// <summary>
        ///  Session limit reached (per PS Gateway and Business Unit)
        /// </summary>
        public const uint PsGatewaySessionLimitReached = 224;

        /// <summary>
        ///  User login tries limit (per time interval) reached
        /// </summary>
        public const uint UserLoginLimitReached = 225;

        /// <summary>
        ///  Limit of outstanding session/user logins reached (per Business Unit)
        /// </summary>
        public const uint OutstandingLoginsBuLimitReached = 226;

        /// <summary>
        ///  Limit of outstanding session/user logins reached (per Session)
        /// </summary>
        public const uint OutstandingLoginsSessionLimitReached = 227;

        /// <summary>
        ///  Password timestamp not in grace period
        /// </summary>
        public const uint PasswordTimestampNotInGracePeriod = 228;

        /// <summary>
        ///  Order not found
        /// </summary>
        public const uint OrderNotFound = 10000;

        /// <summary>
        ///  Price not reasonable
        /// </summary>
        public const uint PriceNotReasonable = 10001;

        /// <summary>
        ///  Duplicate Order (ClOrdID)
        /// </summary>
        public const uint ClientOrderIdNotUnique = 10002;

        /// <summary>
        ///  another quote activation request is pending for the same Product / Instrument Type / SessionID
        /// </summary>
        public const uint QuoteActivationInProgress = 10003;

        /// <summary>
        ///  Stop buy price not reasonable
        /// </summary>
        public const uint StopBidPriceNotReasonable = 10006;

        /// <summary>
        ///  Stop sell price not reasonable
        /// </summary>
        public const uint StopAskPriceNotReasonable = 10007;

        /// <summary>
        ///  GFD order is not executable on current business day
        /// </summary>
        public const uint OrderNotExecutableWithinValidity = 10008;

        /// <summary>
        ///  Throttle limit for creation of complex instrument exceeded
        /// </summary>
        public const uint CreateCiThrottleExceeded = 10010;

        /// <summary>
        ///  Order maintenance not allowed in current state
        /// </summary>
        public const uint TransactionNotAllowedInCurrentState = 10011;

        /// <summary>
        ///  Required min lot size not reached
        /// </summary>
        public const uint RequiredMinLotSizeNotReached = 10013;

        /// <summary>
        ///  Fix Tag for Session Reject Reason
        /// </summary>
        public const ushort FixTag = 373;

        /// <summary>
        ///  Length of Session Reject Reason in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Encode Session Reject Reason
        /// </summary>
        public unsafe static void Encode(byte* pointer, int offset, uint value, int length, out int current)
        {
            if (length > offset + SessionRejectReason.Length)
            {
                throw new System.Exception("Invalid Length for Session Reject Reason");
            }

            Encode(pointer, offset, value, out current);
        }

        /// <summary>
        ///  Encode Session Reject Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void Encode(byte* pointer, int offset, uint value, out int current)
        {
            *(uint*) (pointer + offset) = value;

            current = offset + SessionRejectReason.Length;
        }

        /// <summary>
        ///  Check available length and set Session Reject Reason to no value
        /// </summary>
        public unsafe static void SetNull(byte* pointer, int offset, int length, out int current)
        {
            if (length > offset + SessionRejectReason.Length)
            {
                throw new System.Exception("Invalid Length for Session Reject Reason");
            }

            SetNull(pointer, offset, out current);
        }

        /// <summary>
        ///  Set Session Reject Reason to no value and update index
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset, out int current)
        {
            SetNull(pointer, offset);

            current = offset + SessionRejectReason.Length;
        }

        /// <summary>
        ///  Set Session Reject Reason to no value
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static void SetNull(byte* pointer, int offset)
        {
            *(uint*) (pointer + offset) = NoValue;
        }

        /// <summary>
        ///  TryDecode Session Reject Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, int length, out uint value, out int current)
        {
            if (length > offset + SessionRejectReason.Length)
            {
                return TryDecode(pointer, offset, out value, out current);
            }

            value = default;

            current = offset;

            return false;
        }

        /// <summary>
        ///  TryDecode Session Reject Reason
        /// </summary>
        public unsafe static bool TryDecode(byte* pointer, int offset, out uint value, out int current)
        {
            value = Decode(pointer, offset, out current);

            return value != NoValue;
        }

        /// <summary>
        ///  Decode Session Reject Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset, out int current)
        {
            current = offset + SessionRejectReason.Length;

            return Decode(pointer, offset);
        }

        /// <summary>
        ///  Decode Session Reject Reason
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe static uint Decode(byte* pointer, int offset)
        {
            return *(uint*) (pointer + offset);
        }
    }
}