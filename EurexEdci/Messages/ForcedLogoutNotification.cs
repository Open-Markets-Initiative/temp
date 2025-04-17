using SRFixBase;

namespace Eurex.Edci.v131;

/// <summary>
///  Forced Logout Notification Message Methods
/// </summary>

public static partial class ForcedLogoutNotification
{
    /// <summary>
    ///  Edci Identifier for Forced Logout Notification
    /// </summary>
    public const string Identifier = "10012";

    /// <summary>
    ///  Encode Forced Logout Notification Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.ForcedLogoutNotification, out current);

        // --- encode forced logout notification message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var isVarText = message.TryGetString(VarText.FixTag, out var varText);
        if (isVarText)
        {
            var varTextLen = (ushort)varText.Length;
            VarTextLen.Encode(pointer, current, varTextLen, out current);
        }
        else
        {
            VarTextLen.Zero(pointer, current, out current);
        }

        if (isVarText)
        {
            VarText.Encode(pointer, current, varText, out current);
        }

        var alignment = 8 - ((current - offset) % 8);
        if (alignment != 8)
        {
            AlignmentPadding.Encode(pointer, current, alignment, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Forced Logout Notification Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = ForcedLogoutNotification.Identifier;

        // --- decode forced logout notification message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        var varTextLen = VarTextLen.Decode(pointer, current, out current);

        if (VarText.TryDecode(pointer, current, varTextLen, out var varText, out current))
        {
            message.AppendString(VarText.FixTag, varText);
        }

        if (length != (current - offset))
        {
            current = offset + length;
        }

        return FixErrorCode.None;
    }
}
