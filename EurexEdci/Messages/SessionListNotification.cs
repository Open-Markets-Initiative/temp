using SRFixBase;

namespace Eurex.Edci.v130;

/// <summary>
///  Session List Notification Message Methods
/// </summary>

public static partial class SessionListNotification
{
    /// <summary>
    ///  Eti Identifier for Session List Notification
    /// </summary>
    public const string Identifier = "10036";

    /// <summary>
    ///  Encode Session List Notification Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.SessionListNotification, out current);

        // --- encode session list notification message ---

        Pad2.Encode(pointer, current, out current);

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var isSessionsGrpComp = message.TryGetGroup(NoSessions.FixTag, out var sessionsGrpComp) && sessionsGrpComp.sectionList.Count > 0;
        if (isSessionsGrpComp)
        {
            var noSessions = (ushort)sessionsGrpComp.sectionList.Count;
            NoSessions.Encode(pointer, current, noSessions, out current);
        }
        else
        {
            NoSessions.Zero(pointer, current, out current);
        }

        Pad6.Encode(pointer, current, out current);

        if (isSessionsGrpComp)
        {
            SessionsGrpComp.Encode(pointer, current, sessionsGrpComp, out current);
        }

        // --- complete header ---

        BodyLen.Encode(pointer, offset, (uint)(current - offset));
    }

    /// <summary>
    ///  Decode Session List Notification Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = SessionListNotification.Identifier;

        // --- decode session list notification message ---

        current += Pad2.Length;

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        var noSessions = (int)NoSessions.Decode(pointer, current, out current);

        current += Pad6.Length;

        SessionsGrpComp.Decode(ref message, pointer, current, noSessions, out current);

        return FixErrorCode.None;
    }
}
