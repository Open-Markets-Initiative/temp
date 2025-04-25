using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Heartbeat Notification Message Methods
/// </summary>

public static partial class HeartbeatNotification
{
    /// <summary>
    ///  Eti Identifier for Heartbeat Notification
    /// </summary>
    public const string Identifier = "10023";

    /// <summary>
    ///  Encode Heartbeat Notification Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.HeartbeatNotification, out current);

        // --- encode heartbeat notification message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Heartbeat Notification Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = HeartbeatNotification.Identifier;

        // --- decode heartbeat notification message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        return FixErrorCode.None;
    }
}
