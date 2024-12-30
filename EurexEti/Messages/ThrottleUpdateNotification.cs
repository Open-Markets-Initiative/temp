using SRFixBase;

namespace Eurex.EtiDerivatives.v130
{
    /// <summary>
    ///  Throttle Update Notification Message Methods
    /// </summary>

    public static partial class ThrottleUpdateNotification
    {
        /// <summary>
        ///  Eti Identifier for Throttle Update Notification
        /// </summary>
        public const string Identifier = "10028";

        /// <summary>
        ///  Encode Throttle Update Notification Message
        /// </summary>
        public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            // --- encode message header ---

            BodyLen.Encode(pointer, current, 0, out current);

            TemplateId.Encode(pointer, current, TemplateId.ThrottleUpdateNotification, out current);

            // --- encode throttle update notification message ---

            Pad2.Encode(pointer, current, out current);

            var sendingTime = (ulong)message.sendingTime.Ticks;
            SendingTime.Encode(pointer, current, sendingTime, out current);

            if (message.TryGetLong(ThrottleTimeInterval.FixTag, out var throttleTimeInterval))
            {
                ThrottleTimeInterval.Encode(pointer, current, throttleTimeInterval, out current);
            }
            else
            {
                ThrottleTimeInterval.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ThrottleNoMsgs.FixTag, out var throttleNoMsgs))
            {
                ThrottleNoMsgs.Encode(pointer, current, (uint)throttleNoMsgs, out current);
            }
            else
            {
                ThrottleNoMsgs.SetNull(pointer, current, out current);
            }

            if (message.TryGetInt(ThrottleDisconnectLimit.FixTag, out var throttleDisconnectLimit))
            {
                ThrottleDisconnectLimit.Encode(pointer, current, (uint)throttleDisconnectLimit, out current);
            }
            else
            {
                ThrottleDisconnectLimit.SetNull(pointer, current, out current);
            }

            // --- complete header ---

            BodyLen.Encode(pointer, offset, (uint)(current - offset));
        }

        /// <summary>
        ///  Decode Throttle Update Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ThrottleUpdateNotification.Identifier;

            // --- decode throttle update notification message ---

            current += Pad2.Length;

            if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
            {
                message.sendingTime = new System.DateTime((long)sendingTime);
            }

            if (ThrottleTimeInterval.TryDecode(pointer, current, out var throttleTimeInterval, out current))
            {
                message.AppendLong(ThrottleTimeInterval.FixTag, throttleTimeInterval);
            }

            if (ThrottleNoMsgs.TryDecode(pointer, current, out var throttleNoMsgs, out current))
            {
                message.AppendInt(ThrottleNoMsgs.FixTag, (int)throttleNoMsgs);
            }

            if (ThrottleDisconnectLimit.TryDecode(pointer, current, out var throttleDisconnectLimit, out current))
            {
                message.AppendInt(ThrottleDisconnectLimit.FixTag, (int)throttleDisconnectLimit);
            }

            return FixErrorCode.None;
        }
    }
}