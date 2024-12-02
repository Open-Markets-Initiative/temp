using SRFixBase;

namespace Eurex.EtiDerivatives.v121
{
    /// <summary>
    ///  Throttle Update Notification Message Methods
    /// </summary>

    public partial class ThrottleUpdateNotification
    {
        /// <summary>
        ///  Eti Identifier for Throttle Update Notification
        /// </summary>
        public const string Identifier = "Throttle Update Notification";

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

            var start = current;

            Pad2.Encode(pointer, current, out current);

            var sendingTime = message.GetULong(SendingTime.FixTag);
            SendingTime.Encode(pointer, current, sendingTime, out current);

            var throttleTimeInterval = message.GetLong(ThrottleTimeInterval.FixTag);
            ThrottleTimeInterval.Encode(pointer, current, throttleTimeInterval, out current);

            var throttleNoMsgs = (uint)message.GetInt(ThrottleNoMsgs.FixTag);
            ThrottleNoMsgs.Encode(pointer, current, throttleNoMsgs, out current);

            var throttleDisconnectLimit = (uint)message.GetInt(ThrottleDisconnectLimit.FixTag);
            ThrottleDisconnectLimit.Encode(pointer, current, throttleDisconnectLimit, out current);

            // --- complete header ---

            BodyLen.Encode(pointer, block, (ushort)(current - start));
        }

        /// <summary>
        ///  Decode Throttle Update Notification Message
        /// </summary>
        public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, out int current)
        {
            current = offset;

            message.Reset();

            message.msgType = ThrottleUpdateNotification.Identifier;

            // --- decode throttle update notification message ---

            current += Pad2.Length;

            var sendingTime = SendingTime.Decode(pointer, current, out current);
            message.AppendULong(SendingTime.FixTag, sendingTime);

            var throttleTimeInterval = ThrottleTimeInterval.Decode(pointer, current, out current);
            message.AppendLong(ThrottleTimeInterval.FixTag, throttleTimeInterval);

            var throttleNoMsgs = (int)ThrottleNoMsgs.Decode(pointer, current, out current);
            message.AppendInt(ThrottleNoMsgs.FixTag, throttleNoMsgs);

            var throttleDisconnectLimit = (int)ThrottleDisconnectLimit.Decode(pointer, current, out current);
            message.AppendInt(ThrottleDisconnectLimit.FixTag, throttleDisconnectLimit);

            return FixErrorCode.None;
        }
    }
}