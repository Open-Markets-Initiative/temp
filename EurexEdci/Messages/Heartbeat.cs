using SRFixBase;

namespace Eurex.Edci.v131;

/// <summary>
///  Heartbeat Message Methods
/// </summary>

public static partial class Heartbeat
{
    /// <summary>
    ///  Edci Identifier for Heartbeat
    /// </summary>
    public const string Identifier = "10011";

    /// <summary>
    ///  Encode Heartbeat Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.Heartbeat, out current);

        // --- encode heartbeat message ---

        Pad2.Encode(pointer, current, out current);

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Heartbeat Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = Heartbeat.Identifier;

        // --- decode heartbeat message ---

        current += Pad2.Length;

        return FixErrorCode.None;
    }
}
