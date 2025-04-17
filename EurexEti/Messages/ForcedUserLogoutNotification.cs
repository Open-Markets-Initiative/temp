using SRFixBase;

namespace Eurex.Eti.v131;

/// <summary>
///  Forced User Logout Notification Message Methods
/// </summary>

public static partial class ForcedUserLogoutNotification
{
    /// <summary>
    ///  Eti Identifier for Forced User Logout Notification
    /// </summary>
    public const string Identifier = "10043";

    /// <summary>
    ///  Encode Forced User Logout Notification Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.ForcedUserLogoutNotification, out current);

        // --- encode forced user logout notification message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        if (message.TryGetInt(Username.FixTag, out var username))
        {
            Username.Encode(pointer, current, (uint)username, out current);
        }
        else
        {
            Username.SetNull(pointer, current, out current);
        }

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

        if (message.TryGetInt(UserStatus.FixTag, out var userStatus))
        {
            UserStatus.Encode(pointer, current, (byte)userStatus, out current);
        }
        else
        {
            UserStatus.SetNull(pointer, current, out current);
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
    ///  Decode Forced User Logout Notification Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = ForcedUserLogoutNotification.Identifier;

        // --- decode forced user logout notification message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (Username.TryDecode(pointer, current, out var username, out current))
        {
            message.AppendInt(Username.FixTag, (int)username);
        }

        var varTextLen = VarTextLen.Decode(pointer, current, out current);

        if (UserStatus.TryDecode(pointer, current, out var userStatus, out current))
        {
            message.AppendInt(UserStatus.FixTag, userStatus);
        }

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
