using SRFixBase;

namespace Eurex.Eti.v130;

/// <summary>
///  Inquire Session List Response Message Methods
/// </summary>

public static partial class InquireSessionListResponse
{
    /// <summary>
    ///  Eti Identifier for Inquire Session List Response
    /// </summary>
    public const string Identifier = "10036";

    /// <summary>
    ///  Encode Inquire Session List Response Message
    /// </summary>
    public static unsafe void Encode(FixMessage message, byte* pointer, int offset, int length, out int current)
    {
        current = offset;

        // --- encode message header ---

        BodyLen.Encode(pointer, current, 0, out current);

        TemplateId.Encode(pointer, current, TemplateId.InquireSessionListResponse, out current);

        // --- encode inquire session list response message ---

        Pad2.Encode(pointer, current, out current);

        if (message.TryGetULong(RequestTime.FixTag, out var requestTime))
        {
            RequestTime.Encode(pointer, current, requestTime, out current);
        }
        else
        {
            RequestTime.SetNull(pointer, current, out current);
        }

        var sendingTime = (ulong)message.sendingTime.Ticks;
        SendingTime.Encode(pointer, current, sendingTime, out current);

        var msgSeqNum = (uint)message.msgSeqNum;
        MsgSeqNum.Encode(pointer, current, msgSeqNum, out current);

        Pad4.Encode(pointer, current, out current);

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
    ///  Decode Inquire Session List Response Message
    /// </summary>
    public static unsafe FixErrorCode Decode(ref FixMessage message, byte* pointer, int offset, int length, ref int current)
    {
        message.Reset();

        message.msgType = InquireSessionListResponse.Identifier;

        // --- decode inquire session list response message ---

        current += Pad2.Length;

        if (RequestTime.TryDecode(pointer, current, out var requestTime, out current))
        {
            message.AppendULong(RequestTime.FixTag, requestTime);
        }

        if (SendingTime.TryDecode(pointer, current, out var sendingTime, out current))
        {
            message.sendingTime = new System.DateTime((long)sendingTime);
        }

        if (MsgSeqNum.TryDecode(pointer, current, out var msgSeqNum, out current))
        {
            message.msgSeqNum = (int)msgSeqNum;
        }

        current += Pad4.Length;

        var noSessions = (int)NoSessions.Decode(pointer, current, out current);

        current += Pad6.Length;

        SessionsGrpComp.Decode(ref message, pointer, current, noSessions, out current);

        return FixErrorCode.None;
    }
}
